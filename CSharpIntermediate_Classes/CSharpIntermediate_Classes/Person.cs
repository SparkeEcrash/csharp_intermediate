using System;

namespace CSharpIntermediate_Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    //cw + tab -> 'Console.WriteLine'
    //F9 -> Insert Breakpoint
    //ctrl + tab 'on class constructor' -> access class file
    //ctor + tab -> make constructor on class
    //click on class function + click on brush at the right of line number --> 'move to' creates new class file
    //ctrl + k ==> ctrl + c --> comment line
}


