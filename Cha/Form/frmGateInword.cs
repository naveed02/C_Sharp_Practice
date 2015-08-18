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
    public partial class frmGateInword : Form
    {
        int fcboDefaultValue = 0;

        public frmGateInword()
        {
            InitializeComponent();
        }

        private void frmGateInword_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            String lSQL = string.Empty;

            //Gate Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 20 ORDER BY cgdDesc";

            clsFillCombo.FillCombo(cboGate, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboGate.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void lblItemGroup_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateGateInword_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnF1Help_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnExitSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrinting_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGate_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblReceivingPersonName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkPrinter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalQty1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalQty_Click(object sender, EventArgs e)
        {

        }

        private void optInProcess_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void optApprovedVerified_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmGateInword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtGateInwordNumber_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtGateInwordNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }

        #region LookUp_Voc

        private void LookUp_Voc()
        {
            frmLookUp sForm = new frmLookUp(
                    "gi.GateInwordId",
                    "gi.Date, cd.cgdDesc AS ItemGroupName, "
                    + "g.GRNId,g.Date AS GRNDate,g.Note,gi.GateTime, gt.cgdDesc AS GateName",
                    " GateInword gi INNER JOIN CatDtl cd ON gi.ItemGroupID=cd.cgdCode AND cd.cgCode=6 LEFT OUTER JOIN GRN g ON gi.GateInwordId=g.GateInwordId INNER JOIN CatDtl gt ON gi.GateID = gt.cgdCode AND gt.cgCode = 20 ",
                    this.Text.ToString(),
                    1,
                    "GateInword#,Date,Item Group Name,Grn Id,Grn Date,Note, Gate Time ",
                    "10,8,12,12,12,15,8",
                    " T, T, T, T, T, T, T",
                    true,
                    "",
                    "",
                    "TextBox" //text box is the type of gate inword
                    );

            txtGateInwordNumber.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();

            if (txtGateInwordNumber.Text != null)
            {
                if (txtGateInwordNumber.Text != null)
                {
                    if (txtGateInwordNumber.Text.ToString() == "" || txtGateInwordNumber.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtGateInwordNumber.Text.ToString().Trim().Length > 0)
                    {
                       // PopulateRecords();
                    }

                }

            }
        }
        #endregion

        private void PassDataVocID(object sender)
        {
            txtGateInwordNumber.Text = ((TextBox)sender).Text;
        }

        private void txtGateInwordNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmGateInword_DoubleClick(object sender, EventArgs e)
        {

        }

    }
}
