using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Manually Added
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
//
using System.Data.SqlClient;
using Cha.PrintReport;
using Cha.PrintDataSets;
using Cha.StringFun01;

namespace Cha.PrintViewer
{
    public partial class frmPrintViewerSub7Rpt : Form
    {
        string fIDStart = string.Empty;
        string fIDEnd = string.Empty;
        string fFromDate = string.Empty;
        string fToDate = string.Empty;
        string fStartName = string.Empty;
        string fTableName = string.Empty;
        string fRptTitle = string.Empty;
        string fQry = string.Empty;
        string fFL = string.Empty;
        string[] fField;
        string fOrder = string.Empty;
        string fp;
        string fp_2;
        string fStoreProcName;
        string flstField;
        string flstType;
        string flstValue;
        DataSet fDs;
        ReportClass frpt1;
        string fQtyType;
        //
        // 1- Report Title
        // 2- Table Start Name
        // 3- Table Name
        // 4- Field List
        // 5- ID Start
        // 6- ID End
        // 7- Order
        // 8- Custom Qry List<>
        //string pRptTitle, string pFromDate, string pToDate

        public frmPrintViewerSub7Rpt(
            string pRptTitle,
            string p,
            string p_2,
            string pStoreProcName,
            string plstField,
            string plstType,
            string plstValue,
            DataSet pDs,
            ReportClass prpt1,
            string pQtyType
            )                                     // Constructor
        {
            InitializeComponent();

            fRptTitle = pRptTitle;
            fp = p;
            fp_2 = p_2;
            fStoreProcName = pStoreProcName;
            flstField = plstField;
            flstType = plstType;
            flstValue = plstValue;
            fDs = pDs;
            frpt1 = prpt1;
            fQtyType = pQtyType;

            //
            try
            {
                fRptTitle = pRptTitle;
                this.Text = fRptTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception-Initialize: " + ex.Message, this.Text.ToString());
            }
        }

