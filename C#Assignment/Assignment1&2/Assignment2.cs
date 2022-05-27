/*Test your Knowledge
1. When to use String vs. StringBuilder in C# ?
Since string is immutable, it’s good to store some sensitive data, such as username and password. String Builder is
mutable, usually it is used inside the method implementation, so that we can modify the text based on the needs ,
and convert the string builder into string once the operation finished.

2. What is the base class for all arrays in C#?
Object class
The Array class is the base class for all the arrays in C#. It is defined in the System namespace. 
The Array class provides various properties and methods to work with arrays.
 
3.How do you sort an array in C#?
Array.Sort() method

4.What property of an array object can be used to get the total number of elements in an array?
Array.Length property

5. Can you store multiple data types in System.Array?
If we create an object array, we are able to store multiple data types in an array
https://www.c-sharpcorner.com/UploadFile/955025/C-Sharp-interview-questions-part1/

6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()
System.Array.Clone() will return a shallow copy of the array. A shallow copy of an Array copies only the elements of
the Array, whether they are reference types or value types, but it does not copy the objects that the references refer
to. The references in the new Array point to the same objects that the references in the original Array point to.

System.Array.CopyTo() will copy all the elements of the current one-dimensional array to the specified onedimensional
array. This method copies all the elements of the current array instance to the destination array, starting
at index. The destination array must already have been dimensioned and must have a sufficient number of elements
to accommodate the copied elements. Otherwise, the method throws an exception.



/*Array practice
1. Copying an Array
Write code to create a copy of an array. First, start by creating an initial array. (You can use
whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
assign it a new array with 10 items in it. Use the things we’ve discussed to put some values
in the array.
 */


using System;
namespace CopyOfArray
{
    class Program
    {
        public void CopyAnArray(int[] array)
        {
            int[] newArr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
                Console.WriteLine($"The {i}th element of array is {array[i]}");
                Console.WriteLine($"The {i}th element of copied array is {newArr[i]}");
                Console.WriteLine();
            }
        }
    }
}


/*
2.Write a simple program that lets the user manage a list of elements. It can be a grocery list,
"to do" list, etc. Refer to Looping Based on a Logical Expression if necessary to see how to
implement an infinite loop.
 */


using System;
namespace ManageListOfElements
{
    class Program
    {
        public void ManageElements()
        {
            List<string> list = new List<string>();
            Console.Write("Enter command (+ item, - item or -- to clear): ");
            string operation = Console.ReadLine();
            while (operation != null)
            {
                switch (operation)
                {
                    case "+":
                        Console.Write("Please enter the element: ");
                        list.Add(Console.ReadLine());
                        Console.WriteLine($"The current list is: ");
                        foreach (var item in list)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case "-":
                        list.RemoveAt(list.Count - 1);
                        Console.WriteLine($"The current list is: {list}");
                        Console.WriteLine($"The current list is: ");
                        foreach (var item in list)
                        {
                            Console.Write(item + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case "--":
                        list.Clear();
                        Console.WriteLine("You have removed all the elements");
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine("Insert another input to Continue: ");
                operation = Console.ReadLine();
            }
        }
    }
}



/*
3.Write a method that calculates all prime numbers in given range and returns them as array
of integers 
 */

using System;
namespace CalcAllPM
{
    class Program
    {
        public void ManageElements()
        {
            public int[] FindPrimesInRange(int startNum, int endNum)
            {
                if (startNum <= 0 || endNum <= 0 || startNum > endNum)
                {
                    return null;
                }
                List<int> res = new List<int>();
                for (int i = startNum; i <= endNum; i++)
                {
                    if (CheckPrime(i))
                    {
                        res.Add(i);
                    }
                    else
                    {
                        continue;
                    }
                }
                return res.ToArray();
            }
            private bool CheckPrime(int a)
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            //call FindPrimesInRange in program.cs:
            DayTwoSolution solution = new DayTwoSolution(); 
            // I implement this method inside DayTwoSolution class
            int[] res = solution.FindPrimesInRange(2, 20);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}




/*
4.Write a program to read an array of n integers (space separated on a single line) and an
integer k, rotate the array right k times and sum the obtained arrays after each rotation as
shown below.
 */

using System;
namespace ReadArrayOfNInt
{
    class Program
    {
        public int[] SumAfterRotation(int[] arr, int k)
        {
            int times = k / arr.Length;
            int move = k % arr.Length;
            int sum = 0;
            int[] res = new int[arr.Length];
            foreach (var item in arr)
            {
                sum = sum + item;
            }
            sum = sum * times;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= move; j++)
                {
                    if (i - j >= 0)
                    {
                        res[i] = res[i] + arr[i - j];
                    }
                    else
                    {
                        res[i] = res[i] + arr[i - j + arr.Length];
                    }
                }
                res[i] = sum + res[i];
            }
            return res;
        }
    }
}




/*
5.Write a program that finds the longest sequence of equal elements in an array of integers.
If several longest sequences exist, print the leftmost one.
 */


using System;
namespace LongestSquence
{
    class Program
    {
        public int[] LongestSequence(int[] arr)
        {
            int num = arr[0];
            int maxCount = 1;
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        num = arr[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }
            int[] res = new int[maxCount];
            Array.Fill(res, num);
            return res;
        }
    }
}


/*
6&7.Write a program that finds the most frequent number in a given sequence of numbers. In
case of multiple numbers with the same maximal frequency, print the leftmost of them
 */

using System;
namespace MostFrequentNumber
{
    class Program
    {
        public void MostFrequentNumber(int[] arr)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int leftmost = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!freq.ContainsKey(arr[i]))
                {
                    freq.Add(arr[i], 1);
                    firstOccurrence.Add(arr[i], i);
                }
                else
                {
                    freq[arr[i]]++;
                }
            }
            int mostFreq = freq.Values.Max();
            int num = -1;
            foreach (var key in freq.Keys)
            {
                if (freq[key] == mostFreq && firstOccurrence[key] < leftmost)
                {
                    leftmost = firstOccurrence[key];
                    num = arr[leftmost];
                }
            }
            Console.WriteLine($"The number {num} is the most frequent (occurs {mostFreq} times)");
        }
    }
}





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
using System;
namespace ReverseString
{
    class Program
    {
        public string ReverseStringOne(string s)
        {
            if (s == null)
            {
                return string.Empty;
            }
            char[] chars = s.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            string res = new string(chars);
            return res;
        }
    }
}





