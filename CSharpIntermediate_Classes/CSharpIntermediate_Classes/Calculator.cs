namespace CSharpIntermediate_Classes
{
    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
    //cw + tab -> 'Console.WriteLine'
    //F9 -> Insert Breakpoint
    //ctrl + tab 'on class constructor' -> access class file
    //ctor + tab -> make constructor on class
    //click on class function + click on brush at the right of line number --> 'move to' creates new class file
    //ctrl + k ==> ctrl + c --> comment line
}


