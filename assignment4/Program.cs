#region Q1
//Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
//passing by Value creates a copy of the variable, so the original value is not affected.
//Passing by Reference passes the actual reference to the variable, so changes inside the function affect the original value.
/*

//////////////Passing by Value/////////////
using System;

class Program
{
    static void ModifyValue(int number)
    {
        number = number + 10;
        Console.WriteLine("Inside ModifyValue method: " + number);
    }

    static void Main(string[] args)
    {
        int value = 5;
        ModifyValue(value);
        Console.WriteLine("Inside Main method: " + value); // Original value is unchanged
    }
}



Difference Between Passing by Value and Passing by Reference:
Passing by Value:

When a parameter is passed by value, a copy of the argument is passed to the function. Any changes made to the parameter inside the function do not affect the original value.
It is the default behavior for value types (like int, float, char, etc.).
Passing by Reference:

When a parameter is passed by reference, the reference (or memory address) of the argument is passed to the function. This means any changes made to the parameter inside the function will affect the original value.
This is achieved using the ref or out keyword.
Example:
Passing by Value:
csharp
Copy code
using System;

class Program
{
    static void ModifyValue(int number)
    {
        number = number + 10;
        Console.WriteLine("Inside ModifyValue method: " + number);
    }

    static void Main(string[] args)
    {
        int value = 5;
        ModifyValue(value);
        Console.WriteLine("Inside Main method: " + value); // Original value is unchanged
    }
}
/////////////////////////////////////////////////
using System;

class Program
{
    static void ModifyValue(ref int number)
    {
        number = number + 10;
        Console.WriteLine("Inside ModifyValue method: " + number);
    }

    static void Main(string[] args)
    {
        int value = 5;
        ModifyValue(ref value);
        Console.WriteLine("Inside Main method: " + value); // Original value is changed
    }
}
*/
#endregion
#region Q2
/*
Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

Passing Reference Type by Value: The reference to the object is passed by value, so changes to the object's fields will affect the original
object, but reassigning the reference to a new object inside the method won't affect the original reference.
Passing Reference Type by Reference: The reference itself is passed by reference (using ref or out), so changes to both the object 
and the reference itself will affect the original reference and object outside the method.


///////////Passing Reference Type Parameter by Value:///
using System;

class Person
{
    public string Name;
}

class Program
{
    static void ModifyPerson(Person person)
    {
        person.Name = "John"; // This will modify the original object's property
        person = new Person(); // This won't affect the original reference
        person.Name = "Doe"; // This changes the new object, not the original one
        Console.WriteLine("Inside ModifyPerson method: " + person.Name);
    }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Alice";
        ModifyPerson(person);
        Console.WriteLine("Inside Main method: " + person.Name); // The original object is modified
    }
}

///////////////Passing Reference Type Parameter by Reference://////////////////

using System;

class Person
{
    public string Name;
}

class Program
{
    static void ModifyPerson(ref Person person)
    {
        person.Name = "John"; // This modifies the original object's property
        person = new Person(); // This modifies the original reference
        person.Name = "Doe"; // This changes the new object, which is now pointed to by the original reference
        Console.WriteLine("Inside ModifyPerson method: " + person.Name);
    }

    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Alice";
        ModifyPerson(ref person);
        Console.WriteLine("Inside Main method: " + person.Name); // The original reference and object are modified
    }
}
*/
#endregion
#region Q3
/*
Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        int num4 = int.Parse(Console.ReadLine());

        int summation = num1 + num2 + num3 + num4;
        int subtraction = num1 - num2 - num3 - num4;

        Console.WriteLine("Summation result: " + summation);
        Console.WriteLine("Subtraction result: " + subtraction);
    }
}










*/
#endregion
#region Q4
/*
 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like 
        Enter a number: 25                                                                                            
        The sum of the digits of the number 25 is: 7
using System;

class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        
        // Loop through each digit and add it to the sum
        while (number > 0)
        {
            sum += number % 10;  // Get the last digit
            number /= 10;         // Remove the last digit
        }
        
        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = SumOfDigits(number);

        Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
    }
}






*/
#endregion
#region Q5
/*
 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a prime number.");
        }
    }
}



*/
#endregion
#region Q6
/*
Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
using System;

class Program
{
    static void MinMaxArray(int[] arr, ref int min, ref int max)
    {
        min = arr[0];
        max = arr[0];

        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
            if (num > max)
            {
                max = num;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 3, 7, 15, 2, 8 };
        int min = 0;
        int max = 0;

        MinMaxArray(arr, ref min, ref max);

        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine($"Maximum value: {max}");
    }
}

*/
#endregion
#region Q7
/*
 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
using System;

class Program
{
    static int Factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = Factorial(number);

        Console.WriteLine($"The factorial of {number} is: {result}");
    }
}



*/
#endregion
#region Q8
/*
 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
using System;

class Program
{
    static string ChangeChar(string str, int position, char newChar)
    {
        if (position < 0 || position >= str.Length)
        {
            return str;  
        }

        char[] strArray = str.ToCharArray();
        strArray[position] = newChar;

        return new string(strArray);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the position to change (0 based): ");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Enter the new character: ");
        char newChar = Console.ReadLine()[0];

        string modifiedString = ChangeChar(inputString, position, newChar);

        Console.WriteLine($"Modified string: {modifiedString}");
    }
}



*/
#endregion
#region Q9
/*
 Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the
identity table of size n * n.
using System;

class Program
{
    static void PrintIdentityMatrix(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the size of the matrix (n): ");
        int n = int.Parse(Console.ReadLine());
        PrintIdentityMatrix(n);
    }
}



*/
#endregion
#region Q10
/*
 Write a program in C# Sharp to find the sum of all elements of the array.
using System;

class Program
{
    static int SumOfArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int result = SumOfArray(arr);
        Console.WriteLine("Sum of all elements in the array: " + result);
    }
}


*/
#endregion
#region Q11
/*
  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
using System;

class Program
{
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                mergedArray[k++] = arr1[i++];
            }
            else
            {
                mergedArray[k++] = arr2[j++];
            }
        }

        while (i < arr1.Length)
        {
            mergedArray[k++] = arr1[i++];
        }

        while (j < arr2.Length)
        {
            mergedArray[k++] = arr2[j++];
        }

        return mergedArray;
    }

    static void Main(string[] args)
    {
        int[] arr1 = { 1, 3, 5, 7 };
        int[] arr2 = { 2, 4, 6, 8 };

        int[] mergedArray = MergeArrays(arr1, arr2);

        Console.WriteLine("Merged array:");
        foreach (int item in mergedArray)
        {
            Console.Write(item + " ");
        }
    }
}



*/
#endregion
#region Q12
/*
  Write a program in C# Sharp to count the frequency of each element of an array.
using System;
using System.Collections.Generic;

class Program
{
    static void CountFrequency(int[] arr)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in arr)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        foreach (var item in frequencyMap)
        {
            Console.WriteLine($"Element {item.Key} appears {item.Value} time(s).");
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        CountFrequency(arr);
    }
}



*/

