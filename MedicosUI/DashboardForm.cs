using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicosUI
{
    public partial class DashboardForm : Form
    {
        Form activeForm = null;
        public DashboardForm()
        {
            InitializeComponent();
        }

        //Left menu onClick methods to display respective child forms
        private void openChildForm(Form formObj)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            formObj.MdiParent = this;
            formObj.Show();
            formObj.Dock = DockStyle.Fill;
            formObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formObj.TopLevel = false;
            activeForm = formObj;
        }
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardChildForm formObj = new DashboardChildForm();
            openChildForm(formObj);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm formObj = new UserForm();
            openChildForm(formObj);
        }
    }
}
