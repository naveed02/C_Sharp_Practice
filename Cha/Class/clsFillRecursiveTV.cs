using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;            // DataTable
using System.Drawing;         //  Color

// Note: private static void AddChildNodeTable(TreeNode tn) was non static, it was not working, when made static it is working
// The error was:
namespace Cha.Class
{
     public class FillRecursiveTV
     {
          public static DataTable dt = new DataTable();
          public static DataTable fdt = new DataTable();

         // 1- Control
         // 2- Query
         // 3- Field List
         // 4- Parent ID
         // 5- TreeKey
         //
          public static void LoadNodesTable(
            TreeView tv,
            string pQry,
            string pFList,
            string pPid,
            string pTreeKey
            )
          {
               tv.Nodes.Clear();
               try
               {
                   dt = clsGetTable.GetDataTable(pQry);
                   foreach (DataRow r1 in dt.Rows)
                   {
                       //if (r1[8] == DBNull.Value)  // 1 = PARENTID FIELD, now = 8
                       if (r1[4] == DBNull.Value)  // 1 = PARENTID FIELD, now = 8
                       //if (r1[8] != DBNull.Value)  // 1 = PARENTID FIELD, now = 8 by bira for test
                       {
                           // 1- Key/Name
                           // 2- Text   [ ID ] Title
                           // 
                           TreeNode tn = tv.Nodes.Add(
                               r1[0].ToString(),
                               "[ " + r1[6].ToString() + " ]  " + r1[1].ToString());
                           tn.Tag = "ID: " + r1[0].ToString();

                           //r1[4].ToString(),
                           //    "[ " + r1[10].ToString() + " ]  " + r1[5].ToString());
                           //tn.Tag = "ID: " + r1[4].ToString();

                           //    r1[0].ToString(),
                           //    "[ " + r1[3].ToString() + " ]  " + r1[4].ToString()); 
                           //tn.Tag = "ID: " + r1[3].ToString();
                           //tn.ForeColor = Color.ForestGreen;
                           AddChildNodeTable(tn, pPid);
                       }
                   } // end foreach loop
               }
               catch (SqlException ex)
               {
                   MessageBox.Show("SQL Exception: " + ex.Message, "Fill TV-R, Load Table");
               }
               catch (Exception exp)
               {
                   MessageBox.Show("Exception: Load Table: " + exp.Message, "Fill TV-R, Load Table");
               }
          } // end LoadNodesTable

          // ---------------------------------------------------------
          private static void AddChildNodeTable(TreeNode tn, string pPID)
          {
               //fdt = FilterTableTV("acparentid = " + tn.Name);
              //fdt = FilterTableTV("ac_pid = " + tn.Name);
              fdt = FilterTableTV(pPID + " = " + tn.Name);
               try
               {
                   foreach (DataRow r2 in fdt.Rows)
                   {
                       //TreeNode tn = treeview1.Nodes.Add(sqlDataReader.GetInt64(0).ToString(), "[ " + sqlDataReader.GetString(3).ToString() + " ]  " + sqlDataReader.GetString(4));  //(ID,Name)
                       // 1- Key/Name
                       // 2- Text   [ ID ] Title
                       // 
                       TreeNode tnChild = tn.Nodes.Add(
                            r2[0].ToString(),
                           "[ " + r2[6].ToString() + " ]  " + r2[1].ToString());

    //                   TreeNode tnChild = tn.Nodes.Add(
    // r2[4].ToString(),
    //"[ " + r2[10].ToString() + " ]  " + r2[5].ToString());

                           //r2[0].ToString(), 
                           //"[ " + r2[3].ToString() + " ]  " + r2[4].ToString());
                       tnChild.Tag = "Sub ID: " + r2[0].ToString();
                       if (r2[5].ToString() == "2")
                       {
                           tnChild.ForeColor = Color.RoyalBlue;
                       }
                       else if (r2[5].ToString() == "3")
                       {
                           tnChild.ForeColor = Color.Magenta;
                       }
                       else if (r2[5].ToString() == "4")
                       {
                           tnChild.ForeColor = Color.Purple;
                       }
                       else if (r2[5].ToString() == "5")
                       {
                         tnChild.ForeColor = Color.Green;
                       }

                       else
                       {
                           tnChild.ForeColor = Color.Red;
                       }
                       AddChildNodeTable(tnChild, pPID);
                   } // END foreach LOOP
               }
               catch (Exception exp)
               {
                   MessageBox.Show("Exception: Add Node" + exp.Message , "Fill TV-`R, Add Child Node");
               }

          } // AddChildNodeTable

          //
          private static DataTable FilterTableTV(string filter)
          {
               DataTable dt1 = dt.Clone();
               //label2.Text = "Before dt1: " + dt1.Rows.Count.ToString();
               try
               {
                    foreach (DataRow dr in dt.Select(filter))
                    {
                         dt1.ImportRow(dr);
                    }
                    //return dt1;
                    //label2.Text += " After Import: " + dt1.Rows.Count.ToString();
               }
               catch (Exception exp)
               {
                    // should be commented
                   MessageBox.Show("Exception: Error filter: " + exp.Message, "Fill TV-`R, Filtering");
                    //return dt1;
               }
               return dt1;
          }  // End FilterTableTV
     } // End Class
} // End NameSpace
