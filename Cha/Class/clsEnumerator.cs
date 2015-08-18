using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cha.Class
{


  public static class clsEnumerator
  {
    ////=======//=======//=======//=======//=========
    public static void FillComboWithEnum( ComboBox pCbo, string pEnumName, bool pSort )
    {
      try
      {
        List<NameValuePair> ControlGroupList = new List<NameValuePair>();
        switch (pEnumName)
        {
          case "GLVoucher":
            {
              var values = Enum.GetValues(typeof(GLVoucher))
             .Cast<GLVoucher>()
             .Select(d => Tuple.Create((( int )d).ToString(), d.ToString()))
             .ToList();  // it is ok but it is comma seperated list.
              //
              foreach (var item in values)
              {
                string lName = item.Item2.ToString().Replace('_', ' '); ;
                string lValue = item.Item1.ToString();
                NameValuePair NvP = new NameValuePair(lName, Convert.ToInt32(lValue));
                ControlGroupList.Add(NvP);
              }
              break;
            }
          case "ControlAc":
            {
              var values = Enum.GetValues(typeof(ControlAc))
             .Cast<ControlAc>()
             .Select(d => Tuple.Create((( int )d).ToString(), d.ToString()))
             .ToList();  // it is ok but it is comma seperated list.
              //
              //values.Dump();
              foreach (var item in values)
              {
                string lName = item.Item2.ToString().Replace('_', ' '); ;
                string lValue = item.Item1.ToString();
                NameValuePair NvP = new NameValuePair(lName, Convert.ToInt32(lValue));
                ControlGroupList.Add(NvP);
              }
              break;
            }
          case "TranPriority":
            {
              var val = Enum.GetValues(typeof(TranPriorityId)); 
              var values = Enum.GetValues(typeof(TranPriorityId))
             .Cast<TranPriorityId>()
             .Select(d => Tuple.Create((( int )d).ToString(), d.ToString()))
             .ToList();  // it is ok but it is comma seperated list.
              //
              //values.Dump();
              foreach (var item in values)
              {
                string lName = item.Item2.ToString().Replace('_', ' '); ;
                string lValue = item.Item1.ToString();
                NameValuePair NvP = new NameValuePair(lName, Convert.ToInt32(lValue));
                ControlGroupList.Add(NvP);
              }
              break;
            }

          default:
            {

              break;
            }
        }
        if (pSort)
        {
          ControlGroupList.Sort(NameValuePair.NameComparison);
        }
        //
        pCbo.DataSource = ControlGroupList;
        pCbo.DisplayMember = "NameStr";
        pCbo.ValueMember = "ValueInt";
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, Enumerator ComboBox: " + ex.Message);
      }
    }
    ////=======//=======//=======//=======//=========

    ////=======//=======//=======//=======//=========
    public static void FillComboColWithEnum( 
      DataGridViewComboBoxColumn pCbo,
      string pEnumName, 
      bool pSort )
    { 
      try
      {
        List<NameValuePair> ControlGroupList = new List<NameValuePair>();
        switch (pEnumName)
        {
          case "GLVoucher":
            {
              var values = Enum.GetValues(typeof(GLVoucher))
             .Cast<GLVoucher>()
             .Select(d => Tuple.Create((( int )d).ToString(), d.ToString()))
             .ToList();  // it is ok but it is comma seperated list.
              //
              foreach (var item in values)
              {
                string lName = item.Item1.ToString().Replace('_', ' ');
                string lValue = item.Item2.ToString();
                NameValuePair NvP = new NameValuePair(lValue, Convert.ToInt32(lName));
                ControlGroupList.Add(NvP);
              }
              break;
            }
          case "ControlAc":
            {
              var values = Enum.GetValues(typeof(ControlAc))
             .Cast<ControlAc>()
             .Select(d => Tuple.Create((( int )d).ToString(), d.ToString()))
             .ToList();  // it is ok but it is comma seperated list.
              //
              foreach (var item in values)
              {
                string lName = item.Item2.ToString().Replace('_', ' '); 
                string lValue = item.Item1.ToString();
                NameValuePair NvP = new NameValuePair(lName, Convert.ToInt32(lValue));
                ControlGroupList.Add(NvP);
              }
              break;
            }
          default:
            {

              break;
            }
        }
        if (pSort)
        {
          ControlGroupList.Sort(NameValuePair.NameComparison);
        }
        //
        pCbo.DataSource = ControlGroupList;
        pCbo.DisplayMember = "NameStr";
        pCbo.ValueMember = "ValueInt";
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception");
      }
    }
    ////=======//=======//=======//=======//=========

  }

public enum Category
{
    enmShift = 1        ,
    enmGodown = 2       ,
    enmColor = 3        ,
    enmCharges = 4      ,
    enmSize = 5         ,
    enmItemGroup = 6    ,
    enmShoePart = 7     ,
    enmType = 8         ,
    enmLC = 9           ,
    enmPurpose = 10     ,
    enmMachineNo = 11   ,
    enmContractor = 12  ,
    enmDiscount = 13    ,
    enmAdda = 14        ,
    enmMainGroup = 15   ,
    enmPacking = 16     ,
    enmProdProc = 17    ,
    enmProdStatus = 18  ,
    enmProdProcPart = 19,
    enmGate = 20        ,
    enmClaimEffect = 21 ,
    enmBatchStatus = 22 
}

public enum Table
{
    enmItem=1,
    enmIMS_UOM=2,
    enmEmployee=3,
    enmDepartment=4
}

  // Enum GLVoucher
  public enum GLVoucher
  {
    TranId = 0,
    SNum = 1,
    SerialOrder = 2,
    NumAcId = 3,
    AcstrId = 4,
    AcTitle = 5,
    JobId = 6,
    JobTitle = 7,
    DocTranRef = 8,
    DocNarration = 9,
    Debit = 10,
    Credit = 11,
    SideDrCr = 12,
    DocTranRemarks = 13
  }
  // Enum Control Accounts
  public enum ControlAc
  {
    Accounts_Receivable = 101,
    Accounts_Payable = 102,
    Cash_Account = 201,
    Bank_Account = 202,
    Taxes_Receivable = 250,
    Taxes_Payable = 275,
    Taxes_All = 280,
    Purchase_Account = 301,
    Purchase_Return = 325,
    Discount_on_Purchase = 350,
    Sales_Account = 401,
    Services_Account = 410,
    Sales_Return = 425,
    Discount_on_Sales = 450,
    Work_in_Process = 501,
    Closing_Stock = 601,
    Cost_of_Production = 701,
    Cost_of_Sales = 750,
    Administrative_Expenses = 801,
    Selling_and_Distribution_Expenses = 810,
    Bilty_Expense = 1001
  }
  // Enum Transaction Priority
  // 2013 05 08
  public enum TranPriorityId 
  { 
    // In
    Adjustment_Debit = 101,
    Production_Receipt = 102,
    Purchase_FG = 103,
    Purchase_RM = 104,
    Purchase_Imp = 105,
    Purchase_Oth = 106,
    Sales_Return_FG = 107,
    Sales_Return_RM = 108,
    Sales_Return_IMP = 109,
    Sales_Return_Oth = 110,
    Issue_Return_RM = 111,
    Issue_Return_Oth = 112,
    Transfer_Debit = 113,
    Services_Cancelled = 114, 
    // Out
    Adjustment_Credit = 201,
    Production_Return = 202,
    Purchase_Return_FG = 203,
    Purchase_Return_RM = 204,
    Purchase_Return_Imp = 205,
    Purchase_Return_Oth = 206,
    Sales_FG = 207,
    Sales_RM = 208,
    Sales_IMP = 209,
    Sales_Oth = 210,
    Issue_RM = 211,
    Issue_Oth = 212,
    Transfer_Credit = 213,
    Services_Provided = 214

  }
  //tHDR = "SerialOrder";                       // 0-   Hidden
  //tHDR += ",Chk";                             // 1-   
  //tHDR += ",Type";                            // 2-   
  //tHDR += ",FP.";                             // 3-
  //tHDR += ",Date";                            // 4-
  //tHDR += ",Doc ID";                          // 5-
  ////tHDR += ",Ac ID";                           // 6-
  ////tHDR += ",Account Title";                   // 7-
  //tHDR += ",Ref.";                            // 8-
  //tHDR += ",Transaction Narration";           // 9-
  //tHDR += ",Prj/Job ID";                      // 10-
  //tHDR += ",Prj/Job Title";                   // 11-
  //tHDR += ",Debit";                           // 12-
  //tHDR += ",Credit";                          // 13-
  //tHDR += ",Running Bal";                     // 14-
  //tHDR += ",Tran. Remarks";                   // 15-
  // Enum GLVoucher

  // shift to local
  //public enum GLViewLedger
  //{
  //  SerialOrder = 0,
  //  IsChecked = 1,
  //  SerialNo = 2,
  //  DocType = 3,
  //  Fiscal = 4,
  //  DocDate = 5,
  //  DocID = 6,
  //  TranRef = 7,
  //  TranNarration = 8,
  //  JobProjectID = 9,
  //  JobProjectTitle = 10,
  //  Debit = 11,
  //  Credit = 12,
  //  RunningBalance = 13,
  //  DocTranRemarks = 14
  //}




}
