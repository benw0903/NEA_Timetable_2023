using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeTableApp_NEA
{
    class MainTimeTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
███╗   ███╗██╗   ██╗████████╗██╗███╗   ███╗███████╗
████╗ ████║╚██╗ ██╔╝╚══██╔══╝██║████╗ ████║██╔════╝
██╔████╔██║ ╚████╔╝    ██║   ██║██╔████╔██║█████╗  
██║╚██╔╝██║  ╚██╔╝     ██║   ██║██║╚██╔╝██║██╔══╝  
██║ ╚═╝ ██║   ██║      ██║   ██║██║ ╚═╝ ██║███████╗
╚═╝     ╚═╝   ╚═╝      ╚═╝   ╚═╝╚═╝     ╚═╝╚══════╝
                                                   


Press any key to enter.");

            Console.WriteLine("");

            Console.ReadKey();
            Console.Clear();
            FileName();

        }
        static void ViewOrCreate()
        {

            string option = "";

            while (option != "view" || option != "create")
            {
                Console.Clear();
                Console.WriteLine("Would you like to view or create a table today(View/Create)");
                option = Console.ReadLine();
                option = option.ToLower();


                if (option == "view")
                {
                    ViewTable();
                }
                if (option == "create")
                {
                    SlotAmount();
                }
            }
        }
        static void SlotAmount()
        {
            Console.Clear();
            Console.WriteLine("Hello user. How many slots for activities will you want?");


            int numRows = int.Parse(Console.ReadLine());
            int numColumns = 7;


            Console.WriteLine("Are you happy with the amount of slots you chave chosen for you activities? " + "(" + numRows + ")");
            string option = Console.ReadLine();

            while (option != "yes")
            {
                Console.Clear();
                Console.WriteLine("Hello user. How many slots for activities will you want?");

                numRows = int.Parse(Console.ReadLine());
                Console.WriteLine("Are you happy with the amount of slots you chave chosen for you activities? " + "(" + numRows + ")");

                Console.WriteLine("Are you happy with the amount of slots you chave chosen?");
                option = Console.ReadLine();
            }

            if (option == "yes")
            {
                CreateTable Table = new CreateTable(numColumns, numRows);
                Console.Clear();
                ActivitiesAndTime(numColumns, numRows);
            }
        }

        static void ActivitiesAndTime(int numColumns, int numRows)
        {
            Console.Clear();

            int[,] times = new int[numColumns, numRows];
            ActivitiesAndTimes[,] activities = new ActivitiesAndTimes[numColumns, numRows];

            int count1 = 0,count2 = 0, count3 = 0, count4 = 0;


            for (int i = 0; i < numColumns * numRows; i++)
            {

                Console.WriteLine("Enter a the hour of the activity will take place. 0-23");
                if (int.Parse(Console.ReadLine()) >= 0 && int.Parse(Console.ReadLine()) <= 23)
                {
                    //link this with ActivitiesAndTime
                }
                else
                {
                    Console.WriteLine("Invalid input.PLease enter an Hour between 0-23.");
                    i--;
                }
                count1++;
                if (count1 == numRows)
                {
                    count2++;
                    count1 = 0;
                }



            }
            for (int i = 0; i < numColumns * numRows; i++)
            {
                Console.WriteLine("Enter the activity for");
                count3++;
                if (count3 == numRows)
                {
                    count4++;
                    count3 = 0;
                }
            }
        }

        static void FileName()
        {
            DateTime currentTime = DateTime.Now;

            Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in the date (dd/mm/yyyy).");
            string filename = Console.ReadLine();

            string currentTimeString = currentTime.ToString();
            // Make the current time into a string
            
            string currentDayString = currentTimeString.Substring(0, 2),currentMonthString = currentTimeString.Substring(3, 2),currentYearString = currentTimeString.Substring(6, 5);
            int currentDayInt = int.Parse(currentDayString), currentMonthInt = int.Parse(currentMonthString), currentYearInt = int.Parse(currentYearString);
            // Converting the current date into induvidual days months and years


            string dayString = filename.Substring(0, 2), monthString = filename.Substring(3, 2), YearString = filename.Substring(6, 4);           

            int dayInt = int.Parse(dayString), monthInt = int.Parse(monthString), yearInt = int.Parse(YearString);
            // Converting the inputed date into induvidual days months and years

            while (dayInt > 31 && monthInt > 12 || dayInt < 1 && monthInt < 1)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a valid date (dd/mm/yyyy)."); ;
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);

            }

            while (dayInt > 31 && monthInt == 1 || dayInt > 28 && monthInt == 2 || dayInt > 31 && monthInt == 3)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a valid date (dd/mm/yyyy).");
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);

            }
            //Days for jan,feb,march 

            while (dayInt > 30 && monthInt == 4 || dayInt > 31 && monthInt == 5 || dayInt > 30 && monthInt == 6)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a valid date (dd/mm/yyyy).");
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);
            }
            //Days for april,may,june

            while (dayInt > 31 && monthInt == 7 || dayInt > 31 && monthInt == 8 || dayInt > 30 && monthInt == 9)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a valid date (dd/mm/yyyy).");
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);
            }
            //Days for july,Aug,Sep

            while (dayInt > 31 && monthInt == 10 || dayInt > 30 && monthInt == 11 || dayInt > 31 && monthInt == 12)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a valid date (dd/mm/yyyy).");
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);
            }
            //Days for oct,nov,dec

            while(currentDayInt - dayInt >=0 && currentMonthInt - monthInt >= 0 && currentYearInt - yearInt >= 0)
            {
                Console.Clear();
                Console.WriteLine(@"The current Date and Time is: " + currentTime +
". Enter in a future or current date (dd/mm/yyyy).");
                filename = Console.ReadLine();

                dayString = filename.Substring(0, 2); monthString = filename.Substring(3, 2); YearString = filename.Substring(6, 4);
                dayInt = int.Parse(dayString); monthInt = int.Parse(monthString); yearInt = int.Parse(YearString);
            }
            Console.WriteLine(filename);
            Console.ReadKey();
        }


        static void ViewTable()
        {
            Console.WriteLine("Enter the name of the file you would like to view.");
            string fileName = Console.ReadLine();
        }




    }
}