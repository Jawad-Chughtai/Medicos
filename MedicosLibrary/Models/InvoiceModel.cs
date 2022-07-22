using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText;

namespace MedicosLibrary.Models
{
    public class InvoiceModel
    {
        public string InvoiceId { get; set; }
        public int CreatedBy_Id { get; set; }
        public string CreatedBy_Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public double InvoiceTotal { get; set; }
        public double Discount { get; set; }
        public int CustomerId { get; set; }
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
            var message = "Successful";
            try
            {
                if (StockAvailable(invoice))
                {
                    if (CreateInvoice(invoice))
                    {
                        if (CreateInvoiceItems(invoice))
                        {
                            if (UpdateStock(invoice))
                            {
                                if (invoice.BalanceAmount == 0)
                                {
                                    message = "successful";
                                }
                                else
                                {
                                    UpdateCustomer(invoice);
                                }
                            }
                            else
                            {
                                message = "stock could not be updated.";

                                DeleteInvoiceItems(invoice);
                                DeleteInvoice(invoice);

                            }
                        }

                        else
                        {
                            message = "Invoice Items could not be created.";
                            DeleteInvoiceItems(invoice);
                            DeleteInvoice(invoice);
                        }
                    }

                    else
                    {
                        message = "Invoice could not be created";
                    }
                }


                else
                {
                    message = "Stock Not Available";
                }

                return message;
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
                    if (Convert.ToInt32(rd["stock"]) < item.Quantity)
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
                bool IsStock = new bool();
                int Stock = new int();

                SqlConnection con = dbConnection.getCon();
                SqlCommand get_cmd = new SqlCommand("spBatch_GetStockOnSale", con);
                get_cmd.CommandType = CommandType.StoredProcedure;
                get_cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));


                SqlCommand update_cmd = new SqlCommand("spBatch_UpdateStockOnSale", con);
                update_cmd.CommandType = CommandType.StoredProcedure;
                update_cmd.Parameters.Add(new SqlParameter("@batch", item.BatchTitle));
                update_cmd.Parameters.Add(new SqlParameter("@Qty", Stock));
                update_cmd.Parameters.Add(new SqlParameter("@IsStock", IsStock));

                try
                {
                    con.Open();
                    SqlDataReader rd = get_cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        Stock = Convert.ToInt32(rd["stock"]) - item.Quantity;
                       
                        if (Stock > 0)
                        {
                            IsStock = true;
                        }
                        else
                        {
                            IsStock = false;
                        }

                    }
                    con.Close();
                    con.Open();
                    update_cmd.ExecuteNonQuery();
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

        private void DeleteInvoiceItems(InvoiceModel invoice)
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

        private void DeleteInvoice(InvoiceModel invoice)
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
