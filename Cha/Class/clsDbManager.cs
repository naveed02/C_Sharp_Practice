using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
// for Image/Attachment
using CSUST.Data;
//
using MSMaskedEditBox;
using System.ComponentModel;
using Cha.StringFun01;
using System.Windows.Forms.VisualStyles;

namespace Cha
{
    public class clsDbManager
    {
        public static DataSet GetData_Set(string pQry, string strtable)
        {
            // strtable is optional: any string may be used as name to fullfull
            // formality of ds.
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            DataSet ds = new DataSet();
            SqlCommand com = new SqlCommand(pQry, con);
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = com;
                adapter.Fill(ds, strtable);
                //           
                adapter.Dispose();
                com.Dispose();
                con.Close();
            }
            catch
            {
                com.Dispose();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            //
            return ds;

            // condition ? first_expression : second_expression;
            // The condition must evaluate to true or false. If condition is true, first_expression is evaluated and 
            // becomes the result. If condition is false, second_expression is evaluated and becomes the result. Only 
            // one of the two expressions is evaluated.

            // Either the type of first_expression and second_expression must be the same, or an implicit conversion must 
            // exist from one type to the other.
        }
        // Return value is string instead of Number. So that may be converted to any No type    
        // It may be Int16, Int32 or int 64, therefore string may be converted to any form      Child ID
        // Get Title                  Table Name            Field_ID     Field_Title            ID to be searched      Custom Qry                  
        //
        // Table Name
        // Key Field ID
        // Parent Field ID
        // Search Value
        // CustQry
        public static string GetParentID(
          string pTable,
          string pKeyFieldID,
          string pPidField,
          Int64 pSearchValue,
          string pCustomQry = ""
          )
        {
            string strRtnIDString = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pPidField;
                mySQL += " from " + pTable + " Where " + pKeyFieldID + " = " + pSearchValue.ToString();
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnIDString = "Err";
                }
                else
                {
                    reader.Read();
                    strRtnIDString = reader[pPidField].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                strRtnIDString = "Err";
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnIDString;
        } // Get Parent ID

