namespace Day8_Line_Comparison_Problem_using_OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Welcome to Line Comparison Problem using OOPS!!!");

            //Find length of line
             FindLength obj = new FindLength(-6, 4, -4, 6);
             double length = obj.FindingLength();
             Console.WriteLine("Length of Line is: " + length);

            //Check equality of two lines
            CheckEquality obj1 = new CheckEquality(4,3,2,-7);
            double length1 = obj1.FindingLength1();
            CheckEquality obj2 = new CheckEquality(5,1,9,7);
            double length2 = obj2.FindingLength1();

            Console.WriteLine("Length of First Line " + length1);
            Console.WriteLine("Length of Second Line " + length2);
            obj1.EqualityMethod(length1.ToString(), length2.ToString());

        }
    }
}