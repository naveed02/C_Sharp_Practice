using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cha.Class;

namespace Cha
{
    public partial class frmPurchaseOrder : Form
    {
        int fcboDefaultValue = 0;

        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            //Employee Combo Fill
            lSQL = " select employeeid, first_name + ' ' + last_name AS Name from PR_Employee ";

            clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = " + Convert.ToString((int)Category.enmItemGroup);

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);
        }

        private void lblDemandNote1_Click(object sender, EventArgs e)
        {

        }

        private void lblDemandNote_Click(object sender, EventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmpCode_Click(object sender, EventArgs e)
        {

        }

        private void cboEmpCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblVendorCode_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblPurchaserOrder_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblItemGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboItemGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNamePurchaser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamVendore_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNamePurchaser_Click(object sender, EventArgs e)
        {

        }

        private void lblNameVendor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void optInProgress_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExitSave_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNote1_Click(object sender, EventArgs e)
        {

        }

        private void optForPurchsePrint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDemandNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDemandNote_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        #region LookUp_Voc

        private void LookUp_Voc()
        {
            frmLookUp sForm = new frmLookUp(

////                select p.POId, p.Date, p.DNId, p.DNDate, e.first_name + ' ' + e.last_name AS EmployeeName, p.Note
//                    from PO p
//                    INNER JOIN PR_Employee e ON p.EmployeeId = e.employeeid

                    "p.POId",
                    " p.Date, p.DNId, p.DNDate, e.first_name + ' ' + e.last_name AS EmployeeName, p.Note",
                    "  PO p INNER JOIN PR_Employee e ON p.EmployeeId = e.employeeid", //from and join
                    this.Text.ToString(),
                    1,
                    "P.O.#, P.O. Date, Demand Note #, D.N.Date, Employee Name, Note", // displayed columns names
                    "10,8,12,12,12,15", // column width
                    " T, T, T, T, T, T", //Column type
                    true,
                    "",
                    "",
                    "TextBox" //text box is the type of gate inword
                    );

            txtPurchaseOrder.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();

            if (txtPurchaseOrder.Text != null)
            {
                if (txtPurchaseOrder.Text != null)
                {
                    if (txtPurchaseOrder.Text.ToString() == "" || txtPurchaseOrder.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtPurchaseOrder.Text.ToString().Trim().Length > 0)
                    {
                        // PopulateRecords();
                    }

                }

            }
        }
        #endregion

        private void PassDataVocID(object sender)
        {
            txtPurchaseOrder.Text = ((TextBox)sender).Text;
        }
    }
}
