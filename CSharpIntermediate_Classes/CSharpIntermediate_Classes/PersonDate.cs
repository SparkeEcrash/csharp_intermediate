using System;

namespace CSharpIntermediate_Classes
{
    public class PersonDate
    {
        /////////////////////SHORT VERSION
        //ONE LINE SHORTCUT WITH _birthdate AUTO CREATED BY COMPILER AS PRIVATE VARIABLE
        public DateTime Birthdate { get; private set; }
        //with "private" before "set"... the set function can only be used in 
        //the constructor for this class at line 13

        public PersonDate(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


        /*public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }*/

        public int Age //does not have a set method
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }





        ///////////////////LONG VERSION
        public PersonDate()
        {
        }

        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
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


