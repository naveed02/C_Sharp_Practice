using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// In .NET, there are two categories of types, reference types and value types
// Structs are value types and classes are reference types
// The general different is that a reference type lives on the heap, and a value type lives inline, that is, wherever it is your variable or field is defined.
// A variable containing a value type contains the entire value type value. For a struct, that means that the variable contains the entire struct, with all its fields
// A variable containing a reference type contains a pointer, or a reference to somewhere else in memory where the actual value resides.
// 
// Since classes are reference type, a class variable can be assigned null.But we cannot assign null to a struct variable, since structs are value type.
// When you instantiate a class, it will be allocated on the heap.When you instantiate a struct, it gets created on the stack.
// You will always be dealing with reference to an object ( instance ) of a class. But you will not be dealing with references to an instance of a struct 
// ( but dealing directly with them ).


namespace Cha
{
    public struct Photo
    {


        public int Id { get; set; }
        // Header Fields
        public int Loc { get; set; }                // 1
        public int Grp { get; set; }                // 2
        public int Co { get; set; }                 // 3
        public int Year { get; set; }               // 4
        public int Frm { get; set; }                // 5
        public int DocType { get; set; }            // 6
        public int DocID { get; set; }              // 7
        public int Fiscal { get; set; }             // 8
        // Data Fields
        public int SoID { get; set; }               // 1
        public string Title { get; set; }           // 2
        public string St { get; set; }              // 3
        public string Name { get; set; }            // 4
        public string Ext { get; set; }             // 5
        public Int32 Length { get; set; }           // 6
        // CFTTB: public byte[] Thumbnail { get; set; }       // 7
        public byte[] Img { get; set; }             // 8

    }
}

