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
    public partial class frmGoodsReceiveNoteReturn : Form
    {
        int fcboDefaultValue = 0;
        public frmGoodsReceiveNoteReturn()
        {
            InitializeComponent();
        }

        private void frmGoodsReceiveNoteReturn_Load(object sender, EventArgs e)
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

            
            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

        }





        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGoodsReceiveNoteReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
