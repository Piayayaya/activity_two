using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionOutputBox.Text = WishList.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            WishList.Items.Add("iPhone 14 Pro Max");
            WishList.Items.Add("House and Lot");
            WishList.Items.Add("Travel to Japan");
            WishList.Items.Add("Go to Imagine Dragons concert");
            WishList.Items.Add("Graduate");
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            WishList.Sorted = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            WishList.Items.Clear();
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            CountOutputBox.Text = Convert.ToString(WishList.Items.Count);
        }
    }
}
