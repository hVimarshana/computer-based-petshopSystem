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
    public partial class Dog : Form
    {
        public Dog()
        {
            InitializeComponent();
        }

        private void Dog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addDogs.Tbl_Dogs' table. You can move, or remove it, as needed.
            this.tbl_DogsTableAdapter.Fill(this.addDogs.Tbl_Dogs);
            Edit(false);
        }

        private void Edit(bool value)
        {
            cmb_DogsBreed.Enabled = value;
            txt_Age.Enabled = value;
            txt_Country.Enabled = value;
            txt_Price.Enabled = value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                addDogs.Tbl_Dogs.AddTbl_DogsRow(addDogs.Tbl_Dogs.NewTbl_DogsRow());
                tblDogsBindingSource.MoveLast();
                cmb_DogsBreed.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addDogs.Tbl_Dogs.RejectChanges();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblDogsBindingSource.EndEdit();
                tbl_DogsTableAdapter.Update(addDogs.Tbl_Dogs);
                dgv_Dog.Refresh();
                cmb_DogsBreed.Focus();
                MessageBox.Show("Added succefully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addDogs.Tbl_Dogs.RejectChanges();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            cmb_DogsBreed.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this dog record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblDogsBindingSource.RemoveCurrent();
            }
        }

        private void btn_StaffReg_Click(object sender, EventArgs e)
        {
            StaffRegistration f2 = new StaffRegistration();
            f2.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frmdash = new Dashboard();
            frmdash.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            fl.Show();
            this.Hide();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product fpr = new Product();
            fpr.Show();
            this.Hide();
        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            Billing fbill = new Billing();
            fbill.Show();
            this.Hide();
        }

        private void btn_DogsCat_Click(object sender, EventArgs e)
        {

        }
    }
}
