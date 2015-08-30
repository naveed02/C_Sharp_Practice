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
    public partial class frmSaleOrderEntryFactory : Form
    {
        public frmSaleOrderEntryFactory()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmSaleOrderEntryQuotationFactory_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmSaleOrderEntryQuotationFactory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            { 
                this.Close();
            }

        }

        
    }
}