        private void ExecuteSPData()
        {
            //dsGLTrialC ds = new dsGLTrialC();
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand cmd = new SqlCommand();
            //DataSet ds = null;
            SqlDataAdapter adapter;
            //Table Getting
            //SqlConnection ConLogo = new SqlConnection(clsGVar.ConString1);
            //SqlCommand cmdLogo = new SqlCommand("Select ID, Name, Photo From Photos where id=16", ConLogo);
            //SqlCommand com = new SqlCommand(flstField, con);
            //DataSet ds = null;
            //SqlDataAdapter adapterLogo;

            try
            {
                Con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = fStoreProcName;

                string[] aryField = flstField.Split(',');
                string[] aryType = flstType.Split(',');
                string[] aryValue = flstValue.Split(',');

                for (int i = 0; i < aryField.Length; i++)
                {

                    switch (int.Parse(aryType[i]))
                    {
                        //sqlDBType.Int
                        case 8:
                            {
                                cmd.Parameters.Add(aryField[i], SqlDbType.Int).Value = int.Parse(aryValue[i]);
                                break;
                            }

                        //sqlDBType.DateTime
                        case 4:
                            {
                                cmd.Parameters.Add(aryField[i], SqlDbType.DateTime).Value = DateTime.Parse(aryValue[i]);
                                break;
                            }
                        //sqlDBType.Text
                        case 18:
                            {
                                cmd.Parameters.Add(aryField[i], SqlDbType.Text).Value = aryValue[i];
                                break;
                            }

                        default:
                            break;
                    }

                }


                //DateTime = 4,
                //Decimal = 5,
                //Float = 6,
                //Image = 7,
                //Int = 8,
                //Money = 9,
                //NChar = 10,
                //NText = 11,
                //NVarChar = 12,
                //Real = 13,
                //UniqueIdentifier = 14,
                //SmallDateTime = 15,
                //SmallInt = 16,
                //SmallMoney = 17,
                //Text = 18,

                //cmd.Parameters.Add("@Co_ID", SqlDbType.Int).Value = 1;
                //cmd.Parameters.Add("@ToDate", SqlDbType.Text).Value = fToDate; //"2013-01-01";
                cmd.Connection = Con;

                adapter = new SqlDataAdapter(cmd);
                //adapter.TableMappings.Add("Table", "Table");

                adapter.Fill(fDs);
                //
                int cCount = fDs.Tables[1].Rows.Count;
                // Table 1 is used as table 0 is already present at the time of design of DataSet.
                //CrGLTrial rpt1 = new CrGLTrial();                 // Instiantiate a report
                //CrBira01 rpt1 = new CrBira01();                 // Instiantiate a report
                //rpt1.SetDataSource(ds.Tables[1]);

                frpt1.DataDefinition.FormulaFields["CoName"].Text = "'" + clsGVar.CoTitle1 + "'";
                frpt1.DataDefinition.FormulaFields["RptTitle"].Text = "'" + fRptTitle + "'";
                frpt1.DataDefinition.FormulaFields["AppUserName"].Text = "'" + clsGVar.AppUserTitle + "'";
                frpt1.DataDefinition.FormulaFields["fromdate"].Text = "'" + fp + "'";
                frpt1.DataDefinition.FormulaFields["ToDate"].Text = "'" + fp_2 + "'";

                //frpt1.SetDataSource(fDs.Tables[1]);
                //frpt1.OpenSubreport("CrImage").SetDataSource(fDs.Tables[2]);
                //
                crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                crystalReportViewer1.Width = 900;
                crystalReportViewer1.Height = 300;
                //
                //---------------------***********
                //dsPhoto ds = new dsPhoto();
                //cmdLogo.Connection = ConLogo;
                //adapterLogo = new SqlDataAdapter(cmdLogo);
                //ConLogo.Open();
                //SqlDataAdapter adapterLogo = new SqlDataAdapter();
                //adapterLogo.SelectCommand = cmdLogo;
                //adapter.TableMappings.Add("table", fTableName);
                //adapterLogo.TableMappings.Add("table", "abctablename"); // Actual table has nothing to do with DataSet. 
                //
                //adapterLogo.Fill(ds);
                //           
                //---------------****************
                //CrLogo rptLogo = new CrLogo();
                //rptLogo.SetDataSource(ds.Tables["Photos"]);

                //frpt1.OpenSubreport("CrImages.rpt").SetDataSource(ds.Tables["Photos"]); 
                //frpt1.OpenSubreport("CrBira01.rpt").SetDataSource(dsPhoto.Tables["Photos"]);
                //customerReport.OpenSubreport("MainSubReport.rpt").SetDataSource(dsSubReportResult.Tables["MainTableSubReportRecord"]); ;

                //frpt1.SetDataSource(fDs.Tables[1]);
                //frpt1.OpenSubreport("CrLogo.rpt").SetDataSource(fDs.Tables[2]);
                //frpt1.OpenSubreport("CrReceiptSub.rpt").SetDataSource(fDs.Tables[1]);
                //frpt1.OpenSubreport("CrPaymentSub.rpt").SetDataSource(fDs.Tables[2]);

                frpt1.OpenSubreport("CrMfgClose.rpt").SetDataSource(fDs.Tables[1]);
                frpt1.OpenSubreport("CrMfgCloseHeader.rpt").SetDataSource(fDs.Tables[1]);
                frpt1.OpenSubreport("CrLogo.rpt").SetDataSource(fDs.Tables[2]);
                
                frpt1.OpenSubreport("CrMfgSumSubWOOpn.rpt").SetDataSource(fDs.Tables[3]);
                frpt1.OpenSubreport("CrStockSumSub.rpt").SetDataSource(fDs.Tables[4]);

                crystalReportViewer1.ReportSource = frpt1;
                //crystalReportViewer1.ReportSource = rptLogo;
                crystalReportViewer1.Refresh();
                //adapterLogo.Dispose();
                //cmdLogo.Dispose();
                //ConLogo.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void ExecuteTableData()
        {
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            //flstField -- Actually -- Select * from TableName
            SqlCommand com = new SqlCommand(flstField, con);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = com;
                //adapter.TableMappings.Add("table", fTableName);
                adapter.TableMappings.Add("table", "abctablename"); // Actual table has nothing to do with DataSet. 
                //
                adapter.Fill(fDs);
                //           
                adapter.Dispose();
                com.Dispose();
                con.Close();
                // ----------------------------------------------------------------
                int cCount = fDs.Tables[1].Rows.Count;
                // Table 1 is used as table 0 is already present at the time of design of DataSet.
                //CryList rpt1 = new CryList();                 // Instiantiate a report
                // in the report designer
                // Highlight / select the field and press Properties
                // CurrencySymbol = blank
                // DecimalSymbol = blank
                // DecimalPlaces = 0
                // ThousandsSeperators = false
                // ThousandSymbol = blank
                // the above did not work
                // (on control or text field) Right Click -> Find in Formula
                // select Display String
                // ToText({TblListMast.mast_id})

                //frpt1.DataDefinition.FormulaFields["CoName"].Text = "'" + clsGVar.CoTitle + "'";
                frpt1.DataDefinition.FormulaFields["RptTitle"].Text = "'" + fRptTitle + "'";
                frpt1.DataDefinition.FormulaFields["AppUserName"].Text = "'" + clsGVar.AppUserTitle + "'";
                //
                //rpt1.ReportDefinition.Sections[3].ReportObjects[2]
                //
                // Cstr({field}, "dd/MM/yyyy") 
                // ToText(Date ({Table.DATEField}),"MM/dd/yyyy") 
                // Date(Year({datetimefield}), Month({datetimefield}), Day({datetimefield})) 
                // ToText({MyDate}, "dd-MM-yyyy") 
                // count ({OTA.Record_Count}),'00000000'
                // totext(count ({OTA.Record_Count}),'00000000')

                //===============================================
                //frpt1.SetDataSource(fDs.Tables[1]);
                //frpt1.OpenSubreport("CrLogo.rpt").SetDataSource(fDs.Tables[2]);

                //
                crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
                crystalReportViewer1.Width = 900;
                crystalReportViewer1.Height = 300;

                //---------------------***********
                //---------------****************

                //frpt1.SetDataSource(fDs.Tables[1]);
                frpt1.OpenSubreport("CrReceipt.rpt").SetDataSource(fDs.Tables[1]);
                frpt1.OpenSubreport("CrPayment.rpt").SetDataSource(fDs.Tables[2]);
                frpt1.OpenSubreport("CrLogo.rpt").SetDataSource(fDs.Tables[3]); 

                crystalReportViewer1.ReportSource = frpt1;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                com.Dispose();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                MessageBox.Show("Exception-Load-2: " + ex.Message, this.Text.ToString());
            }
        }

        private void frmPrintViewer_Load(object sender, EventArgs e)
        {
            if (fQtyType == "SP")
            {
                ExecuteSPData();
            }
            else if (fQtyType == "Table")
            {
                ExecuteTableData();
            }

        }
    }

}
