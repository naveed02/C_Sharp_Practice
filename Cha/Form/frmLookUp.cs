using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
//using GUI_Task.PrintDataSets;
using System.Data.SqlClient;

namespace Cha
{
  public partial class frmLookUp : Form
  {
    // Constructor Fields 
    string fKeyField = string.Empty;         // 1
    string fFL = string.Empty;               // 2
    string fTableName = string.Empty;        // 3
    string fFormTitle = string.Empty;        // 4
    int fDefaultFindField = 1;               // 5
    string fFT = string.Empty;               // 6
    string fTitleWidth = string.Empty;       // 7
    string fTitleFormat = string.Empty;      // 8
      // One or More Tables
    bool fOneTable = true;                   // D 1
    string fJoin = string.Empty;             // D 2    
    string fAddWhere = string.Empty;        // Additional Where
    string fTBType = string.Empty;           // D 3     11 Text Box Type MaskedTextBox or TextBox (mTextBox, TextBox)
    bool fGridControl = false;

    int fGridColumns = 0;
    // RunTime Fields
    string[] fFieldList;
    string[] fTitleList;
    //
    string fFindField = string.Empty;
    string isLoading = "Y";
    //
    DataSet dtset = new DataSet();
    //
    public delegate void LUPassControl(object sender);

    // Declare a new instance of the delegate (null)
    public LUPassControl lupassControl;
    private string p;
    private string p_2;
    private string fTableNameCOA;
    private string lTitle;
    private int p_3;
    private string p_4;
    private string p_5;
    private string p_6;
    private bool p_7;
    private string p_8;
    private string lAddWhere;
    private string p_9;
    private bool p_10;
    private bool p_11;
    //
      // 1- KeyField
      // 2- Field List
      // 3- Table Name
      // 4- Form Title
      // 5- Default Find Field (Int) 0,1,2,3 etc
      // 6- Grid Title List
      // 7- Grid Title Width
      // 8- Grid Title format T = Text, N = Numeric etc
      // 9- Bool One Table = True, More Then One = False
      // 10 Join String Otherwise Empty String.
      // 11 Additional Where Default = ""
      // 11 Return Control Type TextBox or MaskedTextBox

    public frmLookUp(
        string pKeyField, 
        string pFL, 
        string pTableName, 
        string pFormTitle, 
        int pDefaultFindField, 
        string pFT, 
        string pTitleWidth, 
        string pTitleFormat, 
        bool pOneTable = true, 
        string pJoin = "", 
        string pAddWhere = "",
        string pTBType = "mTextBox")
    {
      InitializeComponent();
      this.ControlBox = false;
      this.Text = pFormTitle;
      textSearch.MaxLength = 20;
      panelStatus.BackColor = lblFormTitle.BackColor;
      lblTotalRecTitle.BackColor = lblFormTitle.BackColor;
      lblTotalRecTitle.ForeColor = lblFormTitle.ForeColor;
      lblTotalRec.BackColor = lblFormTitle.BackColor;
      lblTotalRec.ForeColor = lblFormTitle.ForeColor;  // Color.Yellow;
      LblError.ForeColor = Color.Red;
      //
      dGVLookUp.BorderStyle = BorderStyle.None;
      dGVLookUp.ReadOnly = true;
      dGVLookUp.MultiSelect = false;
      // Initialize Variables
      fKeyField = pKeyField;                 // 1
      fFL = pFL;                             // 2 Field List
      fTableName = pTableName;               // 3
      fFormTitle = pFormTitle;               // 4
      //fDefaultFindField = ?                // 5
      fFT = pFT;                             // 6 Title List
      fTitleWidth = pTitleWidth;             // 7
      fTitleFormat = pTitleFormat;           // 8
      // One or More Tables
      fOneTable = pOneTable;                 // D 1
      fJoin = pJoin;                         // D 2
      fAddWhere = pAddWhere;  
      fTBType = pTBType;                     // D 3
      // ----------------------------------------------------------------------------------
      int i = 0;
      int iList = 0;
      // Manually Prepare List for Combo Box Display Member and Valuemember
      var list4Cbo = new List<KeyValuePair<int, string>>();
      fFieldList = (pKeyField + "," + pFL).Split(',');
      fTitleList = pFT.Split(',');   
      iList = fTitleList.Length;
      fGridColumns = fTitleList.Length;
      for (i = 0; i < iList; i++)
      {
        list4Cbo.Add(new KeyValuePair<int, string>(i, fTitleList[i]));
      }
      // Clear the combobox
      cBField.DataSource = null;
      cBField.Items.Clear();

      // Bind the combobox
      cBField.DataSource = new BindingSource(list4Cbo, null);
      cBField.DisplayMember = "Value";
      cBField.ValueMember = "Key";
      // Set Index
      cBField.SelectedIndex = clsSetCombo.Set_ComboBox(cBField, fDefaultFindField);
      fFindField = fFieldList[fDefaultFindField];
      isLoading = "N";
      // ----------------------------------------------------------------------------------
    }

