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
    public partial class frmGateOutword : Form
    {
        int fcboDefaultValue = 0;
        public frmGateOutword()
        {
            InitializeComponent();
        }

        private void frmGateOutword_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }


        private void AtFormLoad()
        {
            String lSQL = string.Empty;

         
            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGateOutword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
