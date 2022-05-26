/*PART I
 * Test your Knowledge
  1. What type would you choose for the following “numbers”?
    A person's telephone number--Int
    A person's height--Double
    A person's age--Int
    A person's gender--Male, Female, Transgender, Gender Neutral, Non-Binary, Agender, Pangender, Genderqueer, Two-Spirit, Third Gender. 
    A person's salary--Decimal
    A book's ISBN--Int
    A book's price--Deciaml 
    A book's shipping weight--Double 
    A country’s population--Int
    The number of stars in the universe--Long 
    The number of employees in each of the small or medium businesses in the United Kingdom 
    (up to about 50,000 employees per business)--Int

  2.What are the difference between value type and reference type variables? What is boxing and unboxing?
    Value type 
        - int, float, double, bool.
        - Direct contain their data.
        - Each has its own copy of data.
        - operation on one can not effect another.
    reference type
        - string, stringBuilder, object.
        - store references to their data (kown as objects).
        - two reference variable can reference the same object.
        - operation on one can effect another.
    boxing - convert a value type to a reference type.
    unboxing - convert the reference type to a value type.
  3. What is meant by the terms managed resource and unmanaged resource in .NET
    managed resource - directly under the control of the garbage collector
    unmanaged resource - not directly under the control of the garbage collector. 
  4. Whats the purpose of Garbage Collector in .NET?
    
    Garbage Collector: automatic memory manager
      •Benefits:
        •Don’t need to manually release memory
        •Allocates objects on managed heap efficiently*/

/*Practice number sizes and ranges
1. Create a console application project named /02UnderstandingTypes/ that outputs the
number of bytes in memory that each of the following number types uses, and the
minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.*/


//using System;
//namespace Practice01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("--------------------------------------------------------------------------");
//            Console.WriteLine("Type    Byte(s) of memory               Min                            Max");
//            Console.WriteLine("--------------------------------------------------------------------------");
//            Console.WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
//            Console.WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
//            Console.WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
//            Console.WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
//            Console.WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
//            Console.WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
//            Console.WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
//            Console.WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
//            Console.WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
//            Console.WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
//            Console.WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
//            Console.WriteLine("--------------------------------------------------------------------------");
//        }
//    }
//}



/*2. Write program to enter an integer number of centuries and convert it to years, days, hours,
minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
type for every data conversion. Beware of overflows!*/
//using System;
//public class CenturiesAndConvert
//{
//    public static void Main()
//    {
//        int centuries = Convert.ToInt32(Console.ReadLine());
//        int years = centuries * 100;
//        int days = (int)(years * 365.2422);
//        long hours = (long)(days * 24);
//        long minutes = hours * 60;
//        ulong seconds = (ulong)(minutes * 60);
//        ulong miliseconds = (ulong)(seconds * 1000);
//        ulong microseconds = miliseconds * 1000;
//        ulong nanoseconds = microseconds * 1000;

//        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
//    }
//}


/*PART II
 * 
1. What happens when you divide an int variable by 0?
    Error.

2. What happens when you divide a double variable by 0?
    Undefined.

3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
    If an integer addition overflows, then the result is the low-order bits of the mathematical sum as 
    represented in some sufficiently large two's-complement format. If overflow occurs, 
    then the sign of the result is not the same as the sign of the mathematical sum of the two operand values.

4. What is the difference between x = y++; and x = ++y;?
    y++ is post increment and ++x is pre increment. y++ value is incremented after value assign or printed.

5.What is the difference between break, continue, and return when used inside a loop statement?
    break statement - A loop control statement that is used to terminate the loop..
    continue statement - pposite to that of break statement, instead of terminating the loop, 
                         it forces to execute the next iteration of the loop.
    return statement - Ends the execution of a function, and returns control to the calling function.

6. What are the three parts of a for statement and which of them are required?
    The keyword For that starts the loop, the condition being tested, and the EndFor keyword that terminates the loop.

7. What is the difference between the = and == operators?
    The “=” is an assignment operator is used to assign the value on the right to the variable on the left. 
    The '==' operator checks whether the two given operands are equal or not.

8. Does the following statement compile? for ( ; true; ) ;
    No

9.What does the underscore _ represent in a switch expression?
    The underscore (_) character replaces the default keyword to signify that it should match anything if reached.. 
10. What interface must an object implement to be enumerated over by using the foreach statement ?
    The IEnumerable interface provides support for the foreach iteration
*/





