using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement_ICTProject_
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            dogslist();
            productlist();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-C39TI599;Initial Catalog=ICTProject;Integrated Security=True");

        private void dogslist()
        {
            Con.Open();
            string query1 = "select * from Tbl_Dogs";
            SqlDataAdapter sda = new SqlDataAdapter(query1, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv_DogsBill.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void productlist()
        {
            Con.Open();
            string query2 = "select * from Tbl_Products";
            SqlDataAdapter sda1 = new SqlDataAdapter(query2, Con);
            SqlCommandBuilder builder1 = new SqlCommandBuilder(sda1);
            var ds1 = new DataSet();
            sda1.Fill(ds1);
            dgv_ProductBill.DataSource = ds1.Tables[0];
            Con.Close();
        }
















        private void btn_Billing_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void dgv_ProductBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ProductName.Text = dgv_ProductBill.SelectedRows[0].Cells[1].Value.ToString();
            txt_Qty.Text = dgv_ProductBill.SelectedRows[0].Cells[2].Value.ToString();
            txt_PRPrice.Text = dgv_ProductBill.SelectedRows[0].Cells[3].Value.ToString();
            if (txt_ProductName.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(dgv_ProductBill.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dgv_ProductBill.SelectedRows[0].Cells[2].Value.ToString());
            }
        }

        double FinalTotal = 0;
        int n = 0;
        int key = 0;
        int stock = 0;

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            int quanity = Convert.ToInt32(txt_Qty.Text);
            double PPrice = Convert.ToDouble(txt_PRPrice.Text);
            double total = quanity * PPrice;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgv_Bill);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txt_ProductName.Text;
            newRow.Cells[2].Value = txt_PRPrice.Text;
            newRow.Cells[3].Value = quanity;
            newRow.Cells[4].Value = total;
            dgv_Bill.Rows.Add(newRow);
            n++;
            UpdateProduct();
            FinalTotal = FinalTotal + total;
            lblTotal.Text = "Rs." + FinalTotal.ToString();
        }
        private void UpdateProduct()
        {

            try
            {
                int newQty = stock - Convert.ToInt32(txt_Qty.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Tbl_Products set Quantity = " + newQty + " where ProductID = " + key + "", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                productlist();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }


        private void dgv_DogsBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_OrderName.Text = dgv_DogsBill.SelectedRows[0].Cells[1].Value.ToString();
            txt_price.Text = dgv_DogsBill.SelectedRows[0].Cells[4].Value.ToString(); ;
        }

        private void btn_AddDog_Click(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(txt_price.Text);
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgv_Bill);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txt_OrderName.Text;
            newRow.Cells[2].Value = txt_price.Text;
            newRow.Cells[3].Value = 0;
            newRow.Cells[4].Value = total;
            dgv_Bill.Rows.Add(newRow);
            n++;
            UpdateDogCategory();
            FinalTotal = FinalTotal + total;
            lblTotal.Text = FinalTotal.ToString();
        }
        private void UpdateDogCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Dogs where DogID='" + dgv_DogsBill.SelectedRows[0].Cells[0].Value.ToString() + "'", Con);
            cmd.ExecuteNonQuery();
            dgv_DogsBill.Rows.RemoveAt(dgv_DogsBill.SelectedRows[0].Index);
            Con.Close();
        }



        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tblBill._TblBill' table. You can move, or remove it, as needed.
            //this.tblBillTableAdapter.Fill(this.tblBill._TblBill);

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 350, 400);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        string proName;
        int proID, pos = 60;
        double proPrice, pTotal;

        private void btn_Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_Bill.Rows.Count; i++)
            {
                string OrderName = dgv_Bill.Rows[i].Cells[1].Value.ToString();
                Double Price = Convert.ToDouble(dgv_Bill.Rows[i].Cells[2].Value.ToString());
                int Quantity = Convert.ToInt32(dgv_Bill.Rows[i].Cells[3].Value.ToString());
                Double Total = Convert.ToDouble(dgv_Bill.Rows[i].Cells[4].Value.ToString());
                Double Gtotal = Convert.ToDouble(lblTotal.Text);


                //Con = ConnectionManager.GetConnection();
                Con.Open();
                string query1 = "insert into TblBill values ('" + OrderName + "','" + Price + "','" + Quantity + "', '" + Total + "','" + Gtotal + "')";
                SqlCommand cmd = new SqlCommand(query1, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
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

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product fpr = new Product();
            fpr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_OrderName.Text = "";
            txt_price.Text = "";
            txt_ProductName.Text = "";
            txt_PRPrice.Text = "";
            txt_Qty.Text = "";

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("PUPPY PET SHOP", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID  Product  Qty       Price       Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in dgv_Bill.Rows)
            {
                proID = Convert.ToInt32(row.Cells["Column1"].Value);
                proName = "" + row.Cells["Column2"].Value;
                proPrice = Convert.ToDouble(row.Cells["Column3"].Value);
                int proQty = Convert.ToInt32(row.Cells["Column4"].Value);
                pTotal = Convert.ToDouble(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + proID, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + proName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + proPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + proQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + pTotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
            }
            e.Graphics.DrawString("Grand Total: RS. " + FinalTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60, pos + 50));
            e.Graphics.DrawString("*******************************", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40, pos + 85));
            dgv_Bill.Rows.Clear();
            dgv_Bill.Refresh();
            pos = 100;
            FinalTotal = 0;

        }
    }
}
