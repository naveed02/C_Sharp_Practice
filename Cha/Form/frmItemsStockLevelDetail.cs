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
    public partial class frmItemsStockLevelDetail : Form
    {
        int fcboDefaultValue = 0;
        public frmItemsStockLevelDetail()
        {
            InitializeComponent();
        }

        private void frmItemsStockLevelDetail_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
            
        }

        private void AtFormLoad()
        {
        
            String lSQL= String.Empty;

            // Item Group Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6 "; 
            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "Items" + "," + ","+ "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            //Category Combo Fill
            lSQL = "select distinct 1, RIGHT(ItemCode,1) from Item";

            clsFillCombo.FillCombo(cboCategory, clsGVar.ConString1, "Item" + "," + "" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboCategory.SelectedValue);
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemsStockLevelDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
