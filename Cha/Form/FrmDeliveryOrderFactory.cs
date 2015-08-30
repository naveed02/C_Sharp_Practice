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
    public partial class FrmDeliveryOrderFactory : Form
    {
        public FrmDeliveryOrderFactory()
        {
            InitializeComponent();
        }

        private void FrmDeliveryOrderFactory_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void FrmDeliveryOrderFactory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
