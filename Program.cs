namespace DateToDayGaussProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int day = 0;


            Console.WriteLine("Please enter the year");
            int year = int.Parse(Console.ReadLine());
            while (year < 0)
            {
                Console.WriteLine("Please enter a valid year");
                year = int.Parse(Console.ReadLine());

            }




            Console.WriteLine("Please enter the month(1-12)");
            int month = int.Parse(Console.ReadLine());
            while (month < 1 || month > 12)
            {
                Console.WriteLine("Please enter a valid month again");
                month = int.Parse(Console.ReadLine());

            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Enter the day(1-31)");
                    day = int.Parse(Console.ReadLine());
                    while (day < 1 || day > 31)
                    {
                        Console.WriteLine("Please enter a valid day again!");
                        day = int.Parse(Console.ReadLine());
                    }

                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Enter the day(1-30)");
                    day = int.Parse(Console.ReadLine());
                    while (day < 1 || day > 30)
                    {
                        Console.WriteLine("Please enter a valid day again!");
                        day = int.Parse(Console.ReadLine());
                    }
                    break;
                case 2:
                    if (year % 4 == 0)
                    {
                        Console.WriteLine("Enter the day(1-29)");
                        day = int.Parse(Console.ReadLine());
                        while (day < 1 || day > 29)
                        {
                            Console.WriteLine("Please enter a valid day again!");
                            day = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the day(1-30)");
                        day = int.Parse(Console.ReadLine());
                        while (day < 1 || day > 28)
                        {
                            Console.WriteLine("Please enter a valid day again!");
                            day = int.Parse(Console.ReadLine());
                        }
                    }
                    break;


            }

            int yearTwoDig = year;
            while (yearTwoDig > 99)
            {
                yearTwoDig /= 100;

            }

            int twoFirstYearDig = yearTwoDig;
            while (yearTwoDig >= 4)
            {
                yearTwoDig -= 4;
            }

            int doomYear;
            switch (yearTwoDig)
            {
                case 0: doomYear = 3; break;
                case 2: doomYear = 6; break;
                case 3: doomYear = 4; break;
                default: doomYear = 1; break;
            }
            int doomDay = 0;

            switch (month)
            {
                case 1:
                    if (year % 4 == 0)
                    {
                        doomDay = 4;
                    }
                    else
                        doomDay = 3;
                    break;

                case 2:
                    if (year % 4 == 0)
                    {
                        doomDay = 29;
                    }
                    else
                        doomDay = 28;
                    break;
                case 3: doomDay = 14; break;
                case 4: doomDay = 4; break;
                case 5: doomDay = 9; break;
                case 6: doomDay = 6; break;
                case 7: doomDay = 11; break;
                case 8: doomDay = 8; break;
                case 9: doomDay = 5; break;
                case 10: doomDay = 10; break;
                case 11: doomDay = 7; break;
                case 12: doomDay = 12; break;

            }
            int twoLastYearDig = year;

            while (twoLastYearDig > 99)
            {
                twoLastYearDig %= 100;


            }
            if (doomDay > 7)
            {
                doomDay -= 7;
            }

            int index = (twoLastYearDig / 12) + (twoLastYearDig % 12) + ((twoLastYearDig % 12) / 4) + doomYear + (day - doomDay);



            while (index > 7)
            {
                index -= 7;
            }

            switch (index)
            {
                case 1: Console.WriteLine("The day is Sunday"); break;
                case 2: Console.WriteLine("The day is Monday"); break;
                case 3: Console.WriteLine("The day is Tuesday"); break;
                case 4: Console.WriteLine("The day is Wednesday"); break;
                case 5: Console.WriteLine("The day is Thursday"); break;
                case 6: Console.WriteLine("The day is Friday"); break;
                case 7: Console.WriteLine("The day is Saturday"); break;
            }
        }
    }
}