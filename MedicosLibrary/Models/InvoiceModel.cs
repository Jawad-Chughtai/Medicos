using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class InvoiceModel
    {
        public string InvoiceId { get; set; }
        public int CreatedBy_Id { get; set; }
        public string CreatedBy_Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public double InvoiceSubTotal { get; set; }
        public double Discount { get; set; }
        public double InvoiceTotal { get; set; }
        public double ReceivedAmount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public double BalanceAmount { get; set; }
        public List<InvoiceItemsModel> Items { get; set; } = new List<InvoiceItemsModel>();

        public bool InvoiceExists()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spInvoice_InvoiceExists", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@InvoiceId", InvoiceId));
            try
            {
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            finally
            {
                con.Close();
            }
        }
        public string CreateSale(InvoiceModel invoice)
        {
            try
            {
                if (!StockAvailable(invoice))
                {
                    return "Stock for some item is not available.";
                }
                else if (!CreateInvoice(invoice))
                {
                    return "Invoice could not be created.";
                }
                else if (!CreateInvoiceItems(invoice))
                {
                    return "Invoice Items could not be created.";
                }
                else if (UpdateStock(invoice))
                {
                    if (invoice.BalanceAmount > 0)
                    {
                        UpdateCustomer(invoice);
                    }
                    return "Invoice Created Successfully.";
                }
                else
                {
                    DeleteInvoiceItems(invoice);
                    DeleteInvoice(invoice);
                    return "Transaction Failed.";
                }
            }
            catch
            {
                DeleteInvoiceItems(invoice);
                DeleteInvoice(invoice);
                throw;
            }
        }

        private bool StockAvailable(InvoiceModel invoice)
        {
            var result = true;

            foreach (var item in invoice.Items)
            {
                SqlConnection con = dbConnection.getCon();
                SqlCommand cmd = new SqlCommand("spBatch_GetStockOnSale", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    var Stock = Convert.ToInt32(rd["stock"]);
                    if (Stock < item.Quantity)
                    {
                        result = false;
                    }
                }
                con.Close();
            }

            return result;
        }
        private bool CreateInvoice(InvoiceModel invoice)
        {
            bool result = false;
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spInvoice_CreateInvoice", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@InvoiceId", invoice.InvoiceId));
            cmd.Parameters.Add(new SqlParameter("@CustomerId", invoice.CustomerId));
            cmd.Parameters.Add(new SqlParameter("@UserId", invoice.CreatedBy_Id));
            cmd.Parameters.Add(new SqlParameter("@CreatedAt", invoice.CreatedAt));
            cmd.Parameters.Add(new SqlParameter("@Discount", invoice.Discount));
            cmd.Parameters.Add(new SqlParameter("@subTotal", invoice.InvoiceSubTotal));
            cmd.Parameters.Add(new SqlParameter("@received", invoice.ReceivedAmount));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return result;
        }


        private bool CreateInvoiceItems(InvoiceModel invoice)
        {
            bool result = false;

            foreach (var item in invoice.Items)
            {
                SqlConnection con = dbConnection.getCon();
                SqlCommand cmd = new SqlCommand("spInvoiceItems_CreateInvoice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@InvoiceId", invoice.InvoiceId));
                cmd.Parameters.Add(new SqlParameter("@ItemId", item.ItemId));
                cmd.Parameters.Add(new SqlParameter("@Qty", item.Quantity));
                cmd.Parameters.Add(new SqlParameter("@total", item.ItemTotal));
                cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch
                {
                    result = false;
                    throw;
                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }

        private bool UpdateStock(InvoiceModel invoice)
        {
            bool result = true;
            foreach(var item in invoice.Items)
            {
                SqlConnection get_con = dbConnection.getCon();
                SqlCommand get_cmd = new SqlCommand("spBatch_GetStockOnSale", get_con);
                get_cmd.CommandType = CommandType.StoredProcedure;
                get_cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));
                
                try
                {
                    get_con.Open();
                    SqlDataReader rd = get_cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        int PreviousStock = Convert.ToInt32(rd["stock"]);
                        item.UpdatedStock = PreviousStock - item.Quantity;

                        if (item.UpdatedStock > 0)
                        {
                            item.IsStock = true;
                        }
                        else
                        {
                            item.IsStock = false;
                        }

                    }
                }
                catch
                {
                    result = false;
                    throw;
                }
                finally
                {
                    get_con.Close();
                }

                SqlConnection update_con = dbConnection.getCon();
                SqlCommand update_cmd = new SqlCommand("spBatch_UpdateStockOnSale", update_con);
                update_cmd.CommandType = CommandType.StoredProcedure;
                update_cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));
                update_cmd.Parameters.Add(new SqlParameter("@UpdatedStock", item.UpdatedStock));
                update_cmd.Parameters.Add(new SqlParameter("@IsStock", item.IsStock));

                try
                {
                    update_con.Open();
                    update_cmd.ExecuteNonQuery();
                }

                catch
                {
                    result = false;
                    throw;
                }
                finally
                {
                    update_con.Close();
                }
                
            }
            return result;
        }

        public void DeleteInvoiceItems(InvoiceModel invoice)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spInvoiceItems_DeleteOnFail", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@InvoiceId", invoice.InvoiceId));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }

        public void DeleteInvoice(InvoiceModel invoice)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spInvoice_DeleteOnFail", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@InvoiceId", invoice.InvoiceId));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void UpdateCustomer(InvoiceModel invoice)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spCustomer_UpdateOnSale", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@CustomerId", invoice.CustomerId));
            cmd.Parameters.Add(new SqlParameter("@Balance", invoice.BalanceAmount));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }

}
