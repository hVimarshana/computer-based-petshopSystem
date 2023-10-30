using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShopManagement_ICTProject_
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-C39TI599;Initial Catalog=ICTProject;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;

        public Login()
        {
            InitializeComponent();
        }

        String log;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM TblStaffRegistration WHERE Username='"+txt_UserName.Text+"' and Password='"+txt_Password.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                
                if(dr[7].ToString() == "Admin")
                {
                    UserLog.type = "A";
                }
                else if (dr[7].ToString() == "Cashier")
                {
                    UserLog.type = "C";
                }
                log = " Welcome :" + txt_UserName.Text;
                this.Hide();
                Dashboard fa = new Dashboard(log);
                fa.Show();
                
            }
            else
            {
                MessageBox.Show("Please check your username or password");
            }
            con.Close();
        }
    }
}
