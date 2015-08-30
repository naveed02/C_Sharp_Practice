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

        private void txtDemandNote_DoubleClick_1(object sender, EventArgs e)
        {
            LookUp_VocPur();
        }

        #region LookUp_VocPur

        private void LookUp_VocPur()
        {
            frmLookUp sForm = new frmLookUp(

//select m.DNId, m.Date, i.cgdDesc AS ItemGroupName, d.department_name, 
//e.first_name + ' ' + e.last_name AS EmpName, m.Note
//from DN m
//INNER JOIN CatDtl i ON m.ItemGroupId = i.cgdCode AND i.cgCode = 6
//INNER JOIN PR_Department d ON m.DepartmentId = d.departmentid
//INNER JOIN PR_Employee e ON m.EmployeeId = e.employeeid

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
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocIDPurc);
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

        private void PassDataVocIDPurc(object sender)
        {
            txtDemandNote.Text = ((TextBox)sender).Text;
        }

        private void txtPurchaseOrder_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1) 
            {
                LookUp_VocPur();
            }
        }
    }
}