    public frmLookUp(string p, string p_2, string fTableNameCOA, string lTitle, int p_3, string p_4, string p_5, string p_6, bool p_7, string p_8, string lAddWhere, string p_9, bool p_10, bool p_11)
    {
        // TODO: Complete member initialization
        this.p = p;
        this.p_2 = p_2;
        this.fTableNameCOA = fTableNameCOA;
        this.lTitle = lTitle;
        this.p_3 = p_3;
        this.p_4 = p_4;
        this.p_5 = p_5;
        this.p_6 = p_6;
        this.p_7 = p_7;
        this.p_8 = p_8;
        this.lAddWhere = lAddWhere;
        this.p_9 = p_9;
        this.p_10 = p_10;
        this.p_11 = p_11;
    }

    private void btn_Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmLookUp01_Load(object sender, EventArgs e)
    {
        AtFormLoad();
        btn_Search_Click(sender, e);
        textSearch.Focus();
    }
    private void AtFormLoad()
    {
        this.KeyPreview = true;
        // Form Layout
        this.MaximizeBox = false;
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        //
        dGVLookUp.AllowUserToResizeRows = false;
        dGVLookUp.AllowUserToAddRows = false;
        dGVLookUp.BorderStyle = BorderStyle.None;
        dGVLookUp.AllowUserToResizeRows = false;
        dGVLookUp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        DisplayGrdHdr();
        // Remove alias character from the table name
        string tKeyField = string.Empty;
        string[] tKeyFieldValue;
        if (!fOneTable)
        {
            tKeyFieldValue = fKeyField.Split('.');
            tKeyField = tKeyFieldValue[1];
        }
        else
        {
            tKeyField = fKeyField;
        }

        lblTotalRec.Text = clsDbManager.GetTotalRec(fTableName, tKeyField);
        textSearch.Focus();
    }
    private void btn_Clear_Click(object sender, EventArgs e)
    {
      textSearch.Text = string.Empty;
      //lblTotalRec.Text = "0";
      LblError.Text = string.Empty;
      //
      ClearGrd();
      DisplayGrdHdr();
      //
      textSearch.Focus();

    }

