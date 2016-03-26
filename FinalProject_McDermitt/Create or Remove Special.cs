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
    public partial class frmModify : Form
    {

        Boolean dayChanged = false; //checks to see if you changed the date when adding
        Boolean dataSaved = true; //checks to see if you modified data
        string deletedItem = ""; //holds a empty deletedItem

        /// <summary>
        /// method to go to the specials form
        /// </summary>
        private void gotoSpecials()
        {
            frmSpecials specials = new frmSpecials(); //variable specials to change to the specials form
            this.Hide();
            specials.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// method to go to the main menu form
        /// </summary>
        private void gotoMainMenu()
        {
            frmBegin mainMenu = new frmBegin(); //variable mainMenu to change to the main menu form
            this.Hide();
            mainMenu.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// method to display if the data has not been saved when exiting
        /// </summary>
        /// <returns></returns>
        private Boolean NotSaved()
        {
            Boolean result; //holds result of the dialogbox
            DialogResult saveFile = MessageBox.Show("You have unsaved data. Do you want to continue without saving?", "Confirmation", MessageBoxButtons.YesNo); //holds DialogResult data for what user selects 

            //determins what the user selected
            if (saveFile == DialogResult.No)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// method to make all of the buttons and text boxes visible or not
        /// </summary>
        private void ToggleButtons()
        {

            //data has been saved, disables text boxes, enables buttons
            if (dataSaved == true)
            {
                bindingNavigatorMoveLastItem.Enabled = true;
                bindingNavigatorMoveNextItem.Enabled = true;
                bindingNavigatorMoveFirstItem.Enabled = true;
                bindingNavigatorMovePreviousItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
                txtProductName.Enabled = false;
                txtSalePrice.Enabled = false;
                txtOriginalPrice.Enabled = false;
                txtStoreName.Enabled = false;
                dtpExpiration.Enabled = false;
            }
            //data has not bee saved, enables text boxes, disables buttons
            else
            {
                bindingNavigatorMoveLastItem.Enabled = false;
                bindingNavigatorMoveNextItem.Enabled = false;
                bindingNavigatorMoveFirstItem.Enabled = false;
                bindingNavigatorMovePreviousItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                txtProductName.Enabled = true;
                txtSalePrice.Enabled = true;
                txtOriginalPrice.Enabled = true;
                txtStoreName.Enabled = true;
                dtpExpiration.Enabled = true;
            }
        }

        public frmModify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// validates text boxes, adds and saves all items, displays status label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //resets error labels and status label
            lblStatus.Text = "";
            errProviderSaleID.Clear();
            errProviderStoreName.Clear();
            errProviderSale.Clear();
            errProviderProductName.Clear();
            errProviderOriginal.Clear();
            errProviderExpire.Clear();

            Boolean newItem = false; //holds if the item edited is a new item
            DateTime thisDay = DateTime.Today; //holds today's date
            DateTime expire = dtpExpiration.Value; //holds expiration date

            //validates text boxes
            if (txtSaleId.Text == "")
            {
                errProviderSaleID.SetError(txtSaleId, "Please enter an ID");
                txtSaleId.Text = "-1";
                return;
            }
            if (txtProductName.Text == "")
            {
                errProviderProductName.SetError(txtProductName, "Please enter a product name");
                return;
            }
            if (txtSalePrice.Text == "")
            {
                errProviderSale.SetError(txtSalePrice, "Please enter a valid sale price");
                return;
            }
            if (txtOriginalPrice.Text == "")
            {
                errProviderOriginal.SetError(txtOriginalPrice, "Please enter a valid original price");
                return;
            }
            if (txtStoreName.Text == "")
            {
                errProviderStoreName.SetError(txtStoreName, "Please enter a valid store name");
                return;
            }
            if (expire < thisDay)
            {
                errProviderExpire.SetError(dtpExpiration, "Please enter a date that has not expired already");
                return;
            }

            //checks to see if it is a new item
            if (double.Parse(txtSaleId.Text) <= -1)
            {
                newItem = true;
            }


            //must change date if it's a new item
            if (newItem)
            {


                if (dayChanged == false || dtpExpiration.Value == DateTime.MinValue)
                {
                    errProviderExpire.SetError(dtpExpiration, "Please re-select the date");
                    return;

                }
            }

            this.Validate();
            this.saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleItemsDataSet);

            //update status label if it is a new item or not
            if (newItem)
            {
                newItem = true;
                lblStatus.Text = "Added Item: " + txtProductName.Text;
            }
            else
            {
                lblStatus.Text = "All Items saved";
            }

            //update values and togglebuttons
            dayChanged = false;
            dataSaved = true;
            ToggleButtons();

        }

        /// <summary>
        /// fills the data set with the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmModify_Load(object sender, EventArgs e)
        {
            //this.saleTableAdapter.DeleteQuery();
            // TODO: This line of code loads data into the 'saleItemsDataSet.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.saleItemsDataSet.Sale);


        }

        /// <summary>
        /// checks if data is saved or not and runs method, closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!dataSaved)
            {
                if (!NotSaved())
                {
                    return;
                }
            }
            Close();
        }

        /// <summary>
        /// checks if data is saved or not and runs method, goes back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {

            if (!dataSaved)
            {
                if (!NotSaved())
                {
                    return;
                }
            }
            gotoMainMenu();

        }

        /// <summary>
        /// checks if data is saved or not and and runs method, goes back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!dataSaved)
            {
                if (!NotSaved())
                {
                    return;
                }
            }
            gotoMainMenu();
        }

        /// <summary>
        /// checks if data is saved or not and runs method, closes application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!dataSaved)
            {
                if (!NotSaved())
                {
                    return;
                }
            }
            Close();
        }

        /// <summary>
        /// checks if data is saved or not and runs method, goes to specials form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!dataSaved)
            {
                if (!NotSaved())
                {
                    return;
                }
            }
            gotoSpecials();
        }

        /// <summary>
        /// if the expiration date is selected, it changes the dayChanged to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpExpiration_MouseDown(object sender, MouseEventArgs e)
        {
            dayChanged = true;
        }

        /// <summary>
        /// when the key is pressed in txtSaleId, makes sure letters are not pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSaleId_KeyPress(object sender, KeyPressEventArgs e)
        {
            errProviderSaleID.Clear();
            if (Char.IsLetter(e.KeyChar))
            {
                errProviderSaleID.SetError(txtSaleId, "Please enter only a number");
                e.Handled = true;
            }
        }

        /// <summary>
        /// when a key is pressed in txtSalePrice, makes sure letters are not pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            errProviderSale.Clear();
            if (Char.IsLetter(e.KeyChar))
            {
                errProviderSale.SetError(txtSalePrice, "Please enter only a number");
                e.Handled = true;
            }
        }

        /// <summary>
        /// when a key is pressed in txtOriginalPrice, makes sure letters are not pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtOriginalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            errProviderOriginal.Clear();
            if (Char.IsLetter(e.KeyChar))
            {
                errProviderOriginal.SetError(txtOriginalPrice, "Please enter only a number");
                e.Handled = true;
            }
        }

        /// <summary>
        /// deletes item, displays status label, changes data saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Item Deleted: " + deletedItem;
            dataSaved = false;
        }

        /// <summary>
        /// sets the item to be deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_MouseEnter(object sender, EventArgs e)
        {
            deletedItem = txtProductName.Text;
        }

        /// <summary>
        /// lets you add a new item, sets data saved to false, toggles buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dataSaved = false;
            ToggleButtons();
        }

        /// <summary>
        /// lets you edit an item, sets data saved to false, toggles buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editNavigator_Click(object sender, EventArgs e)
        {
            dataSaved = false;
            ToggleButtons();
        }
    }
}
