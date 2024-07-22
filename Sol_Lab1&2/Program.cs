#region GreetingProgram
/*
 using System;

namespace GreetingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
 */
#endregion

#region ASCII Value Program
/*
using System;

namespace ASCIIValueProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine("\nThe ASCII code of " + character + " is: " + (int)character);
        }
    }
}

*/
#endregion


#region Days of the Week Array
/*
using System;

namespace DaysOfWeekArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Saturday", "Sunday" , "Monday" , "Tuesday", "Wednesday", "Thursday", "Friday" };

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
*/
#endregion

#region  Array Sum
/*
using System;

namespace ArraySummation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array values:");
            int sum = 0;
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
                sum += number;
            }
            Console.WriteLine("\nSum of array elements: " + sum);
        }
    }
}
*/
#endregion

#region Managed code vs Unmanaged code:
/*
   -- managed code : is the code [written by intermidite language (IL) , stored in hard desk] to allow cross platform because it is compiled by 
(JIT compiler) which exists in (CLR) to provide a native code in RunTime to execute your program.

-- Unmanged code : is the native code (0s & 1s) which interacts directly with your platform (OS & hard desk)
offering performance benefits but requiring careful memory management and error handling.
 */
#endregion

#region Student Structure

using System;

namespace StudentStructure
{
    struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Degree { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Degree: " + Degree);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 123,
                Name = "Belal Saied",
                Age = 20,
                Degree = "Computer Science"
            };

            student.PrintInformation();
        }
    }
}

#endregion