using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;

namespace Cha.Class
{
  public class clsLookUpGLAc
  {
    string lTitle = "Find GL ID";
    MaskedTextBox fTextBox;
    string fTitle;
    string fJoin = string.Empty;
    string fAddWhere = string.Empty;
    bool fAutoPopulate = false;
    //
    string fTableNameCOA = "gl_ac";
    //
    public clsLookUpGLAc( 
      MaskedTextBox pTextBox, 
      string pTitle, 
      string pJoin = "" 
      //,string pAddWhere = ""
      )
    {
      fTextBox = pTextBox;
      fTitle = pTitle;
      fJoin = pJoin;
      // Additional where is not required here, it is now available at Find Method
      //fAddWhere = pAddWhere;
      //fAutoPopulate = pAutoPopulate;
      
    }
    //
    public void FindGLAllId()
    {
      string lAddWhere = "";
      try
      {
        // 12 Parameters
        frmLookUp sForm = new frmLookUp(
        "ac_strid",
        "ac_title,ac_atitle,Ordering",
        fTableNameCOA,
        lTitle,
        1,
        "ID,Account Title, Alternate Title,Ordering",
        "10,20,20,10",
        "T,T,T,T",
        true,
        "",
        lAddWhere,
        "mTextBox",
        true,
        false

        );
        //
        sForm.lupassControl = new frmLookUp.LUPassControl(PassGLData);
        sForm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, GL Lookup: " + ex.Message,fTitle);
      }
      //
    }
    public void FindGLTransactionalId(string pAddWhere = "", bool pAutopopulate = false)
    {
      string lAddWhere = "istran = 1";
      if (pAddWhere != "")
      {
        lAddWhere = pAddWhere;
      }
      try
      {
        frmLookUp sForm = new frmLookUp(
        "ac_strid",
        "ac_title,ac_atitle,Ordering",
        fTableNameCOA,
        lTitle,
        1,
        "ID,Account Title, Alternate Title,Ordering",
        "10,20,20,10",
        "T,T,T,T",
        true,
        "",
        lAddWhere,
        "mTextBox",
        true,
        pAutopopulate
        );
        //
        sForm.lupassControl = new frmLookUp.LUPassControl(PassGLData);
        sForm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, GL Lookup: " + ex.Message, fTitle);
      }
      //
    }
    //
    public void FindGLControlId() 
    {
      string lAddWhere = "istran = 0";
      string lJoin = "";
      try
      {
        frmLookUp sForm = new frmLookUp(
        "ac_strid",
        "ac_level,ac_title,ac_atitle,Ordering",
        fTableNameCOA,
        lTitle,
        1,
        "ID,Level,Account Title, Alternate Title,Ordering",
        "10,4,20,20,10",
        "T,T,T,T,T",
        true,
        lJoin,
        lAddWhere,
        "mTextBox",
        true,
        true
        );
        //
        sForm.lupassControl = new frmLookUp.LUPassControl(PassGLData);
        sForm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, GL Lookup Control IDs: " + ex.Message, fTitle);
      }
      //
    } 

    public void PassGLData( object sender )
    {
      fTextBox.Text = (( MaskedTextBox )sender).Text;
      fTextBox.Tag = (( MaskedTextBox )sender).Tag;
    }
    //
  }
}
