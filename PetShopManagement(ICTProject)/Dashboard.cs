using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement_ICTProject_
{
    public partial class Dashboard : Form
    {
        public Dashboard(string log)
        {
            InitializeComponent();
            lbl_Log.Text = log;
        }

        public Dashboard()
        {
        }

        private void btn_StaffReg_Click(object sender, EventArgs e)
        {
            StaffRegistration frm = new StaffRegistration();
            frm.ShowDialog();
            this.Hide();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            fl.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tblBill._TblBill' table. You can move, or remove it, as needed.
            this.tblBillTableAdapter.Fill(this.tblBill._TblBill);
            // TODO: This line of code loads data into the 'tblBill._TblBill' table. You can move, or remove it, as needed.
            this.tblBillTableAdapter.Fill(this.tblBill._TblBill);
            if (UserLog.type == "A")
            {
                btn_Dashboard.Visible = true;
                btn_StaffReg.Visible = true;
                btn_DogsCat.Visible = true;
                btn_Billing.Visible = true;
                btn_Logout.Visible = true;
            }
            else if (UserLog.type == "C")
            {
                btn_Dashboard.Visible = true;
                btn_StaffReg.Visible = false;
                btn_DogsCat.Visible = false;
                btn_Billing.Visible = true;
                btn_Logout.Visible = true;
            }
        }

        private void btn_DogsCat_Click(object sender, EventArgs e)
        {
            Dog f2 = new Dog();
            f2.Show();
            this.Hide();
        }

        private void btn_ShowDemand_Click(object sender, EventArgs e)
        {

        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            Billing fbill = new Billing();
            fbill.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product fpr = new Product();
            fpr.Show();
            this.Hide();
        }
    }
}
