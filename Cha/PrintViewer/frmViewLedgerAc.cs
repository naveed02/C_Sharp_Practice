using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//
using Cha.StringFun01;
using System.Text.RegularExpressions;
using Cha.Class;
//using TLERP.GL.Tran;
using Cha.PrintDataSets;
using Cha.PrintReport;
using Cha.PrintViewer;
using Cha.Temp; // for Multiple Character Split

namespace Cha
{
  public partial class frmViewLedgerAc : Form
  {
    // Fields
    bool fActiveGridControl = false;
    string fFocusedTab = "tabDetailTran";
    bool IsFormDirty = false;
    bool IsGridLoading = true;
    //
    List<string> fManySQL;                                      // Query for storing DML SQL    
    //
    bool ftTIsBalloon = true;                                   // Type of tool tip Baloon or simple (at later stage it will be form Db Table)
    Int64 fAddressUID = 0;                                      // Address unique ID
    string fAcStrID = string.Empty;                             // GL / Fin COA string ID
    Int64 fAcID = 0;                                            // GL / Fin Numeric ID
    string fAcTitle = string.Empty;                             // GL / Fin Title
    int fAcIdRange = 0;                                         // Account Id Range  type = AR, AP etc
    //
    List<Tuple<string, string, string>> fArGLAcList;            // List to Control Range of valid accounts Receivable
    List<Tuple<string, string, string>> fApGLAcList;            // List to Control Range of valid accounts Payable
    List<Tuple<string, string, string>> fGenGLAcList;           // List to Control Range of valid accounts (General)
    ////
    string fAddWhereAr = string.Empty;                          // Additional Where Accounts Receivable
    string fAddWhereAp = string.Empty;                          // Additional Where Accounts Payable
    string fGenAddWhere = string.Empty;                            // Additional Where Accounts (General)
    // Table / Query
    //string fTableNameCOA = "gl_ac";                             // GL / Fin COA
    string fTableName = "ar_cust";                              // This forms table
    //string fKeyFieldName = "customer_ac_id";                        // This table's key field
    string fFieldListforDML = string.Empty;                     // List for Update / Insert fields
    string fQryforDML = string.Empty;                           // Query for DML
    string fErrrMsg = string.Empty;                             // Error message used for validation or ot
    // Context Menu
    //ContextMenu cMMasterForm;                                   // Context Menu
    //MenuItem[] cMSMasterFormMenuItem;                           // Context Menu Items
    // Last ID
    string fLastID = string.Empty;
    public frmViewLedgerAc()
    {
      InitializeComponent();
    }
    //
    private enum GLViewLedger
    {
      SerialOrder = 0,
      IsChecked = 1,
      SerialNo = 2,
      DocType = 3,
      Fiscal = 4,
      DocDate = 5,
      DocID = 6,
      TranRef = 7,
      TranNarration = 8,
      JobProjectID = 9,
      JobProjectTitle = 10,
      Debit = 11,
      Credit = 12,
      RunningBalance = 13,
      DocTranRemarks = 14
    }
    //
    private void frmViewLedgerAc_Load(object sender, EventArgs e)
    {
      LoadFormSetting();
      SetControlMask();
      LoadIntegrationData();
      SetGridLayout();
      LoadDataCbo();
      //
      //if (cboControlAcGroup.Items.Count > 0)
      //{
      //  lblControlGroupID.Text = cboControlAcGroup.SelectedValue.ToString();
      //  fGenAddWhere = "control_ac_pid = " + cboControlAcGroup.SelectedValue.ToString();
      //}
      //
      tabDetailTran.Focus();
      //

      this.ActiveControl = mtextID;
    }

private void LoadDataCbo()
{
 	throw new NotImplementedException();
}

