using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cha
{
  public class LookUp
  {
    private string _firstName;
    private string _lastName;
    private int _age;

    public LookUp()
    {
      // abc
    }
    public string cTableName { get; set; }
    public string FirstName
    {
      get
      {
        return _firstName;
      }
      set
      {
        _firstName = value;
      }
    }

    public string cKeyFieldID { get; set; }
    public int cDefaultFindField { get; set; }
    public string cSelectedFieldIDOut { get; set; }
    public string cSelectedFiedlTitleOut { get; set; }
    public bool cBlnIsSet { get; set; }

  }
}