#endregion
#region Q13
/*
  Write a program in C# Sharp to find maximum and minimum element in an array
using System;

class Program
{
    static void FindMaxMin(int[] arr, out int max, out int min)
    {
        max = arr[0];
        min = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 2, 34, 4, 50, 12, 7 };
        int max, min;

        FindMaxMin(arr, out max, out min);

        Console.WriteLine($"Maximum element: {max}");
        Console.WriteLine($"Minimum element: {min}");
    }
}



*/
#endregion
#region Q14
/*
  Write a program in C# Sharp to find the second largest element in an array.
using System;

class Program
{
    static int FindSecondLargest(int[] arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 20, 4, 45, 99, 45 };
        int secondLargest = FindSecondLargest(arr);

        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("There is no second largest element.");
        }
        else
        {
            Console.WriteLine($"The second largest element is: {secondLargest}");
        }
    }
}

*/
#endregion
#region Q15
/*
  Consider an Array of Integer values with size N, having values as    
 in this Example
using System;
using System.Collections.Generic;

class Program
{
    static int LongestDistance(int[] arr)
    {
        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        int longestDistance = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (firstOccurrence.ContainsKey(arr[i]))
            {
                int distance = i - firstOccurrence[arr[i]] - 1;
                if (distance > longestDistance)
                {
                    longestDistance = distance;
                }
            }
            else
            {
                firstOccurrence[arr[i]] = i;
            }
        }

        return longestDistance;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the size of the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int result = LongestDistance(arr);

        Console.WriteLine($"The longest distance between two equal cells is: {result}");
    }
}




 */
#endregion
#region Q17
/*
 Given a list of space separated words, reverse the order of the words.

Input: this is a test		Output: test a is this
Input: all your base		Output: base your all
Input: Word			Output: Word
Note : 
Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of space-separated words:");
        string input = Console.ReadLine();

        string[] words = input.Split(' '); // Split the string into words
        Array.Reverse(words); // Reverse the order of the words

        Console.WriteLine(string.Join(" ", words)); // Join the words back into a string and print
    }
}

 */
#endregion
#region Q18
/*
  Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows and columns for the arrays:");

        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] firstArray = new int[rows, cols];
        int[,] secondArray = new int[rows, cols];

        Console.WriteLine("Enter the values for the first array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter value for position ({i}, {j}): ");
                firstArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Copy elements from first array to second array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                secondArray[i, j] = firstArray[i, j];
            }
        }

        // Print the second array
        Console.WriteLine("The second array after copying values from the first array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(secondArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


  */
#endregion
#region Q19
/*
 
Write a Program to Print One Dimensional Array in Reverse Order
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array:");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array in reverse order:");
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

 */
#endregion