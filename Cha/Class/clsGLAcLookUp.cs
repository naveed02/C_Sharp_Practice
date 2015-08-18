using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Windows.Forms;

namespace Cha
{
  public class clsGLAcLookUp
  {
    string lTitle = "Find GL ID";
    MaskedTextBox fTB;
    string fTitle;
    string fJoin = string.Empty;
    string fAddWhere = string.Empty;
    //
    string fTableNameCOA = "gl_ac";
    //
    public clsGLAcLookUp( MaskedTextBox pTB, string pTitle,string pJoin = "", string pAddWhere = ""  )
    {
      fTB = pTB;
      fTitle = pTitle;
      fJoin = pJoin;
      fAddWhere = pAddWhere;
    }
    //
    public void FindGLID()
    {
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
        ""
        );
        //
        sForm.lupassControl = new frmLookUp.LUPassControl(PassGLData);
        sForm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Exception, GL Lookup: " + ex.Message,fTitle);
      }

    } 
    public void PassGLData( object sender )
    {
      fTB.Text = (( MaskedTextBox )sender).Text;
      fTB.Tag = (( MaskedTextBox )sender).Tag;
    }

  }
}
