namespace Assignment_04_Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadKey();
        Console.WriteLine( );
    }
   
       #region Qustion 1
        //1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        static void Add5(int x)
        {
            x += 5;
        }
    #endregion

    #region Qustion 2
        //2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        static void Add5Ref(ref int x)
        {
            x += 5;
        }
    #endregion

    #region Qustion 3
        //3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        static void Q3(int x, int y, out int sum, out int sub)
        {
            sub=x-y;
            sum = x + y;
        }
    #endregion

    #region Qustion 4
    
        /*
         4-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            Output should be like 
            Enter a number: 25                                                                                            
            The sum of the digits of the number 25 is: 7
         */
        static int sumOfDigit(int num)
        {
            if (num == 0)
            {
                return 0;
            }

            return sumOfDigit(num / 10) + num % 10;
        }


        #endregion
        
    #region Qustion 5
        //5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i*i <= num ; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }       
                }

                return true;
            }
    #endregion

    #region Qustion 6
        //6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        static void MinMaxArray(ref int[] arr ,ref int min,ref int max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                else if (arr[i] < min) min = arr[i];
            }
        }

    #endregion

    #region Qustion 7
       //Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
       static int factorial(int num)
       {
           int fact = 1;
           if (num < 2) return fact;
           for (int i = 2; i <= num; i++) fact *= num;
           return fact;
       }
    #endregion

    #region Qustion 8
        //8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        static void ChangeChar(string s,int pos,char newchar)
        {
            if(pos<0||pos>s.Length-1) Console.WriteLine("Invalid pos");
            if(s == null) Console.WriteLine("Invalid string");
            char[] chararray = s.ToCharArray();
            chararray[pos] = newchar;
            s = chararray.ToString();
        }
    #endregion

    #region Qustion 9
        //9-. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
        static void printmatrix(int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (i==j)
                        Console.WriteLine("1 ");
                    else
                        Console.WriteLine("0 ");
        }
    #endregion

    #region Qustion 10
        //10-Write a program in C# Sharp to find the sum of all elements of the array.
        static int sumOfArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        } 

    #endregion
    
    #region Qustion 11
        //Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0, k = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    result[k++] = arr1[i++];
                }
                else
                {
                    result[k++] = arr2[j++];
                }
            }

            // Copy remaining elements of arr1, if any
            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            // Copy remaining elements of arr2, if any
            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }

    #endregion

    #region Qustion 12
        //12- Write a program in C# Sharp to count the frequency of each element of an array.
        static void Frequency()
        {
            Console.Write("Enter size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int max =Int32.MinValue;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element {i}:");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max) max = arr[i];
            }

            int[] freq = new int[max+1];
            foreach (var num in arr)
            {
                freq[num]++;
            }

            for (int i = 0; i < max; i++)
            {
                if (freq[i]!=0)
                {
                    Console.WriteLine($"Array of element {i} have {freq[i]}");
                }
            }
        }
    #endregion
    
    #region Qustion 13
        //13-Write a program in C# Sharp to find maximum and minimum element in an array
        static void arrayMinMax(int[] arr, out int min, out int max)
        {
            min = Int32.MaxValue; 
            max = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
    #endregion

    #region Qustion 14
        
        //14- Write a program in C# Sharp to find the second largest element in an array.
        static int secondLargestElement()
        {
            Console.Write("Enter size:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int max =Int32.MinValue;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter Element {i}:");
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max) max = arr[i];
            }
            int secondlargestelement=Int32.MinValue;
            foreach (var num in arr)
            {
                if (secondlargestelement < num && num != max)
                {
                    secondlargestelement = num;
                }
            }

            return secondlargestelement;
        }

    #endregion

    #region Qustion 17
        /*
         * 17-Given a list of space separated words, reverse the order of the words.

            Input: this is a test		Output: test a is this
            Input: all your base		Output: base your all
            Input: Word			Output: Word
            Note :
            Check the Split Function (Member in String Class) Output will be a Single Console.WriteLine Statement
         */
        static void reverseString()
        {
            Console.WriteLine("Enter String:");
            string s = Console.ReadLine();
            string[] words = s.Split();
            Array.Reverse(words);
            foreach (var word in words)
            {
                Console.Write( word+" ");
            }
        }
        

    #endregion

    #region Qustion 18
        /*
         * Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
         */

        static void mulArray()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] firstArray = new int[rows, cols];
            int[,] secondArray = new int[rows, cols];

            // Accepting values for the first array
            Console.WriteLine("\nEnter elements for the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Copying elements to the second array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    secondArray[i, j] = firstArray[i, j];
                }
            }

            // Printing the second array
            Console.WriteLine("\nSecond array (copied values):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    

    #endregion
}