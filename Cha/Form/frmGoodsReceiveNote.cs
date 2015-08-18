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
    public partial class frmGoodsReceiveNote : Form
    {
        int fcboDefaultValue = 0;
        public frmGoodsReceiveNote()
        {
            InitializeComponent();
        }

        private void btnF1HelpAddNew_Click(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void optSingleItemGroup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmGoodsReceiveNote_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }
        private void AtFormLoad()
        {
            String lSQL = string.Empty;

            //Type Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 8";

            clsFillCombo.FillCombo(cboType, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboType.SelectedValue);

            //LC# Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 9";

            clsFillCombo.FillCombo(cboLC, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboLC.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            //Gate Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 20 ORDER BY cgdDesc";

            clsFillCombo.FillCombo(cboGate, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboGate.SelectedValue);
        }


        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoodsReceiveNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
