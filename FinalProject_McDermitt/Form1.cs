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
        private void gotoModify()
        {
            frmModify modify = new frmModify();
            this.Hide();
            modify.ShowDialog();

            this.Close();
        }

        private void gotoSpecials()
        {
            frmSpecials specials = new frmSpecials();
            this.Hide();
            specials.ShowDialog();

            this.Close();
        }

        public frmBegin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gotoSpecials();
        }

        private void modifySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoModify();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoSpecials();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
