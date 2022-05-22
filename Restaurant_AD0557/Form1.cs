using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_AD0557
{
    public partial class RestaurantAcc : Form
    {
        private List<User> Ulist = new List<User>();
        public RestaurantAcc()
        {
            InitializeComponent();
            User user1 = new User("ism", "123");
            User user2 = new User("adi", "123");
            Ulist.Add(user1);
            Ulist.Add(user2);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();                   //Close The Form1
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            string USERNAME = txtUserName.Text;
            string PASSWORD = txtPassword.Text;
            foreach (User user3 in Ulist)
            {
                if (USERNAME == user3.UserName && PASSWORD == user3.Password) 
                {
                    this.Hide();

                    frm.Show();
                }
            }
            
                
               
               
        }
    }
}
