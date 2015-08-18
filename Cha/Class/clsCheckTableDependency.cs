using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

// 2012 12 12
// To check dependent table before deleting a record in a table.
// Parameter: pDependencyList = List of tables and field name to be checked
// Parameter: pValue = Value of ID, Numeric or String (mentioned in above field)
// Handles multiple table DataSet
//
namespace Cha.Class
{
  class clsCheckTableDependency
  {
    //
    public static string CheckTableDependency(
      List<string> pDependencyList,
      string pValueNumID,
      string pValueStringID
      )
    {
      List<string> lDepencyName = new List<string>();
      DataSet lDs = new DataSet();
      string cErrMessage = "";
      string cQryList = "";
      string cRtnValue = "Dependency Not Found";
      int cMaxEntries = 10;
      try
      {
        // Prepare Query
        for (int i = 0; i < pDependencyList.Count; i++)
        {
          string[] lTableParam = pDependencyList[i].Split(',');
          if (lTableParam.Length < 4)
          {
            cRtnValue = "Count Error, in Depency Parameter List: ";
            return cRtnValue;
          }
          string lQrySeperator = "";
          string lTitle = lTableParam[0];
          lDepencyName.Add(lTitle);
          string lTableName = lTableParam[1];
          string lFieldName = lTableParam[2];
          string lQueryType = lTableParam[3];
          if (i > 0)
          {
            // for Multiple Queries
            lQrySeperator = "; ";
          }
          cQryList += lQrySeperator + "SELECT count(" + lFieldName + ") As totalrec FROM " + lTableName;
          cQryList += " WHERE " + lFieldName + " = ";
          // Check Numeric Or String
          if (lQueryType == "S")
          {
            // reise Exception if pValueStrintID == ""
            cQryList += "'" + pValueStringID + "'";
          }
          else
          {
            cQryList += pValueNumID;
          }
        } // End For loop
        // Check dependent records in relevent tables.
        int lMaxEntries = 0;
        lDs = clsDbManager.GetData_Set(cQryList, "table0");
        if (lDs != null)
        {
          // loop through number of records (each table has one record)
          for (int i = 0; i < pDependencyList.Count; i++)
          {
            int lRows = 0;
            if (lDs.Tables[i].Rows[0]["totalrec"] != DBNull.Value)
            {
              lRows = Convert.ToInt16(lDs.Tables[i].Rows[0]["totalrec"]);
            }
            if (lRows > 0)
            {
              cErrMessage += "\nTable: " + lDepencyName[i] + " has [ " + lRows.ToString() + " ]  record(s)";
              lMaxEntries++;
              if (lMaxEntries == cMaxEntries)
              { 
                // This Option is to prevent increase of message box length. (Default is 10)
                cErrMessage += " More...";
                return cErrMessage;
              }
            }
          }
        }
        if (lMaxEntries > 0)
        {
          return cErrMessage;
        }
        else
        {
          return cRtnValue;
        }
        //return cErrMessage;
      }
      catch (Exception)
      {
        throw;
      }
    } // End Method

  
  }
}
