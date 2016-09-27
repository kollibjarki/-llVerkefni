using System;

namespace theFlightMonitor
{
    public class colors
    {
        public static void flightLandedColors(string value)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }
        public static void flightClosedColors(string value)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(value);
            Console.ResetColor();
        }
        public static void flightDepaActionColors(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(value);
            Console.ResetColor();
        }


        public static void flightActionColors(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }
        public static void flightWarningColors(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }


        public static void programHeaderAndFootColor(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }
        public static void depaAndArriHeader(string value)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }
        public static void timeAndDownloadColor(string value)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(value.PadRight(Console.WindowWidth - 18));
            Console.ResetColor();
        }


    }
}