/*
2.Write a program that reverses the words in a given sentence without changing the
punctuation and spaces
 */

using System;
namespace ReverseWords
{
    class Program
    {
        public string ReverseWords(string s)
        {
            if (s == null)
            {
                return string.Empty;
            }
            char[] separators = new char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '/', '\\', '!', '?', ' ' };
            char[] chars = s.ToCharArray();
            int n = chars.Length;
            bool isWord = true;
            StringBuilder sb = new StringBuilder();
            List<string> wordsList = new List<string>();
            List<string> separatorList = new List<string>();
            foreach (var c in chars)
            {
                if (isWord)
                {
                    if (separators.Contains(c))
                    {
                        wordsList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                }
                else
                {
                    if (!separators.Contains(c))
                    {
                        separatorList.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                }
                sb.Append(c);
            }
            separatorList.Add(sb.ToString());
            sb.Clear();
            int m = wordsList.Count();
            for (int i = 0; i < m; i++)
            {
                sb.Append(wordsList[m - 1 - i]);
                sb.Append(separatorList[i]);
            }
            return sb.ToString();
        }
    }
}


/*
3.Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
and prints them on the console on a single line, separated by comma and space.Print all
unique palindromes (no duplicates), sorted.
 */
using System;
namespace ExtractText
{
    class Program
    {
        public string[] FindPalindrome(string s)
        {
            if (s == null)
            {
                return null;
            }
            HashSet<string> wordsSet = new HashSet<string>();
            bool isWord = true;
            StringBuilder sb = new StringBuilder();
            char[] chars = s.ToCharArray();
            foreach (var c in chars)
            {
                if (isWord)
                {
                    if (!char.IsLetter(c))
                    {
                        wordsSet.Add(sb.ToString());
                        sb.Clear();
                        isWord = !isWord;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (char.IsLetter(c))
                    {
                        sb.Append(c);
                        isWord = !isWord;
                    }
                }
            }
            foreach (var word in wordsSet)
            {
                if (!IsPalindrome(word))
                {
                    wordsSet.Remove(word);
                }
            }
            return wordsSet.ToArray();
        }
        private bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}

/*
4.Write a program that parses an URL given in the following format:
 */
using System;
namespace ParseURL
{
    class Program
    {
        public void ParseUrl(string url)
        {
            char[] seperator = new char[] { ':', '/', '/' };
            int i = url.IndexOfAny(seperator);
            string protocal, secondHalf;
            if (i != -1)
            {
                protocal = url.Substring(0, i);
                secondHalf = url.Substring(i + 3);
            }
            else
            {
                protocal = " ";
                secondHalf = url;
            }
            string[] temp = secondHalf.Split('/');
            string server = temp[0];
            string resource;
            if (temp.Length > 1)
            {
                resource = temp[1];
            }
            else
            {
                resource = " ";
            }
            Console.WriteLine($"[protocal] = {protocal}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
        }
    }
}
