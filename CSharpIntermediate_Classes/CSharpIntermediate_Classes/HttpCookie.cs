using System;
using System.Collections.Generic;

namespace CSharpIntermediate_Classes
{
    partial class Program
    {
        public class HttpCookie
        {
            public DateTime Expiry { get; set; }
            private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
            //readonly makes sure _dictionary is initialized only once in the class constructor

            public string this[string key] //HttpCookie["key"] methods
                //the above is using an indexer "[]" to avoid setting unnecessary set and gets for dictionary methods
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }
    }
    //cw + tab -> 'Console.WriteLine'
    //F9 -> Insert Breakpoint
    //ctrl + tab 'on class constructor' -> access class file
    //ctor + tab -> make constructor on class
    //click on class function + click on brush at the right of line number --> 'move to' creates new class file
    //ctrl + k ==> ctrl + c --> comment line
    //'prop' + tab + tab --> Create auto-implemented property
}


