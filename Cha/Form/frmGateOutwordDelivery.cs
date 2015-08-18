using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cha
{
    public partial class frmGateOutwardDelivery : Form
    {
        public frmGateOutwardDelivery()
        {
            InitializeComponent();
        }

        private void chkPrinter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmGateOutwardDelivery_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGateOutwardDelivery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
