using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cha.Class
{
  public class clsGetTable
  {
    // =========================================================
    public static DataTable GetDataTable(string strQuery)
    {
      DataTable dtGet = new DataTable();
      SqlConnection con = new SqlConnection(clsGVar.ConString1);
      
      try
      {
        con.Open();
        // create a new data adapter based on the specified query.
        SqlDataAdapter da = new SqlDataAdapter();
        //set the SelectCommand of the adapter
        SqlCommand cmd = new SqlCommand(strQuery, con);
        da.SelectCommand = cmd;
        // create a new DataTable
        // DataTable dtGet = new DataTable();
        //fill the DataTable
        da.Fill(dtGet);
        //return the DataTable
        return dtGet;

      }
      catch (SqlException ex)
      {
          MessageBox.Show("SQL Exception: " + ex.Message, "GetDataTable");
        return dtGet;
      }
      catch (Exception ex)
      {
          MessageBox.Show("General Exception: " + ex.Message, "GetDataTable");
        return dtGet;
      }
    }
    //==========================================================
  }

}
