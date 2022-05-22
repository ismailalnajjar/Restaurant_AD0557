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
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            
            InitializeComponent();
            firstControl1.BringToFront();
           
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            firstControl1.BringToFront();
        }

        private void btnTheoffers_Click(object sender, EventArgs e)
        {
            secControl1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTheDrinks_Click(object sender, EventArgs e)
        {
            theDrinkControl1.BringToFront();
        }

        private void btnIceCream_Click(object sender, EventArgs e)
        {
            iceControl1.BringToFront();
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