        // Get Title                  
        // 1- Table Name            
        // 2- Key Field_ID     
        // 3- Key Field_Title            
        // 4- Code to be searched or Located
        // 5- Custom Qry    (Default = "" )                  
        public static string GetTitle(
            string pTable,
            string pKeyFieldID,
            string pKeyFieldTitle,
            Int64 pSearchValue,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pKeyFieldID + ", " + pKeyFieldTitle;
                mySQL += " from " + pTable + " Where " + pKeyFieldID + " = " + pSearchValue.ToString();
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "ID not Found...";
                }
                else
                {
                    reader.Read();
                    strRtnTitle = reader[pKeyFieldTitle].ToString(); // working ok
                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                strRtnTitle = "ID not Found..." + " Exception: ";
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Title ID
        // =======================================
        // Get Title Account               
        // 1- Table Name            
        // 2- Key Field_ID     
        // 3- Key Field_Title            
        // 4- Code to be searched or Located (Value)
        // 5- Custom Qry    (Default = "" )                  
        public static string GetTitleAc(
            string pTable,
            string pKeyFieldID,
            string pKeyFieldTitle,
            string pSearchValue,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pKeyFieldID + ", " + pKeyFieldTitle;
                mySQL += " from " + pTable + " Where " + pKeyFieldID + " = '" + pSearchValue + "'";
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "ID not Found...";
                }
                else
                {
                    reader.Read();
                    strRtnTitle = reader[pKeyFieldTitle].ToString(); // working ok
                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                strRtnTitle = "GetTitleAc: ID not Found..." + " Exception: ";
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Title ID

        //========================================
        public static int FindUserID(string pUserName)
        {
            // Find User ID
            int rtnUserID = 0;
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pUserName == string.Empty || pUserName.Trim() == "")
            {
                return rtnUserID;
            }
            if (pUserName.Trim().Length == 0)
            {
                return rtnUserID;
            }
            else
            {
                mySQL = "select top 1 usr_id from secusr";
                mySQL += " Where usr_name = '" + pUserName.Trim() + "'";
            }
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    //strRtnTitle = "ID not Found...";
                    return 0;
                }
                else
                {
                    reader.Read();
                    rtnUserID = Convert.ToInt32(reader["usr_id"]);
                    reader.Close();
                    com.Dispose();
                    con.Close();
                    return rtnUserID;
                } // End Reader Block
            } // End Try Block
            catch
            {
                //MessageBox.Show("Exception: " + ex.Message, "Already Exists");
                //strRtnTitle = "ID not Found..." + " Exception: ";
                com.Dispose();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    return 0;
                }
            } // End Catch Block
            return rtnUserID;
            // End Find User ID
        }
        public static int FindGroupID(string pGroupName)
        {
            // Find Group ID
            int rtnGroupID = 0;
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            string mySQL = string.Empty;
            if (pGroupName == string.Empty || pGroupName.Trim() == "")
            {
                return rtnGroupID;
            }
            if (pGroupName.Trim().Length == 0)
            {
                return rtnGroupID;
            }
            else
            {
                mySQL = "select top 1 usrgrp_id from secusrgrp";
                mySQL += " Where usrgrp_title = '" + pGroupName.Trim() + "'";
            }
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    //strRtnTitle = "ID not Found...";
                    return 0;
                }
                else
                {
                    reader.Read();
                    rtnGroupID = Convert.ToInt32(reader["usrgrp_id"]);
                    reader.Close();
                    com.Dispose();
                    con.Close();
                    return rtnGroupID;
                } // End Reader Block
            } // End Try Block
            catch
            {
                //MessageBox.Show("Exception: " + ex.Message, "Already Exists");
                //strRtnTitle = "ID not Found..." + " Exception: ";
                com.Dispose();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    return 0;
                }
            } // End Catch Block
            return rtnGroupID;
            // End Find Group ID
        }
        // ====
        public static int FindFormID(string pFormName)
        {
            // Find Group ID
            int rtnFormID = 0;
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            string mySQL = string.Empty;
            if (pFormName == string.Empty || pFormName.Trim() == "")
            {
                return rtnFormID;
            }
            if (pFormName.Trim().Length == 0)
            {
                return rtnFormID;
            }
            else
            {
                mySQL = "select top 1 frm_id from secfrm";
                mySQL += " Where frm_title = '" + pFormName.Trim() + "'";
            }
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    //strRtnTitle = "ID not Found...";
                    return 0;
                }
                else
                {
                    reader.Read();
                    rtnFormID = Convert.ToInt32(reader["frm_id"]);
                    reader.Close();
                    com.Dispose();
                    con.Close();
                    return rtnFormID;
                } // End Reader Block
            } // End Try Block
            catch
            {
                //MessageBox.Show("Exception: " + ex.Message, "Already Exists");
                //strRtnTitle = "ID not Found..." + " Exception: ";
                com.Dispose();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    return 0;
                }
            } // End Catch Block
            return rtnFormID;
            // End Find User ID
        }
        //=====

        public static string GetConfigCode(
            string pTable,
            string pKeyFieldID,
            string pWhere,
            string pCustomQry = "")
        {
            //Int64 rtnValue = 0;
            string rtnString = string.Empty;
            string lSQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                lSQL = "select Top 1 " + pKeyFieldID + " as ReturnCode";
                lSQL += " from " + pTable;
                if (pWhere != "")
                {
                    lSQL += " where ";
                    lSQL += pWhere;
                }
                //lSQL += " and ";
                //lSQL += clsGVar.LGCY;
            }
            else
            {
                lSQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(lSQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    rtnString = string.Empty;
                }
                else
                {
                    reader.Read();
                    if (reader["ReturnCode"] == null)
                    {
                        rtnString = string.Empty;
                    }
                    else
                    {

                        rtnString = reader["ReturnCode"].ToString();
                        //bool bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);

                        // int.TryParse(reader["maxvalue"]); //
                    }
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnString = string.Empty;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            // max value + 1            
            return rtnString;
        }


        //--------------- Get Next Doc ID -----------------
        //
        // 1- Table Name
        // 2- Key Field Name
        // 3- Where Condition / Filter
        // 4- pCustomQry optional ""
        //
        public static Int64 GetNextValDocID(
            string pTable,
            string pKeyFieldID,
            string pWhere,
            string pCustomQry = "")
        {
            Int64 rtnValue = 0;
            string lSQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                lSQL = "select max(" + pKeyFieldID + ") as maxvalue";
                lSQL += " from " + pTable;
                if (pWhere != string.Empty)
                {
                    lSQL += " where ";
                    lSQL += pWhere;
                }
                else
                {
                    lSQL = "select max(" + pKeyFieldID + ") as maxvalue";
                    lSQL += " from " + pTable;
                    //lSQL += " where ";
                }
                //lSQL += " and ";
                //lSQL += clsGVar.LGCY;
            }
            else
            {
                lSQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(lSQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    rtnValue = 0;
                }
                else
                {
                    reader.Read();
                    if (reader["maxvalue"] == null)
                    {
                        rtnValue = 0;
                    }
                    else
                    {
                        Int64 outValue = 0;
                        //bool bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);
                        bool bcheck = Int64.TryParse(reader["maxvalue"].ToString(), out outValue);            // Error without .ToString()
                        if (bcheck)
                        {
                            rtnValue = outValue;
                        }
                        else
                        {
                            rtnValue = 0;
                        }


                        // int.TryParse(reader["maxvalue"]); //
                    }
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            // max value + 1            
            return rtnValue + 1;
        }
        //--------------- Get Next Doc ID -----------------

        //--------------- Get Doc ID -----------------
        //
        // 1- Table Name
        // 2- Key Field Name
        // 3- Where Condition / Filter
        // 4- pCustomQry optional ""
        //
        public static Int64 GetValDocID(
            string pTable,
            string pKeyFieldID,
            string pWhere,
            string pCustomQry = "")
        {
            Int64 rtnValue = 0;
            string lSQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                lSQL = "select top 1 " + pKeyFieldID + " as valueid";
                lSQL += " from " + pTable;
                lSQL += " where ";
                lSQL += pWhere;
                //lSQL += " and ";
                //lSQL += clsGVar.LGCY;
            }
            else
            {
                lSQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(lSQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                if (!reader.HasRows)
                {
                    rtnValue = 0;
                }
                else
                {
                    reader.Read();
                    if (reader["valueid"] == null)
                    {
                        rtnValue = 0;
                    }
                    else
                    {
                        Int64 outValue = 0;
                        //bool bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);
                        bool bcheck = Int64.TryParse(reader["valueid"].ToString(), out outValue);            // Error without .ToString()
                        if (bcheck)
                        {
                            rtnValue = outValue;
                        }
                        else
                        {
                            rtnValue = 0;
                        }
                    }
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            // max value + 1            
            return rtnValue;
        }
        //--------------- Get Next ID int -----------------
        // Table Name
        // KeyField Name
        // Custom Qry
        public static int GetNextValMastID(
          string pTable,
          string pKeyFieldID,
          string pCustomQry
          )
        {
            // Get Next ID
            int rtnValue = 0;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select max( " + pKeyFieldID + ") as maxvalue";
                mySQL += " from " + pTable;
                mySQL += " where ";
                mySQL += clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    rtnValue = 0;
                }
                else
                {
                    reader.Read();
                    if (reader["maxvalue"] == null)
                    {
                        rtnValue = 0;
                    }
                    else
                    {
                        int outValue = 0;
                        //bool bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);
                        bool bcheck = int.TryParse(reader["maxvalue"].ToString(), out outValue);            // Error without .ToString()
                        if (bcheck)
                        {
                            rtnValue = outValue;
                        }
                        else
                        {
                            rtnValue = 0;
                        }


                        // int.TryParse(reader["maxvalue"]); //
                    }
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            // max value + 1            
            return rtnValue + 1;
        } // Get Next ID int
        //--------------- Get Next ID Int64 -----------------
        // Table Name
        // KeyField Name
        // Custom Qry
        public static Int64 GetNextValMastIDInt64(
          string pTable,
          string pKeyFieldID,
          string pCustomQry
          )
        {
            // Get Next ID
            Int64 rtnValue = 0;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select max( " + pKeyFieldID + ") as maxvalue";
                mySQL += " from " + pTable;
                mySQL += " where ";
                mySQL += clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    rtnValue = 0;
                }
                else
                {
                    reader.Read();
                    if (reader["maxvalue"] == null)
                    {
                        rtnValue = 0;
                    }
                    else
                    {
                        Int64 outValue = 0;
                        //bool bcheck = decimal.TryParse(pdGV.Rows[i].Cells[pCol].Value.ToString(), out outValue);
                        bool bcheck = Int64.TryParse(reader["maxvalue"].ToString(), out outValue);            // Error without .ToString()
                        if (bcheck)
                        {
                            rtnValue = outValue;
                        }
                        else
                        {
                            rtnValue = 0;
                        }


                        // int.TryParse(reader["maxvalue"]); //
                    }
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            // max value + 1            
            return rtnValue + 1;
        } // Get Next ID Int64

        //--------------- Get Next ID -----------------

        //--------------- Get Total Rec -----------------
        // Table Name
        // Key Field Name
        // Connection string
        public static string GetTotalRec(
          string pTtable,
          string pFieldID,
          string pConn = clsGVar.ConString1
          )
        {
            string strRtnTotal = string.Empty;
            string mySQL = string.Empty;
            mySQL = "select count ( " + pFieldID + ") as totalrec";
            mySQL += " from " + pTtable;
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            //if (pConn == "")
            //{
            //    con = new SqlConnection(clsGVar.gConString1);
            //}
            //else
            //{
            //    con = new SqlConnection(pConn);
            //}
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();
                if (!reader.HasRows)
                {
                    strRtnTotal = "Empty/Zero";
                }
                else
                {
                    reader.Read();
                    strRtnTotal = reader["totalrec"].ToString();
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                //reader.Close();
                if (con.State == ConnectionState.Open) { con.Close(); }
                com.Dispose();
                strRtnTotal = "Err:";
            }
            return strRtnTotal;
        } //---------------End Get Total Rec -----------------

        // 1- ListView Control
        // 2- Total Columns
        // 3- Column titles
        // 4- Column Width
        // 5- Column Format
        // 6- Color Scheme

        public static void SetLVHeader(
            ListView pLV,
            int pColTotal,
            string pColHeader,
            string pColWidth,
            string pColFormat,
            int pGridColorScheme = 0)
        {
            int widM = 10;     // Multiple for Character width
            string formatChar = string.Empty;

            switch (pGridColorScheme)
            {
                case 1:
                    // Light Blue/Grey
                    pLV.BackColor = Color.FromArgb(193, 208, 222);
                    pLV.ForeColor = Color.FromArgb(193, 208, 222);
                    break;
                case 2:
                    //
                    pLV.BackColor = Color.FromArgb(193, 208, 222);
                    pLV.ForeColor = Color.FromArgb(193, 208, 222);
                    break;
            }

            pLV.GridLines = true;
            pLV.View = View.Details;
            pLV.FullRowSelect = true;
            pLV.Clear();
            // ListView Headers
            string[] ColHeaderArr = pColHeader.Split(',');
            if (ColHeaderArr.Count() < pColTotal)
            {
                pColTotal = ColHeaderArr.Count();
            }
            // ListView headerWidth 
            if (pColWidth.Length == 0)
            {
                pColWidth = "10";
                for (int i = 0; i < pColTotal; i++)
                {
                    pColWidth += ",10";
                }
            }
            string[] ColWidthArr = pColWidth.Split(',');
            // ListView Format
            if (pColFormat.Length == 0)
            {
                // Add default format to all columns when width string length = 0
                formatChar = "T";
                for (int i = 0; i < pColTotal; i++)
                {
                    pColFormat += ",T";
                }
            }
            string[] ColFormatArr = pColFormat.Split(',');
            //
            for (int i = 0; i < pColTotal; i++)
            {
                ColumnHeader hdr = new ColumnHeader();
                hdr.Text = ColHeaderArr[i];
                hdr.Width = Convert.ToInt16(ColWidthArr[i]) * widM;
                // Text Allignment
                switch (ColFormatArr[i])
                {
                    case "N":
                        {
                            hdr.TextAlign = HorizontalAlignment.Right;
                            break;
                        }
                    case "T":
                        {
                            hdr.TextAlign = HorizontalAlignment.Left;
                            break;
                        }
                    case "C":
                        {
                            hdr.TextAlign = HorizontalAlignment.Center;
                            break;
                        }
                } // end Switch statement
                // Add the headers to the ListView control.
                pLV.Columns.Add(hdr);
                //pLV.Columns.Add(ColHeaderArr[i], Convert.ToInt16(ColWidthArr[i]) * widM, HorizontalAlignment.Left); // This statement is ok
            } // End for loop
            //pLV.Columns.Add("File Name", 200, HorizontalAlignment.Left);
            // List View will show columns according to the columns added
            // If columns is not added and try to add data, the data will not appear, (it will ignore unless a column is added here)
            // OR row.SubItems.Add(f.Length.ToString()); WILL BE IN-EFFECTIVE IF COLUMN IS NOT ADDED.


            // End SetLVHeader
        }
        // 1- ListView Control
        // 2- Total Columns
        // 3- Select Query
        // 4- Field List
        // 5- Column Width
        // 6- bool CheckBox Column
        // 7- connection string

        public static void FillListView(
            ListView pLV,
            int pCol,
            string pSQL,
            string pFL,
            string pFLen,
            bool pChkBox = false,
            string pCon = clsGVar.ConString1)
        {

            // 1- ListView Control
            // 2- Columns
            // 3- Query
            // 4- Field List
            // 5- Del: Title List
            // 6- Field Length
            // 7- Optional: pChkBox bool
            // 8- Optional: Connection string

            // ListView

            //
            // ListView Headers
            string[] cFL = pFL.Split(',');
            if (pFL.Count() < pCol)
            {
                pCol = pFL.Count();
            }
            //
            SqlConnection CurrCon = new SqlConnection(pCon);
            DataTable table = new DataTable();
            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(pSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdaptor.Fill(table);

                //pLV.DataBindings.Add("User a", table, "usr_name");
                //pLV.DataBindings.Add("User b", table, "usr_fullname");
                if (pLV.Items.Count > 0)
                {
                    pLV.Items.Clear();
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow drow = table.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        // Define the list items
                        ListViewItem lvi = new ListViewItem(drow[cFL[0]].ToString());
                        for (int j = 1; j < pCol; j++)
                        {
                            lvi.SubItems.Add(drow[cFL[j]].ToString());
                        }
                        // Add the list items to the ListView
                        pLV.Items.Add(lvi);
                    }
                }





                // pLV.DataBindings = table;
                //
                //if (pReadOnly) { pLV.ReadOnly = true; }
                //else { pLV.ReadOnly = false; }
                //
                commandBuilder.Dispose();
                dataAdaptor.Dispose();
                CurrCon.Close();
            }
            catch (Exception exp)
            {
                if (CurrCon.State != ConnectionState.Closed) { CurrCon.Close(); }
                MessageBox.Show("Exception: " + exp.Message, "Fill List View ");
            }
        }
        // Fill ListView End

        // Grid Header Setting Start
        // 1- Grid View Control
        // 2- Total Number of Col           Total Columns for cross check 
        // 3- Column Headers                Comma Seperated String
        // 4- Column Width                  Comma Seperated String
        // 5- Col Max Input                 Maximum number of Characters 0 = No limit
        // 6- Col Format                    T = Text, H = Hidden, TI = Text Integer, N2 = Numeric 2 digit, MT = Masked Text Box
        //                                  CB = ComboBox Column                                    
        // 7- Col Readonly                  1 = Readonly, 0 = Read/Write (Single 1 = all readonly, Single 0 All Read/Write)
        // 8- Grid Type                     Data = Input, Otherwise Lookup Grid
        // 9- Grid Color Scheme             1 = Default , 0 = Custom
        // 
        public static void SetGridHeader(DataGridView DGV1,
            int pColTotal,
            string pColHeader,
            string pColWidth,
            string pColMaxInputLen,
            string pColFormat,
            string pColReadyOnly,
            string pGridType,
            int pGridColorScheme = 1)
        {
            int widM = 10;     // Multiple for Character width
            string formatChar = string.Empty;

            #region Grid Color Scheme

            // Grid Color Scheme
            switch (pGridColorScheme)
            {
                case 1:
                    // Light Blue/Grey
                    //DGV1.BackgroundColor = Color.FromArgb(193, 208, 222);
                    //DGV1.GridColor = Color.FromArgb(102, 179, 64);
                    //DGV1.DefaultCellStyle.BackColor = Color.FromArgb(193, 208, 222);

                    DGV1.BackgroundColor = Color.FromArgb(193, 208, 222);
                    DGV1.GridColor = Color.FromArgb(75, 94, 129);
                    DGV1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224);
                    DGV1.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);        // black
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(193, 208, 222);
                    break;
                case 2:
                    //
                    DGV1.BackgroundColor = Color.FromArgb(255, 255, 192);
                    DGV1.GridColor = Color.FromArgb(214, 10, 46);
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                    break;
            }

            #endregion

            try
            {
                #region Prepare Column Strings and Arrays

                // Prepare Column Strings and Arrays 
                if (DGV1.RowCount == 0)
                {
                    //DGV1.RowCount = 1;
                }

                // Column Headers
                string[] ColHeaderArr = pColHeader.Split(',');
                //if (ColHeaderArr.Count() < pColTotal)
                //{
                //    pColTotal = ColHeaderArr.Count();
                //}

                // Grid headerWidth 
                if (pColWidth.Trim().Length == 0)
                {
                    pColWidth = StrRepeate("10", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                string[] ColWidthArr = pColWidth.Split(',');
                // Column Max Input Length
                string[] ColMaxInputLenArr;
                if (pColMaxInputLen.Trim().Length == 0)
                {
                    pColMaxInputLen = StrRepeate("0", pColTotal);
                    if (pColMaxInputLen == "Err")
                    {
                        // Reaise Error
                    }
                    ColMaxInputLenArr = pColMaxInputLen.Split(',');
                    //ColMaxInputLenArr = new string[] { "0" };
                    //string[] names = new string[3] { "Matt", "Joanne", "Robert" };
                }
                else
                {
                    ColMaxInputLenArr = pColMaxInputLen.Split(',');
                }
                // Column Format
                if (pColFormat.Trim().Length == 0)
                {
                    pColFormat = StrRepeate("T", pColTotal);
                    if (pColFormat == "Err")
                    {
                        // Reaise Error
                    }

                }
                string[] ColFormatArr = pColFormat.Split(',');
                // Column Width
                if (pColWidth.Trim().Length == 0)
                {
                    pColWidth = StrRepeate("10", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                // Column ReadOnly
                if (pColReadyOnly.Trim().Length == 0)
                {
                    // 1 = ReadOnly, 0 = Read/Write 
                    pColReadyOnly = StrRepeate("1", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                else
                {
                    if (pColReadyOnly.Trim() == "1")
                    {
                        // All Read Only
                        pColReadyOnly = StrRepeate("1", pColTotal);
                        if (pColWidth == "Err")
                        {
                            // Reaise Error
                        }

                    }
                    else if (pColReadyOnly.Trim() == "0")
                    {
                        // All Read/Write
                        pColReadyOnly = StrRepeate("0", pColTotal);
                        if (pColWidth == "Err")
                        {
                            // Reaise Error
                        }
                    }
                }
                string[] ColReadyOnlyArr = pColReadyOnly.Split(',');
                // Check Lengths are same as ColumnTotal
                if (ColHeaderArr.Count() != pColTotal ||
                    ColWidthArr.Count() != pColTotal ||
                    ColMaxInputLenArr.Count() != pColTotal ||
                    ColFormatArr.Count() != pColTotal ||
                    ColReadyOnlyArr.Count() != pColTotal)
                {
                    MessageBox.Show("Array Length Conflict. See Debug Info:>>> " + DGV1.Name.ToString(), "Grid Header");
                    return;
                }

                #endregion Prepare Column Strings and Arrays

                #region Column Create

                if (pGridType == "DATA")
                {
                    #region Data Grid
                    // Create Columns: Assign Column Properties
                    for (int i = 0; i < pColTotal; i++)
                    {
                        switch (ColFormatArr[i].Trim())
                        {
                            case "T":
                            case "H":
                            case "TI":
                                {
                                    // T = Text
                                    // H = Hidden
                                    // TI = Text Box Integer
                                    var col4 = new DataGridViewTextBoxColumn();
                                    col4.Name = "Column4" + i.ToString();
                                    if (Convert.ToInt32(ColMaxInputLenArr[i]) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i]);
                                    }
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                            case "N2":
                                {
                                    // Numeric 2 digit
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 2;
                                    col4.Name = "Column4" + i.ToString();
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }

                            case "N3":
                                {
                                    // Numeric 3 digit
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 3;
                                    col4.Name = "Column4" + i.ToString();
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }

                            case "N4":
                                {
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 4;
                                    col4.Name = "Column4" + i.ToString();
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                        } // End switch statement

                    } // end for create column
                    #endregion
                }
                else
                {
                    #region Lookup Grid

                    // Comented in old version: 2012 05 13 commented to implement TN
                    if (DGV1.ColumnCount < pColTotal)
                    {
                        DGV1.ColumnCount = pColTotal;
                    }

                    #endregion LOOKUP GRID
                }
                #endregion Create Columns

                #region Column Allignment

                // Column Allignment and 
                for (int i = 0; i < pColTotal; i++)
                {

                    DGV1.Columns[i].HeaderText = ColHeaderArr[i];
                    DGV1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (ColFormatArr[i].Trim() != "H")
                    {
                        DGV1.Columns[i].Width = widM * Convert.ToInt32(ColWidthArr[i]);
                    }
                    else
                    {
                        DGV1.Columns[i].Visible = false;
                    }
                    switch (ColFormatArr[i].Trim())
                    {
                        case "N2":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N2";
                                break;
                            }
                        case "N3":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N3";
                                break;
                            }
                        case "N4":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N4";
                                break;
                            }
                        case "TI":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;
                            }

                    }
                    switch (ColFormatArr[i].Trim())
                    {
                        case "C":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            }
                    } // end Switch statement

                } // End for loop

                #endregion Column Allignment
                if (ColHeaderArr.Length != ColWidthArr.Length)
                {
                    MessageBox.Show("Warnning: Number of Header Titles and Header Width paramenters are not equal ...", "Set Grid Header");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception: " + exp.Message, "Grid Header Setting");
            }
        }

        // Grid Setting End



        // Start Grid Setting With ComboBox
        // Grid Header Setting Start
        // 1- Grid View Control               Control
        // 2- Total Number of Col             Total Columns for cross check 
        // 3- Column Headers                  Comma Seperated String
        // 4- Column Width                    Comma Seperated String
        // 5- Column Min Width                Column Minimum Width Comma Seperated String
        // 6- Col Max Input                   Maximum number of Characters 0 = No limit
        // 7- Col Format                      T = Text, H = Hidden, TI = Text Integer, N2 = Numeric 2 digit
        //                                    CB = ComboBox Column , MT Masked Text Box                                   
        // 8- Col Readonly                    1 = Readonly, 0 = Read/Write (Single 1 = all readonly, Single 0 All Read/Write)
        // 9- Grid Type                       Data = Input, Otherwise Lookup Grid
        // 10- MaskedEditBox Mask List         Default = null

        // 11- Grid Combo Fill Type List      Q = QRY, T = Table List DEfault = null
        // 12- Grid Combo TableKeyField List  Table Name, KeyField Name, bool Set Default, Default = null
        // 13- Grid Combo Query List          Default = null
        // 14- Grid Color Scheme              1 = Default , 0 = Custom
        // 
        #region SetGridHeaderCmb

        public static void SetGridHeaderCmb(
            DataGridView DGV1,
            int pColTotal,
            string pColHeader,
            string pColWidth,
            string pColMinWidth,
            string pColMaxInputLen,
            string pColFormat,
            string pColReadyOnly,
            string pGridType,
            List<string> pMtMask = null,
            List<string> pCmbFillType = null,
            List<string> pCmbTableKeyfield = null,
            List<string> pCmbQry = null,
            bool AllowUserToAddRow = false,
            int pGridColorScheme = 1)
        {
            //             DataGridViewComboBoxColumn pCmb,

            int widM = 10;     // Multiple for Character width
            string formatChar = string.Empty;
            //string fColFormat = pColFormat;

            //#region Grid Color Scheme
            // Combo Box
            List<string> fCmbFillType = pCmbFillType;
            List<string> fCmbTableKeyfield = pCmbTableKeyfield;
            List<string> fCmbQry = pCmbQry;
            List<string> fMtMask = pMtMask;
            int fNoCbo = 0;
            int fNoMt = 0;
            //if (pCmbTableKeyfield.Count > 0)
            //{ 

            //}
            // Combo Box
            // Grid Color Scheme
            switch (pGridColorScheme)
            {
                case 1:
                    // Light Blue/Grey
                    DGV1.BackgroundColor = Color.FromArgb(193, 208, 222);
                    DGV1.GridColor = Color.FromArgb(102, 179, 64);
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(193, 208, 222);
                    //DGV1.AutoResizeColumnHeadersHeight(30); //= AutoSizeMode.GrowAndShrink;
                    break;
                case 2:
                    //
                    DGV1.BackgroundColor = Color.FromArgb(255, 255, 192);
                    DGV1.GridColor = Color.FromArgb(214, 10, 46);
                    DGV1.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                    break;
            }

            //#endregion

            try
            {
                //#region Prepare Column Strings and Arrays

                // Prepare Column Strings and Arrays 
                if (DGV1.RowCount == 0)
                {
                    //DGV1.RowCount = 1;
                }

                // Column Headers
                string[] ColHeaderArr = pColHeader.Split(',');

                // Grid headerWidth 
                if (pColWidth.Trim().Length == 0)
                {
                    pColWidth = StrRepeate("10", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                string[] ColWidthArr = pColWidth.Split(',');

                // Column Min Width
                string[] ColMinWidthArr;
                if (pColMinWidth.Trim().Length == 0)
                {
                    pColMinWidth = StrRepeate("0", pColTotal);
                    if (pColMinWidth == "Err")
                    {
                        // Reaise Error
                    }
                    ColMinWidthArr = pColMinWidth.Split(',');
                }
                else
                {
                    ColMinWidthArr = pColMinWidth.Split(',');
                }


                // Column Max Input Length
                string[] ColMaxInputLenArr;
                if (pColMaxInputLen.Trim().Length == 0)
                {
                    pColMaxInputLen = StrRepeate("0", pColTotal);
                    if (pColMaxInputLen == "Err")
                    {
                        // Reaise Error
                    }
                    ColMaxInputLenArr = pColMaxInputLen.Split(',');
                }
                else
                {
                    ColMaxInputLenArr = pColMaxInputLen.Split(',');
                }
                // Column Format
                if (pColFormat.Trim().Length == 0)
                {
                    pColFormat = StrRepeate("T", pColTotal);
                    if (pColFormat == "Err")
                    {
                        // Reaise Error
                    }

                }
                string[] ColFormatArr = pColFormat.Split(',');
                if (ColFormatArr.Length > 0)
                {
                    for (int i = 0; i < ColFormatArr.Length; i++)
                    {
                        if (ColFormatArr[i].Trim() == "CB")
                        {
                            if (fCmbFillType == null || fCmbTableKeyfield == null || fCmbQry == null)
                            {
                                MessageBox.Show("Grid Combo Box, data insufficient, check data behind combo box and try again " + DGV1.Name.ToString(), "CB null: Grid Header");
                                return;
                            }
                            else
                            {
                                if (fCmbTableKeyfield.Count == 0)
                                {
                                    MessageBox.Show("Grid Combo Box, data insufficient, check data behind combo box and try again " + DGV1.Name.ToString(), "CB Empty: Grid Header");
                                    return;
                                }
                            }
                        } // if CB
                    } // for
                } // if
                else
                {
                    MessageBox.Show("Grid Format data insufficient, check format try again " + DGV1.Name.ToString(), "Column Format Empty: Grid Header");
                    return;
                }

                // Column Width
                if (pColWidth.Trim().Length == 0)
                {
                    pColWidth = StrRepeate("10", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                // Column ReadOnly
                if (pColReadyOnly.Trim().Length == 0)
                {
                    // 1 = ReadOnly, 0 = Read/Write 
                    pColReadyOnly = StrRepeate("1", pColTotal);
                    if (pColWidth == "Err")
                    {
                        // Reaise Error
                    }
                }
                else
                {
                    if (pColReadyOnly.Trim() == "1")
                    {
                        // All Read Only
                        pColReadyOnly = StrRepeate("1", pColTotal);
                        if (pColWidth == "Err")
                        {
                            // Reaise Error
                        }

                    }
                    else if (pColReadyOnly.Trim() == "0")
                    {
                        // All Read/Write
                        pColReadyOnly = StrRepeate("0", pColTotal);
                        if (pColWidth == "Err")
                        {
                            // Reaise Error
                        }
                    }
                }


                string[] ColReadyOnlyArr = pColReadyOnly.Split(',');
                // Check Lengths are same as ColumnTotal
                if (
                    ColHeaderArr.Count() != pColTotal ||
                    ColWidthArr.Count() != pColTotal ||
                    ColMaxInputLenArr.Count() != pColTotal ||
                    ColFormatArr.Count() != pColTotal ||
                    ColReadyOnlyArr.Count() != pColTotal ||
                    ColMinWidthArr.Count() != pColTotal
                  )
                {
                    MessageBox.Show("Array Length Conflict. See Debug Info:>>> " + DGV1.Name.ToString(), "Parameters & Column Totals: Grid Header");
                    return;
                }

                //#endregion Prepare Column Strings and Arrays

                //#region Column Create

                if (pGridType == "DATA")
                {
                    //#region Data Grid
                    // Create Columns: Assign Column Properties
                    for (int i = 0; i < pColTotal; i++)
                    {
                        switch (ColFormatArr[i].Trim())
                        {
                            case "T":
                            case "TB":
                            case "H":
                            case "TBH":
                            case "TI":
                                {
                                    // T = Text
                                    // H = Hidden Text
                                    // TI = Text Box Integer
                                    var col4 = new DataGridViewTextBoxColumn();
                                    col4.Name = "Column4" + i.ToString();
                                    if (Convert.ToInt32(ColMaxInputLenArr[i].Trim()) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i].Trim());
                                    }
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                            case "N0":
                                {
                                    // Numeric 0 digit
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 0;
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (Convert.ToInt32(ColMaxInputLenArr[i].Trim()) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i].Trim());
                                    }

                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                            case "N2":
                                {
                                    // Numeric 2 digit
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 2;
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (Convert.ToInt32(ColMaxInputLenArr[i].Trim()) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i].Trim());
                                    }

                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }

                            case "N3":
                                {
                                    // Numeric 3 digit
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 3;
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (Convert.ToInt32(ColMaxInputLenArr[i].Trim()) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i].Trim());
                                    }
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }

                            case "N4":
                                {
                                    var col4 = new TNumEditDataGridViewColumn();
                                    col4.DecimalLength = 4;
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (Convert.ToInt32(ColMaxInputLenArr[i].Trim()) != 0)
                                    {
                                        col4.MaxInputLength = Convert.ToInt32(ColMaxInputLenArr[i].Trim());
                                    }
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                            case "CB":
                                {
                                    var col4 = new DataGridViewComboBoxColumn();
                                    // fNoCbo = Number of ComboBoxes
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (fCmbTableKeyfield[fNoCbo] == "")
                                    {
                                        MessageBox.Show("Combo Field List Empty. Connect and try again " + DGV1.Name.ToString(), "CB: Grid Header");
                                        return;
                                    }
                                    if (pCmbQry[fNoCbo] == "")
                                    {
                                        MessageBox.Show("Combo Qry List Empty. Connect and try again " + DGV1.Name.ToString(), "CB: Grid Header");
                                        return;
                                    }

                                    clsFillCombo.FillComboCol(
                                        col4,
                                        fCmbTableKeyfield[fNoCbo],
                                        pCmbQry[fNoCbo]
                                        );
                                    col4.DropDownWidth = 10;
                                    //col4.DropDownStyle = ComboBoxStyle.DropDownList;
                                    col4.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);
                                    //col4.DefaultCellStyle.ForeColor = Color.BlueViolet;
                                    col4.FlatStyle = FlatStyle.Flat;
                                    //var.Name = "ComboColumnSample";
                                    col4.HeaderText = "ComboColumnSample";
                                    //col4.DisplayMember = "Item";
                                    //col4.ValueMember = "Value";
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);

                                    fNoCbo++;
                                    break;
                                }
                            case "CH":
                                {
                                    var col4 = new DataGridViewCheckBoxColumn();
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    break;
                                }
                            case "MT":
                                {
                                    //mtbc = new MaskedTextBoxColumn();
                                    //mtbc.HeaderText = "Employee ID";
                                    //mtbc.Mask = "L00000";
                                    //mtbc.Width = 75;
                                    //this.employeesDataGridView.Columns.Add(mtbc);
                                    if (pMtMask[fNoMt] == "")
                                    {
                                        MessageBox.Show("MT Mask Empty. Connect and try again " + DGV1.Name.ToString(), "MT: Grid Header");
                                        return;
                                    }
                                    var col4 = new MaskedTextBoxColumn();
                                    col4.Name = "Column4" + i.ToString();
                                    col4.Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                    if (Convert.ToInt32(ColMinWidthArr[i].Trim()) > 0)
                                    {
                                        col4.MinimumWidth = widM * Convert.ToInt32(ColMinWidthArr[i].Trim());
                                    }
                                    col4.Mask = pMtMask[fNoMt];
                                    if (ColReadyOnlyArr[i].Trim() == "1")
                                    {
                                        col4.ReadOnly = true;
                                    }
                                    DGV1.Columns.Add(col4);
                                    fNoMt++;
                                    break;
                                }
                            default:
                                {
                                    MessageBox.Show("Grid Column Format Type unknown, Connect and try again " + DGV1.Name.ToString() + " Column Name :" + ColFormatArr[i].Trim(), "Column Format: Grid Header");
                                    return;
                                    //break;
                                }

                        } // End switch statement

                    } // end for create column
                    //#endregion
                }
                else
                {
                    //#region Lookup Grid

                    // Comented in old version: 2012 05 13 commented to implement TN
                    if (DGV1.ColumnCount < pColTotal)
                    {
                        DGV1.ColumnCount = pColTotal;
                    }

                    //#endregion LOOKUP GRID
                }

                //#endregion Create Columns

                //#region Column Allignment

                // Column Allignment and 
                for (int i = 0; i < pColTotal; i++)
                {

                    DGV1.Columns[i].HeaderText = ColHeaderArr[i].Trim();
                    DGV1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (ColFormatArr[i].Trim() != "H")
                    {
                        DGV1.Columns[i].Width = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                    }
                    else
                    {
                        DGV1.Columns[i].Visible = false;
                    }
                    switch (ColFormatArr[i].Trim())
                    {
                        case "N0":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                //DGV1.Columns[i].ValueType = typeof(decimal);
                                //DGV1.Columns[i].DefaultCellStyle.Format = "N2";
                                break;
                            }

                        case "N2":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N2";
                                break;
                            }
                        case "N3":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N3";
                                break;
                            }
                        case "N4":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                DGV1.Columns[i].ValueType = typeof(decimal);
                                DGV1.Columns[i].DefaultCellStyle.Format = "N4";
                                break;
                            }
                        case "TI":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;
                            }
                        case "CB":
                            {
                                // Minimum Width
                                // DGV1.Columns[i].MinimumWidth = widM * Convert.ToInt32(ColWidthArr[i].Trim());
                                break;
                            }
                    }
                    switch (ColFormatArr[i].Trim())
                    {
                        case "C":
                            {
                                DGV1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                break;
                            }
                    } // end Switch statement

                } // End for loop
                //
                // Grid Level Settings
                //
                // Allow User to Add Row
                if (AllowUserToAddRow == false)
                {
                    DGV1.AllowUserToAddRows = false;
                }
                // Auto Size Last Column
                DGV1.Columns[pColTotal - 1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                DGV1.RowHeadersVisible = false;                            // Headers at left hand side of the Grid
                //DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                // Fix Row Height 
                DGV1.AllowUserToResizeRows = false;
                //

        #endregion Column Allignment
                if (ColHeaderArr.Length != ColWidthArr.Length)
                {
                    MessageBox.Show("Warnning: Number of Header Titles and Header Width paramenters are not equal ...", "Set Grid Header");
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception: " + exp.Message, "Grid Header Setting");
            }
        }
        // End Grid Setting with ComboBox
        //#endregion SetGridHeaderCmb

        public static string StrRepeate(string pChar, int pColTotal)
        {
            string RtnString = string.Empty;
            // Add default format to all columns when width string length = 0
            string lChar = pChar;
            RtnString = pChar;
            try
            {
                for (int i = 0; i < pColTotal - 1; i++)
                {
                    RtnString += "," + lChar;
                }
                return RtnString;
            }
            catch (Exception)
            {
                return "Err";
            }
        }

        // =========================================================
        // Fill Grid Start 
        // 1- Grid Control
        // 2- Query
        // 3- Connection
        // 4- Readonly
        public static void FillGrid(
            DataGridView pDGV1,
            string pSQL,
            string pCon = clsGVar.ConString1,
            bool pReadOnly = true
            )
        {
            SqlConnection CurrCon = new SqlConnection(pCon);
            DataTable table = new DataTable();
            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(pSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdaptor.Fill(table);
                pDGV1.DataSource = table;
                //
                if (pReadOnly) { pDGV1.ReadOnly = true; }
                else { pDGV1.ReadOnly = false; }
                //
                commandBuilder.Dispose();
                dataAdaptor.Dispose();
                CurrCon.Close();
            }
            catch (Exception exp)
            {
                if (CurrCon.State != ConnectionState.Closed) { CurrCon.Close(); }
                MessageBox.Show("Exception: " + exp.Message, "Fill Grid ");
            }
        }
        // Fill Grid End

        public static void FillGridWList(
            DataGridView pDGV1,
            List<string> pList,
            bool pReadOnly = true
            )
        {
            string tobeRemoved = string.Empty;
            try
            {
                tobeRemoved = "abcabcabc";

            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception: " + exp.Message, "Fill Grid ");
            }
        }
        // Fill Grid With List End

        // ================ ExeMany =======================
        public static bool ExeMany(List<string> pManySQL)
        {
            bool ExeSuccess = false;
            string mySQL = string.Empty;
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            if (pManySQL.Capacity == 0 || pManySQL.Count == 0)
            {
                return false;
            }
            int lrowCount = 0;
            int lTotalrowCount = 0;
            SqlTransaction transaction = null;
            SqlCommand command = Con.CreateCommand();
            try
            {
                //cmd.CommandType = System.Data.CommandType.Text;
                // baba cmd.CommandText = pSQL; //"INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthWestern')";
                //cmd.Connection = Con;
                Con.Open();
                //===============================================
                transaction = Con.BeginTransaction();
                // Assign Transaction to Command 
                command.Transaction = transaction;

                for (int i = 0; i < pManySQL.Count; i++)
                {
                    lrowCount = 0;
                    // Execute 1st Command 
                    command.CommandText = pManySQL[i];
                    lrowCount = command.ExecuteNonQuery();
                    lTotalrowCount += lrowCount;
                }
                transaction.Commit();
                ExeSuccess = true;
                //================================================

                //int rowsCount = cmd.ExecuteNonQuery();    // cmd.ExecuteNonQuery();

                Con.Close();
                Con.Dispose();
                cmd.Dispose();
                //if (lrowCount > 0)
                //{
                //    ExeSuccess = true;
                //}
                //
                return ExeSuccess;
            }
            catch (SqlException exp)
            {
                transaction.Rollback();
                MessageBox.Show("Exception: " + exp.Message, "ExeMany:");
            }
            //
            finally
            {
                //Check for close and respond accordingly
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                //Clean up my mess
                Con.Dispose();
                cmd.Dispose();
                //tn.Dispose();

            }
            return ExeSuccess;
        } //---------------End Execute Many  -----------------


        // ================ ExeMany =======================
        //--------------- Execute Command -----------------
        public static bool ExeOne(string pSQL)
        {
            bool ExeSuccess = false;
            string mySQL = string.Empty;
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            if (pSQL.Trim().Length == 0 || pSQL == string.Empty)
            {
                return false;
            }
            try
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = pSQL; //"INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthWestern')";
                cmd.Connection = Con;
                Con.Open();
                int rowsCount = cmd.ExecuteNonQuery();    // cmd.ExecuteNonQuery();
                Con.Close();
                Con.Dispose();
                cmd.Dispose();
                if (rowsCount > 0)
                {
                    ExeSuccess = true;
                }
                //
                return ExeSuccess;
            }
            catch (SqlException exp)
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Con.Dispose();
                cmd.Dispose();
                MessageBox.Show("Exception: " + exp.Message, "ExeOne:");
                return false;
            }
            //
            finally
            {
                //Check for close and respond accordingly
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                //Clean up my mess
                Con.Dispose();
                cmd.Dispose();
                //tn.Dispose();
            }
        } //---------------End Execute One  -----------------

        public static bool IDAlreadyExistWw(
            string pTable,
            string pKeyField,
            string pWhere
            )         // Ww = Without Where
        {

            string mySQL;
            mySQL = "select top 1 " + pKeyField;
            mySQL += " from " + pTable + " Where ";     // what about coData ? it will come in pwhere parameter
            mySQL += pWhere;
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand Com = new SqlCommand(mySQL, Con);
            try
            {
                Con.Open();
                SqlDataReader reader = Com.ExecuteReader();
                //MessageBox.Show("mySQL: " + mySQL);
                //
                if (!reader.HasRows)
                {
                    // To Be Removed
                    //MessageBox.Show ("There is no Record for: " + searchValue.ToString());
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return true;
                }
            } // End try block
            catch
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Com.Dispose();
                // To Be Removed
                //MessageBox.Show("Exception: " + exp.Message, "Already Exists");
                return false;
            }
        } // End Already Exists Ww
        //// ==============================================================

        // ID Already Exists
        // 1- Table Name     
        // 2- Key Field_id          
        // 3- To Be Search Value
        // 4- Co Data    
        public static bool IDAlreadyExist(
            string pTable,
            string pKeyField,
            string pID,
            string pCoData)
        {
            string mySQL;
            mySQL = "select top 1 " + pKeyField;
            mySQL += " from " + pTable + " Where "; // +clsGVar.LGCY;               // create a seperate id for Security 
            mySQL += " " + pKeyField + " = " + pID;
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand Com = new SqlCommand(mySQL, Con);
            try
            {
                Con.Open();
                SqlDataReader reader = Com.ExecuteReader();
                //MessageBox.Show("mySQL: " + mySQL);
                //
                if (!reader.HasRows)
                {
                    // To Be Removed
                    //MessageBox.Show("There is no Record for: " + searchValue.ToString());
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return true;
                }
            } // End try block
            catch (Exception exp)
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Com.Dispose();
                MessageBox.Show("Exception: " + exp.Message, "Already Exists");
                return false;
            }
        }
        // ID Already Exists String Account
        // 1- Table Name     
        // 2- Key Field_id          
        // 3- To Be Search Value
        // 4- Co Data    
        public static bool IDAlreadyExistStrAc(
            string pTable,
            string pKeyField,
            string pID,
            string pCoData)
        {
            string mySQL;
            mySQL = "select top 1 " + pKeyField;
            mySQL += " from " + pTable + " Where " + clsGVar.LGCY;               // create a seperate id for Security 
            mySQL += " and " + pKeyField + " = '" + pID + "'";
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand Com = new SqlCommand(mySQL, Con);
            try
            {
                Con.Open();
                SqlDataReader reader = Com.ExecuteReader();
                //MessageBox.Show("mySQL: " + mySQL);
                //
                if (!reader.HasRows)
                {
                    // To Be Removed
                    //MessageBox.Show("There is no Record for: " + searchValue.ToString());
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return true;
                }
            } // End try block
            catch (Exception exp)
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Com.Dispose();
                MessageBox.Show("Exception: " + exp.Message, "Already Exists Str Ac");
                return false;
            }
        }

        // End Already Exists Custom Query
        // 1- Table Name     
        // 2- Key Field_id          
        // 3- To Be Search Value
        // 4- Custom Query    
        //
        public static bool IDAlreadyExistCQ(
            string pTable,
            string pKeyField,
            string pID,
            string pQry)
        {
            string mySQL = string.Empty;
            if (pQry == "")
            {
                mySQL = "select top 1 " + pKeyField;
                mySQL += " from " + pTable + " Where "; // +clsGVar.LGCY;               // create a seperate id for Security 
                mySQL += " " + pKeyField + " = " + pID;
            }
            else
            {
                mySQL = pQry;
            }
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand Com = new SqlCommand(mySQL, Con);
            try
            {
                Con.Open();
                SqlDataReader reader = Com.ExecuteReader();
                //MessageBox.Show("mySQL: " + mySQL);
                //
                if (!reader.HasRows)
                {
                    // To Be Removed
                    //MessageBox.Show("There is no Record for: " + searchValue.ToString());
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return true;
                }
            } // End try block
            catch (Exception exp)
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Com.Dispose();
                MessageBox.Show("Exception CQ: " + exp.Message, "Already Exists");
                return false;
            }
        } // End Already Exists

        //  Already Exists Query
        //
        public static bool IDAlreadyExistQry(string pQry)
        {
            string mySQL = string.Empty;
            mySQL = pQry;
            SqlConnection Con = new SqlConnection(clsGVar.ConString1);
            SqlCommand Com = new SqlCommand(mySQL, Con);
            try
            {
                Con.Open();
                SqlDataReader reader = Com.ExecuteReader();
                if (!reader.HasRows)
                {
                    // To Be Removed
                    //MessageBox.Show("There is no Record for: " + searchValue.ToString());
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return false;
                }
                else
                {
                    reader.Close();
                    Com.Dispose();
                    Con.Close();
                    return true;
                }
            } // End try block
            catch (Exception exp)
            {
                if (Con.State != ConnectionState.Closed) { Con.Close(); }
                Com.Dispose();
                MessageBox.Show("Exception Query: " + exp.Message, "Already Exists");
                return false;
            }
        } // End Already Exists

        //// ==============================================================
        //public static void AddPhoto(int albumId, Photo photo)
        //{
        //    using (SqlConnection conn = new SqlConnection(clsGVar.gConString1))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("InsertPhoto", conn))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredpColReadyOnlycedure;
        //            conn.Open();

        //            // Add the Title parameter and set the value
        //            cmd.Parameters.AddWithValue("@attach_title", photo.Title);
        //            // Add the short title parameter and set the value
        //            cmd.Parameters.AddWithValue("@attach_st", photo.St);
        //            // Add the Name parameter and set the value
        //            cmd.Parameters.AddWithValue("@attach_name", photo.Name);
        //            // Add the image Thumbnail parameter and set the value
        //            cmd.Parameters.AddWithValue("@photo", photo.Thumbnail);
        //            // Add the image parameter and set the value
        //            cmd.Parameters.AddWithValue("@photo", photo.Img);

        //            // Add the return value parameter
        //            //SqlParameter param = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
        //            //param.Direction = ParameterDirection.ReturnValue;

        //            // Execute the insert
        //            cmd.ExecuteNonQuery();

        //            // Return value will be the index of the newly added photo
        //            //photo.Id = (int)cmd.Parameters["RETURN_VALUE"].Value;
        //        }
        //    }
        //}

        // ===============================================================

        // -------------------------------- class start
        // to be checked and tested
        public static bool IsNumeric(ref object val)
        {
            if (val == null)
                return false;

            // Test for numeric type, returning true if match 
            if
                (
                val is double || val is float || val is int || val is long || val is decimal ||
                val is short || val is uint || val is ushort || val is ulong || val is byte ||
                val is sbyte
                )
                return true;
            // Not numeric 
            return false;
        }
        // -------------------------------- class end

        // Convert Decimal MaskedTextBox
        public static decimal ConvDecimal(MaskedTextBox pmtext)
        {
            decimal rtnVal = 0;
            decimal outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = decimal.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Convert Decimal Label
        public static decimal ConvDecimal(Label pmtext)
        {
            decimal rtnVal = 0;
            decimal outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = decimal.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Convert Decimal TextBox
        public static decimal ConvDecimal(TextBox pmtext)
        {
            decimal rtnVal = 0;
            decimal outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = decimal.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Convert Decimal TNumEditBox
        public static decimal ConvDecimal(TNumEditBox pmtext)
        {
            decimal rtnVal = 0;
            decimal outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = decimal.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Convert Decimal String Grid Cell
        public static decimal ConvDecimal(string pmtext)
        {
            decimal rtnVal = 0;
            decimal outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = decimal.TryParse(pmtext, out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Convert Int64
        public static Int64 ConvInt64(CSUST.Data.TNumEditBox pmtext)
        {
            Int64 rtnVal = 0;
            Int64 outValue = 0;
            bool lCheckValue = false;
            try
            {
                if (pmtext.Text == null)
                    return rtnVal;

                lCheckValue = Int64.TryParse(pmtext.Text, out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        // Convert Int32
        public static Int32 ConvInt32(string pmtext)
        {
            Int32 rtnVal = 0;
            Int32 outValue = 0;
            bool lCheckValue = false;
            try
            {
                if (pmtext.Length == 0)
                    return rtnVal;

                lCheckValue = Int32.TryParse(pmtext, out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Convert Int
        public static int ConvInt(MaskedTextBox pmtext)
        {
            int rtnVal = 0;
            int outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = int.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        // Convert Int64
        public static Int64 ConvInt64(MaskedTextBox pmtext)
        {
            Int64 rtnVal = 0;
            Int64 outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = Int64.TryParse(pmtext.Text.ToString(), out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Convert Int64
        public static Int64 ConvInt64(string pmtext)
        {
            Int64 rtnVal = 0;
            Int64 outValue = 0;
            bool lCheckValue = false;
            try
            {
                if (pmtext.Length == 0)
                    return rtnVal;

                lCheckValue = Int64.TryParse(pmtext, out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        // Convert Int from Grid Cell 
        public static int ConvInt(string pmtext)
        {
            int rtnVal = 0;
            int outValue = 0;
            bool lCheckValue = false;
            try
            {
                lCheckValue = int.TryParse(pmtext, out outValue);
                if (lCheckValue)
                {
                    rtnVal = outValue;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //

        // Convert Bit CheckBox Control
        public static string ConvBit(CheckBox pmChk)
        {
            string rtnVal = "0";
            try
            {
                if (pmChk.Checked)
                {
                    rtnVal = "1";
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        // Convert Bit string for Grid Cell
        public static string ConvBit(string pmChk)
        {
            string rtnVal = "0";
            try
            {
                if (pmChk == "True" || pmChk == "1")
                {
                    rtnVal = "1";
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //

        // Convert CheckBox bool with Object
        public static bool ConvCheckBox(object pcol)
        {
            bool rtnVal = false;
            try
            {
                if (pcol.ToString() == "True")
                {
                    rtnVal = true;
                }
                else
                {
                    rtnVal = false;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //
        // Convert CheckBox bool with string
        public static bool ConvCheckBox(string pcol)
        {
            bool rtnVal = false;
            try
            {
                if (pcol.ToString() == "True")
                {
                    rtnVal = true;
                }
                else
                {
                    rtnVal = false;
                }
                return rtnVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region FillDataGrid
        // =========================================================
        // Grid with Field List
        // 1- Grid Control
        // 2- Query
        // 3- Field List
        // 4- Field Format
        // 5- Data Set Default = null optional 
        // 3- Readonly optional
        // 4- Connection optional
        public static void FillDataGrid(
            DataGridView pDGV,
            string pSQL,
            string pFieldList,
            string pFieldFormat,
            DataSet pDS = null,
            int pTableId = 0,
            bool pReadOnly = false,
            string pCon = clsGVar.ConString1
            )
        {

            SqlConnection CurrCon = new SqlConnection(pCon);
            DataRow dRow;
            DataSet lDS;

            try
            {
                // 2012 09 18
                //string[] fFieldList = pFieldList.Replace(" ","").Split(',');
                //string[] fFieldFormat = pFieldFormat.Replace(" ", "").Split(',');
                if (pDS == null)
                {
                    lDS = clsDbManager.GetData_Set(pSQL, "table0");
                }
                else
                {
                    lDS = pDS;
                }
                int lRecCount = lDS.Tables[pTableId].Rows.Count;
                //
                string[] fFieldList = pFieldList.Split(',');
                string[] fFieldFormat = pFieldFormat.Split(',');

                if (pDGV.Rows.Count > 0)
                {
                    pDGV.Rows.Clear();
                }

                //
                for (int lRow = 0; lRow < lRecCount; lRow++)
                {
                    dRow = lDS.Tables[pTableId].Rows[lRow];
                    pDGV.Rows.Add();
                    int RowIndex = pDGV.RowCount - 1;
                    DataGridViewRow R = pDGV.Rows[RowIndex];
                    int abc = pFieldList.Length;
                    int xyz = pFieldList.Count();
                    for (int lCol = 0; lCol < fFieldList.Length; lCol++)
                    {
                        switch (fFieldFormat[lCol].Trim())
                        {
                            case "SKP":
                            case "H":
                            case "T":
                            case "TB":
                                {
                                    string test = lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString();

                                    if (lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()] == DBNull.Value)
                                    {
                                        R.Cells[lCol].Value = string.Empty;
                                    }
                                    else
                                    {
                                        R.Cells[lCol].Value = lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString();
                                    }
                                    break;
                                }
                            //case "DT":
                            //    {

                            //        string test = lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString();

                            //        if (lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()] == DBNull.Value)
                            //        {
                            //            R.Cells[lCol].Value = string.Empty;
                            //        }
                            //        else
                            //        {
                            //            //R.Cells[lCol].Value = lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString();
                            //            R.Cells[lCol].Value =  StrF01.Left(lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString(),10);
                            //        }
                            //        break;
                            //    }
                            case "N0":
                            case "N2":
                            case "N3":
                                {
                                    if (lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()] == DBNull.Value)
                                    {
                                        R.Cells[lCol].Value = string.Empty;
                                    }
                                    else
                                    {
                                        R.Cells[lCol].Value = lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString();
                                    }
                                    break;
                                }

                            case "CB":
                                // Combo Box
                                {
                                    if (lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()] == DBNull.Value)
                                    {
                                        R.Cells[lCol].Value = string.Empty;
                                    }
                                    else
                                    {
                                        R.Cells[lCol].Value = Convert.ToInt32(lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString());
                                    }
                                    break;
                                }
                            case "CH":
                                // Check Box
                                {
                                    if (lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()] == DBNull.Value)
                                    {
                                        R.Cells[lCol].Value = "False";
                                    }
                                    else
                                    {
                                        R.Cells[lCol].Value = Convert.ToBoolean(lDS.Tables[pTableId].Rows[lRow][fFieldList[lCol].Trim()].ToString());
                                    }
                                    break;
                                }

                            case "SN":
                                // Serial Number
                                {
                                    R.Cells[lCol].Value = (lRow + 1).ToString();
                                    break;
                                }

                            default:
                                break;
                        } // End Switch
                    } // End for lCol
                }  // End for lRow

            } // End Try
            catch (Exception exp)
            {
                if (CurrCon.State != ConnectionState.Closed) { CurrCon.Close(); }
                MessageBox.Show("Exception: " + exp.Message + " Grid: " + pDGV.Name, "Fill Data Grid ");
            } // End Try
        } // End FillDataGrid Method
        // Fill Data Grid End

        #endregion FillDataGrid
        #region PrepareGridSQL
        // 1- Data Grid View Control
        // 2- Table Name
        // 3- List Field Names
        // 4- List Grid Column Types
        // 5- Query List
        // 6- Optional: Additional Field Name lik LGCY etc
        // 7- Optional: Additional Values corrosponding to field names.
        //
        public static string PrepareGridSQL(
          DataGridView pdGv,
          string pTableName,
          string pGridFieldName,
          string pGridColType,
          List<string> pList,
          string pAddFieldName = "",
          string pAddValue = ""
          )
        {
            string rtnValue = string.Empty;
            int lLastRow = 0;
            int lCols = 0;
            int lRows = 0;
            string lSQLValues = string.Empty;
            string lSQLFields = string.Empty;
            bool lIsCommaDue = false;
            lLastRow = pdGv.Rows.Count - 1;
            lRows = pdGv.Rows.Count;
            //
            string[] lColType = pGridColType.Split(',');
            string[] lFieldName = pGridFieldName.Split(',');
            lCols = lColType.Length;
            if (lColType.Length != lFieldName.Length)
            {
                rtnValue = "Err";
            }
            try
            {
                //
                for (int i = 0; i < lRows; i++)
                {
                    lSQLFields = "insert into " + pTableName + " ( ";
                    lSQLValues = " Values (";
                    if (pAddFieldName != "")
                    {
                        lSQLFields += pAddFieldName + ", ";
                    }
                    if (pAddValue != "")
                    {
                        lSQLValues += pAddValue + ", ";
                    }
                    lIsCommaDue = false;
                    //
                    for (int j = 0; j < lCols; j++)
                    {
                        if (lColType[j].Trim() == "SKP")
                        {
                            continue;
                        }
                        //
                        if (lIsCommaDue)
                        {
                            lSQLFields += ", ";
                            lSQLValues += ", ";
                        }
                        //
                        lSQLFields += lFieldName[j];
                        //
                        lIsCommaDue = true;
                        switch (lColType[j].Trim())
                        {
                            case "T":
                            case "TB":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += "''";
                                }
                                else
                                {
                                    lSQLValues += "'" + StrF01.EnEpos(pdGv.Rows[i].Cells[j].Value.ToString()) + "'";
                                }
                                break;
                            case "CH":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += ConvBit("False");
                                }
                                else
                                {
                                    lSQLValues += ConvBit(pdGv.Rows[i].Cells[j].Value.ToString());
                                }
                                break;
                            case "CB":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += 1;                    // to be corrected latter
                                }
                                else
                                {
                                    lSQLValues += ConvInt(pdGv.Rows[i].Cells[j].Value.ToString());
                                }
                                break;
                            case "NI":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += "0";
                                }
                                else
                                {
                                    lSQLValues += ConvInt(pdGv.Rows[i].Cells[j].Value.ToString());
                                }
                                break;
                            case "N0":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += "0";
                                }
                                else
                                {
                                    lSQLValues += ConvInt(pdGv.Rows[i].Cells[j].Value.ToString());
                                }
                                break;
                            case "N2":
                            case "N3":
                            case "N4":
                                if (pdGv.Rows[i].Cells[j].Value == null)
                                {
                                    lSQLValues += "0";
                                }
                                else
                                {
                                    lSQLValues += ConvDecimal(pdGv.Rows[i].Cells[j].Value.ToString());
                                }
                                break;
                            default:
                                MessageBox.Show("Unknown Value: i = " + i.ToString() + " j = " + j.ToString(), "");
                                break;
                        } // End Switch

                    } // End j for loop
                    //
                    lSQLFields += ")";
                    lSQLValues += ")";
                    //fManySQL.Add(lSQL);
                    pList.Add(lSQLFields + lSQLValues);
                } // End i for loop
                return "OK";

            } // End try
            catch (Exception ex)
            {
                return "Exp";
            } // End Catch

        } // End Method
        //=================================================================================================================
        #endregion

        public static bool checkStringWithInRange(string pStartString, string pEndString, string pFindString)
        {
            try
            {
                if ((pFindString.CompareTo(pStartString) == 1 || pFindString.CompareTo(pStartString) == 0)
                    && (pFindString.CompareTo(pEndString) == -1 || pFindString.CompareTo(pEndString) == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //
        public static List<Tuple<string, string, string>> PrepareControlAcList(string pInitialControlID)
        {
            string lFromID = string.Empty;
            string lToID = string.Empty;
            string lTitle = string.Empty;
            //
            string lStartControlID = string.Empty;
            string lEndControlID = string.Empty;
            string lSQL = string.Empty;
            pInitialControlID = pInitialControlID.Trim();
            List<Tuple<string, string, string>> rtnValue = new List<Tuple<string, string, string>>();
            if (pInitialControlID.Length == 0)
            {
                return rtnValue;
            }
            else
            {
                if (pInitialControlID.Length > 3 || pInitialControlID.Length < 3)
                    return rtnValue;
            }
            lStartControlID = pInitialControlID + "01";
            lEndControlID = pInitialControlID + "99";
            lSQL = "select control_ac_fromid, control_ac_toid, control_ac_title ";
            lSQL += " from gl_control_ac";
            lSQL += " where control_ac_id between ";

            lSQL += lStartControlID;
            lSQL += " and ";
            lSQL += lEndControlID;
            lSQL += " and ";
            lSQL += clsGVar.LGCY;
            lSQL += " order by control_ac_id, control_ac_fromid";

            DataRow ldataRow;
            DataSet ldataSet = clsDbManager.GetData_Set(lSQL, "gl_control_ac");
            int lRecCount = ldataSet.Tables[0].Rows.Count;
            if (lRecCount == 0)
            {
                return rtnValue;
            }
            for (int lRow = 0; lRow < lRecCount; lRow++)
            {
                ldataRow = ldataSet.Tables[0].Rows[lRow];
                //
                if (ldataSet.Tables[0].Rows[lRow]["control_ac_fromid"] == DBNull.Value)
                {
                    lFromID = string.Empty;
                }
                else
                {
                    lFromID = ldataSet.Tables[0].Rows[lRow]["control_ac_fromid"].ToString();
                }
                //
                if (ldataSet.Tables[0].Rows[lRow]["control_ac_toid"] == DBNull.Value)
                {
                    lToID = string.Empty;
                }
                else
                {
                    lToID = ldataSet.Tables[0].Rows[lRow]["control_ac_toid"].ToString();
                }
                //
                if (ldataSet.Tables[0].Rows[lRow]["control_ac_title"] == DBNull.Value)
                {
                    lTitle = string.Empty;
                }
                else
                {
                    lTitle = ldataSet.Tables[0].Rows[lRow]["control_ac_title"].ToString();
                }
                //
                rtnValue.Add(new Tuple<string, string, string>(lFromID, lToID, lTitle));
            }
            return rtnValue;
        }
        //
        public static bool ExistInControlAcList(List<Tuple<string, string, string>> pAcList, string pAcID)
        {
            bool rtnValue = false;
            string lStartID = string.Empty;
            string lEndID = string.Empty;

            try
            {
                for (int i = 0; i < pAcList.Count(); i++)
                {
                    lStartID = pAcList[i].Item1.ToString();
                    lEndID = pAcList[i].Item2.ToString();
                    if (clsDbManager.checkStringWithInRange(lStartID, lEndID, pAcID))
                    {
                        rtnValue = true;
                    }
                }
                //
                return rtnValue;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Over Loaded: Get Title Account With Numeric ID              
        // 1- Table Name            
        // 2- Key Field_ID     
        // 3- Key Field_Title / Return Field            
        // 4- Code to be searched or Located (Value)
        // 5- Custom Qry    (Default = "" )                  
        public static string GetTitleAc(
            string pTable,
            string pKeyFieldID,
            string pKeyFieldTitle,
            string pSearchValue,
            string pNumIDField,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pKeyFieldID + ", " + pNumIDField + ", " + pKeyFieldTitle;
                mySQL += " from " + pTable + " Where " + pKeyFieldID + " = '" + pSearchValue + "'";
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "ID not Found...";
                }
                else
                {
                    reader.Read();
                    string lTitle = string.Empty;
                    string lID = string.Empty;

                    if (reader[pKeyFieldTitle] != DBNull.Value)
                    {
                        lTitle = reader[pKeyFieldTitle].ToString(); // working ok
                    }
                    else
                    {
                        lTitle = "ID not Found...";
                    }
                    if (reader[pNumIDField] != DBNull.Value)
                    {
                        lID = reader[pNumIDField].ToString();
                    }
                    else
                    {
                        lID = "0";
                    }

                    strRtnTitle = lTitle + "<<SPLITER>>" + lID;

                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                strRtnTitle = "GetTitleAc: ID not Found..." + " Exception: " + ex.Message;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Title ID

        //----------------------------------------------------
        // Over Loaded: Get Title Account With GL String ID              
        // 1- Table Name            
        // 2- Key GL strid     
        // 3- Key Field_Title / Return Field
        // 4- Key Numeric Field Name (ac_id bigint = Int64)      
        // 5- Code to be searched or Located (Value)
        // 6- Custom Qry    (Default = "" )                  
        public static string GetTitlnStrAcID(
            string pTable,
            string pStrIDFieldName,
            string pTitleFieldName,
            string pNumFieldName,
            Int64 pSearchValue,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pNumFieldName + ", " + pStrIDFieldName + ", " + pTitleFieldName;
                mySQL += " from " + pTable + " Where " + pNumFieldName + " = " + pSearchValue.ToString();
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "ID not Found...";
                }
                else
                {
                    reader.Read();
                    string lTitle = string.Empty;
                    string lID = string.Empty;

                    if (reader[pTitleFieldName] != DBNull.Value)
                    {
                        lTitle = reader[pTitleFieldName].ToString(); // working ok
                    }
                    else
                    {
                        lTitle = "ID not Found...";
                    }
                    if (reader[pStrIDFieldName] != DBNull.Value)
                    {
                        lID = reader[pStrIDFieldName].ToString();
                    }
                    else
                    {
                        lID = "0";
                    }

                    strRtnTitle = lTitle + "<<SPLITER>>" + lID;

                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                strRtnTitle = "GetTitleAc: ID not Found..." + " Exception: " + ex.Message;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Title, ac_str ID
        //========================================
        //----------------------------------------
        // Over Loaded: Get Title Account With Numeric ID              
        // 1- Table Name            
        // 2- Key Field_ID     
        // 3- Key Field_Title / Return Field            
        // 4- Code to be searched or Located (Value)
        // 5- Custom Qry    (Default = "" )                  
        public static string GetTitlenNumAcID(
            string pTable,
            string pKeyFieldID,
            string pKeyFieldTitle,
            string pSearchValue,
            string pNumIDField,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pKeyFieldID + ", " + pNumIDField + ", " + pKeyFieldTitle;
                mySQL += " from " + pTable + " Where " + pKeyFieldID + " = '" + pSearchValue + "'";
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "ID not Found...";
                }
                else
                {
                    reader.Read();
                    string lTitle = string.Empty;
                    string lID = string.Empty;

                    if (reader[pKeyFieldTitle] != DBNull.Value)
                    {
                        lTitle = reader[pKeyFieldTitle].ToString(); // working ok
                    }
                    else
                    {
                        lTitle = "ID not Found...";
                    }
                    if (reader[pNumIDField] != DBNull.Value)
                    {
                        lID = reader[pNumIDField].ToString();
                    }
                    else
                    {
                        lID = "0";
                    }

                    strRtnTitle = lTitle + "<<SPLITER>>" + lID;

                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                strRtnTitle = "GetTitleAc: ID not Found..." + " Exception: " + ex.Message;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Title ID

        public static string VocCheckAndDisplayList(
                string pTableName,
                string pFieldName,
                int pDocTypeID,
                string pDate,
                string pManualDocID)
        {
            string rtnValue = string.Empty;
            DataSet ds = new DataSet();
            //DataRow dRow;
            string tSQL = string.Empty;
            string strDocStrID = string.Empty;

            // Fields 0,1,2,3 are Begin  
            tSQL = "SELECT " + pFieldName + " FROM " + pTableName + " Where ";
            tSQL += " doc_vt_id=" + pDocTypeID;
            tSQL += " AND doc_fiscal_id=1 AND doc_date='" + pDate + "'";
            tSQL += " AND doc_strid='" + pManualDocID + "';";
            //Second Query
            tSQL += " SELECT " + pFieldName + " FROM " + pTableName + " Where ";
            tSQL += " doc_vt_id=" + pDocTypeID;
            tSQL += " AND doc_fiscal_id=1 AND doc_date='" + pDate + "'";
            tSQL += " Order by Doc_StrID";

            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "gl_Tran");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int dGVRow = 0; dGVRow < ds.Tables[1].Rows.Count; dGVRow++)
                    {
                        rtnValue += ds.Tables[1].Rows[dGVRow]["doc_strid"].ToString() + " \n";
                        //lSQL += ", " + grdVoucher.Rows[dGVRow].Cells[(int)GColD.snum].Value.ToString();          // 11- Combo 1 
                    }
                    //MessageBox.Show(strDocStrID,this.Text);
                    return rtnValue;
                }
                else
                {
                    rtnValue = "No Found!";
                    return rtnValue;
                }
            }
            catch
            {
                return "No Found!";
                //MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
            }
        }

    //    public static Int64 GetIn64Value(
    //        string pTable,
    //        string pKeyFieldID,
    //        string pFieldToSearch,
    //        Int64 pValueToSearch,
    //        string pCustomQry = ""
    //)
    //    {
    //        string mySQL = string.Empty;
    //        Int64 rtnValue = 0;

    //        if (pCustomQry.Length == 0)
    //        {
    //            mySQL = "select top 1 " + pFieldToSearch;
    //            mySQL += " from " + pTable + " Where " + pKeyFieldID + " = " + pValueToSearch.ToString();
    //            //mySQL += " from " + pTable + " Where " + clsGVar.LGCY;
    //            //mySQL += " and " + pKeyFieldID + " = " + pValueToSearch.ToString();
    //        }
    //        else
    //        {
    //            mySQL = pCustomQry;
    //        }
    //        SqlConnection con = new SqlConnection(clsGVar.ConString1);
    //        SqlCommand com = new SqlCommand(mySQL, con);
    //        SqlDataReader reader;
    //        try
    //        {
    //            con.Open();
    //            reader = com.ExecuteReader();

    //            // As we need only 1 record therefore ExecuteScaller is suitable
    //            //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
    //            if (!reader.HasRows)
    //            {
    //                rtnValue = 0;
    //            }
    //            else
    //            {
    //                reader.Read();
    //                if (reader[pFieldToSearch] != DBNull.Value)
    //                {
    //                    rtnValue = Convert.ToInt64(reader[pFieldToSearch].ToString()); // working ok
    //                }
    //                else
    //                {
    //                    rtnValue = 0;
    //                }
    //            }
    //            // --------------------------------------------------------------
    //            reader.Close();
    //            com.Dispose();
    //            con.Close();
    //        }
    //        catch
    //        {
    //            rtnValue = 0;
    //            com.Dispose();
    //            if (con.State == ConnectionState.Open) { con.Close(); }
    //        }
    //        return rtnValue;
    //    } // Get Title ID


        //internal static string ConvInt32(string p)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static string PrePareAdditionaWhere(List<Tuple<string, string, string>> fGenGLAcList, string p)
        //{
        //    throw new NotImplementedException();
        //}


        //public static string GetStrValue(
        //string pTable,
        //string pSelectFieldName,
        //string pConditionFieldName,
        //string pConditionFieldValue,
        //string pCustomQry = ""
        //)
        //{
        //    string strRtnTitle = string.Empty;
        //    string mySQL = string.Empty;
        //    if (pCustomQry.Length == 0)
        //    {
        //        mySQL = "select top 1 " + pSelectFieldName;
        //        mySQL += " from " + pTable + " Where " + pConditionFieldName + " = " + pConditionFieldValue;
        //        mySQL += " and " + clsGVar.LGCY;
        //    }
        //    else
        //    {
        //        mySQL = pCustomQry;
        //    }
        //    SqlConnection con = new SqlConnection(clsGVar.ConString1);
        //    SqlCommand com = new SqlCommand(mySQL, con);
        //    SqlDataReader reader;
        //    try
        //    {
        //        con.Open();
        //        reader = com.ExecuteReader();

        //        // As we need only 1 record therefore ExecuteScaller is suitable
        //        //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
        //        if (!reader.HasRows)
        //        {
        //            strRtnTitle = "";
        //        }
        //        else
        //        {
        //            reader.Read();
        //            strRtnTitle = reader[pSelectFieldName].ToString(); // working ok
        //            //strRtnTitle = reader["Description"].ToString(); // working ok
        //            // reader[1].ToString() // is also ok
        //        }
        //        // --------------------------------------------------------------
        //        reader.Close();
        //        com.Dispose();
        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        //strRtnTitle = "ID not Found...";
        //        strRtnTitle = "";

        //        com.Dispose();
        //        if (con.State == ConnectionState.Open) { con.Close(); }
        //    }
        //    return strRtnTitle;
        //} // Get String Value
        //================================
        // Get Bool Value                  
        // 1- Table Name            
        // 2- Key Select Field Name  
        // 3- Conditional Field Name            
        // 4- Conditional Field Value
        // 5- Custom Qry    (Default = "" )     
        // see ConvCheckBox, ConvBit etc       
        public static bool GetBoolValue(
            string pTable,
            string pSelectFieldName,
            string pConditionFieldName,
            string pConditionFieldValue,
            string pCustomQry = ""
            )
        {
            bool strRtnTitle = false;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pSelectFieldName;
                mySQL += " from " + pTable + " Where " + pConditionFieldName + " = " + pConditionFieldValue;
                mySQL += " and " + clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = false;
                }
                else
                {
                    reader.Read();
                    strRtnTitle = Convert.ToBoolean(reader[pSelectFieldName].ToString()); // working ok
                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                //strRtnTitle = "ID not Found...";
                strRtnTitle = false;

                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get String Value

        // Called from: ExistInControlAcList method
        // 1- String Starting ID within Control Account
        // 2- String Ending ID within Control Account
        // 3- Account ID to be Searched (StrAcId)
        //
        public static bool ExistStringWithInRange(string pStartString, string pEndString, string pAcID)
        {
            try
            {
                // Greater or  Equal to Starting id
                // && Less then or Equal to Ending id
                if ((pAcID.CompareTo(pStartString) == 1 || pAcID.CompareTo(pStartString) == 0)
              && (pAcID.CompareTo(pEndString) == -1 || pAcID.CompareTo(pEndString) == 0))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //
        // Tuple: Sring-1     From Account ID
        // Tuple: Sring-2     To Account ID
        // Tuple: Sring-3     Control Account Title
        // pParentID          Control Account's Controling ID
        //
        public static List<Tuple<string, string, string>> PrepareControlAcList(Int32 pParentID)
        {
            string lFromID = string.Empty;
            string lToID = string.Empty;
            string lTitle = string.Empty;
            //
            string lStartControlID = string.Empty;
            string lEndControlID = string.Empty;
            string lSQL = string.Empty;
            //pParentID = pParentID.Trim();
            List<Tuple<string, string, string>> rtnValue = new List<Tuple<string, string, string>>();

            //if (pParentID.Length == 0)
            //{
            //  return rtnValue;
            //}
            //else
            //{
            //  if (pParentID.Length > 3 || pParentID.Length < 3)
            //    return rtnValue;
            //}
            //lStartControlID = pParentID + "01";
            //lEndControlID = pParentID + "99";

            try
            {
                lSQL = "select control_ac_fromid, control_ac_toid, control_ac_title ";
                lSQL += " from gl_control_ac";
                lSQL += " where control_ac_pid = " + pParentID.ToString();
                lSQL += " and ";
                lSQL += clsGVar.LGCY;
                lSQL += " order by control_ac_id, control_ac_fromid";

                DataRow ldataRow;
                DataSet ldataSet = clsDbManager.GetData_Set(lSQL, "gl_control_ac");
                int lRecCount = ldataSet.Tables[0].Rows.Count;
                if (lRecCount == 0)
                {
                    return rtnValue;
                }
                for (int lRow = 0; lRow < lRecCount; lRow++)
                {
                    ldataRow = ldataSet.Tables[0].Rows[lRow];
                    //
                    if (ldataSet.Tables[0].Rows[lRow]["control_ac_fromid"] == DBNull.Value)
                    {
                        lFromID = string.Empty;
                    }
                    else
                    {
                        lFromID = ldataSet.Tables[0].Rows[lRow]["control_ac_fromid"].ToString();
                    }
                    //
                    if (ldataSet.Tables[0].Rows[lRow]["control_ac_toid"] == DBNull.Value)
                    {
                        lToID = string.Empty;
                    }
                    else
                    {
                        lToID = ldataSet.Tables[0].Rows[lRow]["control_ac_toid"].ToString();
                    }
                    //
                    if (ldataSet.Tables[0].Rows[lRow]["control_ac_title"] == DBNull.Value)
                    {
                        lTitle = string.Empty;
                    }
                    else
                    {
                        lTitle = ldataSet.Tables[0].Rows[lRow]["control_ac_title"].ToString();
                    }
                    //
                    rtnValue.Add(new Tuple<string, string, string>(lFromID, lToID, lTitle));
                }
                return rtnValue;

            }
            catch (Exception ex)
            {
                return rtnValue;
            }
        }


        //public static bool ExistInControlAcList(List<Tuple<string, string, string>> pAcList, string pAcIDToSearch)
        //{
        //    bool rtnValue = false;
        //    string lStartID = string.Empty;
        //    string lEndID = string.Empty;

        //    try
        //    {
        //        for (int i = 0; i < pAcList.Count(); i++)
        //        {
        //            lStartID = pAcList[i].Item1.ToString();
        //            lEndID = pAcList[i].Item2.ToString();
        //            if (clsDbManager.ExistStringWithInRange(lStartID, lEndID, pAcIDToSearch))
        //            {
        //                rtnValue = true;
        //            }
        //        }
        //        //
        //        return rtnValue;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        //
        //

        public static string PrePareAdditionaWhere(List<Tuple<string, string, string>> pAcList, string pFieldName)
        {
            string rtnValue = string.Empty;
            //
            string lStartID = string.Empty;
            string lEndID = string.Empty;

            try
            {
                for (int i = 0; i < pAcList.Count(); i++)
                {

                    lStartID = pAcList[i].Item1.ToString();
                    lEndID = pAcList[i].Item2.ToString();
                    //
                    if (i > 0)
                    {
                        rtnValue += " OR ";
                    }
                    rtnValue += "( " + pFieldName + " BETWEEN '" + lStartID + "' and '" + lEndID + "' )";

                }
                //
                return rtnValue;
            }
            catch (Exception ex)
            {
                return rtnValue;
            }
        }

     public static Int64 GetIn64Value(
     string pTable,
     string pKeyFieldID,
     string pFieldToSearch,
     Int64 pValueToSearch,
     string pCustomQry = ""
     )
        {
            string mySQL = string.Empty;
            Int64 rtnValue = 0;

            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pFieldToSearch;
                mySQL += " from " + pTable + " Where " + clsGVar.LGCY;
                mySQL += " and " + pKeyFieldID + " = " + pValueToSearch.ToString();
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    rtnValue = 0;
                }
                else
                {
                    reader.Read();
                    if (reader[pFieldToSearch] != DBNull.Value)
                    {
                        rtnValue = Convert.ToInt64(reader[pFieldToSearch].ToString()); // working ok
                    }
                    else
                    {
                        rtnValue = 0;
                    }
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch
            {
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return rtnValue;
        } // Get Title ID
        //================================
        // Get int Value                  
        // 1- Table Name            
        // 2- Key Select Field Name  
        // 3- Conditional Field Name            
        // 4- Conditional Field Value
        // 5- Custom Qry    (Default = "" )                  
        public static int GetIntValue(
            string pTable,
            string pSelectFieldName,
            string pConditionFieldName,
            string pConditionFieldValue,
            string pCustomQry = ""
            )
        {
            int strRtnTitle = 0;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pSelectFieldName;
                mySQL += " from " + pTable + " Where " + pConditionFieldName + " = " + pConditionFieldValue;
                mySQL += " and " + clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = 0;
                }
                else
                {
                    reader.Read();
                    strRtnTitle = Convert.ToInt16(reader[pSelectFieldName].ToString()); // working ok
                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                strRtnTitle = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get Int Value
        //================================
        // Get String Value                  
        // 1- Table Name            
        // 2- Key Select Field Name  
        // 3- Conditional Field Name            
        // 4- Conditional Field Value
        // 5- Custom Qry    (Default = "" )                  
        public static string GetStrValue(
            string pTable,
            string pSelectFieldName,
            string pConditionFieldName,
            string pConditionFieldValue,
            string pCustomQry = ""
            )
        {
            string strRtnTitle = string.Empty;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pSelectFieldName;
                mySQL += " from " + pTable + " Where " + pConditionFieldName + " = " + pConditionFieldValue;
                mySQL += " and " + clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnTitle = "";
                }
                else
                {
                    reader.Read();
                    strRtnTitle = reader[pSelectFieldName].ToString(); // working ok
                    //strRtnTitle = reader["Description"].ToString(); // working ok
                    // reader[1].ToString() // is also ok
                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                //strRtnTitle = "ID not Found...";
                MessageBox.Show("Exception, Get String Value: " + ex.Message, "Class: GetStrValue");
                strRtnTitle = "";

                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnTitle;
        } // Get String Value
        //================================
        // 2013 05 01
        // Get Date Value                  
        // 1- Table Name            
        // 2- Key Select Field Name  
        // 3- Conditional Field Name            
        // 4- Conditional Field Value
        // 5- Custom Qry    (Default = "" )                  
        public static DateTime GetDateValue(
            string pTable,
            string pSelectFieldName,
            string pConditionFieldName,
            string pConditionFieldValue,
            string pCustomQry = ""
            )
        {
            DateTime strRtnValue;
            string mySQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                mySQL = "select top 1 " + pSelectFieldName;
                mySQL += " from " + pTable + " Where " + pConditionFieldName + " = " + pConditionFieldValue;
                mySQL += " and " + clsGVar.LGCY;
            }
            else
            {
                mySQL = pCustomQry;
            }
            SqlConnection con = new SqlConnection(clsGVar.ConString1);
            SqlCommand com = new SqlCommand(mySQL, con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = com.ExecuteReader();

                // As we need only 1 record therefore ExecuteScaller is suitable
                //SqlDataReader reader = com.ExecuteScalar();  // TRIED BUT IT IS NOT WORKING WITH Scalar.
                if (!reader.HasRows)
                {
                    strRtnValue = default(DateTime);
                }
                else
                {
                    reader.Read();
                    strRtnValue = Convert.ToDateTime(reader[pSelectFieldName].ToString()); //


                }
                // --------------------------------------------------------------
                reader.Close();
                com.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                //strRtnTitle = "ID not Found...";
                MessageBox.Show("Exception, Get Date Value: " + ex.Message, "Class: GetDateValue");
                strRtnValue = default(DateTime);

                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return strRtnValue;
        } // Get DateValue
    }
}
