using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specials
{

    /// <summary>
    /// creates an item object for the item information
    /// </summary>
    struct Item
    {
        public int id; //holds item id
        public string productName; //holds item product name
        public double salePrice; //holds item sale price
        public double originalPrice; //holds item original price
        public string storeName; //holds item store name
        public DateTime expiration; //holds item expiration date
    }

    public partial class frmSpecials : Form
    {

        List<Item> saleItems = new List<Item>(); //holds list fot the sale items
        List<Item> filterItems = new List<Item>(); //holds list fot the items that are filtered
        List<string> productNames = new List<string>(); //holds list for the names of the products
        const double SALES_TAX = .07; //holds sales tax constant


        /// <summary>
        /// displays string to status label
        /// </summary>
        /// <param name="status"></param>
        private void DisplayStatus(string status)
        {
            lblStatus.Text = status;
        }

        /// <summary>
        /// copies the saleItems list with the filterItems list if the expiration has not expired
        /// </summary>
        private void CopyList()
        {
            DateTime today = DateTime.Today; //holds today's days

            filterItems.Clear();

            //loops to add each item as long as it is not expired
            foreach (Item product in saleItems)
            {
                if (product.expiration >= today)
                {
                    filterItems.Add(product);
                }

            }
        }

        /// <summary>
        /// displays items in the filter list to the listbox
        /// </summary>
        private void DisplayReportList()
        {
            foreach (Item name in filterItems)
            {

                lstItems.Items.Add(name.productName);
            }
        }

        /// <summary>
        /// determines what the price of the selected items are when they are on sale
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private double TransactionTotal(List<int> index)
        {
            double subtotal = 0; //holds the subtotal
            double total = 0; //holds the total including tax

            //adds all of the selected producs sale prices together
            foreach (int number in index)
            {
                subtotal += filterItems[number].salePrice;
            }

            //checks to see if the radio button is yes or no and adds or doesnt add tax
            if (radYes.Checked)
            {
                total = subtotal + (subtotal * SALES_TAX);
            }
            else
            {
                total = subtotal;
            }

            return total;
        }

        /// <summary>
        /// clears the form list and labels. resets radio button and check box. re-displays lists
        /// </summary>
        private void Clear()
        {
            lstItems.Items.Clear();
            lstItems.ClearSelected();
            DisplayStatus("Form Cleared");
            lblCost.Text = "";
            radYes.Checked = true;
            lstFilter.ClearSelected();
            chkReport.Checked = false;
            CopyList();
            DisplayReportList();
        }

        private void gotoMainMenu()
        {
            frmBegin mainMenu = new frmBegin();
            this.Hide();
            mainMenu.ShowDialog();

            this.Close();
        }

        private void gotoModify()
        {
            frmModify modify = new frmModify();
            this.Hide();
            modify.ShowDialog();

            this.Close();
        }

        public frmSpecials()
        {
            InitializeComponent();
        }

        private void View_Specials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleItemsDataSet.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.saleItemsDataSet.Sale);
            List<string> storeNames = new List<string>(); //holds store names in a list
            Item sale = new Item(); //holds each sale item

            //loops through adding each item in the database to the list through the object
            foreach (var name in lstProductName.Items)
            {

                sale.id = int.Parse(((DataRowView)name)["SaleId"].ToString());
                sale.productName = ((DataRowView)name)["Product Name"].ToString();
                sale.salePrice = double.Parse(((DataRowView)name)["Sale Price"].ToString());
                sale.originalPrice = double.Parse(((DataRowView)name)["Original Price"].ToString());
                sale.storeName = ((DataRowView)name)["Store Name"].ToString();
                sale.expiration = DateTime.Parse(((DataRowView)name)["Expiration Date"].ToString());

                saleItems.Add(sale);
            }

            CopyList();
            DisplayReportList();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifySpecialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        private void lblSalePrice_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// calls clear method to clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// gets the selected indecies and adds to a list, calls the method to get the transaction total and displays labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            List<int> selectedItems = new List<int>(); //list to holds selected indecies
            double amount; //variable to hold total amount

            //loops through selected indecies and adding to list
            foreach (int number in lstItems.SelectedIndices)
            {
                selectedItems.Add(number);
            }

            amount = TransactionTotal(selectedItems);

            lblCost.Text = amount.ToString("c");
            DisplayStatus("Total Amount Displayed.");
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// if the expiration date has passed, displays an errorProvider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            errProviderExpire.Clear();
            DateTime today = DateTime.Today; //holds today's date

            //determines if the expiration date has passed or not
            if (DateTime.Parse(lblExpiration.Text.ToString()) < today)
            {
                errProviderExpire.SetError(lblExpiration, "Please delete record or change Expiration Date");
            }
        }
    }
}
