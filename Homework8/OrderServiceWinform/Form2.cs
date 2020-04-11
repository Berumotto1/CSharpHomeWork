using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework5;
namespace OrderServiceWinform
{
    public partial class Form2 : Form
    {

        public string createOrderID { get; set; }
        public string createCustomerID { get; set; }
        public string createDate { get; set; }
        public string createProductName { get; set; }
        public string createProductNum { get; set; }


        public Form2()
        {
            InitializeComponent();

            CreateOrderID.DataBindings.Add("Text", this, "createOrderID");
            CreateCustomerID.DataBindings.Add("Text", this, "createCustomerID");
            CreateProductName.DataBindings.Add("Text", this, "createProductName");
            CreateProductNum.DataBindings.Add("Text", this, "createProductNum");
            
        }

        private void QueryOrder_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void CreateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
