using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.Collections.ObjectModel;

namespace Cha.Class
{
  class clsEnumToList
  {

  }
  //-------------------------------
  public class AcPeriod
  {
    private string _acptitle;
    private int _acpid;
    private DateTime _acpdateFrom;
    private DateTime _acpdateTo;
    // Constructor
    public AcPeriod(
      string pAcpTitle,
      int pAcpId,
      DateTime pAcpDateFrom,
      DateTime pAcpDateTo )
    {
      _acptitle = pAcpTitle;
      _acpid = pAcpId;
      _acpdateFrom = pAcpDateFrom;
      _acpdateTo = pAcpDateTo;
    }
    // Read Only Properties
    public string acptitle { get { return _acptitle; } }
    public int acpid { get { return _acpid; } }
    public DateTime acpdateFrom { get { return _acpdateFrom; } }
    public DateTime acpdateTo { get { return _acpdateTo; } }
  }
  //=======================
  public class NameValuePair : IComparable<NameValuePair>
  {
    private string _nameStr;
    private Int32 _valueInt;
    //
    public NameValuePair(
      string pNameStr,
      Int32 pValueInt)
    {
      _nameStr = pNameStr;
      _valueInt = pValueInt;
    }
    // Read Only Properties

    //public string NameStr { get; set; }
    //public Int32 ValueInt { get; set; } 

    public string NameStr { get { return _nameStr; } }
    public int ValueInt { get { return _valueInt; } } 
    //
    public static Comparison<NameValuePair> IDComparison = delegate( NameValuePair p1, NameValuePair p2 )
    {
      return p1._valueInt.CompareTo(p2._valueInt);
    };
    //
    public static Comparison<NameValuePair> NameComparison = delegate( NameValuePair p1, NameValuePair p2 )
    {
      return p1._nameStr.CompareTo(p2._nameStr);
    };
    //
    public Int32 CompareTo( NameValuePair other )
    {
      return NameStr.CompareTo(other.NameStr);
    }


  }

  //=======================
  //public class NameValue
  //{
  //  public string Name { get; set; }
  //  public object Value { get; set; }

  //  public static List<NameValue> EnumToList<T>()
  //  {
  //    var array = ( T[] )(Enum.GetValues(typeof(T)).Cast<T>());
  //    var array2 = Enum.GetNames(typeof(T)).ToArray<string>();
  //    List<NameValue> lst = null;
  //    for (int i = 0; i < array.Length; i++)
  //    {
  //      if (lst == null)
  //        lst = new List<NameValue>();
  //      string name = array2[i];
  //      T value = array[i];
  //      lst.Add(new NameValue { Name = name, Value = value });
  //    }
  //    return lst;
  //  }


  //
    //enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri }; 
    //{ Array arr = Enum.GetValues(typeof(Days)); 
    //  List<string> lstDays = new List<string>(arr.Length); 
    //  for (int i = 0; i < arr.Length; i++) 
    //  { lstDays.Add(arr.GetValue(i).ToString());
    //  } 
    //} 
//  class Program { enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri }; static void Main( string[] args ) { Array arr = Enum.GetValues(typeof(Days)); List<string> lstDays = new List<string>(arr.Length); for (int i = 0; i < arr.Length; i++) { lstDays.Add(arr.GetValue(i).ToString()); } } }

}

