using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicosLibrary.Models;

namespace MedicosUI
{
    public partial class ReceiptDetails : Form
    {
        string FileName { get; set; } = "";

        public ReceiptDetails()
        {
            InitializeComponent();
            WireUpDetails();
        }

        private void ReceiptDetails_Load(object sender, EventArgs e)
        {

        }

        private void WireUpDetails()
        {
            BusinessModel business = new BusinessModel();

            try
            {
                var Details = business.GetDetails();
                businessNameTextbox.Text = Details.BusinessName;
                addressTextbox.Text = Details.Address;
                contactTextbox.Text = Details.Contact;
                bottomNoteTextbox.Text = Details.BottomLine;
                imageLabel.Text = Details.Image;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong while loading details.");
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            BusinessModel business = new BusinessModel();

            if (validateForm(business))
            {
                try
                {
                    var IsBusiness = business.Update(business);
                    if (!IsBusiness)
                    {
                        business.Create();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved");
                }
                finally
                {
                    Close();
                }
            }
        }

        //
        // method to validate user details
        //
        private bool validateForm(BusinessModel business)
        {
            businessNameLabel.Text = "";
            businessAddressLabel.Text = "";
            businessContactLabel.Text = "";
            businessNoteLabel.Text = "";

            if (businessNameTextbox.Text.Length < 3)
            {
                businessNameLabel.Text = "Business Name Error.";
                return false;
            }
            else if (addressTextbox.Text.Length < 3)
            {
                businessAddressLabel.Text = "Address Error.";
                return false;
            }
            else if (contactTextbox.Text.Length < 3)
            {
                businessContactLabel.Text = "Contact Error.";
                return false;
            }
            else if (bottomNoteTextbox.Text.Length < 3)
            {
                businessNoteLabel.Text = "Bottom Note Error.";
                return false;
            }
            else if (FileName.Length == 0)
            {
                imageLabel.Text = "Image Error.";
                return false;
            }
            else
            {
                business.BusinessName = businessNameTextbox.Text;
                business.Contact = contactTextbox.Text;
                business.Address = addressTextbox.Text;
                business.BottomLine = bottomNoteTextbox.Text;
                if (FileName.Length > 0)
                {
                    business.Image = FileName;
                }
                return true;
            }
        }
        private void logoButton_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imageLabel.Text = open.FileName;
                var saveDirectory = Application.StartupPath;
                saveDirectory += "Images/";
                if (!Directory.Exists(saveDirectory))
                {
                    Directory.CreateDirectory(saveDirectory);
                }

                string fileName = Path.GetFileName(open.FileName);
                string fileSavePath = Path.Combine(saveDirectory, fileName);
                FileName = fileSavePath;
                File.Copy(open.FileName, fileSavePath, true);
            }
        }


    }
}
