﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDevelop
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }      

        private void HomeScreen_Load(object sender, EventArgs e)
        {


           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void button9_Click(object sender, EventArgs e)
        {
             LoginScreen loginScreen = new LoginScreen();
             loginScreen.Show();

             this.Close();
 
                

        }

        private void ProductList_Click(object sender, EventArgs e)
        {

        }

        private void StockList_Click(object sender, EventArgs e)
        {

        }

        private void AwardInput_Click(object sender, EventArgs e)
        {

        }

        private void ManufacturerOrderList_Click(object sender, EventArgs e)
        {

        }

        private void UndispatchedList_Click(object sender, EventArgs e)
        {

        }

        private void ShopList_Click(object sender, EventArgs e)
        {

        }

        private void MakerList_Click(object sender, EventArgs e)
        {

        }

        private void LogList_Click(object sender, EventArgs e)
        {

        }
    }
}
