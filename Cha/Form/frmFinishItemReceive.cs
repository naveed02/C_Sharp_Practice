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
    public partial class frmFinishItemReceive : Form
    {
        int fcboDefaultValue = 0;
        public frmFinishItemReceive()
        {
            InitializeComponent();
        }

        private void frmFinishItemReceive_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void AtFormLoad()
        {
            String lSQL = string.Empty;
            
            //Category Combo Fill
            lSQL = "select distinct 1, RIGHT(ItemCode,1) from Item";

            clsFillCombo.FillCombo(cboCategory, clsGVar.ConString1, "Item" + "," + "" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboCategory.SelectedValue);
            

            //Employee Combo Fill
            lSQL = " select employeeid, first_name + ' ' + last_name AS Name from PR_Employee ";

            clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);

            //ItemGroup Combo Fill
            lSQL = " select cgCode, cgdDesc from CatDtl where cgCode = 6";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);
        }
       

        private void grd1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinishItemReceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
