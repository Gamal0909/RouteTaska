namespace Assignment_03_Solution;

class Program
{
    static void Main(string[] args)
    {

        Q01();
        
        Console.ReadKey();
    }


    static void Q01()
    {
        /*
          1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Example (1)
            Input: 12
            Output: Yes
            Example (2)
            Input: 9
            Output: No
        */
        
        Console.Write("Enter Num :");
        int num = int.Parse(Console.ReadLine());
        if (num % 3 == 0 && num % 4 == 0)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }

    void Q02()
    {
        /*
         2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Example (1)
            Input: -5
            Output: negative
            Example (2)
            Input: 10
            Output: positive
         */
        
        Console.Write("Enter Num :");
        int num = int.Parse(Console.ReadLine());
        string result = num > 0 ? "positive" : num < 0 ? "negative" : "The num is Zero";
        Console.WriteLine(result);
    }

    void Q03()
    {
        /*
         3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Example (1)
            Input:7,8,5
            Output:
            max element = 8
            min element = 5
            Example (2)
            Input: 3 6 9
            Outputs:
            Max element = 9
            Min element = 3
         */
            
        
        Console.Write("Enter First Num :");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter Second Num :");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter Third Num :");
        int thirdNum = int.Parse(Console.ReadLine());

        int max, min;
        if (firstNum > secondNum && firstNum > thirdNum)
        {
            max = firstNum;
            min = secondNum > thirdNum ? thirdNum : secondNum;
        }
        else if (secondNum > firstNum && secondNum > thirdNum)
        {
            max = secondNum;
            min = firstNum > thirdNum ? thirdNum : firstNum;
        }
        else
        {
            max = thirdNum;
            min = firstNum > secondNum ? secondNum : firstNum;
        }
        
