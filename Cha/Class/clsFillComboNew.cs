using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Cha
{

    public class clsFillComboNew
    {
        //===============================================================================
        // Fill List Box Start 
        // 1- Combo Box
        // 2- Connection
        // 3- strTableKey  // List of variables table,keyfield
        // 4- Query
        // not yet implemented
        public static void ACheckedListBox(
            CheckedListBox lbox,
            string strTableKeyID,
            string strSQL,
            string strCon = clsGVar.ConString1

            )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            strTableField = strTableKeyID.Split(',');
            // strTableKeyID comes with 3 fields
            strTable = strTableField[0];
            strKeyField = strTableField[1];
            bool pSetDefault = Convert.ToBoolean(strTableField[2]);

            SqlConnection CurrCon = new SqlConnection(strCon);

            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(strSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                DataSet ds = new DataSet();
                /// DataTable table = new DataTable();
                /// table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdaptor.Fill(ds, strTable);
                CurrCon.Close();

                lbox.DataSource = ds.Tables[0];
                if (pSetDefault)
                {
                    lbox.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    lbox.ValueMember = ds.Tables[0].Columns[0].ToString();
                }
                else
                {
                    // Note: Width every table loc,grp,co,year is attach
                    // Therefore it start with 4 = ID, 5 = Title
                    // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                    lbox.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    lbox.ValueMember = ds.Tables[0].Columns[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }
        //

        //===============================================================================
        // Fill List Box Start 
        // 1- Combo Box
        // 2- Connection
        // 3- strTableKey  // List of variables table,keyfield
        // 4- Query
        public static void FillListBox(
            ListBox lbox,
            string strTableKeyID,
            string strSQL,
            string strCon = clsGVar.ConString1

            )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            strTableField = strTableKeyID.Split(',');
            // strTableKeyID comes with 3 fields
            strTable = strTableField[0];
            strKeyField = strTableField[1];
            bool pSetDefault = Convert.ToBoolean(strTableField[2]);

            SqlConnection CurrCon = new SqlConnection(strCon);

            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(strSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                DataSet ds = new DataSet();
                /// DataTable table = new DataTable();
                /// table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdaptor.Fill(ds, strTable);
                CurrCon.Close();

                lbox.DataSource = ds.Tables[0];
                if (pSetDefault)
                {
                    lbox.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    lbox.ValueMember = ds.Tables[0].Columns[0].ToString();
                }
                else
                {
                    // Note: Width every table loc,grp,co,year is attach
                    // Therefore it start with 4 = ID, 5 = Title
                    // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                    lbox.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    lbox.ValueMember = ds.Tables[0].Columns[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }
        //
        // =========================

        // Fill Grid Start 
        // 1- Combo Box
        // 2- Connection
        // 3- strTableKey  // List of variables ("TableName,KeyFieldName")
        // 4- Query
        public static void FillCombo(
        ComboBox cbo,
        string strTableKeyID,
        string strSQL,
        bool pAdditional = false,
        string strCon = clsGVar.ConString1


        )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            strTableField = strTableKeyID.Split(',');
            // strTableKeyID comes with 3 fields
            strTable = strTableField[0];
            strKeyField = strTableField[1];
            bool pSetDefault = Convert.ToBoolean(strTableField[2]);
            int lDefaultIndex = 0;
            SqlConnection CurrCon = new SqlConnection(strCon);

            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(strSQL, CurrCon);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                DataTable ds = new DataTable();
                /// DataTable table = new DataTable();
                /// table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                //da.Fill(dt); 

                dataAdaptor.Fill(ds);
                CurrCon.Close();

                // -----------------------------
                if (pAdditional)
                {
                    var dataRow = ds.NewRow();
                    dataRow[0] = 0;
                    dataRow[1] = "<< All >>";
                    ds.Rows.Add(dataRow);
                    lDefaultIndex = ds.Rows.Count - 1;
                }

                //CBParent.DataSource = dt; 

                //row["Category"] = "<-Please select Category->"; 

                //------------------------------
                cbo.DataSource = ds; //.Tables[0];
                if (pSetDefault)
                {
                    cbo.DisplayMember = ds.Columns[1].ToString();
                    cbo.ValueMember = ds.Columns[0].ToString();
                }
                else
                {
                    // Note: Width every table loc,grp,co,year is attach
                    // Therefore it start with 4 = ID, 5 = Title
                    // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                    // Old deprecated 2012 08 09
                    //cbo.ValueMember = ds.Tables[0].Columns[4].ToString();
                    //cbo.DisplayMember = ds.Tables[0].Columns[5].ToString();

                    cbo.ValueMember = ds.Columns[0].ToString();
                    cbo.DisplayMember = ds.Columns[1].ToString();
                }
                if (pAdditional)
                {
                    cbo.SelectedIndex = lDefaultIndex;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }

        // ----------------------------------- Fill Combo width DS
        // Fill Grid Start 
        // 1- Combo Box
        // 2- Connection
        // 3- strTableKey  // List of variables ("TableName,KeyFieldName")
        // 4- Query
        public static void FillComboDS(
        ComboBox cbo,
        DataSet pDS,
        int pTableID,
        bool pAdditional = false

        )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            int lTableID = pTableID;
            //DataSet lDS = pDS.Tables[pTableID];
            int lDefaultIndex = 0;
            try
            {

                // -----------------------------
                //if (pAdditional)
                //{
                //  var dataRow = lDS.NewRow();
                //  dataRow[0] = 0;
                //  dataRow[1] = "<< All >>";
                //  lDS.Rows.Add(dataRow);
                //  lDefaultIndex = ds.Rows.Count - 1;
                //}

                //CBParent.DataSource = dt; 

                //row["Category"] = "<-Please select Category->"; 

                //------------------------------
                //cbo.DataSource = lDS.Tables[pTableID]; //.Tables[0];
                //if (pSetDefault)
                //{
                //  cbo.DisplayMember = lDS.Columns[1].ToString();
                //  cbo.ValueMember = lDS.Columns[0].ToString();
                //}
                //else
                //{
                // Note: Width every table loc,grp,co,year is attach
                // Therefore it start with 4 = ID, 5 = Title
                // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                // Old deprecated 2012 08 09
                //cbo.ValueMember = ds.Tables[0].Columns[4].ToString();
                //cbo.DisplayMember = ds.Tables[0].Columns[5].ToString();

                //  cbo.ValueMember = lDS.Tables[pTableID].Columns[0].ToString();
                //  cbo.DisplayMember = lDS.Tables[pTableID].Columns[1].ToString();

                //cbo.ValueMember = pDS.Tables[pTableID].Columns[0].ToString();
                //cbo.DisplayMember = pDS.Tables[pTableID].Columns[1].ToString();

                cbo.DataSource = pDS.Tables[lTableID];
                cbo.ValueMember = pDS.Tables[lTableID].Columns[0].ToString();
                cbo.DisplayMember = pDS.Tables[lTableID].Columns[1].ToString();

                //}
                //if (pAdditional)
                //{
                //  cbo.SelectedIndex = lDefaultIndex;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }

        // ===================================

        // =================================== Fill Combo width DS



        //========================================================
        //===============================================================================
        // Fill Grid Start 
        // 1- Combo Box
        // 2- Connection
        // 3- strTableKey  // List of variables ("TableName,KeyFieldName")
        // 4- Query
        public static void XXFillComboXX(
        ComboBox cbo,
        string strTableKeyID,
        string strSQL,
        bool pAdditional = false,
        string strCon = clsGVar.ConString1


        )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            strTableField = strTableKeyID.Split(',');
            // strTableKeyID comes with 3 fields
            strTable = strTableField[0];
            strKeyField = strTableField[1];
            bool pSetDefault = Convert.ToBoolean(strTableField[2]);

            SqlConnection CurrCon = new SqlConnection(strCon);

            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(strSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                DataSet ds = new DataSet();
                /// DataTable table = new DataTable();
                /// table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdaptor.Fill(ds, strTable);
                CurrCon.Close();
                // -----------------------------

                //row["Category"] = "<-Please select Category->"; 

                //------------------------------
                cbo.DataSource = ds.Tables[0];
                if (pSetDefault)
                {
                    cbo.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    cbo.ValueMember = ds.Tables[0].Columns[0].ToString();
                }
                else
                {
                    // Note: Width every table loc,grp,co,year is attach
                    // Therefore it start with 4 = ID, 5 = Title
                    // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                    // Old deprecated 2012 08 09
                    //cbo.ValueMember = ds.Tables[0].Columns[4].ToString();
                    //cbo.DisplayMember = ds.Tables[0].Columns[5].ToString();

                    cbo.ValueMember = ds.Tables[0].Columns[0].ToString();
                    cbo.DisplayMember = ds.Tables[0].Columns[1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }

        // ===================================
        public static void FillComboCol(
            DataGridViewComboBoxColumn cbo,
            string strTableKeyID,
            string strSQL

            )  // ToDo: Add Display Member, Value Member, Also set Default value
        {
            //bool pSetDefault = true;
            string strTable = string.Empty;
            string strKeyField = string.Empty;
            string[] strTableField;
            strTableField = strTableKeyID.Split(',');
            // strTableKeyID comes with 3 fields
            strTable = strTableField[0];
            strKeyField = strTableField[1];
            bool pSetDefault = Convert.ToBoolean(strTableField[2]);

            SqlConnection CurrCon = new SqlConnection(clsGVar.ConString1);

            try
            {
                CurrCon.Open();
                SqlDataAdapter dataAdaptor = new SqlDataAdapter(strSQL, CurrCon);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdaptor);
                DataSet ds = new DataSet();
                /// DataTable table = new DataTable();
                /// table.Locale = System.Globalization.CultureInfo.InvariantCulture;

                dataAdaptor.Fill(ds, strTable);
                CurrCon.Close();

                cbo.DataSource = ds.Tables[0];
                if (pSetDefault)
                {
                    cbo.DisplayMember = ds.Tables[0].Columns[1].ToString();
                    cbo.ValueMember = ds.Tables[0].Columns[0].ToString();
                    if (cbo.Items.Count > 0)
                    {
                        cbo.Selected = true;
                    }
                }
                else
                {
                    // Note: Width every table loc,grp,co,year is attach
                    // Therefore it start with 4 = ID, 5 = Title
                    // In case table does not have Codata adopt different feature use: Use true/false reserved for IsDefault in this case  
                    if (ds.Tables[0].Columns.Count == 2)
                    {
                        cbo.DisplayMember = ds.Tables[0].Columns[1].ToString();
                        cbo.ValueMember = ds.Tables[0].Columns[0].ToString();
                    }
                    else
                    {
                        cbo.DisplayMember = ds.Tables[0].Columns[5].ToString();
                        cbo.ValueMember = ds.Tables[0].Columns[4].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Fillcombo:");
                return;
            }

        }


        //====================================
    } // FillCombo



}
