using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cha.StringFun01 
{
    class StrF01
    {
        // 2013 05 08
        public static string FixString(string pText, int pLen)
        {
            string rtnValue = "";
            if (pText.Length == 0)
            {
                return StrF01.EnEpos(rtnValue);
            }
            if (pText.Length > pLen)
            {
                return StrF01.EnEpos(pText.Substring(0, pLen));
            }
            return StrF01.EnEpos(pText);
        }
        // 2013 02 07
        public static string RepeatChar(char character, int numberOfIterations)
        {
            try
            {
                return "".PadLeft(numberOfIterations, character);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception, Repeater Character: " + ex.Message, "StringF01");
                return "";
            }
        }        // 2013 04 29
        public static string ToShortD2StrCrystal(DateTimePicker pLongDate, bool pQuote = false)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                rtnValue = pLongDate.Value.ToString("yyyy-MM-dd");

                if (pQuote)
                {
                    rtnValue = "'" + rtnValue + "'";
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Long Date to Short Date string : " + pLongDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }
        // 2013 03 31 True Quotes available, False no quotes
        public static string ToShortD2Str(string pLongDate, bool pQuote = false)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                if (pLongDate.ToString().Trim(' ', '-') == "")
                {
                    rtnValue = "1001-01-01";
                }
                else
                {
                    if (clsGetGvar.AppDateFormatStandard == "dd/MM/yyyy")
                    {
                        rtnValue = pLongDate.ToString().Substring(0, 2) + "-" + pLongDate.ToString().Substring(3, 2) + "-" + pLongDate.ToString().Substring(6, 4);
                    }
                    else
                    {
                        rtnValue = pLongDate.ToString().Substring(3, 2) + "-" + pLongDate.ToString().Substring(0, 2) + "-" + pLongDate.ToString().Substring(6, 4);
                    }
                }
                if (pQuote)
                {
                    rtnValue = "'" + rtnValue + "'";
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Long Date to Short Date string : " + pLongDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }
        // 2013 04 08 True Quotes available, False no quotes
        // The above is in dd/mm/yyyy format but this is SQL acceptable yyyy-mm-dd format
        public static string ToShortDate(string pLongDate, bool pQuote = false)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                // Check null value
                if (pLongDate.ToString().Trim(' ', '-') == "")
                {
                    rtnValue = "1001-01-01";
                }
                else
                {
                    rtnValue = pLongDate.ToString().Substring(6, 4) + "-" + pLongDate.ToString().Substring(3, 2) + "-" + pLongDate.ToString().Substring(0, 2);
                }
                if (pQuote)
                {
                    rtnValue = "'" + rtnValue + "'";
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Long Date to Short Date string : " + pLongDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }

        // Date to String MaskedTextBox
        public static string D2Str(DateTimePicker pDate)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                //rtnValue = pDate.Value.ToShortDateString();
                rtnValue = pDate.Value.ToString("yyyy-MM-dd");
                //rtnValue = pDate.Text.ToString().Substring(6, 4) + "-" + pDate.Text.ToString().Substring(3, 2) + "-" + pDate.Text.ToString().Substring(0, 2); // +" 00:00:00";

                return "'" + rtnValue + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date to string Date Time Picker:: " + pDate + " Error: " + ex.Message, "F01");
                return "'1000-01-01'";
            }
        }
        // Date to String MaskedTextBox
        public static string D2Str(MaskedTextBox pDate)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                if (pDate.Text.ToString().Trim(' ', '-') == "")
                {
                    rtnValue = "1001-01-01";
                }
                else
                {
                    rtnValue = pDate.Text.ToString().Substring(6, 4) + "-" + pDate.Text.ToString().Substring(3, 2) + "-" + pDate.Text.ToString().Substring(0, 2);
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date to string MT Date: " + pDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }
        // Date to String DateTime Date
        public static string D2Str(DateTime pDate)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                if (pDate.ToString().Trim() == "")
                {
                    rtnValue = "1001-01-01";
                }
                else
                {
                    rtnValue = pDate.ToString().Substring(6, 4) + "-" + pDate.ToString().Substring(3, 2) + "-" + pDate.ToString().Substring(0, 2);
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date to string (Date): " + pDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }
        // Date to String DateTime Date Time
        public static string D2Str(DateTime pDate, bool pTime)
        {
            // Note: Substring is 0 based.  
            string rtnValue = string.Empty;
            try
            {
                if (pDate.ToString().Trim() == "")
                {
                    rtnValue = "1001-01-01";
                }
                else
                {
                    rtnValue = pDate.ToString().Substring(6, 4) + "-" + pDate.ToString().Substring(3, 2) + "-" + pDate.ToString().Substring(0, 2);
                    rtnValue += " " + pDate.ToString("G").Substring(11);
                }
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Date to string (DateTime): " + pDate + " Error: " + ex.Message, "F01");
                return "1000-01-01";
            }
        }
        // Check Date
        public static bool isProperDate(string pDate)
        { 
            bool rtnValue = false;
            bool bCheck = false;
            DateTime tempValue;
            if (pDate.Trim().Length == 0 )
                return rtnValue;
            //
            bCheck = DateTime.TryParse(pDate, out tempValue);
            if (bCheck)
            {
                rtnValue = true;
            }
            return rtnValue;
        }
        public static string getIDFromTreeText(TreeView pTree, char pLeft, char pRight)
        {
            string strCode = string.Empty;
            try
            {
                string source = pTree.SelectedNode.Text;
                int start = source.IndexOf(pLeft);
                int end = source.IndexOf(pRight);
                strCode = source.Substring((start + 1), end - start - 1);
                return strCode.Trim();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string[] SplitCommaArr(string value, char delimiter)
        {
            value = value.Replace("\\" + delimiter, "*");  // Replace escaped commas.
            string[] parts = value.Split(delimiter);       // Split on comma.

            string[] result = new string[parts.Length];    // Array that stores results.
            for (int i = 0; i < result.Length; i++)        // Loop through new array.
            {
                result[i] = parts[i].Replace('*', ',');    // Replace substitution character.
            }
            return result;                                 // Return result.
        }
        //
        public static string AddEscpeChr(string pStrValue, char pDelimiter)
        {
            string lrtnValue = string.Empty;
            string lStr = string.Empty;
            //
            lStr = pStrValue;
            var lBuilder = new StringBuilder();
            foreach (var c in lStr)
            {
                if (c.ToString() == ",")
                {
                    lBuilder.Append('\\');
                }
                lBuilder.Append(c);
            }
            lrtnValue = lBuilder.ToString();
            return lrtnValue;
        }
        //  
        public static string Left(string param, int length)
        {
            //we start at 0 since we want to get the characters starting from the
            //left and with the specified lenght and assign it to a variable
            string result = param.Substring(0, length);
            //return the result of the operation
            return result;
        }
        public static string Right(string param, int length)
        {
            //start at the index based on the lenght of the sting minus
            //the specified lenght and assign it a variable
            string result = param.Substring(param.Length - length, length);
            //return the result of the operation
            return result;
        }

        public static string Mid(string param, int startIndex, int length)
        {
            //start at the specified index in the string ang get N number of
            //characters depending on the lenght and assign it to a variable
            string result = param.Substring(startIndex, length);
            //return the result of the operation
            return result;
        }

        public static string Mid(string param, int startIndex)
        {
            //start at the specified index and return all characters after it
            //and assign it to a variable
            string result = param.Substring(startIndex);
            //return the result of the operation
            return result;
        }
        public static string ToUcFirst(string str)
        {
            // Check for empty string. 
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            str = str.Trim();
            if (str.Length < 2)
            {
                return str.ToUpper();
            }
            // Return char and concat substring.
            return char.ToUpper(str[0]) + str.Substring(1);     // starting from 0 to the end of string
        }
        // Concatinate String
        public static string BuildErrMsg(string fLastErrMsg, string fCurErrMsg)
        {
            string tStr = string.Empty;
            if (fCurErrMsg.Length == 0)
            {
                tStr = "Err Message Not Provided....";
                return tStr;
            }
            else
            {
                if (fLastErrMsg.Length > 0)
                {
                    tStr = fLastErrMsg + "\r\n" + fCurErrMsg;
                }
                else
                {
                    tStr = fCurErrMsg;
                }
            }
            return tStr;
        }
        // ----------------------------------- Date -----------------------------------------
        public static int LastDateOfMonth(DateTime pDate)
        {
            DateTime tDate;
            //int lastDay = 0;
            tDate = new DateTime(pDate.Year, pDate.Month, 1).AddMonths(1);
            tDate = new DateTime(tDate.Year, tDate.Month, 1).AddDays(-1);
            return tDate.Day;
        }
        // Over Loaded function of above
        public static int LastDateOfMonth(int pYear, int pMonth)
        {
            DateTime tDate;
            tDate = new DateTime(pYear, pMonth, 1).AddMonths(1);
            tDate = new DateTime(tDate.Year, tDate.Month, 1).AddDays(-1);
            return tDate.Day;
        }
        public static string LastDayOfMonth(DateTime pDate, string pFormat)
        {
            DateTime tDate;
            //int lastDay = 0;
            tDate = new DateTime(pDate.Year, pDate.Month, 1).AddMonths(1);
            tDate = new DateTime(tDate.Year, tDate.Month, 1).AddDays(-1);
            return tDate.ToString(pFormat);
        }
        // Over Loaded function of above
        public static string LastDayOfMonth(int pYear, int pMonth, string pFormat)
        {
            DateTime tDate;
            tDate = new DateTime(pYear, pMonth, 1).AddMonths(1);
            tDate = new DateTime(tDate.Year, tDate.Month, 1).AddDays(-1);
            return tDate.ToString(pFormat);
        }
        public static string EnEpos(string pStr)
        {
            string strNew = pStr.Replace("'", "''");
            return strNew;
        }

    }

}
