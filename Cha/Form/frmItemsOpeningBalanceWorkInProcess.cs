﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cha
{
    public partial class frmItemsOpeningBalanceWorkInProcess : Form
    {
        int fcboDefaultValue = 0;
        public frmItemsOpeningBalanceWorkInProcess()
        {
            InitializeComponent();
        }

        private void lblIOWIP_Click(object sender, EventArgs e)
        {

        }

        private void frmItemsOpeningBalanceWorkInProcess_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            String lSQL = string.Empty;

            //Department Combo Fill
            lSQL = "  select distinct d.DepartmentId, pd.department_name AS Name from DN d ";
            lSQL += " INNER JOIN PR_Department pd ON pd.DepartmentId = d.departmentid ";

            clsFillCombo.FillCombo(cboDepartment, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboDepartment.SelectedValue);

            //Employee Combo Fill
            lSQL = " select employeeid, first_name + ' ' + last_name AS Name from PR_Employee ";

            clsFillCombo.FillCombo(cboEmployee, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboEmployee.SelectedValue);

            //Purpose Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboPurpose, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboPurpose.SelectedValue);

            //Machine # Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 11";

            clsFillCombo.FillCombo(cboMachine, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboMachine.SelectedValue);

            //Contractor Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 12";

            clsFillCombo.FillCombo(cboContractor, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboContractor.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);
        }
       

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemsOpeningBalanceWorkInProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
