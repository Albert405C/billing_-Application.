using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class frmbilligdetails : Form
    {
        private DataTable customerOrderTable;

        public frmbilligdetails()
        {
            InitializeComponent();
            customerOrderTable = new DataTable();
            customerOrderTable.Columns.Add("YOUR PRODUCT", typeof(string));
            customerOrderTable.Columns.Add("YOUR PRICE", typeof(int));
            customerOrderTable.Columns.Add("THE QUANTITY", typeof(int));
            customerOrderTable.Columns.Add("TOTAL", typeof(int));
            dgvCustomerOrder.DataSource = customerOrderTable;
        }

        private void frmbilligdetails_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            string yourproduct = txtTypeofproduct.Text;
            int yourprice = int.Parse(txtPrice.Text);
            int yourquantity = int.Parse(txtSizeofgoods.Text);
            int total = yourprice * yourquantity;

            customerOrderTable.Rows.Add(yourproduct, yourprice, yourquantity, total);
            ClearText();

        }
        private void ClearText()
        {
        txtTypeofproduct.Text = "";
        txtPrice.Text = "";
        txtSizeofgoods.Text ="";

        }

        private void btnCalculatetotal_Click(object sender, EventArgs e)
        {
            int total = 0;

            foreach (DataRow row in customerOrderTable.Rows)
            {
                total += (int)row["total"];
            }
            txttotal.Text = total.ToString();
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your receipt is printed");
            ClearText();
            customerOrderTable.Clear();
            txttotal.Text = "";
        }
    }
}