        Console.WriteLine("max element = "+max);
        Console.WriteLine("min element = "+min);
    }

    void Q04()
    {
        /*
         * 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
         */
        Console.Write("Enter Num : ");
        int num=int.Parse(Console.ReadLine());
        if (num%2==0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }

    void Q05()
    {
        /*
         * 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Example (1)
            Input: O
            Output: vowel
            Example (2)
            Input: b
            Output: Consonant
         */


        string vowelChars = "aeiou";
        Console.Write("Enter Char : ");
        char character = char.Parse(Console.ReadLine());
        if (vowelChars.Contains(character))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("Consonant");
        }

    }

    void Q06()
    {
        /*
         * 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Example
            Input: 5
            Output: 1, 2, 3, 4, 5
         */
        Console.Write("Enter num : ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            Console.Write(i+", ");
        }

        Console.Write(num);
    }

    void Q07()
    {
        /*
         * 7- Write a program that allows the user to insert an integer then
            print a multiplication table up to 12.
            Example
            Input: 5
            Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
         */
        Console.Write("Enter Num : ");
        int num=int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12 ; i++)
        {
            Console.Write(num * i + " ");
        }
    }

    void Q08()
    {
        /*
         * 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Example:
            Input: 15
            Output: 2 4 6 8 10 12 14
         */
        
        Console.Write("Enter Num : ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i+" ");
            }
        }
    }

    void Q09()
    {
        /*
         * Write a program that takes two integers then prints the power.
            Example:
            Input: 4 3
            Output: 64
            Hint: how to calculate 4^3 = 4 * 4 * 4 =64
         */
        
        Console.Write("Enter Num : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter Power : ");
        int power = int.Parse(Console.ReadLine());
        //Console.WriteLine(Math.Pow(num, power));
        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= num;
        }
        Console.WriteLine(result);
    }

    void Q10()
    {
        /*
         *
            10- Write a program to enter marks of five subjects and calculate total, average and percentage.
                Example
                Input: - Enter Marks of five subjects: 95 76 58 90 89
                Output: Total marks = 408
                        Average Marks = 81
                        Percentage = 81
         */
        int sum = 0, dgree;
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Enter Degree Of Subject Number {i}");
            dgree = int.Parse( Console.ReadLine() );
            sum += dgree;
        }

        Console.WriteLine("Total marks = " + sum);
        Console.WriteLine("Average Marks = " + sum / 5);
        Console.WriteLine("Percentage = " + ((sum / 5) * 100) / 100);
    }

    void Q11()
    {
        /*
         * 11- Write a program to input the month number and print the number of days in that month.
            Example
            Input: Month Number: 1
            Output: Days in Month: 31
         */
        Console.Write("Enter Month Num : ");
        int monthNum = int.Parse(Console.ReadLine());
        Console.WriteLine(" Days in Month: "+DateTime.DaysInMonth(DateTime.Today.Year,monthNum));


    }

    void Q12()
    {
        /*
         * 12- Write a program to create a Simple Calculator.
         */
        
        Console.Write("Enter first Num : ");
        int fristNum = int.Parse(Console.ReadLine());
        Console.Write("Enter OP : ");
        char op = char.Parse(Console.ReadLine());
        Console.Write("Enter Second Num : ");
        int secondNum = int.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine($"{fristNum} {op} {secondNum} = {fristNum+secondNum}");
                break;
            case '/':
                Console.WriteLine($"{fristNum} {op} {secondNum} = {fristNum/secondNum}");
                break;
            case '*':
                Console.WriteLine($"{fristNum} {op} {secondNum} = {fristNum*secondNum}");
                break;
            case '-':
                Console.WriteLine($"{fristNum} {op} {secondNum} = {fristNum-secondNum}");
                break;
            case '%':
                Console.WriteLine($"{fristNum} {op} {secondNum} = {fristNum%secondNum}");
                break;
            default:
                Console.WriteLine("No OP");
                break;
        }
    }

    void Q13()
    {
        /*
         * 13- Write a program to allow the user to enter a string and print the REVERSE of it.
         */
        Console.Write("Enter String : ");
        string s = Console.ReadLine();
        for (int i = s.Length-1; i >= 0; i--)
        {
            Console.Write(s[i]);
        }
    }

    void Q14()
    {
        /*
         * Write a program to allow the user to enter int and print the REVERSED of it.
         */
        Console.Write("Enter Num : ");
        int num = int.Parse(Console.ReadLine());
        while (num>0)
        {
            Console.Write(num % 10);
            num /= 10;
        }
    }

    void Q15()
    {
        /*
       * 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            Test Data :
            Input starting number of range: 1
            Input ending number of range : 50

            Expected Output :
            The prime number between 1 and 50 are :
            2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
       */
      
        Console.WriteLine("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Input ending number of range : ");
        int end = int.Parse(Console.ReadLine());
        for (int i = start; i < end; i++)
        {
            if (i < 2) continue;
            bool prime = true;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime) Console.Write(i + " ");
        }
    }

    void Q16()
    {
        /*
       * 16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            Test Data :
            Enter a number to convert : 25
            Expected Output :
            The Binary of 25 is 11001.
       */
        Console.Write("Enter Num : ");
        int i=0, num = int.Parse(Console.ReadLine());
        int[] result = new int[32];
      
        while (num > 0)
        {
            result[i] = num % 2;
            num /= 2;
            i++;
        }

        for (int j = i - 1; j >= 0; j--)
        {
            Console.Write(result[j]);
        }
    }

    void Q17()
    {
        /*
         * 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
         */
      
        Point P1 = new Point();
        Point P2 = new Point(); 
        Point P3 = new Point();

        Console.WriteLine("Enter Point 1: ");
        P1.X = int.Parse(Console.ReadLine());
        P1.Y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Point 2: ");
        P2.X = int.Parse(Console.ReadLine());
        P2.Y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Point 3: ");
        P3.X = int.Parse(Console.ReadLine());
        P3.Y = int.Parse(Console.ReadLine());

        int slope1 = (P1.X - P2.X)/(P1.Y - P2.Y);
        int slope2 = (P2.X - P3.X)/(P2.Y - P3.Y);
        if (slope1 == slope2)
        {
            Console.WriteLine("These points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("These points not lie on a single straight line.");
        }

    }

    void Q18()
    {
        /*
         * 18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:
            - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            - If the worker takes more than 5 hours, they are required to leave the company.
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
        */
        Console.WriteLine("Enter The Duration that the worker take to complete the task: ");
        double duration = double.Parse(Console.ReadLine());
        if (duration >= 2 && duration <= 3)
        {
            Console.WriteLine("they are considered highly efficient");
        }else if (duration >= 3 && duration <= 4)
        {
            Console.WriteLine("they are instructed to increase their speed");
        }
        else if (duration >= 4 && duration <= 5)
        {
            Console.WriteLine("they are provided with training to enhance their speed. ");
        }
        else
        {
            Console.WriteLine("they are required to leave the company.");
        }
    }
}
internal class Point
{
    public int X; 
    public int Y;
}