    private void btn_Search_Click(object sender, EventArgs e)
    {
      string StrQry = string.Empty;
      string StrTbl = string.Empty;
      string Ta = "";             // Ta = Table alias  
      //StrQry = "select city_id, city_title, city_st, isdisabled, isdefault from city ";
      StrQry = "select " + fKeyField + "," + fFL + " from " + fTableName;
      if (!fOneTable)
      {
        StrQry += " kt " + fJoin;
        Ta = "kt.";
      }
      StrQry += " where ";
      //  
      //StrQry += Ta + "loc_id = " + clsGVar.LocID.ToString();
      //StrQry += " and " + Ta + "grp_id = " + clsGVar.GrpID.ToString();
      //StrQry += " and " + Ta + "co_id = " + clsGVar.CoID.ToString();
      //StrQry += " and " + Ta + "year_id = " + clsGVar.YrID.ToString();
      // not applicable due to kt: StrQry += clsGVar.gLGCY;
      //
      if (fAddWhere != "")
      {
          //StrQry += " and " + Ta + fAddWhere;
          StrQry += " " + Ta + fAddWhere;
          StrQry += " and ";
      }
      //
      //StrQry += " and ";
      if (textSearch.Text.ToString().Length > 0)
      {
          StrQry += " upper(" + fFindField + ") like '%" + textSearch.Text.ToString().ToUpper() + "%'";
      }
      else
      {
          StrQry += " upper(" + fFindField + ") like '%'" + textSearch.Text.ToString().ToUpper();
      }

      StrQry += " order by " + fFindField;
      StrTbl = fTableName;

      // Declared at class level: DataSet dtset = new DataSet();
      // Getting from class
      ClearGrd();
      //
      //MessageBox.Show("sss");
      try
      {
          dtset = clsDbManager.GetData_Set(StrQry, StrTbl);
          //int abc = dtset.Tables.Count; // gives the number of tables.
          int abc = dtset.Tables[0].Rows.Count;
          lblTotalRec.Text = abc.ToString();
          dGVLookUp.DataSource = dtset.Tables[0];
      }
      catch (Exception ex)
      {
          MessageBox.Show("Exception: " + ex.Message,"Lookup DataSet");
      }
      //
      DisplayGrdHdr();
      dGVLookUp.Focus();
    }
    //
    private void DisplayGrdHdr()
    {
      // fGridColumns = Total Number of Titles
        // 1- Grid Control
        // 2- Number of Columns
        // 3- Field Title
        // 4- Field Width
        // 5- 5- Col Max Input                  Maximum number of Characters 0 = No limit
        // 6- Field Title Format
        // 7- Col Readonly                      1 = Readonly, 0 = Read/Write (Single 1 = all readonly, Single 0 All Read/Write)
        // 8- Fill type DATA / LOOKUP
        // 9- Color Scheme
        //
        clsDbManager.SetGridHeader(
            dGVLookUp, 
            fGridColumns, 
            fFT, 
            fTitleWidth,
            "",
            fTitleFormat, 
            "1",
            "LOOKUP",
            1);
    }
    //
    private void ClearGrd()
    {
      if (dGVLookUp.DataSource != null)
      {
        dGVLookUp.DataSource = null;
        dGVLookUp.DataMember = null;
        //
        dGVLookUp.Rows.Clear();
        dGVLookUp.Columns.Clear();
      }
      else
      {
        dGVLookUp.Rows.Clear();
        dGVLookUp.Columns.Clear();
      }
    }
    // Returning Value-1 
    private void btn_Select_Click(object sender, EventArgs e)
    {
     string pEvent = "SelClick";
     PrepareRturnValue(pEvent);

      //if (dGVLookUp.CurrentCell == null)
      //{
      //  LblError.Text = "Sel: Empty or Zero: Select another.";
      //  return;
      //}
      //if (this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value == null)
      //{
      //  LblError.Text = "Sel: Empty or Zero: Select another.";
      //  return;
      //}

         
         
      //LblError.Text = "Sel. Value: " + this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
      //if (fTBType == "mTextBox")
      //{
      //     mtextReturn.Text = this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
      //     if (mtextReturn.Text.ToString() == "" || mtextReturn.Text.ToString() == string.Empty)
      //     {
      //          LblError.Text = "Sel. Value:M: Empty/Last Row or Zero: Select another.";
      //          return;
      //     }
      //}
      //else
      //{
      //     textReturn.Text = this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
      //     if (textReturn.Text.ToString() == "" || textReturn.Text.ToString() == string.Empty)
      //     {
      //          LblError.Text = "Sel. Value:: Empty/Last Row or Zero: Select another.";
      //          return;
      //     }
      //}
      //
      if (lupassControl != null)
      {
           if (fTBType == "mTextBox")
           {
                lupassControl(mtextReturn);
           }
           else
           {
                lupassControl(textReturn);
           }
      }
      this.Close();
    }
    // Returning Value-2 
    private void dGVLookUp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
         string pEvent = "CellDblClick";
         PrepareRturnValue(pEvent, e);
    }
    // Returning Value-3 
    private void dGVLookUp_CellContentClick(object sender, DataGridViewCellEventArgs e )
    {
         string pEvent = "CellContentClick";
         PrepareRturnValue(pEvent, e);
    }
    // Returning Value General 
    private void PrepareRturnValue(string pEvent, DataGridViewCellEventArgs e = null)
    {
         if (pEvent == "SelClick")
         {
              if (dGVLookUp.CurrentCell == null)
              {
                   LblError.Text = pEvent + ": Empty or Zero: Select another.";
                   return;
              }
              if (this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value == null)
              {
                   LblError.Text = pEvent + ": Empty or Zero: Select another.";
                   return;
              }
              LblError.Text = pEvent + " Value: " + this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
         }
         else
         {
              if (e.RowIndex == -1)
              {
                   LblError.Text = pEvent + " Empty/Header or Zero: Select another.";
                   return;
              }
              if (this.dGVLookUp[0, e.RowIndex].Value == null)
              {
                   LblError.Text = pEvent + ": Empty/Last Row or Zero: Select another.";
                   return;
              }

              LblError.Text = pEvent + ": Value " + this.dGVLookUp[0, e.RowIndex].Value.ToString();
         } // End if Statement

         if (fTBType == "mTextBox")
         {
              mtextReturn.Text = this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
              if (mtextReturn.Text.ToString() == "" || mtextReturn.Text.ToString() == string.Empty)
              {
                   LblError.Text = pEvent + " Value M: Empty/Last Row or Zero: Select another.";
                   return;
              }
              if (lupassControl != null)
              {
                   lupassControl(mtextReturn);
              }
         }
         else
         {
              textReturn.Text = this.dGVLookUp[0, dGVLookUp.CurrentCell.RowIndex].Value.ToString();
              if (textReturn.Text.ToString() == "" || textReturn.Text.ToString() == string.Empty)
              {
                   LblError.Text = pEvent + " Value: Empty/Last Row or Zero: Select another.";
                   return;
              }
              if (lupassControl != null)
              {
                   lupassControl(textReturn);
              }
         }
         this.Close();
    }
     //
    private void cBField_SelectedIndexChanged(object sender, EventArgs e)
    {
      //fDefaultFindField = Convert.ToInt32(cBField.SelectedValue.ToString());  // int.Parse
      LblError.Text = "cB Text: " + cBField.Text.ToString() + " : " + cBField.SelectedValue.ToString(); ;

      string abc = string.Empty;
      abc = cBField.SelectedValue.ToString();
      if (isLoading == "N")
      {
        fDefaultFindField = int.Parse(cBField.SelectedValue.ToString());
      }
      fFindField = fFieldList[fDefaultFindField];
      //fFindField = cBField.Text.ToString();
    }

    private void dGVLookUp_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            if (dGVLookUp.Rows.Count > 0)
            {
                btn_Select.PerformClick();
            }
        }

    }

    private void frmLookUp_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            //var aaa = sender.GetType; 
            //if (e.Control is TextBox || e.Control is Button || e.Control is ComboBox)
            //{
            //    e.Handled = true;
            //    SendKeys.Send("{TAB}");
            //}
            if (!fGridControl)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        else if (e.KeyCode == Keys.Escape)
            this.Close();
    }

    private void dGVLookUp_Enter(object sender, EventArgs e)
    {
        fGridControl = true;
    }

    private void dGVLookUp_Leave(object sender, EventArgs e)
    {
        fGridControl = false;
    }

    private void textSearch_KeyDown(object sender, KeyEventArgs e)
    {
        //if (textSearch.TextLength>3)
        //{
        //    btn_Search_Click(sender, e);
        //}
        //btn_Search_Click(sender, e);
        //textSearch.Focus();
    }

    

    
    //

    //internal void ShowDialog()
    //{
    //    throw new NotImplementedException();
    //}
  }
}

