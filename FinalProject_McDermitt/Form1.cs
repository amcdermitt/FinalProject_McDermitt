/*
 Name: Andrew McDermitt
 Project: Final Project: Sales Application
 Date: 4/21/2016
 Purpose: Form for main menu.
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

namespace Specials
{
    public partial class frmBegin : Form
    {

        /// <summary>
        /// method to go to the modify form
        /// </summary>
        private void gotoModify()
        {
            frmModify modify = new frmModify(); //create a modify variable to move to the new form
            this.Hide();
            modify.ShowDialog();

            this.Close();
        }

        /// <summary>
        /// method to go to the specials form
        /// </summary>
        private void gotoSpecials()
        {
            frmSpecials specials = new frmSpecials(); //create a specials variable to move to the specials form
            this.Hide();
            specials.ShowDialog();

            this.Close();
        }

        public frmBegin()
        {
            InitializeComponent();
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
        /// button to call the gotoModify method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        /// <summary>
        /// button to go to the gotoSpecials method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            gotoSpecials();
        }

        /// <summary>
        /// option to go to the gotoModify method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        /// <summary>
        /// option to go to the gotoSpecials method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoSpecials();
        }

        /// <summary>
        /// option to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
