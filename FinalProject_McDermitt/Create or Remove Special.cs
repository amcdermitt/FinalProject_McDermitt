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

        private void gotoSpecials()
        {
            frmSpecials specials = new frmSpecials();
            this.Hide();
            specials.ShowDialog();

            this.Close();
        }

        private void gotoMainMenu()
        {
            frmBegin mainMenu = new frmBegin();
            this.Hide();
            mainMenu.ShowDialog();

            this.Close();
        }



        public frmModify()
        {
            InitializeComponent();
        }

        private void saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.saleItemsDataSet);

        }

        private void frmModify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'saleItemsDataSet.Sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.saleItemsDataSet.Sale);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
           
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoMainMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoSpecials();
        }
    }
}
