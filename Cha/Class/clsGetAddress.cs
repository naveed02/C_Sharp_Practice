using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Cha.Class
{
  public class clsGetAddress
  {
    // By BaBa
    // Address Query
    // Date 2012 12 21
    // Parameter PAcStrID = Account ID in string
    // First OverLoad with str Id
    public static string GetAddressSQL( string pAcStrID, bool pIsNum = false )
    {
      string rtnValue = "";
      string lSQL = String.Empty;
      try
      {
        lSQL = "; ";
        lSQL += "SELECT  top 1 ";
        lSQL += "g.ac_id, g.addr_uid, g.ac_title, g.ac_atitle,";
        lSQL += "a.addr_type_id, a.addr_salute_id, sl.salute_title, sl.salute_st,";
        lSQL += "a.addr_contactperson, a.addr_address1,";
        lSQL += "a.addr_address2, a.addr_country_id, c.country_title,";
        lSQL += "a.addr_province_id, p.province_title,";
        lSQL += "a.addr_city_id, ct.city_title,a.addr_zip,";
        lSQL += "a.addr_phone, a.addr_ext, a.addr_mobile, a.addr_fax, a.addr_email, a.addr_web,";
        lSQL += "a.addr_ref, a.addr_remarks, a.isdisabled ";
        lSQL += " FROM gl_ac g ";
        lSQL += " LEFT OUTER JOIN cmn_address a ON a.addr_uid = g.addr_uid ";
        // Note: for the join 'LEFT' means left of equal sign.
        lSQL += " LEFT OUTER JOIN cmn_salute sl ON a.addr_salute_id = sl.salute_id ";
        lSQL += " LEFT OUTER JOIN geo_country c ON a.addr_country_id = c.country_id ";
        lSQL += " LEFT OUTER JOIN geo_province p ON a.addr_province_id = p.province_id";
        lSQL += " LEFT OUTER JOIN geo_city ct ON a.addr_city_id = ct.city_id";
        lSQL += " Where ";
        lSQL += " g.ac_id = ";
        if (pIsNum)
        {
          lSQL += pAcStrID;
        }
        else
        {
          lSQL += "(SELECT ac_id FROM gl_ac WHERE ac_strid = '" + pAcStrID + "' and " + clsGVar.LGCY + ")";
        }
        
        lSQL += " and " + clsGVar.LGCYg;
        return lSQL;
      }
      catch (Exception ex)
      {
        return rtnValue;
        throw;
      }
    }
    //// 2nd OverLoad with Num Id
    //public static string GetAddressSQL( string pAcStrID )
    //{
    //  string rtnValue = "";
    //  string lSQL = String.Empty;
    //  try
    //  {
    //    lSQL = "; ";
    //    lSQL += "SELECT  top 1 ";
    //    lSQL += "g.ac_id, g.addr_uid, g.ac_title, g.ac_atitle,";
    //    lSQL += "a.addr_type_id, a.addr_salute_id, sl.salute_title, sl.salute_st,";
    //    lSQL += "a.addr_contactperson, a.addr_address1,";
    //    lSQL += "a.addr_address2, a.addr_country_id, c.country_title,";
    //    lSQL += "a.addr_province_id, p.province_title,";
    //    lSQL += "a.addr_city_id, ct.city_title,a.addr_zip,";
    //    lSQL += "a.addr_phone, a.addr_ext, a.addr_mobile, a.addr_fax, a.addr_email, a.addr_web,";
    //    lSQL += "a.addr_ref, a.addr_remarks, a.isdisabled ";
    //    lSQL += " FROM gl_ac g ";
    //    lSQL += " LEFT OUTER JOIN cmn_address a ON a.addr_uid = g.addr_uid ";
    //    // Note: for the join 'LEFT' means left of equal sign.
    //    lSQL += " LEFT OUTER JOIN cmn_salute sl ON a.addr_salute_id = sl.salute_id ";
    //    lSQL += " LEFT OUTER JOIN geo_country c ON a.addr_country_id = c.country_id ";
    //    lSQL += " LEFT OUTER JOIN geo_province p ON a.addr_province_id = p.province_id";
    //    lSQL += " LEFT OUTER JOIN geo_city ct ON a.addr_city_id = ct.city_id";
    //    lSQL += " Where ";
    //    lSQL += " g.ac_id = " + "(SELECT ac_id FROM gl_ac WHERE ac_strid = '" + pAcStrID + "' and " + clsGVar.LGCY + ")";
    //    lSQL += " and " + clsGVar.LGCYg;
    //    return lSQL;
    //  }
    //  catch (Exception ex)
    //  {
    //    return rtnValue;
    //    throw;
    //  }
    //}



    public static void RenderAddress( Control.ControlCollection pMControl, DataSet pMDs, int pMTableID )
    {
      GetControls(pMControl, pMDs, pMTableID);
    }
    //
    private static void GetControls( Control.ControlCollection pControl, DataSet pDs, int pTI )
    {
      // pTI = Parameter Table ID
      try
      {
        foreach (Control MainControl in pControl)
        {

          //////if (MainControl.Tag != null)
          //////{
          //////  if (MainControl.Tag.ToString() == "Sample")
          //////  {
          //////    //MessageBox.Show("Sample: Tab: Address Label Name: " + MainControl.Name);
          //////  }
          //////}
          ////////

          ////////
          //////if (MainControl.Name == "tNtextCreditLimit")
          //////{
          //////  //MessageBox.Show("type = " + MainControl.GetType().Name);
          //////}

          switch (MainControl.GetType().Name)
          {
            // Custom Controls
            // case "TNumEditBox": // [CSUST.Data.TNumEditBox]
            //
            //case "Button":
            //case "CheckBox":
            //case "CheckedListBox":
            //case "ComboBox":
            //case "DateTimePicker":
            ////case "Label":
            //case "LinkLabel":
            //case "ListBox":
            //case "ListView":
            //case "MaskedTextBox":
            //case "MonthCalendar":
            //case "NumericUpDown":
            //case "PictureBox":
            //case "ProgressBar":
            //case "RadioButton":
            //case "RichTextBox":
            //case "TextBox":
            //case "WebBrowser":
            //
            //case "FlowLayoutPanel":
            //case "GroupBox":
            //case "Panel":
            //case "TableLayoutPanel":
            //case "SplitContainer":
            //  cbbControls.Items.Add(t_oBaseControl.Name);
            //  GetControls((( SplitContainer )t_oBaseControl).Panel1.Controls);
            //  GetControls((( SplitContainer )t_oBaseControl).Panel2.Controls);
            //  break;
            //
            //case "TreeView":
            //  cbbControls.Items.Add(t_oBaseControl.Name);
            //  foreach (TreeNode t_oTreeNode in (( TreeView )t_oBaseControl).Nodes)
            //  {
            //    cbbControls.Items.Add(t_oTreeNode.Name);
            //    GetNodes(t_oTreeNode.Nodes);
            //  }
            //  break;
            //
            //case "MenuStrip":
            //  cbbControls.Items.Add(t_oBaseControl.Name);
            //  foreach (ToolStripMenuItem t_oMenuItem in (( ToolStrip )t_oBaseControl).Items)
            //  {
            //    cbbControls.Items.Add(t_oMenuItem.Name);
            //    GetMenuItems(t_oMenuItem.DropDownItems);
            //  }
            //  break;
            //
            //    case "StatusStrip":
            //    case "ToolStrip":
            //        cbbControls.Items.Add(t_oBaseControl.Name);
            //        for(int i = 0;i < ((ToolStrip)t_oBaseControl).Items.Count;i++)
            //        {
            //            switch(((ToolStrip)t_oBaseControl).Items[i].GetType().Name)
            //            {
            //                case "ToolStripButton":
            //                case "ToolStripComboBox":
            //                case "ToolStripLabel":
            //                case "ToolStripMenuItem":
            //                case "ToolStripProgressBar":
            //                case "ToolStripStatusLabel":
            //                case "ToolStripTextBox":
            //                    ToolStripItem t_oToolStripItem = (ToolStripItem)((ToolStrip)t_oBaseControl).Items[i];
            //                    cbbControls.Items.Add(t_oToolStripItem.Name);
            //                    break;
            //                case "ToolStripSplitButton":
            //                    ToolStripSplitButton t_oToolStripSplitButton = (ToolStripSplitButton)((ToolStrip)t_oBaseControl).Items[i];
            //                    cbbControls.Items.Add(t_oToolStripSplitButton.Name);
            //                    GetMenuItems(t_oToolStripSplitButton.DropDownItems);
            //                    break;
            //                case "ToolStripDropDownButton":
            //                    ToolStripDropDownButton t_oToolStripDropDownButton = (ToolStripDropDownButton)((ToolStrip)t_oBaseControl).Items[i];
            //                    cbbControls.Items.Add(t_oToolStripDropDownButton.Name);
            //                    GetMenuItems(t_oToolStripDropDownButton.DropDownItems);
            //                    break;
            //            }
            //        }
            //        break;
            //}

            case "Label":
              if (MainControl.Tag != null)
              {
                if (MainControl.Tag.ToString() == "Addr")
                {
                  //MainControl.Text = "Lbl: " + MainControl.Name;
                  switch (MainControl.Name)
                  {
                    case "lblSalute": // 01
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["salute_st"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["salute_st"].ToString());
                      break;
                    case "lblContactPerson":  // 02
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_contactperson"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_contactperson"].ToString());
                      break;
                    case "lblAddressLine1": // 03
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_address1"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_address1"].ToString());
                      break;
                    case "lblAddressLine2": // 04
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_address2"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_address2"].ToString());
                      break;
                    case "lblCity": // 05
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["city_title"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["city_title"].ToString());
                      break;
                    case "lblStateProvince":  // 06
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["province_title"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["province_title"].ToString());
                      break;
                    case "lblCountry":  // 07
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["country_title"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["country_title"].ToString());
                      break;
                    case "lblZipPostalCode":  // 08
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_zip"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_zip"].ToString());
                      break;
                    case "lblPhone":  // 09
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_phone"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_phone"].ToString());
                      break;
                    case "lblPhoneExt": // 10
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_ext"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_ext"].ToString());
                      break;
                    case "lblMobile": // 11
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_mobile"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_mobile"].ToString());
                      break;
                    case "lblFax":  // 12
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_fax"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_fax"].ToString());
                      break;
                    case "lblEmail": // 13
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_email"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_email"].ToString());
                      break;
                    case "lblWeb":  // 14
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["addr_web"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_web"].ToString());
                      break;
                    case "lblAc_id":  // 15 Additional
                      MainControl.Text = (pDs.Tables[pTI].Rows[0]["ac_id"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["ac_id"].ToString())
                        + " / " + (pDs.Tables[pTI].Rows[0]["addr_uid"] == DBNull.Value ? "" : pDs.Tables[pTI].Rows[0]["addr_uid"].ToString());
                      break;


                  } // end Inner Switch Label:
                } // end if == "Addr"
              } // end if != null
              break;

            case "TabControl":
              foreach (TabPage t_oTabPage in (( TabControl )MainControl).TabPages)
              {
                if (t_oTabPage.Tag != null)
                {
                  if (t_oTabPage.Tag.ToString() == "Addr")
                  {
                    GetControls(t_oTabPage.Controls, pDs, pTI);
                    //MessageBox.Show("Tab: Address Label Name: " + t_oTabPage.Name);
                  }
                }
              }
              break;
            case "TNumEditBox": // CSUST.Data.TNumEditBox
              if (MainControl.Tag != null)
              {
                if (MainControl.Tag.ToString() == "Addr")
                {
                  MessageBox.Show("Tab: Address Label Name: " + MainControl.Name);
                }
              }
              break;
          } // switch
        } // for each
      }
      catch (Exception)
      {
        throw;
      }

    } // end GetControls Private Method
  }
}
