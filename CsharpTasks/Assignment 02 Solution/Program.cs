namespace Assignment_02_Solution;

class Program
{
    static void Main(string[] args)
    {
        Q01();
        Console.ReadKey();
    }

    static void Q01()
    {
        //1-Write a program that allows the user to enter a number then print it.
        Console.WriteLine("Please Enter a Number");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x);
    }

    void Q02()
    {
        //2-Write C# program that converts a string to an integer, 
        //but the string contains non-numeric characters. And mention what will happen 
        
        Console.WriteLine("Enter your number");
        int Number = int.Parse(Console.ReadLine());
        Console.WriteLine(Number);

    }

    void Q03()
    {
        /*
        3-Write C# program that Perform a simple arithmetic
        operation with floating-point numbers And mention what will happen
        */

        float x = 5.5f, y = 6.5f;
        Console.WriteLine(x + y);
    }

    void Q04()
    {
        //4-Write C# program that Extract a substring from a given string.
        
        Console.WriteLine("Enter Your String:");
        string statement = Console.ReadLine();
        Console.WriteLine("Choose Your Frist Index of your substring:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose Your Sec Index of your substring:");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(statement.Substring(x,y));
    }

    void Q05()
    {
        
        //5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

        int x = 9, y = 0;
        x = y;
        Console.WriteLine(x);
    }

    void Q06()
    {
        //6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
        
        Reference reference1 = new Reference();
        Reference reference2 = new Reference();
        reference1.x = 5;
        reference2 = reference1;
        Console.WriteLine(reference2.x);
        
    }

    void Q07()
    {
        //7-Write C# program that take two string variables and print them as one variable 
        
        Console.WriteLine("Enter First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Second Name ");
        string secondName = Console.ReadLine();
        Console.WriteLine(firstName+ " "+secondName);

    }

    void Q08()
    {
        //8-Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is 
        //Interest = (principal * rate * time ) /100.
            
        Console.WriteLine("Enter Principal :");
        int principal=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Rate :");
        int rate=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Time :");
        int time=int.Parse(Console.ReadLine());

        double interest =(double) (principal * rate * time) / 100;
        Console.WriteLine(interest);
    }

    void Q09()
    {
        //9-Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
        //BMI = (Weight)/(Height*Height)
        
        Console.WriteLine("Enter Weight In Kilograms:");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Height In Meters:");
        double height = double.Parse(Console.ReadLine());
        double bmi = (weight) / (height * height);
        Console.WriteLine(bmi);
    }

    void Q10()
    {
        //10-Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
        
        Console.WriteLine("Enter Temprature Degree :");
        int Temprature = int.Parse(Console.ReadLine());
        string result = Temprature > 30 ? "Just Hot" : Temprature < 10 ? "Just Cold" : "Just Good";
        
        Console.WriteLine(result);
    }

    void Q11()
    {
        /*11-Write a program that takes the date from the user and displays it in various formats using string interpolation.
        Ex :
        Today’s date : 20 , 11 , 2001
        Today's date : 20 / 11 / 2001
        Today's date : 20 – 11 – 2001
        */
        Console.Write("Enter a date (e.g., yyyy - MM - dd): ");
        string InputDate = Console.ReadLine();
        
        if (DateTime.TryParse(InputDate, out DateTime date))
        {
            Console.WriteLine("You entered a valid date: " + "(" + date.ToString("dd , MM , yyyy") + ")" + "\n  " +  "(" + date.ToString("dd / MM / yyyy") + ")"+" \n  "+ "("+ date.ToString("dd - MM - yyyy")+")");
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a date in the format yyyy-MM-dd.");
        }

    }
}
internal class Reference
{
    public int x;
    public int y;
}