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
    public partial class StaffRegistration : Form
    {
        public StaffRegistration()
        {
            InitializeComponent();
        }

        
        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet.TblStaffRegistration' table. You can move, or remove it, as needed.
            this.tblStaffRegistrationTableAdapter1.Fill(this.staffDataSet.TblStaffRegistration);

            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_FirstName.Enabled = value;
            txt_LastName.Enabled = value;
            txt_Address.Enabled = value;
            txt_NIC.Enabled = value;
            txt_MobileNumber.Enabled = value;
            txt_UsernameID.Enabled = value;
            txt_Password.Enabled = value;
            cmb_Designation.Enabled = value;
            cmb_Gender.Enabled = value;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "" || txt_LastName.Text == "" || txt_Address.Text == "" || txt_NIC.Text == "" || txt_MobileNumber.Text == "" || txt_UsernameID.Text == "" || txt_Password.Text == "" || cmb_Gender.SelectedItem == null || cmb_Designation.SelectedItem == null)
            {
                MessageBox.Show("Missing informations", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Edit(false);
                    tblStaffRegistrationBindingSource1.EndEdit();
                    tblStaffRegistrationTableAdapter1.Update(staffDataSet.TblStaffRegistration);
                    dgv_Regstration.Refresh();
                    txt_FirstName.Focus();
                    MessageBox.Show("Registration succefully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    staffDataSet.TblStaffRegistration.RejectChanges();
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_FirstName.Focus();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                staffDataSet.TblStaffRegistration.AddTblStaffRegistrationRow(staffDataSet.TblStaffRegistration.NewTblStaffRegistrationRow());
                tblStaffRegistrationBindingSource1.MoveLast();
                txt_FirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffDataSet.TblStaffRegistration.RejectChanges();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblStaffRegistrationBindingSource1.RemoveCurrent();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            fl.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frmdash = new Dashboard();
            frmdash.Show();
            this.Hide();
        }

        private void btn_DogsCat_Click(object sender, EventArgs e)
        {
            Dog f3 = new Dog();
            f3.Show();
            this.Hide();
        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            Billing fbill = new Billing();
            fbill.Show();
            this.Hide();

        }

        private void btn_StaffReg_Click(object sender, EventArgs e)
        {

        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product fpr = new Product();
            fpr.Show();
            this.Hide();
        }
    }
}
