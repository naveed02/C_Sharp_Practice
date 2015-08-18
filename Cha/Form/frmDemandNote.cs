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
    public partial class frmDemandNote : Form
    {
        int fcboDefaultValue = 0;

        public frmDemandNote()
        {
            InitializeComponent();
        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void lblItemGroup_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDemandNote_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            //Department Combo Fill
            lSQL = "  select distinct d.DepartmentId, pd.department_name AS Name from DN d ";
            lSQL += " INNER JOIN PR_Department pd ON pd.DepartmentId = d.departmentid ";

            clsFillCombo.FillCombo(cboDepartment, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboDepartment.SelectedValue);

            //Employee Combo Fill
            lSQL = " select employeeid, first_name + ' ' + last_name AS Name from PR_Employee ";

            clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = " + Convert.ToString((int)Category.enmItemGroup);

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            //Godown Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 2";

            clsFillCombo.FillCombo(cboGodownForBal, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboGodownForBal.SelectedValue);
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNote1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmDemandNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtDemandNote_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        #region LookUp_Voc

        private void LookUp_Voc()
        {
            frmLookUp sForm = new frmLookUp(

//                SELECT d.DNId, d.Date, i.cgdDesc AS ItemGroupName, dept.department_name,
//e.first_name + ' ' + e.last_name AS EmpName, d.Note
//FROM DN d
//INNER JOIN CatDtl i ON d.ItemGroupId = i.cgdCode AND i.cgCode = 6
//INNER JOIN PR_Department dept ON d.DepartmentId = dept.departmentid
//INNER JOIN PR_Employee e ON d.EmployeeId = e.employeeid

                    "d.DNId", //select
                    "d.Date, i.cgdDesc AS ItemGroupName, dept.department_name,e.first_name + ' ' + e.last_name AS EmpName, d.Note", //select
                    "  DN d INNER JOIN CatDtl i ON d.ItemGroupId = i.cgdCode AND i.cgCode = 6 INNER JOIN PR_Department dept ON d.DepartmentId = dept.departmentid INNER JOIN PR_Employee e ON d.EmployeeId = e.employeeid", //from and join
                    this.Text.ToString(),
                    1,
                    "DN #,DN Date,Item Group,Department,Employee Name,Note", // displayed columns names
                    "10,8,12,12,12,15", // column width
                    " T, T, T, T, T, T", //Column type
                    true,
                    "",
                    "",
                    "TextBox" //text box is the type of gate inword
                    );

            txtDemandNote.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();

            if (txtDemandNote.Text != null)
            {
                if (txtDemandNote.Text != null)
                {
                    if (txtDemandNote.Text.ToString() == "" || txtDemandNote.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtDemandNote.Text.ToString().Trim().Length > 0)
                    {
                        // PopulateRecords();
                    }

                }

            }
        }
        #endregion

        private void PassDataVocID(object sender)
        {
            txtDemandNote.Text = ((TextBox)sender).Text;
        }

        private void txtDemandNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }

        private void btnF1Help_Click(object sender, EventArgs e)
        {
            LookUp_Voc();
        }
    }
}
