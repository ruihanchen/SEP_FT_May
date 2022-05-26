/*Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
If a string is going to remain constant throughout the program, then use String class object because a String object is immutable.
If a string can change (example: lots of logic and operations in the construction of the string) then using a StringBuilder is the best option.

2. What is the base class for all arrays in C#?
The Array class is the base class for all the arrays in C#. It is defined in the System namespace. 
The Array class provides various properties and methods to work with arrays.
 
3.How do you sort an array in C#?
 We can sort a one-dimensional array in two ways, using Array. Sort() method and using LINQ query

4.What property of an array object can be used to get the total number of elements in an array?
The length property of an object which is an instance of type Array sets or returns the number of elements in that array.

5. Can you store multiple data types in System.Array?
We can't store multiple datatype in an Array, we can store similar datatype only in an Array.
6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()

The Clone() method returns a new array (a shallow copy) object containing all the elements in the original array. 
The CopyTo() method copies the elements into another existing array. Both perform a shallow copy. 



/*Array practice
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
 */


//char[] firstArray = new char[10] { 'x', 'g', 'z', 'd', 'b', 'n', 'f', 's', 'h', 'e' };
//char[] secondArray = new char[firstArray.Length];

//for (int i = 0; i < firstArray.Length; i++)
//{
//    secondArray[i] = firstArray[i];
//}

//Console.WriteLine(secondArray);
//Console.ReadLine();



/*
2.Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop.
 */


//public int RemoveElement(int[] nums, int val)
//{
//    if (nums == null || nums.Length == 0)
//        return 0;

//    int slowIndex = 0, fastIndex = 0;

//    while (slowIndex <= nums.Length - 1 && fastIndex <= nums.Length - 1)
//    {
//        if (nums[fastIndex] != val)
//        {
//            nums[slowIndex] = nums[fastIndex];
//            slowIndex++;
//            fastIndex++;
//        }
//        else
//            fastIndex++;
//    }

//    return slowIndex;
//}



/*
3.Write a method that calculates all prime numbers in given range and returns them as array
of integers 
 */

//int start = 1, end = 100;
//Console.WriteLine($"The prime numbers between {start} and {end} are :");

//var numbers = Enumerable.Range(start, end - start)
//                        .Where(IsPrime)
//                        .Select(number => number)
//                        .ToList();

//Console.WriteLine(string.Join(", ", numbers));

//bool IsPrime(int number)
//{
//    // local function
//    bool CalculatePrime(int value)
//    {
//        var possibleFactors = Math.Sqrt(number);
//        for (var factor = 2; factor <= possibleFactors; factor++)
//        {
//            if (value % factor == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//    return number > 1 && CalculatePrime(number);
//}




/*
4.Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
 */

//public class rRotateSum {
//    static void Rotate(int[] a, int k)
//    {
//        k = k % a.Length;
//        reverse(a, 0, a.Length - 1);
//        reverse(a, 0, k - 1);
//        reverse(a, k, a.Length - 1);
//    }
//    static void reverse(int[] a, int s, int e)
//    {
//        while (s < e)
//        {
//            int temp = a[s];
//            a[s] = a[e];
//            a[e] = temp;
//            s++;
//            e--;
//        }
//    }

//}




/*
5.Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.
 */


//int[] numbers = new[] { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

//int count = 1;
//int longestNum = numbers[0];
//int longestCount = 1;

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] != numbers[i - 1])
//    {
//        count = 0;
//    }
//    count++;

//    if (count > longestCount)
//    {
//        longestCount = count;
//        longestNum = numbers[i];
//    }
//}
//Console.WriteLine(string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));


/*
6&7.Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
 */

//int startNum, endNum;

//static int[] FindPrimesInRange(startNum, endNum)
//{
//    for (int i = startNum; i < endNum; i++)
//    {
//        for (int j = 2; j <= i / 2; j++)
//        {
//            if (i % j == 0)
//            {
//                Console.WriteLine();
//                break;
//            }
//        }
//    }
//}





//Practice Strings
/*
1. Write a program that reads a string from the console, reverses its letters and prints the
result back at the console.
 */


//public void ReverseString(char[] s)
//{
//	var n = s.Length;

//	for (var i = 0; i < n / 2; i++)
//	{
//		var temp = s[i];
//		s[i] = s[n - i - 1];
//		s[n - i - 1] = temp;
//	}
//}




/*
Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
 */

//{
//    class Program
//{
//    static void Main(string[] args)
//    {
//        Console.ForegroundColor = ConsoleColor.White;
//        Console.WriteLine("Eneter the String:");
//        Console.ForegroundColor = ConsoleColor.Yellow;
//        string s = Console.ReadLine();
//        string[] a = s.Split(' ');
//        Array.Reverse(a);
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Reverse String is:");
//        for (int i = 0; i <= a.Length - 1; i++)
//        {
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.Write(a[i] + "" + ' ');
//        }
//        Console.ReadKey();
//    }
//}
//}


/*
3.Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted.
 */
//var text = Console.ReadLine().ToCharArray();
//foreach (var letter in text)
//    (
//        Console.Write(string.Join(",", $ "\\ u {(int) letter: x4}"));
//                // print without space and without a comma like this \ u0048 \ u0069 \ u0021
//            }

/*
4.Write a program that parses an URL given in the following format:
 */
//string path = "https://docs.microsoft.com/en-us/dotnet/api/system.uri.scheme?view=net-6.0";
//Uri uri = new Uri(path);
//Console.WriteLine(uri.Scheme); 
//Console.WriteLine(uri.Host);
//Console.WriteLine(uri.AbsolutePath);
