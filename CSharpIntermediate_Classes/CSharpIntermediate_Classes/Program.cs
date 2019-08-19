using System;

namespace CSharpIntermediate_Classes
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //useConstructors();
            //usePoints();
            //useParams();
            //tryParse();
            //tryParseLongVersion();
            //useAccessModifiers();
            //useProperties();
            //useIndexer();

            
        }

        static void useIndexer()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
        }

        static void useProperties()
        {
            var person = new PersonDate(new DateTime(1982, 1, 1));

            Console.WriteLine(person.Birthdate);
            //use "person.Birthdate" 
            //to get birthdate variable using the {get; set;} in the property
            Console.WriteLine(person.Age);

            //person.Birthdate = new DateTime(1999, 2, 2);
            //"person.Birthdate = ***"
            //cannot be used because the "set" in {get; private set;}
            ///is set to private and can only be used in the constructor
        }

        static void useAccessModifiers()
        {
            var person = new PersonDate();
            person.SetBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }

        static void readOnly()
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote(); //this re-initializes Orders and empties out data
            Console.WriteLine(customer.Orders.Count);
            //should be two but returns zero
        }

        static void tryParse()
        {
            int number;
            var result = int.TryParse("abc", out number); //number is the parsed int value after parsing successfully
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        static void tryParseLongVersion()
        {
            try
            {
                var number = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }
        }

        static void useConstructors()
        {
            // var person = new Person();
            // person.Name = "John";
            var person = Person.Parse("John");
            person.Introduce("Mosh");

            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            //customer.Orders = new List<Order>(); //this is incorrect 
            customer.Orders.Add(order);
        }
        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void usePoints()
        {
            try
            {
                //Method overloads
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(null);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
                //throw;
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


