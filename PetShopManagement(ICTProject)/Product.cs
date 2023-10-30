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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addProducts.Tbl_Products' table. You can move, or remove it, as needed.
            this.tbl_ProductsTableAdapter.Fill(this.addProducts.Tbl_Products);
            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_Product.Enabled = value;
            txt_Qty.Enabled = value;
            txt_Description.Enabled = value;
            txt_Price.Enabled = value;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblProductsBindingSource.EndEdit();
                tbl_ProductsTableAdapter.Update(addProducts.Tbl_Products);
                dgv_Product.Refresh();
                txt_Product.Focus();
                MessageBox.Show("Product added succefully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addProducts.Tbl_Products.RejectChanges();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                addProducts.Tbl_Products.AddTbl_ProductsRow(addProducts.Tbl_Products.NewTbl_ProductsRow());
                tblProductsBindingSource.MoveLast();
                txt_Product.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addProducts.Tbl_Products.RejectChanges();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_Product.Focus();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this product record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblProductsBindingSource.RemoveCurrent();
            }
        }

        private void btn_Billing_Click(object sender, EventArgs e)
        {
            Billing fbill = new Billing();
            fbill.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frmdash = new Dashboard();
            frmdash.Show();
            this.Hide();
        }

        private void btn_StaffReg_Click(object sender, EventArgs e)
        {
            StaffRegistration f2 = new StaffRegistration();
            f2.Show();
            this.Hide();
        }

        private void btn_DogsCat_Click(object sender, EventArgs e)
        {
            Dog f3 = new Dog();
            f3.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login fl = new Login();
            fl.Show();
            this.Hide();
        }
    }
}
