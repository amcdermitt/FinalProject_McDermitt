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
    public partial class frmSpecials : Form
    {

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

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

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

        private void lstProductName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