    private void SetControlMask()
    {

      //
      tabContactInfo.Tag = "Addr";
      //tabCustAddress.Tag = "Addr";
      //tabCustLimit.Tag = "Addr";
      //
      //tabCust.Tag = "Data";
      //tabCustTaxInfo.Tag = "Data";
      //tabCustLimit.Tag = "Data";
      //tabCustOtherInfo.Tag = "Data";
      // Address
      lblSalute.Tag = "Addr";
      lblContactPerson.Tag = "Addr";
      lblAddressLine1.Tag = "Addr";
      lblAddressLine2.Tag = "Addr";
      lblZipPostalCode.Tag = "Addr";
      lblStateProvince.Tag = "Addr";
      lblCity.Tag = "Addr";
      lblCountry.Tag = "Addr";
      // Contact
      lblPhone.Tag = "Addr";
      lblPhoneExt.Tag = "Addr";
      lblMobile.Tag = "Addr";
      lblFax.Tag = "Addr";
      lblEmail.Tag = "Addr";
      lblWeb.Tag = "Addr";
      // Additional
      // ? lblAc_id.Tag = "Addr";

      // Sample
      // Tab: Tax Info
      // 0- Marker
      // 1- Field Number for maping with table field name
      // 2- Type of Field
      // 3- Required or optional against Empty or null
      // 4- Clear Flag (Clear data on press of Clear button)
      // 5- D or d Default Clear Value or specific value

      // R or r = required
      // Note: d or D for default value.
      // other wise this field is also used for specific default value.
      // for example textSTN.Tag = ">><<,02,string,clear,this is specific default value";                                   // 02 STN
      //

      ////////textCNIC.Tag = ">><<,00,string,clear,d,R,CNIC";                                 // 00`NIC

    }
    //private void LoadDataCbo()
    //{
    //  textAlert.Text = clsGVar.LGCY;
    //  clsEnumerator.FillComboWithEnum(cboControlAcGroup, "ControlAc", true);
    //}
    //
    private void ClearThisForm()
    {
      mtextID.Text = string.Empty;
      lblTitle.Text = string.Empty;
      lblTitle.Tag = null;              // Important
      // 
      lblOpeningBalance.Text = "0.00";
      lblClosingBalance.Text = "0.00";
      lblTotalDebit.Text = "0.00";
      lblTotalCredit.Text = "0.00";
      //
      lblShowLongText.Text = string.Empty;
      //
      //if (dGvDetail.Rows.Count > 0)
      //{
      //  dGvDetail.Rows.Clear();
      //}
      //
      mtextID.Enabled = true;

      //
      mtextID.Focus();
    }
    //
    private void LoadFormSetting()
    {
      lblFormTitle.Text = "View Ledger Account";
      //
      this.KeyPreview = true;
      this.MinimumSize = new System.Drawing.Size(940, 500);
      this.Size = this.MinimumSize;
      // Optional
      //this.StartPosition = FormStartPosition.CenterScreen;
      //
      mtextID.BorderStyle = BorderStyle.FixedSingle;
      mtextID.Mask = clsGetGvar.MaskGlId;
      mtextID.HidePromptOnLeave = true;

      lblTitle.BorderStyle = BorderStyle.FixedSingle;
      //cboControlAcGroup.Enabled = false;

      //
      //dtpFrom.MinDate = clsGVar.YrDateStart;
      //dtpTo.MaxDate = clsGVar.YrDateEnd;
      //DateTime a  = clsGVar.YrDateStart;
      //DateTime b = clsGVar.YrDateEnd;

      dtpStart.Value = clsGVar.YrDateStart;
      dtpEnd.Value = clsGVar.YrDateEnd;
    }
    //
    private void SetGridLayout()
    { 
      //Detail Tran Grid ---------------------------------------------------------------------------
      //List<string> MtMask = new List<string>
      //      {
      //          clsGetGvar.MaskGlID,
      //          ""
      //      };
      //
      string lHDR = "";                       // Column Header
      string lColWidth = "";                  // Column Width (Input)
      string lColMinWidth = "";               // Column Minimum Width
      string lColMaxInputLen = "";            // Column Visible Length/Width 
      string lColFormat = "";                 // Column Format  
      string lColReadOnly = "";               // Column ReadOnly 1 = ReadOnly, 0 = Read-Write  
      //
      List<string> lMask = null; //new List<string>;
      List<string> lCboFillType = null; //new List<string>;
      List<string> lCboTableKeyField = null; //new List<string>;
      List<string> lCboQry = null; //new List<string>;
      // ******************************************************************************************************
      // Grid Header
      lHDR  = "TranID";                           // 00-   Hidden
      lHDR += ",Chk";                             // 01-   
      lHDR += ",S.#";                             // 02-   
      lHDR += ",Type";                            // 03-   
      lHDR += ",FP.";                             // 04-
      lHDR += ",Date";                            // 05-
      lHDR += ",Doc ID";                          // 06-
      lHDR += ",Ref.";                            // 07-
      lHDR += ",Transaction Narration";           // 08-
      lHDR += ",Prj/Job ID";                      // 09-
      lHDR += ",Prj/Job Title";                   // 10-
      lHDR += ",Debit";                           // 11-
      lHDR += ",Credit";                          // 12-
      lHDR += ",Running Bal";                     // 13-
      lHDR += ",Tran. Remarks";                   // 14-
      // Col Visible Width
      lColWidth = "  2";                          // 00-  "TranID" Hidden
      lColWidth += ", 2";                         // 01-  ",S.#";                  
      lColWidth += ", 3";                         // 02-  ",Chk";                   
      lColWidth += ", 3";                         // 03-  ",Type";                  
      lColWidth += ", 3";                         // 04-  ",FP.";                   
      lColWidth += ", 8";                         // 05-  ",Date";                  
      lColWidth += ", 6";                         // 06-  ",Doc ID";                
      lColWidth += ", 6";                         // 07- ",Ref.";         
      lColWidth += ",15";                         // 08-  ",Transaction Narration"; 
      lColWidth += ", 6";                         // 09-   ",Prj/Job ID";            
      lColWidth += ",8";                          // 10-  ",Prj/Job Title";
      lColWidth += ",10";                         // 11-  ",Debit";                 
      lColWidth += ",10";                         // 12-  ",Credit";
      lColWidth += ",10";                         // 13-  ",Running Bal         
      lColWidth += ",20";                         // 14-  ",Tran. Remarks";  Max input = 200       
      // Column Input Length/Width
      lColMaxInputLen = "  2";                     // 00-  "TranID" Hidden
      lColMaxInputLen += ", 3";                    // 01-  ",Chk";
      lColMaxInputLen += ", 2";                    // 02-  ",S.#";                              
      lColMaxInputLen += ", 3";                    // 03-  ",Type";                  
      lColMaxInputLen += ", 3";                    // 04-  ",FP.";                   
      lColMaxInputLen += ",10";                    // 05-  ",Date";                  
      lColMaxInputLen += ", 6";                    // 06-  ",Doc ID";                
      lColMaxInputLen += ", 6";                    // 07- ",Ref.";
      lColMaxInputLen += ",20";                    // 08-  ",Transaction Narration"; 
      lColMaxInputLen += ", 6";                    // 09-   ",Prj/Job ID";            
      lColMaxInputLen += ",10";                    // 10-  ",Prj/Job Title";         
      lColMaxInputLen += ",10";                    // 11-  ",Debit";                 
      lColMaxInputLen += ",10";                    // 12-  ",Credit";                
      lColMaxInputLen += ",10";                    // 13-  ",Running Bal";
      lColMaxInputLen += ",200";                   // 14-  ",Tran. Remarks";
      // Column Min Width
      lColMinWidth = "   0";                      // 00-  "TranID" Hidden
      lColMinWidth += ", 0";                      // 01-  ",Chk";
      lColMinWidth += ", 2";                      // 02-  ",S.#";                                           
      lColMinWidth += ", 0";                      // 03-  ",Type";                  
      lColMinWidth += ", 0";                      // 04-  ",FP.";                   
      lColMinWidth += ", 0";                      // 05-  ",Date";                  
      lColMinWidth += ", 0";                      // 06-  ",Doc ID";                
      lColMinWidth += ", 0";                      // 07- ",Ref.";                  
      lColMinWidth += ", 0";                      // 08-  ",Transaction Narration"; 
      lColMinWidth += ", 0";                      // 09-   ",Prj/Job ID";            
      lColMinWidth += ", 0";                      // 10-  ",Prj/Job Title";
      lColMinWidth += ", 0";                      // 11-  ",Debit";                 
      lColMinWidth += ", 0";                      // 12-  ",Credit";                
      lColMinWidth += ", 0";                      // 13-  ",Running Bal";                
      lColMinWidth += ",30";                      // 14-  ",Tran. Remarks";      
      // Column Format
      lColFormat = "  H";                         // 00-  "TranID" Hidden
      lColFormat += ",CH";                        // 01-  ",Chk"; 
      lColFormat += ", T";                        // 02-  ",S.#";                                                       
      lColFormat += ", T";                        // 03-  ",Type";                  
      lColFormat += ", T";                        // 04-  ",FP.";                   
      lColFormat += ", T";                        // 05-  ",Date";                  
      lColFormat += ", T";                        // 06-  ",Doc ID";                
      lColFormat += ", T";                        // 07- ",Ref.";                  
      lColFormat += ", T";                        // 08-  ",Transaction Narration"; 
      lColFormat += ", T";                        // 09-   ",Prj/Job ID";            
      lColFormat += ", T";                        // 10-  ",Prj/Job Title";         
      lColFormat += ",N2";                        // 11-  ",Debit";                 
      lColFormat += ",N2";                        // 12-  ",Credit";                
      lColFormat += ",N2";                        // 13-  ",Running Bal.";                
      lColFormat += ", T";                        // 14-  ",Tran. Remarks";
      // Column ReadOnly 1= readonly, 0 = read-write
      lColReadOnly = "  1";                       // 00-  "TranID" Hidden
      lColReadOnly += ",0";                       // 01-  ",Chk";
      lColReadOnly += ",1";                       // 02-  ",S.#";                                    
      lColReadOnly += ",1";                       // 03-  ",Type";                  
      lColReadOnly += ",1";                       // 04-  ",FP.";                   
      lColReadOnly += ",1";                       // 05-  ",Date";                  
      lColReadOnly += ",1";                       // 06-  ",Doc ID";                
      lColReadOnly += ",1";                       // 07- ",Ref.";
      lColReadOnly += ",1";                       // 08-  ",Transaction Narration"; 
      lColReadOnly += ",1";                       // 09-   ",Prj/Job ID";            
      lColReadOnly += ",1";                       // 10-  ",Prj/Job Title";         
      lColReadOnly += ",1";                       // 11-  ",Debit";                 
      lColReadOnly += ",1";                       // 12-  ",Credit";
      lColReadOnly += ",1";                       // 13-  ",Running Bal.";                          
      lColReadOnly += ",0";                       // 14-  ",Tran. Remarks";
      //                                          
      lMask = null; 
      lCboFillType = null;
      lCboTableKeyField = null;
      lCboQry = null; 
      //
      //clsDbManager.SetGridHeaderCmb(
      //  dGvDetail,
      //  15,
      //  lHDR,
      //  lColWidth,
      //  lColMinWidth,
      //  lColMaxInputLen,
      //  lColFormat,
      //  lColReadOnly,
      //  "DATA",
      //  lMask,
      //  lCboFillType,
      //  lCboTableKeyField,
      //  lCboQry,
      //  false,
      //  2);
      //Detail Tran Grid//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============
      //
      //Type Wise Detail---------------------------------------------------------------------------- 
      // Same as above
      //clsDbManager.SetGridHeaderCmb(
      //  dGvTypeWiseDetailTran,
      //  15,
      //  lHDR,
      //  lColWidth,
      //  lColMinWidth,
      //  lColMaxInputLen,
      //  lColFormat,
      //  lColReadOnly,
      //  "DATA",
      //  lMask,
      //  lCboFillType,
      //  lCboTableKeyField,
      //  lCboQry,
      //  false,
      //  1);
      //Type Wise Detail//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============
      //Summary Tran.-------------------------------------------------------------------------------
      // Header
      lHDR =  "Type";                         // 0-
      lHDR += ",Doc/Voucher Type Detail";     // 1-   
      lHDR += ",Tran.";                       // 2-   
      lHDR += ",First Date";                  // 3-
      lHDR += ",Last Date";                   // 4-
      lHDR += ",Total Dr.";                   // 5-
      lHDR += ",Total Cr.";                   // 6-

      // Input Width
      lColWidth = "    4";                        // 0-   "Type";                         
      lColWidth += ", 30";                        // 1-   ",Doc/Voucher Type Detail";              
      lColWidth += ", 3";                         // 2-   ",Number of Trans";                                 
      lColWidth += ", 8";                         // 3-   ",First Date";                           
      lColWidth += ", 8";                         // 4-   ",Last Date";                            
      lColWidth += ",10";                         // 5-   ",Total Dr.";                            
      lColWidth += ",10";                         // 6-   ",Total Cr.";                            
      // Column Visible Length/Width
      lColMaxInputLen = "    4";                   // 0-   "Type";                    
      lColMaxInputLen += ", 30";                   // 1-   ",Doc/Voucher Type Detail";         
      lColMaxInputLen += ", 3";                    // 2-   ",Number of Trans";                            
      lColMaxInputLen += ", 8";                    // 3-   ",First Date";                      
      lColMaxInputLen += ", 8";                    // 4-   ",Last Date";                       
      lColMaxInputLen += ",10";                    // 5-   ",Total Dr.";                       
      lColMaxInputLen += ",10";                    // 6-   ",Total Cr.";              
      // Column Min Width
      lColMinWidth = "   0";                        // 0-   "Type";                    
      lColMinWidth += ", 0";                        // 1-   ",Doc/Voucher Type Detail";           
      lColMinWidth += ", 0";                        // 2-   ",Type";                              
      lColMinWidth += ", 0";                        // 3-   ",First Date";                        
      lColMinWidth += ", 0";                        // 4-   ",Last Date";                         
      lColMinWidth += ", 10";                       // 5-   ",Total Dr.";                         
      lColMinWidth += ", 10";                       // 6-   ",Total Cr.";              
      // Column Format
      lColFormat = "   T";                          // 0-   "Type";                    
      lColFormat += ", T";                          // 1-   ",Doc/Voucher Type Detail";          
      lColFormat += ", T";                          // 2-   ",Type";                             
      lColFormat += ", T";                          // 3-   ",First Date";                       
      lColFormat += ", T";                          // 4-   ",Last Date";                        
      lColFormat += ",N2";                          // 5-   ",Total Dr.";                       
      lColFormat += ",N2";                          // 6-   ",Total Cr."; 
      // Column ReadOnly
      lColReadOnly = "  1";                         // 0-   "Type";                    
      lColReadOnly += ",1";                         // 1-   ",Doc/Voucher Type Detail";           
      lColReadOnly += ",1";                         // 2-   ",Type";                              
      lColReadOnly += ",1";                         // 3-   ",First Date";                        
      lColReadOnly += ",1";                         // 4-   ",Last Date";                         
      lColReadOnly += ",1";                         // 5-   ",Total Dr.";                         
      lColReadOnly += ",1";                         // 6-   ",Total Cr."; 
      //
      lMask = null;
      lCboFillType = null;
      lCboTableKeyField = null;
      lCboQry = null;
      //
      clsDbManager.SetGridHeaderCmb(
        dGvSummaryTran,
        7,
        lHDR,
        lColWidth,
        lColMinWidth,
        lColMaxInputLen,
        lColFormat,
        lColReadOnly,
        "DATA",
        lMask,
        lCboFillType,
        lCboTableKeyField,
        lCboQry,
        false,
        2);
      //Summary Tran.//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=========
      //Contact Info.-------------------------------------------------------------------------------
      // Header
      lHDR = "Name";                                // 0- Name
      lHDR += ",Contact Info.";                     // 1- Contact Info  

      // Input Width
      lColWidth = "   10";                          // 0- Name                       
      lColWidth += ", 30";                          // 1- Contact Info              
      // Column Visible Length/Width
      lColMaxInputLen = "   10";                   // 0- Name                  
      lColMaxInputLen += ", 30";                   // 1- Contact Info         
      // Column Min Width
      lColMinWidth = "   0";                        // 0- Name                  
      lColMinWidth += ", 0";                        // 1- Contact Info           
      // Column Format
      lColFormat = "   T";                          // 0- Name                  
      lColFormat += ", T";                          // 1- Contact Info          
      // Column ReadOnly
      lColReadOnly = "  1";                         // 0- Name
      lColReadOnly += ",1";                         // 1- Contact Info           
      //
      lMask = null;
      lCboFillType = null;
      lCboTableKeyField = null;
      lCboQry = null;
      //
      //clsDbManager.SetGridHeaderCmb(
      //  dGvContactInfo,
      //  2,
      //  lHDR,
      //  lColWidth,
      //  lColMinWidth,
      //  lColMaxInputLen,
      //  lColFormat,
      //  lColReadOnly,
      //  "DATA",
      //  lMask,
      //  lCboFillType,
      //  lCboTableKeyField,
      //  lCboQry,
      //  false,
      //  2);
      //Contact Info.//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=========

    }

