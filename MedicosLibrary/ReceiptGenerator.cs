using MedicosLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;
namespace MedicosLibrary
{
    public class ReceiptGenerator
    {
        private string Path { get; set; }
        private InvoiceModel Invoice { get; set; }
        private string StoreName { get; set; }
        private string Details { get; set; }
        private string Contact { get; set; }
        private string Address { get; set; }

        private void GetData()
        {
            SqlConnection con = dbConnection.getCon();
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblReceiptDetails", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    StoreName = rd["storeName"].ToString();
                    Details = rd["bottomLine"].ToString();
                    Contact = rd["contact"].ToString();
                    Address = rd["address"].ToString();
                }

            }
            finally
            {
                con.Close();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("select userFullName from tblUser where id = '" + Invoice.CreatedBy_Id + "'", con);
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
                SqlCommand cmd = new SqlCommand("select fullName from tblCustomer where id = '" + Invoice.CustomerId + "'", con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Invoice.CustomerName = rd["fullName"].ToString();
                }

            }
            finally
            {
                con.Close();
            }
        }

        public void PrintReceipt(InvoiceModel invoice, string path)
        {
            Invoice = invoice;
            Path = path + "/Invoices/"; // Path of the file
            
            GetData(); // Get Customer Name, User Name and Business Details to print


            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path); // Created new folder INVOICES if it does not exist.
            }

            Path += Invoice.InvoiceId + ".pdf"; // File name

            if (File.Exists(Path))
            {
                File.Delete(Path); // Deletes file if already exists with the same name.
            }


            //======= Page Size of the Print Document =========//

            var rectangle = new Rectangle(295f, 420f);

            // Margins
            var ml = 10f;
            var mt = 10f;
            var mr = 10f;
            var mb = 10f;

            //-------- Fonts for the document --------//
            #region Fonts
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font_small = new iTextSharp.text.Font(bf, 7, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font_heading = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font_total = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font_title = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);

            iTextSharp.text.Font font_detail = new iTextSharp.text.Font(bf, 8);
            iTextSharp.text.Font font_detail_heading = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);

            #endregion


            var document = new Document(rectangle, ml, mr, mt, mb);


            PdfWriter.GetInstance(document, new FileStream(Path, FileMode.Create));
            document.Open();

            try
            {
                //-------- Pharmacy Details on the top of Receipt --------/

                Paragraph TitlePara = new Paragraph();
                TitlePara.Alignment = Element.ALIGN_CENTER;
                Phrase NamePhrase = new Phrase(StoreName, font_title);
                TitlePara.Add(NamePhrase);

                Paragraph AddressPara = new Paragraph();
                AddressPara.Alignment = Element.ALIGN_CENTER;
                Phrase AddressPhrase = new Phrase(Address, font_detail_heading);
                AddressPara.Add(AddressPhrase);

                Paragraph ContactPara = new Paragraph();
                ContactPara.Alignment = Element.ALIGN_CENTER;
                Phrase ContactPhrase = new Phrase(Contact, font_detail_heading);
                ContactPara.Add(ContactPhrase);


                // ------- Table for Invoice Details on Top of Receipt ---------//

                PdfPTable InvoiceDetailsTable = new PdfPTable(6);
                InvoiceDetailsTable.WidthPercentage = 100;
                InvoiceDetailsTable.SpacingBefore = 20;

                Phrase InvoiceIdPhrase = new Phrase(Invoice.InvoiceId, font_detail);
                Phrase Date = new Phrase(Invoice.CreatedAt.ToString("hh-MM-yyyy hh:mm:yy tt"), font_detail);
                Phrase CustomerName = new Phrase(Invoice.CustomerName, font_detail);
                Phrase UserName = new Phrase(Invoice.CreatedBy_Name, font_detail);

                // ---------- First Row ---------//

                PdfPCell Cell1 = new PdfPCell();
                Cell1.Colspan = 1;
                Cell1.Border = 0;

                PdfPCell Cell2 = new PdfPCell();
                Cell2.Colspan = 2;
                Cell2.Border = 0;

                Cell1.Phrase = new Phrase("Invoice # : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell1);

                
                Cell2.Phrase = new Phrase(InvoiceIdPhrase);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell2);

                 
                Cell1.Phrase = new Phrase("Date : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                InvoiceDetailsTable.AddCell(Cell1);

                Cell2.Phrase = new Phrase(Date);
                Cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell2);


                // ------- Second Row ---------- //

                Cell1.Phrase = new Phrase("Customer : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell1);

                Cell2.Phrase = new Phrase(CustomerName);
                Cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell2);

                
                Cell1.Phrase = new Phrase("User : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_RIGHT;
                InvoiceDetailsTable.AddCell(Cell1);

                Cell2.Phrase = new Phrase(UserName);
                Cell2.HorizontalAlignment = Element.ALIGN_LEFT;
                InvoiceDetailsTable.AddCell(Cell2);


                // *******  Items Table Starts ******** //

                PdfPTable ItemsTable = new PdfPTable(6);
                ItemsTable.WidthPercentage = 100;
                ItemsTable.SpacingBefore = 10;

                PdfPCell SrCell = new PdfPCell();
                SrCell.Colspan = 1;
                SrCell.Border = 0;
                SrCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell ItemNameCell = new PdfPCell();
                ItemNameCell.Colspan = 2;
                ItemNameCell.Border = 0;
                ItemNameCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell UnitPriceCell = new PdfPCell();
                UnitPriceCell.Colspan = 1;
                UnitPriceCell.Border = 0;
                UnitPriceCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell QuantityCell = new PdfPCell();
                QuantityCell.Colspan = 1;
                QuantityCell.Border = 0;
                QuantityCell.HorizontalAlignment = Element.ALIGN_CENTER;

                PdfPCell TotalCell = new PdfPCell();
                TotalCell.Colspan = 1;
                TotalCell.Border = 0;
                TotalCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // ---- Header Row ----- //

                SrCell.Phrase = new Phrase("Sr #", font_heading);
                ItemNameCell.Phrase = new Phrase("Item", font_heading);
                UnitPriceCell.Phrase = new Phrase("UP", font_heading);
                QuantityCell.Phrase = new Phrase("Qty", font_heading);
                TotalCell.Phrase = new Phrase("Total", font_heading);

                ItemsTable.AddCell(SrCell);
                ItemsTable.AddCell(ItemNameCell);
                ItemsTable.AddCell(UnitPriceCell);
                ItemsTable.AddCell(QuantityCell);
                ItemsTable.AddCell(TotalCell);

                // ----- Items Rows ------ //
                var count = 0;
                foreach (var item in Invoice.Items)
                {

                    SrCell.Phrase = new Phrase((++count).ToString(), font);

                    ItemNameCell.Phrase = new Phrase(item.ItemName, font);

                    UnitPriceCell.Phrase = new Phrase(item.UnitPrice.ToString(), font);

                    QuantityCell.Phrase = new Phrase(item.Quantity.ToString(), font);

                    TotalCell.Phrase = new Phrase(item.ItemTotal.ToString("N2"), font);

                    ItemsTable.AddCell(SrCell);
                    ItemsTable.AddCell(ItemNameCell);
                    ItemsTable.AddCell(UnitPriceCell);
                    ItemsTable.AddCell(QuantityCell);
                    ItemsTable.AddCell(TotalCell);

                }

                // ----- Adding a line under Items Table ----------//

                PdfPCell NewLineCell = new PdfPCell();
                NewLineCell.Phrase = new Phrase("\n", font);
                NewLineCell.Colspan = 6;
                NewLineCell.Border = 0;
                ItemsTable.AddCell(NewLineCell);

                NewLineCell.Phrase = new Phrase("", font);
                NewLineCell.Colspan = 6;
                NewLineCell.Border = 1;
                ItemsTable.AddCell(NewLineCell);


                // --------- Totals Tabel ----------//

                PdfPTable TotalTable = new PdfPTable(5);
                TotalTable.WidthPercentage = 100;
                TotalTable.SpacingBefore = 10;

                PdfPCell SpacerCell = new PdfPCell();
                SpacerCell.Colspan = 3;
                SpacerCell.Border = 0;
                SpacerCell.Phrase = new Phrase("", font);
                TotalTable.AddCell(SpacerCell);

                Cell1.Phrase = new Phrase("Sub Total : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);


                Cell1.Phrase = new Phrase(Invoice.InvoiceSubTotal.ToString("N2"), font);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);

                SpacerCell.Colspan = 3;
                SpacerCell.Border = 0;
                SpacerCell.Phrase = new Phrase("", font);
                TotalTable.AddCell(SpacerCell);

                Cell1.Phrase = new Phrase("GST 17% : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);


                Cell1.Phrase = new Phrase("", font);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);

                SpacerCell.Colspan = 3;
                SpacerCell.Border = 0;
                SpacerCell.Phrase = new Phrase("", font);
                TotalTable.AddCell(SpacerCell);

                Cell1.Phrase = new Phrase("Discount : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);


                Cell1.Phrase = new Phrase(Invoice.Discount.ToString("N2"), font);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);

                SpacerCell.Colspan = 3;
                SpacerCell.Border = 0;
                SpacerCell.Phrase = new Phrase("", font);
                TotalTable.AddCell(SpacerCell);

                Cell1.Phrase = new Phrase("Total : ", font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);


                Cell1.Phrase = new Phrase(Invoice.InvoiceTotal.ToString("N2"), font);
                Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                Cell1.Colspan = 1;
                TotalTable.AddCell(Cell1);

                if (Invoice.BalanceAmount > 0)
                {
                    SpacerCell.Colspan = 3;
                    SpacerCell.Border = 0;
                    SpacerCell.Phrase = new Phrase("", font);
                    TotalTable.AddCell(SpacerCell);

                    Cell1.Phrase = new Phrase("Balance : ", font_detail_heading);
                    Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    Cell1.Colspan = 1;
                    TotalTable.AddCell(Cell1);


                    Cell1.Phrase = new Phrase(Invoice.BalanceAmount.ToString("N2"), font);
                    Cell1.HorizontalAlignment = Element.ALIGN_LEFT;
                    Cell1.Colspan = 1;
                    TotalTable.AddCell(Cell1);
                }

                // ------ Bottom Note Table --------- //

                PdfPTable BottomTable = new PdfPTable(1);
                BottomTable.SpacingBefore = 30;
                BottomTable.SpacingAfter = 10;
                BottomTable.WidthPercentage = 70;
                BottomTable.HorizontalAlignment = Element.ALIGN_CENTER;

                Cell1.Phrase = new Phrase(Details, font_detail_heading);
                Cell1.HorizontalAlignment = Element.ALIGN_CENTER;
                Cell1.Colspan = 1;
                BottomTable.AddCell(Cell1);

                // -------- Adding everything to the document ---------//

                document.Add(TitlePara);
                document.Add(AddressPara);
                document.Add(ContactPara);
                document.Add(InvoiceDetailsTable);
                document.Add(ItemsTable);
                document.Add(TotalTable);
                document.Add(BottomTable);

            }

            catch
            {
                File.Delete(Path);
                throw;
            }

            finally
            {
                document.Close();
            }
        }
    }
}
