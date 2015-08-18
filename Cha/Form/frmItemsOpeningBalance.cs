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
    public partial class frmItemsOpeningBalance : Form
    {
        int fcboDefaultValue = 0;
        public frmItemsOpeningBalance()
        {
            InitializeComponent();
        }

        private void cboItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmItemsOpeningBalance_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }


        private void AtFormLoad()
        {
            String lSQL = string.Empty;

            //Category Combo Fill
            lSQL = "select distinct 1, RIGHT(ItemCode,1) from Item";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "Item" + "," + "" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup1, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup1.SelectedValue);
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemsOpeningBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
