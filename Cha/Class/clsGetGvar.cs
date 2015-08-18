using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;
using System.Drawing;         // for Color

namespace Cha
{
  public static class clsGetGvar
  {
      // //=======//=======//=========== Global Variables
      // Color
      static Color _gridBackColorLYellow;
      static Color _gridBackColorLGrey;
      static Color _gridBackColorLPink;
      static Color _gridBackColorLGreen;
      static Color _gridLineGreen;
      static Color _gridLineRed;
      static Color _colorVLGrey;
      static Color _color2010Blue;
      static Color _colorRequired;

      // 
      static string _appDateFormatStandard;               // 0a- Application Date Format Standard.
      static string _appDateFormatStandardTime;           // 0b- Application Date Time Format Standard. (for Date Picker)
      static string _appDateFormatStandardMinuteSecond;   // 0c- Application Date Minute Second Standard format for display in Alert.

      static string _maskGLId;                            // 1- Masked Picture of General Ledger Account ID
                                                          // 2- not known
      static string _maskJobProjectId;                    // 3- Masked Picture of Job/Project ID
      static string _maskInventoryId;                     // 4- Masked Picture of Inventory ID (if common for Finished & Raw Material Inventory)
      static string _maskFinishedInventoryId;             // 5- Masked Picture of Finished Inventory ID
      static string _maskRawStoreInventoryId;             // 6- Masked Picture of Raw Material & Stores & Spares Inventory ID
      // Quantity Decimal
      static string _qtyDecimalZero;                      // 100- Qty Decimal Zero = 0
      static string _qtyDecimalTwo;                       // 101- Qty Decimal Two = 2  
      static string _qtyDecimalThree;                     // 102- Qty Decimal Three = 3
      static string _qtyDecimalFour;                      // 102- Qty Decimal Four = 4

      // Rate Decimal
      static string _rateDecimalZero;                      // 110- Rate Decimal Zero = 0
      static string _rateDecimalTwo;                       // 111- Rate Decimal Two = 2  
      static string _rateDecimalThree;                     // 112- Rate Decimal Three = 3
      static string _rateDecimalFour;                      // 112- Rate Decimal Four = 4
      // Amount Decimal
      static string _amountDecimalZero;                      // 120- Amount Decimal Zero = 0
      static string _amountDecimalTwo;                       // 121- Amount Decimal Two = 2  
      static string _amountDecimalThree;                     // 122- Amount Decimal Three = 3
      static string _amountDecimalFour;                      // 122- Amount Decimal Four = 4

      static string FormatTwoDecimal = "N";
      //
      static int _SegmentGLId;                            // Number of Segments in General Ledger Account ID
      static bool _isDisabledGLId;                        // IsDisabled ?
      //static bool _isAppTerminationDue = false;
      // Fiscal Date 2013 05 01
      static DateTime _fiscalDateStart;                   // Fiscal Date Start
      static DateTime _fiscalDateEnd;                     // Fiscal Date End
      static DateTime _resetMinDate;                      // Reset Min Date (To remove min Date Value form Date Picker.
      static DateTime _resetMaxDate;                      // Reset Max Date (To remove max Date Value form Date Picker. 
      //
      static int _SecondCityId;
      // Goods Transport Variables
      static string _maskBiltyNumber;                            // 1- Masked Picture of Bilty Number (Company-Serial_Number)
      // Color
      public static Color GridBackColorLYellow
      {
        get
        {
          return _gridBackColorLYellow;
        }
        set
        {
          _gridBackColorLYellow = Color.FromArgb(255, 255, 192); 
        }
      } // End Set
      public static Color GridBackColorLGrey
      {
        get
        {
          return _gridBackColorLGrey;
        }
        set
        {
          _gridBackColorLGrey = Color.FromArgb(193, 208, 222); // Light Grey
          // Color.FromArgb((( int )((( byte )(255)))), (( int )((( byte )(213)))), (( int )((( byte )(213)))));   // Even: pink;
        }
      } 
      public static Color GridBackColorLPink
      {
        get
        {
          return _gridBackColorLPink;
        }
        set
        {
          _gridBackColorLPink = Color.FromArgb((( int )((( byte )(255)))), (( int )((( byte )(213)))), (( int )((( byte )(213)))));   // Even: pink;
        }
      }
      public static Color GridBackColorLGreen
      {
        get
        {
          return _gridBackColorLGreen;
        }
        set
        {
          _gridBackColorLGreen = Color.FromArgb((( int )((( byte )(231)))), (( int )((( byte )(253)))), (( int )((( byte )(230))))); // Light green
        }
      }
      public static Color GridLineGreen
      {
        get
        {
          return _gridLineGreen;
        }
        set
        {
          _gridLineGreen = Color.FromArgb(102, 179, 64);
        }
      }
      public static Color GridLineRed
      {
        get
        {
          return _gridLineRed;
        }
        set
        {
          _gridLineRed = Color.FromArgb(214, 10, 46);
        }
      } 
      public static Color ColorVLGrey
      {
        get
        {
          return _colorVLGrey;
        }
        set
        {
          _colorVLGrey = Color.FromArgb(224, 224, 224);
        }
      }
      public static Color Color2010Blue
      {
        get
        {
          return _color2010Blue;
        }
        set
        {
          _color2010Blue = Color.FromArgb(75, 94, 129);
        }
      }
      public static Color ColorRequired
      {
        get
        {
          return _colorRequired;
        }
        set
        {
          _colorRequired = Color.PapayaWhip;
        }
      }

