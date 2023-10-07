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

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

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
            Console.WriteLine("Enter in the date. (dd/mm/yyyy)");
            string filename = Console.ReadLine();

            string day = filename.Substring(0,2);
            string month = filename.Substring(3,2);
            Console.WriteLine(day + month);
            Console.ReadKey();
        }


        static void ViewTable()
        {
            Console.WriteLine("Enter the name of the file you would like to view.");
            string fileName = Console.ReadLine();
        }




    }
}