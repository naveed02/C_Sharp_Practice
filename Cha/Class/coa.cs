using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cha
{
    public static class coa
    {
        static string fZeroStr = "000000000000000000000000000000";

        public static Int64 GetNumAcID(
            string pTable,
            string pFieldAcIDstr,
            string pFieldAcIDnum,
            string pSearchValue,
            string pCustomQry)
        {
            Int64 rtnValue = 0;
            string lSQL = string.Empty;
            if (pCustomQry.Length == 0)
            {
                lSQL = "select top 1 " + pFieldAcIDnum;
                lSQL += " from " + pTable + " Where " + pFieldAcIDstr + " = '" + pSearchValue + "'";
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
                    rtnValue = Convert.ToInt64(reader[pFieldAcIDnum]); // working ok
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
                rtnValue = 0;
                com.Dispose();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            return rtnValue;
        }
        public static string GetIDLevelStr(string pInput, int pLevel)
        {
            string rtnValue = "";
            // if mask is 999 then replace it with 0 temporarily
            string[] lLevelInputArr;
            //
            lLevelInputArr = pInput.Split('-');
            for (int i = 0; i < pLevel; i++)
            {
                if (i == 0)
                {
                    rtnValue += lLevelInputArr[i];
                }
                else
                {
                    rtnValue += "-" + lLevelInputArr[i];
                }
            }
            return rtnValue;
        }
        public static string GetNextMaskID(MaskedTextBox pmTB, int pParentLevel, string pParam)
        {
            // pParam = 
            // 1- TableName, 
            // 2- Field Name, 
            // 3- Level Field Name
            //
            string[] lIDLevel;
            string[] lIDtmpLevel;
            lIDtmpLevel = pmTB.Text.ToString().Split('-');
            string[] lMain;
            lMain = pParam.Split(',');
            //
            string lTableName = lMain[0];
            string lFieldName = lMain[1];
            string lLevelFieldName = lMain[2];
            //
            string rtnValue = string.Empty;
            string lSQL = string.Empty;
            string lLevelStr = string.Empty;
            //
            try
            {
                if (pParentLevel > 0 && pParentLevel != lIDtmpLevel.Length)  // lesss then lIDtmpLevel.length
                {
                    lLevelStr = GetIDLevelStr(pmTB.Text.ToString(), pParentLevel);
                    if (lLevelStr == "")
                    {
                        return "Err.";
                    }
                }
                else
                {
                    if (pParentLevel == lIDtmpLevel.Length)
                    {
                        lLevelStr = pmTB.Text.ToString();
                    }
                    else
                    {
                        return "Err.";
                    }
                }
                //
                if (lLevelStr.Length > 0)
                {
                    lSQL = "select max(" + lFieldName + ") from " + lTableName + " where ";
                    //lSQL += clsGVar.LGCY;
                    //lSQL += " and ";
                    lSQL += " substring(" + lFieldName + ",1," + lLevelStr.Length.ToString() + ") = '" + lLevelStr + "'";
                    lSQL += " and ";
                    lSQL += lLevelFieldName + " = ";
                    if (pParentLevel == lIDtmpLevel.Length)
                    {
                        lSQL += pParentLevel.ToString();
                    }
                    else
                    {
                        lSQL += (pParentLevel + 1).ToString();
                    }
                }
                DataSet dtset = new DataSet();
                DataRow dRow;
                dtset = clsDbManager.GetData_Set(lSQL, lTableName);
                //int abc = dtset.Tables.Count; // gives the number of tables.
                int nor = dtset.Tables[0].Rows.Count;

                //if (nor == 0 || nor == null)
                if (nor == 0)
                {
                    rtnValue = lLevelStr + "last segment";
                }
                else
                {
                    dRow = dtset.Tables[0].Rows[0];
                    if (dRow.ItemArray.GetValue(0).ToString().Trim() == "")
                    {
                        //toolStripStatuslblAlertText.Text = mtextParentID.Text.ToString();
                        lIDLevel = pmTB.Text.ToString().Split('-');
                    }
                    else
                    {
                        //toolStripStatuslblAlertText.Text = dRow.ItemArray.GetValue(0).ToString();
                        lIDLevel = dRow.ItemArray.GetValue(0).ToString().Split('-');
                    }
                    // 00-00-0000
                    string beforeLevel = "";
                    string thisLevel = "";
                    string afterLevel = "";
                    int originalLen = 0;

                    // original: for (int i = 0; i < lIDLevel.Length; i++)
                    //{
                    //    if (i + 1 < pParentLevel + 1)
                    //    {
                    //        if (beforeLevel.Length > 0)
                    //        {
                    //            beforeLevel += "-" + lIDLevel[i];
                    //        }
                    //        else
                    //        {
                    //            beforeLevel += lIDLevel[i];
                    //        }
                    //    }
                    //    else if (i + 1 == pParentLevel + 1)
                    //    {
                    //        if (thisLevel.Length == 0)
                    //        {
                    //            thisLevel = lIDLevel[i];
                    //        }
                    //    }
                    //    else if (i + 1 > pParentLevel + 1)
                    //    {
                    //        afterLevel += lIDLevel[i];
                    //    }
                    //}




                    for (int i = 0; i < lIDLevel.Length; i++)
                    {
                        if (i < pParentLevel)
                        {
                            if (beforeLevel.Length > 0)
                            {
                                beforeLevel += "-" + lIDLevel[i];
                            }
                            else
                            {
                                beforeLevel += lIDLevel[i];
                            }
                        }
                        else if (i == pParentLevel)
                        {
                            if (thisLevel.Length == 0)
                            {
                                thisLevel = lIDLevel[i];
                            }
                        }
                        else if (i > pParentLevel)
                        {
                            afterLevel += lIDLevel[i];
                        }
                    }
                    originalLen = thisLevel.Length;
                    thisLevel = (Convert.ToInt64(thisLevel) + 1).ToString();
                    if (thisLevel.Length < originalLen)
                    {
                        thisLevel = fZeroStr.Substring(0, originalLen - thisLevel.Length) + thisLevel;
                    }
                    lIDLevel[pParentLevel] = thisLevel;
                    rtnValue = string.Join("-", lIDLevel);
                    //toolStripStatuslblAlertText.Text += " Before : " + beforeLevel + " this " + thisLevel + " after : " + afterLevel + " RtnValue: " + rtnValue;
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ex " + ex.Message);
                return "Err.";
            }
        }

    }
}