      //clsGetGvar.QtyDecimalZero = "";
      //clsGetGvar.QtyDecimalTwo = "";
      //clsGetGvar.QtyDecimalThree = "";
      //clsGetGvar.QtyDecimalFour = "";
      //
      // QtyDecimalZero
      public static string QtyDecimalZero
      {
        get
        {
          return _qtyDecimalZero;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lQtyDecimalZero = string.Empty;
          lQtyDecimalZero = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "100", "");
          if (lQtyDecimalZero != "ID not Found..." && lQtyDecimalZero != "")
          {
            _qtyDecimalZero = lQtyDecimalZero;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Qty Decimal Zero, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      //
      // QtyDecimalTwo
      public static string QtyDecimalTwo 
      { 
        get
        {
          return _qtyDecimalTwo;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lQtyDecimalTwo = string.Empty;
          lQtyDecimalTwo = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "101", "");
          if (lQtyDecimalTwo != "ID not Found..." && lQtyDecimalTwo != "")
          {
            _qtyDecimalTwo = lQtyDecimalTwo;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Qty Decimal Two, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // QtyDecimalThree
      public static string QtyDecimalThree
      {
        get
        {
          return _qtyDecimalThree;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lQtyDecimalThree = string.Empty;
          lQtyDecimalThree = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "102", "");
          if (lQtyDecimalThree != "ID not Found..." && lQtyDecimalThree != "")
          {
            _qtyDecimalThree = lQtyDecimalThree;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Qty Decimal Three, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // QtyDecimalFour
      public static string QtyDecimalFour
      {
        get
        {
          return _qtyDecimalFour;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lQtyDecimalFour = string.Empty;
          lQtyDecimalFour = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "103", "");
          if (lQtyDecimalFour != "ID not Found..." && lQtyDecimalFour != "")
          {
            _qtyDecimalFour = lQtyDecimalFour;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Qty Decimal Four, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
    ////=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============
      // RateDecimalZero
      public static string RateDecimalZero
      {
        get
        {
          return _rateDecimalZero;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lRateDecimalZero = string.Empty;
          lRateDecimalZero = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "110", "");
          if (lRateDecimalZero != "ID not Found..." && lRateDecimalZero != "")
          {
            _rateDecimalZero = lRateDecimalZero;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Rate Decimal Zero, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      //
      // RateDecimalTwo
      public static string RateDecimalTwo
      {
        get
        {
          return _rateDecimalTwo;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lRateDecimalTwo = string.Empty;
          lRateDecimalTwo = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "111", "");
          if (lRateDecimalTwo != "ID not Found..." && lRateDecimalTwo != "")
          {
            _rateDecimalTwo = lRateDecimalTwo;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Rate Decimal Two, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // RateDecimalThree
      public static string RateDecimalThree
      {
        get
        {
          return _rateDecimalThree;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lRateDecimalThree = string.Empty;
          lRateDecimalThree = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "112", "");
          if (lRateDecimalThree != "ID not Found..." && lRateDecimalThree != "")
          {
            _rateDecimalThree = lRateDecimalThree;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Rate Decimal Three, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // RateDecimalFour
      public static string RateDecimalFour
      {
        get
        {
          return _rateDecimalFour;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lRateDecimalFour = string.Empty;
          lRateDecimalFour = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "113", "");
          if (lRateDecimalFour != "ID not Found..." && lRateDecimalFour != "")
          {
            _rateDecimalFour = lRateDecimalFour;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Rate Decimal Four, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set

    ////=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============
      ////=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============
      // AmountDecimalZero
      public static string AmountDecimalZero
      {
        get
        {
          return _amountDecimalZero;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAmountDecimalZero = string.Empty;
          lAmountDecimalZero = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "110", "");
          if (lAmountDecimalZero != "ID not Found..." && lAmountDecimalZero != "")
          {
            _amountDecimalZero = lAmountDecimalZero;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Amount Decimal Zero, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      //
      // AmountDecimalTwo
      public static string AmountDecimalTwo
      {
        get
        {
          return _amountDecimalTwo;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAmountDecimalTwo = string.Empty;
          lAmountDecimalTwo = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "111", "");
          if (lAmountDecimalTwo != "ID not Found..." && lAmountDecimalTwo != "")
          {
            _amountDecimalTwo = lAmountDecimalTwo;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Amount Decimal Two, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // AmountDecimalThree
      public static string AmountDecimalThree
      {
        get
        {
          return _amountDecimalThree;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAmountDecimalThree = string.Empty;
          lAmountDecimalThree = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "112", "");
          if (lAmountDecimalThree != "ID not Found..." && lAmountDecimalThree != "")
          {
            _amountDecimalThree = lAmountDecimalThree;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Amount Decimal Three, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // AmountDecimalFour
      public static string AmountDecimalFour
      {
        get
        {
          return _amountDecimalFour;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAmountDecimalFour = string.Empty;
          lAmountDecimalFour = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "113", "");
          if (lAmountDecimalFour != "ID not Found..." && lAmountDecimalFour != "")
          {
            _amountDecimalFour = lAmountDecimalFour;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Amount Decimal Four, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set

      ////=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=======//=============

      // AppDateFormatStandard
      public static string AppDateFormatStandard
      {
        get
        {
          return _appDateFormatStandard;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAppDateFormatStandard = string.Empty;
          lAppDateFormatStandard = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "306", "");
          if (lAppDateFormatStandard != "ID not Found..." && lAppDateFormatStandard != "")
          {
            _appDateFormatStandard = lAppDateFormatStandard;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Standard Date Format, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // AppDateTimeFormatStandard (for DatePicker)
      public static string AppDateFormatStandardTime
      {
        get
        {
          return _appDateFormatStandardTime;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAppDateFormatStandardTime = string.Empty;
          lAppDateFormatStandardTime = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "307", "");
          if (lAppDateFormatStandardTime != "ID not Found..." && lAppDateFormatStandardTime != "")
          {
            _appDateFormatStandardTime = lAppDateFormatStandardTime;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Standard Date Format, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // AppDateTimeFormatStandard (for DatePicker)
      public static string AppDateFormatStandardMinuteSecond
      {
        get
        {
          return _appDateFormatStandardMinuteSecond;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lAppDateFormatStandardMinuteSecond = string.Empty;
          lAppDateFormatStandardMinuteSecond = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "308", "");
          if (lAppDateFormatStandardMinuteSecond != "ID not Found..." && lAppDateFormatStandardMinuteSecond != "")
          {
            _appDateFormatStandardMinuteSecond = lAppDateFormatStandardMinuteSecond;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Standard Date Minute Second Format, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set

      // Date Start
      public static DateTime FiscalDateStart
      {
        get
        {
          return _fiscalDateStart;
        }
        set
        {
          DateTime lDateStart ;
          lDateStart = Convert.ToDateTime(clsDbManager.GetDateValue("cnf_appsetup", "appsetup_strvalue", "appsetup_id", "80001", ""));
          if (lDateStart != null)
          {
            _fiscalDateStart = lDateStart;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Fiscal Date Start, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Date Start
      //
      public static DateTime ResetMinDate
      { 
        get
        {
          return _resetMinDate;
        }
        set
        {
          _resetMinDate = new DateTime(1900, 1, 1);
        }
      }
      //
      //
      public static DateTime ResetMaxDate
      {
        get
        {
          return _resetMaxDate;
        }
        set
        {
          _resetMaxDate = new DateTime(2099, 1, 1);
        }
      }

      // Date Start
      public static DateTime FiscalDateEnd
      {
        get
        {
          return _fiscalDateEnd;
        }
        set
        {
          DateTime lDateEnd;
          lDateEnd = Convert.ToDateTime(clsDbManager.GetDateValue("cnf_appsetup", "appsetup_strvalue", "appsetup_id", "80002", ""));
          if (lDateEnd != null)
          {
            _fiscalDateEnd = lDateEnd;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Fiscal Date End, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Date Start
      //
      public static string MaskGlId
      {
        get
        {
          return _maskGLId;
        }
        set
        {
          string lMaskGLId = string.Empty;
          lMaskGLId = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", clsGVar.SystemGL.ToString(), "");
          if (lMaskGLId != "ID not Found..." && lMaskGLId != "")
          {
            _maskGLId = lMaskGLId;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: GLMask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      // End Property
      public static int SegmentGlId
      {
        get
        {
          return _SegmentGLId;
        }
        set
        {
          int lSegmentGLID = 0;
          lSegmentGLID = clsDbManager.GetIntValue("cnf_levelmst", "aclevel_levels", "aclevel_id", clsGVar.SystemGL.ToString(), "");
          if (lSegmentGLID != 0)
          {
            _SegmentGLId = lSegmentGLID;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Accounts Levels, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
        // End Set
      }
      // End Property
      public static string MaskJobProjectId
      {
        get
        {
          return _maskJobProjectId;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  

          string lMasobProjectID = string.Empty;
          lMasobProjectID = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "306", "");
          if (lMasobProjectID != "ID not Found..." && lMasobProjectID != "")
          {
            _maskJobProjectId = lMasobProjectID;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Job/Project Mask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      }  // End Set
      ////=============
      public static string MaskInventoryId
      {
        get
        {
          return _maskInventoryId;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lMaskInventoryId = string.Empty;
          lMaskInventoryId = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", clsGVar.SystemInventory.ToString(), "");
          if (lMaskInventoryId != "ID not Found..." && lMaskInventoryId != "")
          {
            _maskInventoryId = lMaskInventoryId;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Finished Inventory Mask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      }

      ////=======//=========
      public static string MaskFinishedInventoryId
      {
        get
        {
          return _maskFinishedInventoryId;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lMaskFinishedInventoryId = string.Empty;
          lMaskFinishedInventoryId = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", clsGVar.SystemInventoryFinished.ToString(), "");
          if (lMaskFinishedInventoryId != "ID not Found..." && lMaskFinishedInventoryId != "")
          {
            _maskFinishedInventoryId = lMaskFinishedInventoryId;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Finished Inventory Mask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      }
      // End Set
      public static string MaskrawStoreInventoryId
      {
        get
        {
          return _maskRawStoreInventoryId;
        }
        set
        {
          // Get String Value                  
          // 1- Table Name            
          // 2- Key Select Field Name  
          // 3- Conditional Field Name            
          // 4- Conditional Field Value
          // 5- Custom Qry    (Default = "" )                  
          //
          string lMaskRawStoreInventoryId = string.Empty;
          lMaskRawStoreInventoryId = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", clsGVar.SystemInventoryRawMaterial.ToString(), "");
          if (lMaskRawStoreInventoryId != "ID not Found..." && lMaskRawStoreInventoryId != "")
          {
            _maskRawStoreInventoryId = lMaskRawStoreInventoryId;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Raw Material Store Inventory Mask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set
      //
      public static int AcP0
      { 
        get
        {
          return 0;
        }
      }
      //
      public static bool IsDisabledGlId
      {
        get
        {
          return _isDisabledGLId;
        }
        set
        {
          bool lIsDisabledGLID = false;
          lIsDisabledGLID = clsDbManager.GetBoolValue("cnf_levelmst", "isdisabled", "aclevel_id", clsGVar.SystemGL.ToString(), "");
          if (lIsDisabledGLID != false && lIsDisabledGLID != true)
          {
            _isDisabledGLId = false;
          }
          else
          {
            _isDisabledGLId = lIsDisabledGLID;
          }
          // End if
        }
        // End Set
      }
    // End Property
      public static bool IsAppTerminationDue
      {
        get; set;
      }
      //
      public static int SecondCityId
      {
        get
        {
          return _SecondCityId;
        }
        set
        {
          int rtnVal = 0;
          int outValue = 0;
          bool lCheckValue = false;

          string tSecondCityId = clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", "309", "");

          if (tSecondCityId != "ID not Found..." && tSecondCityId != "")
          {
            lCheckValue = int.TryParse(tSecondCityId, out outValue);
            if (lCheckValue)
            {
              _SecondCityId = outValue;
            }

          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Second City Value, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              //Environment.Exit(0);
            }
          }

          // End if
        }
        // End Set
      }
    // End Property


      // //=======//=======//=========== Start: Global Variables Goods Transport
      public static string MaskBiltyNumber
      {
        get
        {
          return _maskBiltyNumber;
        }
        set
        {
          string lMaskBiltyNumber = string.Empty;
          lMaskBiltyNumber = "0-000000"; // clsDbManager.GetStrValue("cnf_levelmst", "aclevel_mask", "aclevel_id", clsGVar.SystemGL.ToString(), "");
          if (lMaskBiltyNumber != "ID not Found..." && lMaskBiltyNumber != "")
          {
            _maskBiltyNumber = lMaskBiltyNumber;
          }
          else
          {
            MessageBox.Show("Error in Configuration Table: Bilty Mask, \r\nAsk Application Administrator for configuration", "Initial Setup");
            if (clsGVar.AppUserName != "Admin")
            {
              //IsAppTerminationDue = true;
              //return;
              Environment.Exit(0);
            }
          }
          // End if
        }
      } // End Set

      // //=======//=======//=========== End: Global Variables Goods Transport



  }
}
