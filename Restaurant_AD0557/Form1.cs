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

namespace Restaurant_AD0557
{
    public partial class RestaurantAcc : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\source\repos\Restaurant_AD0557\Restaurant_AD0557\Database1.mdf;Integrated Security=True");
        SqlDataAdapter Da;
        

        public RestaurantAcc()
        {
            InitializeComponent();
           
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                   //Close The Form1
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String Username, Password;

            Username = txtUserName.Text;
            Password = txtPassword.Text;

            try
            {
                String qerry = "SELECT * FROM LOGIN  WHERE [Username] = '" + txtUserName.Text + "'AND [Password] = '" + txtPassword.Text + "'";

                Da = new SqlDataAdapter(qerry, conn);
                DataTable dt = new DataTable();
                Da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Username = txtUserName.Text;
                    Password = txtPassword.Text;


                    
                    frmMenu frm = new frmMenu();
                    
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Try Again","Error");

                    txtUserName.Clear();
                    txtPassword.Clear();

                    txtUserName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }
            private void RestaurantAcc_Load(object sender, EventArgs e)
            {

            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();

            txtUserName.Focus();
        }
    } 
}