    private void btn_Clear_Click(object sender, EventArgs e)
    {
      ClearThisForm();
    }

    private void frmViewLedgerAc_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        if (!fActiveGridControl)
        {
          e.Handled = true;
          SendKeys.Send("{TAB}");
        }
      }
    }
    //
    private void tabLedger_SelectedIndexChanged(object sender, EventArgs e)
    {
      fFocusedTab = tabLedger.SelectedTab.Name.ToString();
      switch (fFocusedTab)
      {
        case "tabDetailTran":
          break;
        case "tabTypeWise":
          //
          break;
        case "tabSummaryTran":
          //
          break;
        case "tabContactInfo":
          //
          break;
        case "tabPostDatedCheques":
          //
          break;
        case "tabDisHonouredCheques":
          //
          break;
        case "tabOverDueAging":
          //
          break;

      }

      //if (tabLedger.SelectedTab == tabLedger.TabPages["tabDetailTran"])
      //{
      //  MessageBox.Show("Detail Tran " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabTypeWise"])
      //{
      //  MessageBox.Show("Type Wise Detail Tran " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabSummaryTran"])
      //{
      //  MessageBox.Show("Summary Tran " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabContactInfo"])
      //{
      //  MessageBox.Show("Contact Info " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabPostDatedCheques"])
      //{
      //  MessageBox.Show("Post Dated Cheques " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabDishonouredCheques"])
      //{
      //  MessageBox.Show("Dis Honour chq " + fFocusedTab);
      //}
      //else if (tabLedger.SelectedTab == tabLedger.TabPages["tabOverDueAging"])
      //{
      //  MessageBox.Show("Aging " + fFocusedTab);
      //}

    } // Tab Selection
    //
    private void ViewGLID(object sender)
    { 
      try
      {
        mtext.Text = ((MaskedTextBox)sender).Text;
        //mtAcID.Text = mtext.Text;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lookup GLID: " + ex.Message, lblFormTitle.Text.ToString());
      }
    }

    private void LookUpGLID()
    {
      // 1- KeyField
      // 2- Field List
      // 3- Table Name
      // 4- Form Title
      // 5- Default Find Field (Int) 0,1,2,3 etc Default = 1 = title field
      // 6- Grid Title List
      // 7- Grid Title Width
      // 8- Grid Title format T = Text, N = Numeric etc
      // 9- Bool One Table = True, More Then One = False
      // 10 Join String Otherwise Empty String.
      // 11 Optional Where
      // 11 Return Control Type TextBox or MaskedTextBox Default mtextBox
      //
      if (!chkSelectedControlAc.Checked)
      {
        fGenAddWhere = "istran = 1";
      }
      frmLookUp sForm = new frmLookUp(
              "ac_strid",
              "ac_title,ac_atitle,Ordering",
              "gl_ac",
              "GL COA",
              1,
              "ID,Account Title,Account Alternate Title,Ordering",
              "10,20,20,20",
              "T,T,T,T",
              true,
              "",
              fGenAddWhere // here
              );
      sForm.lupassControl = new frmLookUp.LUPassControl(ViewGLID);        // private void PassData(object sender) is a method
      sForm.ShowDialog();
      if (mtext.Text != null)
      {
        if (mtext.Text.ToString() == "" || mtext.Text.ToString() == string.Empty)
        {
          return;
        }
        mtextID.Text = mtext.Text.ToString();
        SendKeys.Send("{TAB}");
      }
    } // End LookUpGLID

    private void mtAcID_DoubleClick(object sender, EventArgs e)
    {
      LookUpGLID();
    }
    //--
    private void LoadIntegrationData()
    {
      //try
      //{
      //  fGenAddWhere = string.Empty;
      //  if (chkSelectedControlAc.Checked)
      //  {
      //    fGenGLAcList = clsDbManager.PrepareControlAcList( clsDbManager.ConvInt32(  lblControlGroupID.Text.ToString() )  );
      //    if (fGenGLAcList.Count > 0)
      //    {
      //      fGenAddWhere = clsDbManager.PrePareAdditionaWhere(fGenGLAcList, "ac_strid");
      //      if (fGenAddWhere.Length > 0)
      //      {
      //        fGenAddWhere += " and istran = 1";
      //      }
      //    }
      //    else
      //    {
      //      fGenAddWhere += "istran = 1";
      //    }
      //    //
      //    //fApGLAcList = clsDbManager.PrepareControlAcList(( int )ControlAc.Accounts_Payable);
      //    //if (fArGLAcList.Count > 0)
      //    //{
      //    //  fAddWhereAp = clsDbManager.PrePareAdditionaWhere(fApGLAcList, "ac_strid");
      //    //}
      //  }
      //}
      //catch (Exception ex)
      //{
      //  MessageBox.Show("Exception, Load Integration Data: " + ex.Message, lblFormTitle.Text.ToString());
      //}
    }
    //---


    private void mtAcID_Validating(object sender, CancelEventArgs e)
    {
      fAcStrID = string.Empty;
      fAcID = 0;
      fAcTitle = string.Empty;
      fAddressUID = 0;
      textAlert.Text = "";
      string tSQL = string.Empty;
      DateTime now = DateTime.Now;


      try
      {
        if (mtextID.Text.ToString().Trim(' ', '-') == "")
        {
          return;
        }
        //
        if (!mtextID.MaskFull)
        {
          int lSpaceLoc = 0;
          lSpaceLoc = mtextID.Text.IndexOf(" ");
          //
          if (lSpaceLoc != -1)
          {
            MessageBox.Show("Account ID: ID is incomplete or Space at location " + lSpaceLoc.ToString(), lblFormTitle.Text);
            e.Cancel = true;
            return;
          }
          else
          {
            MessageBox.Show("Account ID: ID is incomplete or Un-wanted character exists in ID.", lblFormTitle.Text);
            e.Cancel = true;
            return;
          }
        }
        
        // Check Category of GL ID, Customer,Vendor/Supplier or Other
        // and set form information accordingly.
        // Check if ID Exists Within AR Range, For Example: Credit limit etc
        if (chkSelectedControlAc.Checked)
        {
              fAcIdRange = clsDbManager.ConvInt32(lblControlGroupID.Text.ToString() );
              Int32 aaa = ( Int32 )ControlAc.Accounts_Receivable;
              //-----------------------------------------------------
              switch (fAcIdRange)
              {
                case ( Int32 )ControlAc.Accounts_Receivable:
                  {
                    tSQL = "select top 1 ";
                    tSQL += " gl.ac_id";
                    tSQL += ",gl.ac_title";
                    tSQL += ",ar.customer_ac_id";
                    tSQL += ",ar.customer_nic";
                    tSQL += ",ar.customer_ntn";
                    tSQL += ",ar.customer_stn";
                    tSQL += ",ar.customer_taxtype_id";
                    tSQL += ",ar.customer_creditlimit";
                    tSQL += ",ar.customer_iscreditlimitactive";
                    tSQL += ",ar.customer_creditterms";
                    tSQL += ",ar.customer_latecharges";
                    tSQL += ",ar.customer_discount";
                    tSQL += ",ar.customer_isdiscountactive";
                    tSQL += ",ar.customer_isperitemdiscount";
                    tSQL += ",ar.customer_isbilltobillaging";
                    tSQL += ",ar.customer_custsupcat_id";
                    tSQL += ",ar.customer_goco_id";
                    tSQL += ",gl.addr_uid";
                    tSQL += ",ar.customer_remarks";
                    tSQL += ",ar.ordering";
                    tSQL += ",ar.isdisabled";
                    tSQL += ",ar.isdefault";
                    tSQL += " from " + "ar_customer ar";
                    tSQL += " INNER JOIN gl_ac gl ON ar.customer_ac_id = gl.ac_id and ";
                    //tSQL += " OUTER JOIN gl_ac gl ON ar.customer_ac_id = gl.ac_id and ";
                    clsGVar.JoinPrefixLGCY = "ar,gl";
                    tSQL += clsGVar.WithJoinPrefixLGCY;
                    //
                    tSQL += " where ";
                    tSQL += "ar.customer_ac_id = ";
                    tSQL += "(SELECT ac_id FROM gl_ac WHERE ac_strid = '" + mtextID.Text.ToString() + "' and " + clsGVar.LGCY + ")";
                    tSQL += " and ";
                    clsGVar.PrefixLGCY = "ar";
                    tSQL += clsGVar.WithPrefixLGCY;
                    tSQL += clsGetAddress.GetAddressSQL(mtextID.Text.ToString());                // Address Query
                    tSQL += ";SELECT ac_id, ac_title FROM gl_ac WHERE ac_strid = '" + mtextID.Text.ToString() + "' and " + clsGVar.LGCY;
                  }
                  break;
                case ( Int32 )ControlAc.Accounts_Payable:
                  {

                  }
                  break;
                case -999:
                case 0:
                  break;
                default:
                    {
                      tSQL += "SELECT ac_id, ac_title FROM gl_ac WHERE ac_strid = '" + mtextID.Text.ToString() + "' and " + clsGVar.LGCY;
                    }
                  break;
              }
              // ---
              DataSet dtset = new DataSet();
              DataRow dRow;
              dtset = clsDbManager.GetData_Set(tSQL, "ar_customer");
              int lCustRec = dtset.Tables[0].Rows.Count;
              //
              if (lCustRec == 0)
              {
                int lGLRec = dtset.Tables[1].Rows.Count;
                if (lGLRec == 0)
                {
                  MessageBox.Show("No Record to display in COA ...", lblFormTitle.Text.ToString());
                  return;
                }
                else
                {
                  lblTitle.Text = dtset.Tables[1].Rows[0]["ac_title"] == DBNull.Value ? "" : dtset.Tables[1].Rows[0]["ac_title"].ToString();
                  fAcID = dtset.Tables[1].Rows[0]["ac_id"] == DBNull.Value ? 0 : clsDbManager.ConvInt64(dtset.Tables[1].Rows[0]["ac_id"].ToString());
                  lblTitle.Tag = dtset.Tables[1].Rows[0]["ac_id"] == DBNull.Value ? 0 : clsDbManager.ConvInt64(dtset.Tables[1].Rows[0]["ac_id"].ToString());
                  lblAc_id.Text = dtset.Tables[1].Rows[0]["ac_id"] == DBNull.Value ? "0" : dtset.Tables[1].Rows[0]["ac_id"].ToString();
                  textAlert.Text = "New: Got Title from COA";
                  //
                  mtextID.Enabled = false;
                  //EnableDDisableButtons(true);
                  return;
                  //
                }
              }
              else
              {
                // Assign Values to controls
                fAcID = clsDbManager.ConvInt64(dtset.Tables[0].Rows[0]["ac_id"].ToString());
                lblTitle.Text = dtset.Tables[0].Rows[0]["ac_title"] == DBNull.Value ? "" : dtset.Tables[0].Rows[0]["ac_title"].ToString();
                lblTitle.Tag = dtset.Tables[0].Rows[0]["ac_id"] == DBNull.Value ? 0 : clsDbManager.ConvInt64(dtset.Tables[0].Rows[0]["ac_id"].ToString());
                lblAc_id.Text = dtset.Tables[0].Rows[0]["ac_id"] == DBNull.Value ? "0" : dtset.Tables[0].Rows[0]["ac_id"].ToString();
                textAlert.Text = "Found in Customers: ";
                //
                //if (dtset.Tables[1].Rows != null)   
                // start testing
                foreach (DataTable table in dtset.Tables)
                {
                    if (table.Rows.Count != 0)
                    { 
                    }
                }
                int abc111 = dtset.Tables.Count;
                // end testing

                if (dtset.Tables.Count > 1)
                {
                  clsGetAddress.RenderAddress(this.Controls, dtset, 1);                       // Address Population/Rendering
                }
              }
              // 
              string lRtnValue = string.Empty;
              string[] lAcTitle;
          //------------------------------------------------------
        } // if : chk.Checked
        else
        {
          tSQL += "SELECT ac_id, ac_title FROM gl_ac WHERE ac_strid = '" + mtextID.Text.ToString() + "' and " + clsGVar.LGCY;
          DataSet dtset = new DataSet();
          dtset = clsDbManager.GetData_Set(tSQL, "Gen_GL");
          //
          int lGLRec = dtset.Tables[0].Rows.Count;
          if (lGLRec == 0)
          {
            MessageBox.Show("No Record to display in COA ...", lblFormTitle.Text.ToString());
            return;
          }
          else
          {
            // Assign Values to controls
            fAcID = clsDbManager.ConvInt64(dtset.Tables[0].Rows[0]["ac_id"].ToString());
            lblTitle.Text = dtset.Tables[0].Rows[0]["ac_title"] == DBNull.Value ? "" : dtset.Tables[0].Rows[0]["ac_title"].ToString();
            lblTitle.Tag = dtset.Tables[0].Rows[0]["ac_id"] == DBNull.Value ? 0 : clsDbManager.ConvInt64(dtset.Tables[0].Rows[0]["ac_id"].ToString());
            lblAc_id.Text = dtset.Tables[0].Rows[0]["ac_id"] == DBNull.Value ? "0" : dtset.Tables[0].Rows[0]["ac_id"].ToString();
            textAlert.Text = "Found in Customers: ";
          }
          // 
          string lRtnValue = string.Empty;
          string[] lAcTitle;
        } // else chk
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, ID Validating: " + ex.Message, lblFormTitle.Text.ToString());
        return;
      }
      //

    } // End Validating 
    //
    private void mtAcID_Enter(object sender, EventArgs e)
    {
      lblTitle.Text = string.Empty;
    }
    //
    private void frmViewLedgerAc_FormClosing(object sender, FormClosingEventArgs e)
    {
      try
      {
        if (IsFormDirty)
        {
          if (MessageBox.Show("Are You Sure To Exit the Form without Saving Marked changes ?", lblFormTitle.Text.ToString(), MessageBoxButtons.OKCancel) != DialogResult.OK)
          {
            e.Cancel = true;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception Form Closing: " + ex.Message, lblFormTitle.Text.ToString());
      }
    } // End Form Closing

    private void btn_Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btn_View_Click(object sender, EventArgs e)
    {
      if (dtpStart.Value > dtpEnd.Value)
      {
        MessageBox.Show("From Date > To Date, Re-enter...",lblFormTitle.Text.ToString() );
        dtpStart.Focus();
        return;
      }
      //
      if (mtextID.Text.ToString().Trim(' ', '-') == "")
      {
        MessageBox.Show("Account ID empty or blank, Re-enter...", lblFormTitle.Text.ToString());
        mtextID.Focus();
        return;
      }
      LoadSampleData();
      sumDebitCredit();
      lblClosingBalance.Text = CalcClosingBalance(lblOpeningBalance, lblTotalDebit, lblTotalCredit).ToString();
    } 
    //
    private void LoadSampleData()
    {
      // Opening Balance
      string lSQL = "";
      lSQL += "select ( sum(d.debit) - sum(d.credit) ) as openingbalance from gl_trandtl d ";
      lSQL += " RIGHT OUTER JOIN gl_tran m ON d.doc_vt_id = m.doc_vt_id ";
      lSQL += " AND d.doc_id = m.doc_ID ";
      lSQL += " AND d.doc_fiscal_id = m.doc_fiscal_id ";
      lSQL += " and d.loc_id = m.loc_id ";
      lSQL += " and d.grp_id = m.grp_id ";
      lSQL += " and d.co_id = m.co_id ";
      lSQL += " and d.year_id = m.year_id ";

      lSQL += " where ";
      lSQL += "d.doc_ac_id = ";
      lSQL +=  ( lblTitle.Tag == null ? "0" : lblTitle.Tag.ToString() );
      lSQL += " and m.doc_date < " + StrF01.D2Str(dtpStart) ;
      //
      lSQL += " and d.loc_id = " + clsGVar.LocID;
      lSQL += " and d.grp_id = " + clsGVar.GrpID;
      lSQL += " and d.co_id = " + clsGVar.CoID;
      lSQL += " and d.year_id = " + clsGVar.YrID;

      // Transactions
      lSQL += ";";
      lSQL += "SELECT ";
      lSQL += "  d.doc_ischecked";                                        // 0a- Status for check box : now not required
      lSQL += ", '' as serial_no";                                        // 0- d.serial_no as serial_no";   
      lSQL += ", d.SERIAL_ORDER";                                         // 1-
      lSQL += ", 0 as sno ";                                              // 2-
      lSQL += ", ma.ac_id ";                                              // 3- Not Required
      lSQL += ", d.jobproject_id";                                        // 6-
      lSQL += ", mj.jobproject_title";                                    // 7-
      lSQL += ", d.doc_tran_ref";                                         // 8-
      lSQL += ", d.doc_narration";                                        // 9-
      lSQL += ", d.DEBIT";                                                // 10-    
      lSQL += ", d.CREDIT";                                               // 11-
      lSQL += ", 0 as rbalance";                                          // 12-
      lSQL += ", d.doc_tran_remarks";                                     // 13-
      //
      lSQL += ", m.doc_id";
      lSQL += ", m.doc_vt_id";
      lSQL += ", m.doc_fiscal_id";
      lSQL += ", m.doc_date";
      lSQL += ", m.doc_ref";
      lSQL += ", m.doc_tnot";
      lSQL += ", m.doc_tnoa";
      lSQL += ", m.doc_remarks";
      lSQL += ", m.doc_amt";
      lSQL += ", m.frm_id";
      //
      lSQL += " FROM gl_trandtl d ";
      lSQL += " RIGHT OUTER JOIN gl_tran m ON d.doc_vt_id = m.doc_vt_id ";
      lSQL += " AND d.doc_id = m.doc_ID ";
      lSQL += " AND d.doc_fiscal_id = m.doc_fiscal_id ";
      lSQL += " and d.loc_id = m.loc_id ";
      lSQL += " and d.grp_id = m.grp_id ";
      lSQL += " and d.co_id = m.co_id ";
      lSQL += " and d.year_id = m.year_id ";
      //lSQL += " geo_city mc  ON d.jobproject_id = mc.city_id LEFT OUTER JOIN ";
      lSQL += " LEFT OUTER JOIN cmn_jobproject mj  ON d.jobproject_id = mj.jobproject_id ";
      lSQL += " and d.loc_id = mj.loc_id ";
      lSQL += " and d.grp_id = mj.grp_id ";
      lSQL += " and d.co_id = mj.co_id ";
      lSQL += " and d.year_id = mj.year_id ";
      lSQL += " LEFT OUTER JOIN  gl_ac ma ON d.doc_ac_id = ma.ac_id";
      lSQL += " and d.loc_id = ma.loc_id ";
      lSQL += " and d.grp_id = ma.grp_id ";
      lSQL += " and d.co_id = ma.co_id ";
      lSQL += " and d.year_id = ma.year_id ";

      lSQL += " where ";
       //lSQL += DocWhere("d.");
      lSQL += "d.doc_ac_id = ";
      if (lblTitle.Tag == null)
      {
        MessageBox.Show("Warnning: Label Tag is null, Select Account ID, try again.",lblTitle.Text.ToString() );
        return;
      }
      else
      {
        lSQL += lblTitle.Tag.ToString(); //mtAcID.Text.ToString();
      }
      lSQL += " and m.doc_date between " + StrF01.D2Str(dtpStart) + " and " + StrF01.D2Str(dtpEnd);
       //
       lSQL += " and d.loc_id = " + clsGVar.LocID;
       lSQL += " and d.grp_id = " + clsGVar.GrpID;
       lSQL += " and d.co_id = " + clsGVar.CoID;
       lSQL += " and d.year_id = " + clsGVar.YrID;

      lSQL += " ORDER BY m.doc_date, sidedrcr, d.doc_id ";

      string tHDR = ""; // not used
      tHDR = "SerialOrder";                       // 0-   Hidden
      tHDR += ",Chk";                             // 1-   
      tHDR += ",ccc";                             // 2-    
      tHDR += ",Type";                            // 3-  
      tHDR += ",FP.";                             // 4-
      tHDR += ",Date";                            // 5-
      tHDR += ",Doc ID";                          // 6-
      tHDR += ",Ref.";                            // 7-
      tHDR += ",Transaction Narration";           // 8-
      tHDR += ",Prj/Job ID";                      // 9-
      tHDR += ",Prj/Job Title";                   // 10-
      tHDR += ",Debit";                           // 11-
      tHDR += ",Credit";                          // 12-
      tHDR += ",Running Bal";                     // 13-
      tHDR += ",Tran. Remarks";                   // 14

      //
      string tFieldList = "";
      tFieldList += "  serial_order";                                       // 00- hidden
      tFieldList += ", doc_ischecked";                                      // 01-
      tFieldList += ", serial_no";                                          // 02-
      tFieldList += ", doc_vt_id";                                          // 03-
      tFieldList += ", doc_fiscal_id";                                      // 04-
      tFieldList += ", doc_date";                                           // 05-
      tFieldList += ", doc_id";                                             // 06-
      tFieldList += ", doc_tran_ref";                                       // 07-  
      tFieldList += ", doc_narration";                                      // 08-  
      tFieldList += ", jobproject_id";                                      // 09-  
      tFieldList += ", jobproject_title";                                   // 10-  
      tFieldList += ", debit";                                              // 11-      
      tFieldList += ", credit";                                             // 12-
      tFieldList += ", rbalance";                                           // 13-
      tFieldList += ", doc_tran_remarks";                                   // 14  
      //                                                                        
      string tColFormat = "";
      tColFormat += " TB";                                                    // 00-  "  serial_order";     
      tColFormat += ",TB";                                                    // 01-  ", doc_ischecked"
      tColFormat += ",TB";                                                    // 02-  ", serial_no";   
      tColFormat += ",TB";                                                    // 03-  ", doc_vt_id";   
      tColFormat += ",TB";                                                    // 04-  ", doc_fiscal_id"
      tColFormat += ",DT";                                                    // 05-  ", doc_date";    
      tColFormat += ",TB";                                                    // 06-  ", doc_id";      
      tColFormat += ",TB";                                                    // 07-  ", doc_tran_ref";
      tColFormat += ",TB";                                                    // 08-  ", doc_narration"
      tColFormat += ",TB";                                                    // 09-  ", jobproject_id"
      tColFormat += ",TB";                                                    // 10-  ", jobproject_tit
      tColFormat += ",N2";                                                    // 11-  ", debit";       
      tColFormat += ",N2";                                                    // 12-  ", credit";      
      tColFormat += ",N2";                                                    // 13-  ", rbalance";    
      tColFormat += ",TB";                                                    // 14-  ", doc_tran_remar
      //
      DataSet lDs = clsDbManager.GetData_Set(lSQL, "table0");
      int lOpeningRecord = lDs.Tables[0].Rows.Count;
      int lTranRecord = lDs.Tables[1].Rows.Count;
      if (lTranRecord > 0)
      {
        if (lDs.Tables[0].Rows[0]["openingbalance"] == DBNull.Value)
        {
          lblOpeningBalance.Text = "0";
        }
        else
        {
          lblOpeningBalance.Text = lDs.Tables[0].Rows[0]["openingbalance"].ToString();
        }
      }

      IsGridLoading = true;                                                                               
      clsDbManager.FillDataGrid(                                                     
      dGvDetail,                                                                 
      lSQL,                                                                          
      tFieldList,
      tColFormat,
      lDs,
      1
      );
      //
      IsGridLoading = false;
      SetCheckedColor();
    }

    private void SetCheckedColor()
    {
      try
      {
        if (dGvDetail.RowCount > 0)
        {
          for (int i = 0; i < dGvDetail.RowCount; i++)
          {
            if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.IsChecked].Value == DBNull.Value)
            {
              dGvDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192); // Light Yellow
            }
            else
            {
              if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.IsChecked].Value.ToString() == "True")
              {
                dGvDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(206, 252, 203); // green
              }
              else
              {
                dGvDetail.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192); // Light Yellow
              }
            }
          }
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Check Box Click Color Change: " + ex.Message,lblFormTitle.Text.ToString());
      }
    }
    // Prepare Document Where
    private string DocWhere(string pPrefix = "")
    {
      // pPrefix is including dot
      string fDocWhere = string.Empty;
      try
      {
        fDocWhere += " and " + pPrefix + "ac_strid = " + lblTitle.Tag.ToString();    //mtAcID.Text.ToString();
        fDocWhere += " and " + pPrefix + "doc_date >= " + StrF01.D2Str(dtpStart);
        fDocWhere += " and " + pPrefix + "doc_date <= " + StrF01.D2Str(dtpEnd);
        //
        fDocWhere += " and " + pPrefix + "loc_id = " + clsGVar.LocID;
        fDocWhere += " and " + pPrefix + "grp_id = " + clsGVar.GrpID;
        fDocWhere += " and " + pPrefix + "co_id = " + clsGVar.CoID;
        fDocWhere += " and " + pPrefix + "year_id = " + clsGVar.YrID;
        return fDocWhere;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Where: Exception " + ex.Message,lblFormTitle.Text.ToString());
        return fDocWhere;
      }
    }

    private void dGvDetailTran_DataError( object sender, DataGridViewDataErrorEventArgs e )
    {

      //MessageBox.Show("Exception: Include Debit Grid Data Error: " + e.Exception.Message + " Context: " + e.Context.ToString(), lblFormTitle.Text.ToString());

      if (e.Context.ToString() == "Formatting, Display")
      {
        MessageBox.Show("Exception, Ledger View Grid, Formatting, Display Error: \n\r" + e.Exception.Message, lblFormTitle.Text.ToString());
      }
      else
      {
        MessageBox.Show("Exception, Ledger View Grid Data Error, Unknown Error " + e.Exception.Message + "\n\rError: " + e.Context.ToString() , lblFormTitle.Text.ToString());
      }
    }

    private void btn_MarkAll_Click( object sender, EventArgs e )
    {
      try
      {
        for (int i = 0; i < dGvDetail.RowCount; i++)
        {
          dGvDetail[( int )GLViewLedger.IsChecked, i].Value = "True";
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Mark All: " + ex.Message , lblFormTitle.Text.ToString());
      }
    }

    private void btn_UnMarkAll_Click( object sender, EventArgs e )
    {
      try
      {
        for (int i = 0; i < dGvDetail.RowCount; i++)
        {
          dGvDetail[( int )GLViewLedger.IsChecked, i].Value = "False";
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Un-Mark All: " + ex.Message , lblFormTitle.Text.ToString());
      }
    }

    private void dGvDetailTran_CellClick( object sender, DataGridViewCellEventArgs e )
    {
      try
      {
        // check if row is valid
        if (e.RowIndex != -1)
        {
          if (e.ColumnIndex == (int)GLViewLedger.SerialNo ||
              e.ColumnIndex == (int)GLViewLedger.DocType ||
              e.ColumnIndex == (int)GLViewLedger.Fiscal ||
              e.ColumnIndex == (int)GLViewLedger.DocDate ||
              e.ColumnIndex == (int)GLViewLedger.DocID ||
              e.ColumnIndex == (int)GLViewLedger.TranRef ||
              e.ColumnIndex == (int)GLViewLedger.TranNarration ||
              e.ColumnIndex == (int)GLViewLedger.JobProjectID ||
              e.ColumnIndex == (int)GLViewLedger.RunningBalance

            )
          {
            lblShowLongText.Text = dGvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ? "" : dGvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
          }

        } // end if e.rowindex
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Detail Grid Cell Click: " + ex, lblFormTitle.Text.ToString());
      }


    }

    private void dGvDetailTran_CellValueChanged( object sender, DataGridViewCellEventArgs e )
    {

      if (!IsGridLoading)
      {

        if (e.ColumnIndex == ( int )GLViewLedger.IsChecked || e.ColumnIndex == ( int )GLViewLedger.DocTranRemarks)
        {

          if (e.ColumnIndex == ( int )GLViewLedger.IsChecked)
          {
            if (dGvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
              if (dGvDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "True")
              {
                //MessageBox.Show("True Checked");
                //dGvDetailTran.RowsDefaultCellStyle.BackColor = Color.FromArgb((( int )((( byte )(255)))), (( int )((( byte )(255)))), (( int )((( byte )(192)))));
                //dGvDetailTran.RowsDefaultCellStyle.BackColor = Color.FromArgb((( int )((( byte )(253)))), (( int )((( byte )(230)))), (( int )((( byte )(189)))));

                //for (int i = 0; i < dGvDetailTran.ColumnCount; i++)
                //{
                dGvDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(206, 252, 203); // green

                //}
                // dGvDetailTran.Row
                //return;
              }
              else
              {
                dGvDetail.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192); // Light Yellow
                //MessageBox.Show("False Un-Checked");
                //return;
              }
            }
          } // if CheckBox
          IsFormDirty = true;
          //return;
        } // if CheckBox or Tran Remarks
      } // isGridLopadiong


    }

    private void btn_Save_Click( object sender, EventArgs e )
    {
      if (IsFormDirty)
      {
        PrepareUpdateSQL();
        if (fManySQL.Count > 0)
        {
          if (!clsDbManager.ExeMany(fManySQL))
          {
            MessageBox.Show("Not Saved see log...", lblFormTitle.Text.ToString());
            return;
          }
        }
      } // end if isDirty
      //
      if (dGvDetail.Rows.Count > 0)
      {
        dGvDetail.Rows.Clear();
      }
    }
    //
    private void PrepareUpdateSQL()
    {
      fManySQL = new List<string>();
      //
      try
      {
        string lSQLStart = "update gl_trandtl set ";
        string lSQLDocYear = "";
        lSQLDocYear += " and doc_ac_id = " + lblTitle.Tag.ToString();
        lSQLDocYear += " and loc_id = " + clsGVar.LocID;
        lSQLDocYear += " and grp_id = " + clsGVar.GrpID;
        lSQLDocYear += " and co_id = " + clsGVar.CoID;
        lSQLDocYear += " and year_id = " + clsGVar.YrID;

        for (int i = 0; i < dGvDetail.RowCount; i++)
        {
          string lSQLFieldValues = "";
          lSQLFieldValues += lSQLStart + " doc_ischecked = ";
          if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.IsChecked].Value == DBNull.Value)
          {
            lSQLFieldValues += "0";
          }
          else
          {
            if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.IsChecked].Value.ToString() == "True")
            {
              lSQLFieldValues += "1";
            }
            else
            {
              lSQLFieldValues += "0";
            }
          } // if DbNull checkbox
          // Tran Remarks
          lSQLFieldValues += ", doc_tran_remarks = ";
          if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value == DBNull.Value)
          {
            lSQLFieldValues += "''";
          }
          else
          {
            if (dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value == null)
            {
              lSQLFieldValues += "''";
            }
            else
            {
              if ( (dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value.ToString()).Trim().Length > 0)
              {
                //int aaaa = 999;
                //aaaa = dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value.ToString().Trim().Length;
                //string bbbb = "( int )GLViewLedger.DocTranRemarks = " + (( int )GLViewLedger.DocTranRemarks).ToString();
                //bbbb = dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value.ToString();
                //MessageBox.Show(
                //  "( int )GLViewLedger.DocTranRemarks = " + (( int )GLViewLedger.DocTranRemarks).ToString()
                //  + "\r\n" + " Cell Value 14 =  " + dGvDetail.Rows[i].Cells[14].Value.ToString()
                //  + "\r\n" + " Cell Value 12 =  " + dGvDetail.Rows[i].Cells[12].Value.ToString()
                //  + "\r\n" + " Cell Value 11 =  " + dGvDetail.Rows[i].Cells[11].Value.ToString()
                //);
                lSQLFieldValues += StrF01.EnEpos(dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocTranRemarks].Value.ToString());
              }
              else
              {
                lSQLFieldValues += "''";
              }

            }
          } // if DbNull tran
          lSQLFieldValues += " Where ";
          //lSQLFieldValues += " doc_vt_id = " + dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocType].Value.ToString();
          //lSQLFieldValues += " and doc_fiscal_id = " + dGvDetail.Rows[i].Cells[( int )GLViewLedger.Fiscal].Value.ToString();
          //lSQLFieldValues += " and doc_id = " + dGvDetail.Rows[i].Cells[( int )GLViewLedger.DocID].Value.ToString();
          lSQLFieldValues += " serial_order = " + dGvDetail.Rows[i].Cells[( int )GLViewLedger.SerialOrder].Value.ToString();
          lSQLFieldValues += lSQLDocYear;
          fManySQL.Add(lSQLFieldValues);
        } // for loop

      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception: Preparing Update SQL: " + ex.Message,lblFormTitle.Text.ToString());
      }
    }
    private void sumDebitCredit()
    {
      try
      {
        lblTotalDebit.Text = (sumDecimal(dGvDetail, ( int )GLViewLedger.Debit)).ToString();
        lblTotalCredit.Text = (sumDecimal(dGvDetail, ( int )GLViewLedger.Credit)).ToString();

      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Sum Debit-Credit: " + ex, lblFormTitle.Text.ToString());
      }
    }
    private decimal sumDecimal( DataGridView pdGV, int pCol, bool pCheckEmptyRow = false )
    {
      bool bcheck = false;
      decimal rtnValue = 0;
      decimal outValue = 0;

      try
      {
        if (pdGV.RowCount == 0)
        {
          return rtnValue;
        }
        else
        {
          for (int i = 0; i < pdGV.RowCount; i++)
          {
            if (pdGV.Rows[i].Cells[pCol].Value != null)
            {
              bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);
              if (bcheck)
              {
                rtnValue += outValue;
              }
            } // if != null
          } // for loop
        }

        return rtnValue;

      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Sum Decimal: " + ex, lblFormTitle.Text.ToString());
        return 0;
      }
    }
    private decimal CalcClosingBalance(Label pOpening, Label pDebit, Label pCredit)
    {
      bool bcheck = false;
      decimal rtnValue = 0;
      decimal outValue = 0;
      //
      try
      {
        if (pOpening.Text != null)
        {
          bcheck = decimal.TryParse(pOpening.Text.ToString(), out outValue);
          if (bcheck)
          {
            rtnValue += outValue;                   // Note Add
          }
        }
        if (pDebit.Text != null)
        {
          bcheck = decimal.TryParse(pDebit.Text.ToString(), out outValue);
          if (bcheck)
          {
            rtnValue += outValue;                   // Note Add
          }
        }
        if (pCredit.Text != null)
        {
          bcheck = decimal.TryParse(pCredit.Text.ToString(), out outValue);
          if (bcheck)
          {
            rtnValue -= outValue;                   // Note Subtract
          }
        }


        return rtnValue;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Sum Decimal: " + ex, lblFormTitle.Text.ToString());
        return 0;
      }
    }

    private void btn_Print_Click( object sender, EventArgs e )
    {
      //foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
      //{
      //  if (prop.PropertyType.FullName == "System.Drawing.Color")
      //    comboBox1.Items.Add(prop.Name);
      //}
        string fRptTitle = this.Text;
        string plstField = "@pLoc_id,@pGrp_id,@pCo_id,@pYear_id,@pAc_ID,@pFromDate,@pToDate";
        string plstType = "8,8,8,8,8,18,18"; // {   "8, 8, 8, 8, 8, 8" };
        string plstValue = clsGVar.LocID.ToString() + "," + clsGVar.GrpID.ToString() +
            "," + clsGVar.CoID.ToString() + "," + clsGVar.YrID.ToString() + "," + lblTitle.Tag
            +"," + StrF01.ToShortD2StrCrystal(dtpStart) + "," + StrF01.ToShortD2StrCrystal(dtpEnd);

       // StrF01.ToShortD2StrCrystal(
        dsLedger ds = new dsLedger();
        CrLedger rpt1 = new CrLedger();

        frmPrintViewer rptLedger = new frmPrintViewer(
           fRptTitle,
           this.dtpStart.Text,
           this.dtpEnd.Text,
           "sp_gl_Ledger",
           plstField,
           plstType,
           plstValue,
           ds,
           rpt1,
           "SP"
           );

        rptLedger.Show();
    }

    private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
    {
      lblTestColor.BackColor = Color.FromName(comboBox1.Text.ToString());
      lblTestColor.Text = comboBox1.Text.ToString();
      //
      Color lSelectedColor = Color.FromName(comboBox1.Text.ToString());

      // MessageBox.Show("Color : " + lSelectedColor.ToArgb().ToString());
      string color1 = lSelectedColor.ToString();
      Int32 color2 = lSelectedColor.ToArgb();
      int color3 = lSelectedColor.A;
      int color4 = lSelectedColor.R;
      int color5 = lSelectedColor.G;
      int color6 = lSelectedColor.B;
      float color7 = lSelectedColor.GetBrightness();
      float color8 = lSelectedColor.GetHue();
      float color9 = lSelectedColor.GetSaturation();

      //string abc GetType( lSelectedColor.ToArgb() ).ToString();
    }

    //private void label1_Click( object sender, EventArgs e )
    //{
    //  string[] colorset = textGridBackGroundColor.Text.Split(',');
    //  dGvDetail.BackgroundColor = Color.FromArgb(Convert.ToInt16(colorset[0].Trim()), Convert.ToInt16(colorset[1].Trim()), Convert.ToInt16(colorset[2].Trim()));
    //}

    //private void lblAcID_Click( object sender, EventArgs e )
    //{
    //  mtextID.Text = "1-2-03-01-0001";
    //}

    //private void label2_Click( object sender, EventArgs e )
    //{
    //  string[] colorset = textGridColor.Text.Split(',');
    //  dGvDetail.GridColor = Color.FromArgb(Convert.ToInt16(colorset[0].Trim()), Convert.ToInt16(colorset[1].Trim()), Convert.ToInt16(colorset[2].Trim()));
    //}

    //private void label3_Click( object sender, EventArgs e )
    //{
    //  string[] colorset = textDefaultCellStyle.Text.Split(',');
    //  dGvDetail.DefaultCellStyle.BackColor = Color.FromArgb(Convert.ToInt16(colorset[0].Trim()), Convert.ToInt16(colorset[1].Trim()), Convert.ToInt16(colorset[2].Trim()));
    //}

    //private void mtextID_MaskInputRejected( object sender, MaskInputRejectedEventArgs e )
    //{

    //}

    //private void chkSpecificCOA_CheckedChanged( object sender, EventArgs e )
    //{
    //  if (chkSelectedControlAc.Checked)
    //  {
    //    cboControlAcGroup.Enabled = true;
    //  }
    //  else
    //  {
    //    cboControlAcGroup.Enabled = false;
    //  }
    //}

    //private void cboControlAcGroup_SelectedIndexChanged( object sender, EventArgs e )
    //{
    //  cboControlAcGroupValueChange();
    //}
    ////
    //private void cboControlAcGroupValueChange()
    //{
    //  try
    //  {
    //    if (cboControlAcGroup.Items.Count > 0)
    //    {
    //      lblControlGroupID.Text = cboControlAcGroup.SelectedValue.ToString();
    //      LoadIntegrationData();
    //      // NR: fGenAddWhere = "control_ac_pid = " + cboControlAcGroup.SelectedValue.ToString();
    //    }

    //  }
    //  catch (Exception ex)
    //  {
    //    MessageBox.Show("Exception, Only Selected Control Ids, Cbo Value Changed: " + ex.Message, lblFormTitle.Text.ToString());
    //  }
    //}

    private void mtextID_KeyDown( object sender, KeyEventArgs e )
    {
      if (e.KeyCode == Keys.F8 || e.KeyCode == Keys.F1)
      {
        LookUpGLID();
      } 
    }

    private void dGvDetail_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
    {
      try
      {
        // check if row is valid
        if (e.RowIndex != -1)
        {
          if (e.ColumnIndex == ( int )GLViewLedger.DocID)
          {
            ViewGLVoucher(e.RowIndex);
          }
        } // end if e.rowindex
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception: Grid Cell Double-Click: " + ex, lblFormTitle.Text.ToString());
      }
    }
    private void ViewGLVoucher(int pRowId)
    {
      try
      {
      //  string lDocTypeId = dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.DocType].Value == null ? "" : dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.DocType].Value.ToString();
      //  string lDocFiscalId = dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.Fiscal].Value == null ? "" : dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.Fiscal].Value.ToString();
      //  string lDocId = dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.DocID].Value == null ? "" : dGvDetail.Rows[pRowId].Cells[( int )GLViewLedger.DocID].Value.ToString();
      //  frmViewGLVoucher lViewGLVoucher = new frmViewGLVoucher(
      //  lDocTypeId,
      //  lDocFiscalId,
      //  lDocId
      //  );
      //  lViewGLVoucher.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, View GL Voucher: " + ex, lblFormTitle.Text.ToString());
      }
    }
    //private void dGvDetail_KeyDown( object sender, KeyEventArgs e )
    //{
    //  {
    //    try
    //    {
    //      //if (( int )dGvDetail.CurrentCell.RowIndex == -1)
    //      //{
    //      //  MessageBox.Show("== -1");
    //      //  return;
    //      //}

    //      //if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.F2)
    //      //{
    //      //  ViewGLVoucher(( int )dGvDetail.CurrentCell.RowIndex);
    //      //  //MessageBox.Show("F1 or F2 is pressed.");
    //      //} // End F1,F2
    //      //
    //      // Other then GL (Invoice, Purchase etc)
    //      if (e.KeyCode == Keys.F3)
    //      {
    //        //MessageBox.Show("F3 is pressed.");
    //    //    string lDocTypeId = dGvDetail.Rows[( int )dGvDetail.CurrentCell.RowIndex].Cells[( int )GLViewLedger.DocType].Value == null ? "" : dGvDetail.Rows[( int )dGvDetail.CurrentCell.RowIndex].Cells[( int )GLViewLedger.DocType].Value.ToString();
    //    //    string lName = string.Empty; 
    //    //    switch (Convert.ToInt16(lDocTypeId))
    //    //    {
    //    //        case (int)TranPriorityId.Purchase_FG:
    //    //            {   // 103
    //    //                lName = TranPriorityId.Purchase_FG.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Purchase_RM:
    //    //            {   // 104
    //    //                lName = TranPriorityId.Purchase_RM.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Purchase_Imp:
    //    //            {   // 105
    //    //                lName = TranPriorityId.Purchase_Imp.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Purchase_Oth:
    //    //            {   // 106
    //    //                lName = TranPriorityId.Purchase_Oth.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Sales_Return_FG:
    //    //            {   // 107
    //    //                lName = TranPriorityId.Sales_Return_FG.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Sales_Return_RM:
    //    //            {   // 108
    //    //                lName = TranPriorityId.Sales_Return_RM.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Sales_Return_IMP:
    //    //            {   // 109
    //    //                lName = TranPriorityId.Sales_Return_IMP.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Sales_Return_Oth:
    //    //            {   // 110
    //    //                lName = TranPriorityId.Sales_Return_Oth.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Issue_Return_RM:
    //    //            {   // 111
    //    //                lName = TranPriorityId.Issue_Return_RM.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Issue_Return_Oth:
    //    //            {   // 112
    //    //                lName = TranPriorityId.Issue_Return_Oth.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Transfer_Debit:
    //    //            {   // 113
    //    //                lName = TranPriorityId.Transfer_Debit.ToString();
    //    //                break;
    //    //            }
    //    //        case (int)TranPriorityId.Services_Cancelled:
    //    //            {   // 114
    //    //                lName = TranPriorityId.Services_Cancelled.ToString();
    //    //                break;
    //    //            }

    //    //      case ( int )TranPriorityId.Services_Provided:
    //    //        { // 214
    //    //            lName = TranPriorityId.Services_Provided.ToString();
    //    //            break;
    //    //        }

    //    //      case 6:
    //    //        {
    //    //            lName = "Sixth Book";
    //    //            break;
    //    //        }

    //    //      default:
    //    //        {
    //    //            lName = "Default Book";
    //    //            break;
    //    //        }
    //    //    }
    //    //    MessageBox.Show("Value: " + lDocTypeId + " String: " + lName.Replace('_', ' '));



    //    //  } // End F3
    //    //}
    //    //catch (Exception ex)
    //    //{
    //    //  MessageBox.Show("Exception, Grid KeyDown: " + ex, lblFormTitle.Text.ToString());
    //    //}
    //  //}

    //}






    //public ComboBox cboControlAcGroup { get; set; }

    public DataGridView dGvDetail { get; set; }

    //public DataGridView dGvTypeWiseDetailTran { get; set; }

    public DataGridView dGvSummaryTran { get; set; }
  }
}