/*Practice loops and operators
1. FizzBuzzis a group word game for children to teach them about division. Players take turns
to count incrementally, replacing any number divisible by three with the word /fizz/, any
number divisible by five with the word /buzz/, and any number divisible by both with /
fizzbuzz/.
Create a console application in Chapter03 named Exercise03 that outputs a simulated
FizzBuzz game counting up to 100. The output should look something like the following
screenshot:
What will happen if this code executes?

 
* int max = 500;
for (byte i = 0; i<max; i++)
{
    if (i%3 == 0)
    {
        Console.WriteLine("fizz");
    }else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");    
    }else if(i%3 == 3 && i%5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}*/


/*2.Print-a-Pyramid.Like the star pattern examples that we saw earlier, create a program that
will print the following pattern: If you find yourself getting stuck, try recreating the two
examples that we just talked about in this chapter first. They’re simpler, and you can
compare your results with the code included above.
This can actually be a pretty challenging problem, so here is a hint to get you going. I used
three total loops. One big one contains two smaller loops. The bigger loop goes from line
to line. The first of the two inner loops prints the correct number of spaces, while the
second inner loop prints out the correct number of stars.


 * int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("guest a number between 1 and 3");
string guess = Console.ReadLine();
int g = Convert.ToInt32(guess);
if( g > correctNumber)
{
    Console.WriteLine("smaller");
}
else if ( g < correctNumber)
{
    Console.WriteLine("larger");
}
else
{
    Console.WriteLine("bingo");
}*/


/*3. Write a program that generates a random number between 1 and 3 and asks the user to
guess what the number is. Tell the user if they guess low, high, or get the correct answer.
Also, tell the user if their answer is outside of the range of numbers that are valid guesses
(less than 1 or more than 3). You can convert the user's typed answer from a string to an
int using this code:
*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        int layer = 6, space, star;

//        for (int i = 1; i <= layer; i++)
//        {
//            for(space = 1; space <= layer - i; space++)
//            {
//                Console.Write(" ");
//            }
//            for(star = 1; star <= i *2 -1; star++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

/*4.Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
For extra credit, output the date of their next 10,000 day (about 27 years) anniversary.
Note: once you figure out their age in days, you can calculate the days until the next
anniversary using int daysToNextAnniversary = 10000 - (days % 10000);
*/

//class Program
//{
//    static void Main(string[] args)
//    {   
//        int correctNumber = new Random().Next(3) + 1;

//        Console.WriteLine("guess a number between 1 and 3");
//        int guessedNumber = int.Parse(Console.ReadLine());

//        while (guessedNumber != correctNumber)
//        {
//            if (guessedNumber > correctNumber)
//            {
//                Console.WriteLine("smaller");
//                break;
//            }
//            else if (guessedNumber < correctNumber)
//            {
//                Console.WriteLine("larger");
//                break;
//            }
//            else if(guessedNumber>3 || guessedNumber < 1)
//            {
//                Console.WriteLine("out of range");
//            }
//        }
//        Console.WriteLine("bingo");
//    }
//}


/*5.Write a program that greets the user using the appropriate greeting for the time of day.
Use only if , not else or switch , statements to do so. Be sure to include the following
greetings
*/

//using System;

//namespace ConsoleApplication
//{
//	public class Program
//	{
//		public static void Main()
//		{


//			DateTime currentDateTime = DateTime.Now;
//			//DateTime currentDateTime = new DateTime(2017, 9, 3, 8, 4, 0); //Test data
//			int currentHour = currentDateTime.Hour;
//			int startMorningHour = 6;
//			int startAfternoonHour = 12;
//			int startEveningHour = 17;
//			int startNightHour = 22;

//			if (startMorningHour <= currentHour && currentHour < startAfternoonHour)
//			{
//				Console.WriteLine("Good morning!");
//			}

//			;
//			if (startAfternoonHour <= currentHour && currentHour < startEveningHour)
//			{
//				Console.WriteLine("Good Afternoon!");
//			}

//			;
//			if (startEveningHour <= currentHour && currentHour < startNightHour)
//			{
//				Console.WriteLine("Good Evening!");
//			}

//			;
//			if (startNightHour <= currentHour || currentHour < startMorningHour)
//			{
//				Console.WriteLine("Good Night!");
//			}

//			;

//			Console.WriteLine("Right now it is {0}:{1} o'clock.", currentDateTime.Hour, currentDateTime.Minute);
//		}
//	}
//}


/*6.Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.
*/

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        CountTo24();
//    }

//    private static void CountTo24()
//    {
//        for (int countBase = 1; countBase <= 24; countBase += 1)
//        {
//            Console.Write(countBase.ToString().PadLeft(4) + "|");
//            for (int countUp = 0; countUp <= 24; countUp += countBase)
//            {
//                Console.Write(countUp.ToString().PadLeft(4));
//            }

//            Console.WriteLine();
//        }
//    }
//}