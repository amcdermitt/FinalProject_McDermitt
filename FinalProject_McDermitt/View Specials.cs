/*
 Name: Andrew McDermitt
 Project: Final Project: Sales Application
 Date: 4/21/2016
 Purpose: Form to view the specials and create reports.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        /// determines what the price of selected items are when not on sale
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private double TransactionSavings(List<int> index)
        {
            double subtotal = 0; //holds subtotal
            double total = 0; //holds total including tax

            //adds all of the selected products original prices together
            foreach (int number in index)
            {
                subtotal += filterItems[number].originalPrice;
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

        /// <summary>
        /// method to switch to the main menu
        /// </summary>
        private void gotoMainMenu()
        {
            frmBegin mainMenu = new frmBegin(); //creates a mainMenu variable to switch to the main menu
            this.Hide();
            mainMenu.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// method to switch to the modify form
        /// </summary>
        private void gotoModify()
        {
            frmModify modify = new frmModify(); //creates a modify variable to switch to the modify form
            this.Hide();
            modify.ShowDialog();

            this.Close();
        }

        public frmSpecials()
        {
            InitializeComponent();
        }

        /// <summary>
        /// displays all information from the database and adds it to an object list, calls other methods to copy and display more items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            DateTime today = DateTime.Today; //holds today's date

            //adds each store name to the storeNames list
            foreach (Item storeName in saleItems)
            {
                if (storeName.expiration >= today)
                {
                    storeNames.Add(storeName.storeName);
                }

            }

            //sorts the list
            storeNames.Sort();

            //loops through the storeNames list and deletes duplicates
            int index = 0;//holds index
            while (index < storeNames.Count - 1)
            {
                if (storeNames[index] == storeNames[index + 1])
                    storeNames.RemoveAt(index);
                else
                {
                    index++;
                }
            }

            //adds all of the store names to the list box
            foreach (string name in storeNames)
            {
                lstFilter.Items.Add(name);
            }

        }

        /// <summary>
        /// calls gotoMainMenu method and goes back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        /// <summary>
        /// calls gotoMainMenu method and goes back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// calls the gotoModify method and goes to the modify form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifySpecialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        /// <summary>
        /// nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// enables or disables the group box when checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked)
            {
                grpFilter.Enabled = true;
            }
            else
            {
                grpFilter.Enabled = false;
            }
        }


        /// <summary>
        /// gets which stores are selected and calls methods to filter the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (lstFilter.SelectedIndex == -1)
            {
                DisplayStatus("No store selected to filter.  Please select a store.");
                return;
            }
            List<string> selectedItem = new List<string>(); //holds all of the selected store names
            filterItems.Clear(); //clears the filterItems list

            //loops through the selected store names and adds them to the selectedItem list
            foreach (string name in lstFilter.SelectedItems)
            {
                selectedItem.Add(name);
            }

            //clears the lstItems listbox
            lstItems.Items.Clear();

            //adds each item with the selected store name to the filterItems list
            DateTime today = DateTime.Today;
            foreach (Item name in saleItems)
            {

                foreach (string storeName in selectedItem)
                {
                    if (name.storeName == storeName)
                    {

                        if (name.expiration >= today)
                        {
                            filterItems.Add(name);
                        }
                        // filterItems.Add(name);
                        // lstItems.Items.Add(name.productName);
                    }
                }





            }
            //re-displays listbox
            DisplayReportList();
        }

        /// <summary>
        /// creates report with the selected items in a new file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile; //holds streamwriter
            double amount = 0; //holds total sale amount
            double original = 0; //holds amount without sale
            double savings = 0; //holds the savings amount
            saveFileDialog1.Filter = "Text | *.txt | Word Document | *.doc "; //filters the way you can save files

            //when the user presses OK
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog1.FileName); //creates new text file

                List<int> selectedItems = new List<int>(); //holds selectedItems in a list

                //adds all selected items into new list
                foreach (int number in lstItems.SelectedIndices)
                {
                    selectedItems.Add(number);
                }

                //loops through and outputs all item information to the list
                foreach (int number in selectedItems)
                {

                    outputFile.WriteLine("Item: " + filterItems[number].productName);
                    outputFile.WriteLine("Sale Price: " + filterItems[number].salePrice.ToString("c"));
                    outputFile.WriteLine("Original Price: " + filterItems[number].originalPrice.ToString("c"));
                    outputFile.WriteLine("Store Name: " + filterItems[number].storeName);
                    outputFile.WriteLine("Expiration Date: " + filterItems[number].expiration);
                    outputFile.WriteLine("");

                }

                amount = TransactionTotal(selectedItems); //gets the total sale amount
                original = TransactionSavings(selectedItems); //gets the total amount without sale
                savings = original - amount; //holds total savings
                outputFile.WriteLine("------------------------------");

                //determines if they wanted tax or not
                if (radYes.Checked)
                {
                    outputFile.WriteLine("You chose to include tax: ");
                }
                else
                {
                    outputFile.WriteLine("You chose to not include tax: ");
                }

                //displays information
                outputFile.WriteLine("It would cost " + original.ToString("c") + " at normal price");
                outputFile.WriteLine("It costs " + amount.ToString("c") + " at the sale price");
                outputFile.WriteLine("You are saving a total of " + savings.ToString("c"));



                outputFile.Close();

                DisplayStatus("Report Created");
            }
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
