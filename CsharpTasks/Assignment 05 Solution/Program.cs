namespace Assignment_05_Solution;

class Program
{
    static void Main(string[] args)
    {
       Days();
    }

    #region Qustion 01
        /*
         * 1-Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
         */
        enum WeekDays
        {
            Saterday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }

        static void Days()
        {
            foreach (var weekDay in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(weekDay);
            }
        }
    #endregion

    #region Qustion 02

        /*
         * 2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
         */
        enum Seasons
        {
            Spring, 
            Summer, 
            Autumn, 
            Winter
        }

        static void Season()
        {
            Console.WriteLine("Enter The Season : ");
            Enum.TryParse(typeof(Seasons),Console.ReadLine(), true, out Object O1);
            Seasons season = (Seasons)O1; 
                switch (season)
                {
                    case Seasons.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Seasons.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Seasons.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Seasons.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season");
                        break;

                }
        }
    #endregion

    #region Qustion 03

    [Flags]
    enum Permission
    {
        Read = 8,
        Write = 4,
        Delete = 2,
        Execute = 1
    }

    static void Permissions()
    {
        /*Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                ● Create Variable from previous Enum to Add and Remove Permission from variable,
                  check if specific Permission is existed inside variable
            */
         Permission P01 = Permission.Read;
         P01 |= Permission.Delete;
         P01 |= Permission.Write;
         P01 ^= Permission.Delete;

         P01 &= ~Permission.Delete;
         Console.WriteLine(P01);

         //// & -> Check Permission
         if ((P01 & Permission.Delete) == Permission.Delete)
         {
             Console.WriteLine("Exists");
         }
         else
         {
             Console.WriteLine("Not Exisit");
         }

    }

    #endregion

    #region Qustion 04
        
    enum PrimeColor
    {
        Red,
        Blue,
        Green
    }

    static void PrimeColors()
    {
        Console.WriteLine("Enter a color name (Red, Green, Blue):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out PrimeColor color))
        {
            if (color == PrimeColor.Red || color == PrimeColor.Green || color == PrimeColor.Blue)
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{color} is not a primary color.");
            }
        }
        else
        {
            Console.WriteLine("Invalid : This Is Not A Prime Color.");
        }
    }
    

    #endregion
}