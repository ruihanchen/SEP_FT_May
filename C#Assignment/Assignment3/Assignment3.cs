/*
 * Test your knowledge
1. What are the six combinations of access modifier keywords and what do they do? 
a.Public: Objects that implement public access modifiers are accessible from everywhere in a project without 
any restrictions.
b.Private: Objects that implement private access modifier are accessible only inside a class or a structure. 
c.Protected: The protected keyword implies that the object is accessible inside the class and in all classes 
that derive from that class.
d.Internal: For Internal keyword, the access is limited exclusively to classes defined within the current project assembly.
e.Protected Internal: The protected internal access modifier is a combination of protected and internal.
f.Private Protected: The private protected access modifier is a combination of the private and protected keywords.

2. What is the difference between the static, const, and readonly keywords when applied to
a type member?
The value of readonly field can be changed.
The const variable is basically used for declaring a constant value that cannot be modified. 
A static keyword is been used to declare a variable or a method as static.

3. What does a constructor do?
Initializes a newly created object of that type.

4. Why is the partial keyword useful?
The partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace.

5. What is a tuple?
A tuple is a data structure that contains a sequence of elements of different data types.

6. What does the C# record keyword do?
Define a reference type that provides built-in functionality for encapsulating data.

7. What does overloading and overriding mean?
Overriding is to provide a specific implementation in a derived class method for a method already existing in the base class. 
Overloading is to create multiple methods with the same name with different implementations.

8. What is the difference between a field and a property?
A field is a variable of any type that is declared directly in a class or struct.
Properties are methods and as such there are certain things that are not supported for properties, 
and some things that may happen with properties but never in the case of fields.

9. How do you make a method parameter optional?
By using default value,By using Method Overloading,By using OptionalAttribute,By Params Keyword.

10. What is an interface and how is it different from abstract class?
An abstract class permits you to make functionality that subclasses 
can implement or override whereas an interface only permits you to state functionality but not to implement it.

11. What accessibility level are members of an interface?
The access level for class members and struct members, including nested classes and structs, is private by default. 
Private nested types are not accessible from outside the containing type.

12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
15. True/False. Abstract methods can be used in a normal (non-abstract) class. 16.
True/False. Normal (non-abstract) methods can be used in an abstract class. 17. True/False.
Derived classes can override methods that were virtual in the base class. 18. True/False.
Derived classes can override methods that were abstract in the base class. 19. True/False.
In a derived class, you can override a method that was neither virtual non abstract in the
base class.
20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
22. True/False. A class can have more than one base class.
23. True/False. A class can implement more than one interface.*/


/*
 * Working with methods
1. Let’s make a program that uses methods to accomplish a task. Let’s take an array and
reverse the contents of it. For example, if you have 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, it would
become 10, 9, 8, 7, 6, 5, 4, 3, 2, 1.
To accomplish this, you’ll create three methods: one to create the array, one to reverse the
array, and one to print the array at the end.
Your Mainmethod will look something like this:*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(3);
            Reverse(ref numbers); // to test
            PrintNumbers(numbers);

        }
        public static int[] Reverse(ref int[] arr)
        {

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }
        public static int[] GenerateNumbers(int length)
        {
            int[] arrOfNumbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrOfNumbers[i] = i;
            }

            return arrOfNumbers;
        }

        public static void PrintNumbers(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}












/*
2. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
and every other number in the sequence after it is the sum of the two numbers before it. So
the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
number: 2 + 3 = 5. This keeps going forever.*/

namespace _18.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
        }

        public static int Fibonacci(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            return num + Fibonacci(num - 1);
        }
    }
}




/*
Designing and Building Classes using object-oriented principles
1. Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism/.*/

public class Humanbeing
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        Console.Write("How many people are to be stored?: ");

        int personCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= personCount; i++)
        {
            Console.Write("Name of person " + i + ":");
            string nameInput = Console.ReadLine();
            Console.Write("Age of " + nameInput + ": ");
            int ageInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height of " + nameInput + ": ");
            double heightInput = Convert.ToDouble(Console.ReadLine());
            Console.Write("Weight of " + nameInput + ": ");
            double weightInput = Convert.ToDouble(Console.ReadLine());
            people.Add(new Person(nameInput, ageInput, heightInput, weightInput));
        }

        // here goes (i think) the code to type info stored in list

        Console.WriteLine("Press ENTER to close.");

        Console.ReadLine();
    }
}
class Person
{
    public string name;
    public int age;
    public double height;
    public double weight;

    public Person(string name, int age, double height, double weight)
    {
        this.name = name;
        this.age = age;
        this.height = height;
        this.weight = weight;
    }
}


/*2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.*/



/*3. Use /Encapsulation/ to keep many details private in each class.*/



/*4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes*/.



/*5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.*/





/*6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
person specific methods). IStudentService, IInstructorService should inherit from
IPersonService.
Person*/



/*7. Try creating the two classes below, and make a simple program to work with them, as
described below*/



