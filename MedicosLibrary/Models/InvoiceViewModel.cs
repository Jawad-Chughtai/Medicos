using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicosLibrary.Models
{
    public class InvoiceViewModel
    {
        public InvoiceModel Invoice = new InvoiceModel();

        public InvoiceModel GetInvoiceById (string id)
        {
            Invoice.InvoiceId = id;

            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spInvoice_GetById", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                con.Open();
                cmd.Parameters.Add(new SqlParameter("@invoiceId", Invoice.InvoiceId));
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Invoice.CustomerId = Convert.ToInt32(rd["customerID"]);
                    Invoice.CreatedAt = Convert.ToDateTime(rd["createdAt"]);
                    Invoice.Discount = Convert.ToDouble(rd["discount"]);
                    Invoice.InvoiceSubTotal = Convert.ToDouble(rd["subTotal"]);
                    Invoice.InvoiceTotal = Invoice.InvoiceSubTotal - Invoice.Discount;
                    if (!Convert.IsDBNull(rd["received"]))
                    {
                        Invoice.ReceivedAmount = Convert.ToDouble(rd["received"]);
                    }
                    Invoice.CreatedBy_Id = Convert.ToInt32(rd["createdBy"]);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            try
            {
                cmd = new SqlCommand("spCustomer_GetSingle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", Invoice.CustomerId));
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Invoice.CustomerName = rd["fullName"].ToString();
                    Invoice.CustomerContact = rd["contact"].ToString();
                }
            }

            finally
            {
                con.Close();
            }

            try
            {
                cmd = new SqlCommand("spUser_GetSingle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", Invoice.CreatedBy_Id));
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Invoice.CreatedBy_Name = rd["userFullName"].ToString();
                }
            }

            finally
            {
                con.Close();
            }

            try
            {
                cmd = new SqlCommand("spInvoiceItems_GetById", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@id", Invoice.InvoiceId));
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    InvoiceItemsModel item = new InvoiceItemsModel();
                    item.Quantity = Convert.ToInt32(rd["itemQuantity"]);
                    item.ItemTotal = Convert.ToDouble(rd["total"]);
                    item.BatchTitle = rd["batch"].ToString();
                    item.ItemName = rd["itemName"].ToString();
                    item.UnitPrice = Convert.ToDouble(rd["unitPrice"]);
                    item.Expiry = Convert.ToDateTime(rd["expiry"]);

                    Invoice.Items.Add(item);
                }
            }
            finally
            {
                con.Close();
            }
            return Invoice;
        }
    }
}
