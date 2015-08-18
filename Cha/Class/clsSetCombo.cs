using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cha.Class;
//
using System.Data;

namespace Cha 
{
    class clsSetCombo
    {
        //public static int Set_ComboBox(ComboBox cbo, Int64 setId)
        //{
        //    int setcboIndex = 0;
        //    int rtnValue = 0;
        //    int iLast = cbo.Items.Count;
        //    try
        //    {
        //        //for (int Ii = 0; Ii < iLast; Ii++)
        //        //{
        //        //    cbo.SelectedIndex = Ii;
        //        //    if (Convert.ToInt32(cbo.SelectedValue.ToString()) == setId)
        //        //    {
        //        //        MessageBox.Show("Text = " + cbo.Text + " Value: " + cbo.SelectedValue.ToString() + " Index: " + cbo.SelectedIndex.ToString());
        //        //        setcboIndex = Ii;
        //        //        break;
        //        //    }
        //        //}
        //        //return setcboIndex;
        //        //StringBuilder sb = new StringBuilder();
        //        if (cbo.Items.Count > 0)
        //        {
        //            string abc1 = "";
        //            string key1 = "";
        //            string abc2 = "";

        //            foreach (object item in cbo.Items)
        //            {
        //                abc1 = item.GetType().ToString();
        //                if (abc1 == "System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]")
        //                {
        //                    //MessageBox.Show("keyvalue pair type:");

        //                    KeyValuePair<int, string> Keyv1 = (KeyValuePair<int, string>)item;
        //                    // key1 = Keyv1.Value.ToString();
        //                    key1 = Keyv1.Key.ToString();
        //                    if (Convert.ToInt32(key1) == setId)
        //                    {
        //                        setcboIndex = rtnValue;
        //                        break;
        //                    }
        //                }
        //                else if (abc1 == "System.Data.DataRowView")
        //                {
        //                    DataRowView row = (DataRowView)item;
        //                    //abc1 = row.Row[cbo.DisplayMember].ToString();
        //                    //MessageBox.Show("Text = " + cbo.Text + " Value: " + cbo.SelectedValue.ToString() + " Index: " + cbo.SelectedIndex.ToString());


        //                    abc2 = row.Row[cbo.ValueMember].ToString();
        //                    if (Convert.ToInt32(abc2) == setId)
        //                    {
        //                        setcboIndex = rtnValue;
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Unknown type");
        //                }
        //                rtnValue++;    
        //            } 
        //        }
        //        return setcboIndex;
        //    }
        //    catch (Exception exp)
        //    {
        //        MessageBox.Show("Exception: " + exp.Message,"Set Combo Box");
        //        return 0;
        //    }
        //}
        #region SetCombo Integer

        public static int Set_ComboBox(ComboBox cbo, Int64 setId)
        {
            int setcboIndex = 0;
            int rtnValue = 0;
            int iLast = cbo.Items.Count;
            try
            {
                //for (int Ii = 0; Ii < iLast; Ii++)
                //{
                //    cbo.SelectedIndex = Ii;
                //    if (Convert.ToInt32(cbo.SelectedValue.ToString()) == setId)
                //    {
                //        MessageBox.Show("Text = " + cbo.Text + " Value: " + cbo.SelectedValue.ToString() + " Index: " + cbo.SelectedIndex.ToString());
                //        setcboIndex = Ii;
                //        break;
                //    }
                //}
                //return setcboIndex;
                //StringBuilder sb = new StringBuilder();
                if (cbo.Items.Count > 0)
                {
                    string lCboTypeKeyValue = "";
                    string lCbokey = "";
                    string lCboTypeDataRowView = "";

                    foreach (object item in cbo.Items)
                    {
                        lCboTypeKeyValue = item.GetType().ToString();
                        if (lCboTypeKeyValue == "System.Collections.Generic.KeyValuePair`2[System.Int32,System.String]")
                        {
                            //MessageBox.Show("keyvalue pair type:");

                            KeyValuePair<int, string> Keyv1 = (KeyValuePair<int, string>)item;
                            // key1 = Keyv1.Value.ToString();
                            lCbokey = Keyv1.Key.ToString();
                            if (Convert.ToInt32(lCbokey) == setId)
                            {
                                setcboIndex = rtnValue;
                                break;
                            }
                        }
                        else if (lCboTypeKeyValue == "GUI_Task.Class.NameValuePair")
                        {
                            NameValuePair Keyv1 = (NameValuePair)item;
                            lCbokey = Keyv1.ValueInt.ToString();

                            if (Convert.ToInt32(lCbokey) == setId)
                            {
                                setcboIndex = rtnValue;
                                break;
                            }

                        }
                        else if (lCboTypeKeyValue == "System.Data.DataRowView")
                        {
                            DataRowView row = (DataRowView)item;
                            //abc1 = row.Row[cbo.DisplayMember].ToString();
                            //MessageBox.Show("Text = " + cbo.Text + " Value: " + cbo.SelectedValue.ToString() + " Index: " + cbo.SelectedIndex.ToString());


                            lCboTypeDataRowView = row.Row[cbo.ValueMember].ToString();
                            if (Convert.ToInt32(lCboTypeDataRowView) == setId)
                            {
                                setcboIndex = rtnValue;
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Combo Setting, Unknown type");
                        }
                        rtnValue++;
                    }
                }
                return setcboIndex;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception: " + exp.Message, "Set Combo Box");
                return 0;
            }

        }
        #endregion SetCombo Integer

        #region SetCombo String
        // STRING ID
        public static int Set_ComboBox(ComboBox cbo, string psetId)
        {
            int setcboIndex = 0;
            int rtnValue = 0;
            int iLast = cbo.Items.Count;
            try
            {
                if (cbo.Items.Count > 0)
                {
                    string abc1 = "";
                    string key1 = "";
                    string abc2 = "";

                    foreach (object item in cbo.Items)
                    {
                        abc1 = item.GetType().ToString();
                        DataRowView row = (DataRowView)item;

                        abc2 = row.Row[cbo.ValueMember].ToString();
                        if (abc2 == psetId)
                        {
                            setcboIndex = rtnValue;
                            break;
                        }
                        rtnValue++;
                    }
                }
                return setcboIndex;
            }
            catch (Exception exp)
            {
                MessageBox.Show("Exception: " + exp.Message, "Set Combo Box");
                return 0;
            }

        }
        #endregion SetCombo String

    }
}

/*
 Dim table As DataTable = DirectCast(Me.ComboBox1.DataSource, DataTable)
        For i As Integer = 0 To table.Rows.Count - 1
            Dim displayItem As String = table.Rows(i)(ComboBox1.DisplayMember).ToString()
            Dim valueItem As String = table.Rows(i)(ComboBox1.ValueMember).ToString()

            If valueItem = "TheValueYouAreSearchingFor" Then
               ' something to do e.g.
               Me.ComboBox1.SelectedIndex = i
            End If
        Next
*/