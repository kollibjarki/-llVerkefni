using System;
using System.Net;
using Newtonsoft.Json;
using System.Threading;

namespace theFlightMonitor
{
    class Program
    {

        static void Main(string[] args)
        {
            string title = "\t\t\t\t\t\t\t\t\t\n----------  The Best Flight Monitoring Software In The World  ----------\n\t\t\t\t\t\t\t\t\t";
            int maxLength = 14;
            Console.Title = "The B.F.M.S.I.T.W was made by Davíð Már Gunnarsson";
            Console.WindowHeight = 72;
            Console.WindowWidth = 72;

            menuStart:
            Console.Clear();
            Console.CursorVisible = true;
            colors.programHeaderAndFootColor(title);
            Console.WriteLine("\n\n\tA ) Monitor Arrivals \n\n\tD ) Monitor Departures \n\n\tor \n\n\tQ ) To Quit\n\n\t\t\t\t\t:");
            Console.SetCursorPosition(42, 13);
            string userInput = Console.ReadLine();
            Console.Clear();

            //********************************   ARRIVALS   **************************************************************************************************************\\

            if (userInput == "a" || userInput == "A")
            {
                Console.Clear();
                chooseDownloadRate:
                colors.programHeaderAndFootColor(title);
                Console.WriteLine("\n\n\tPlease choose an update interval from 1 to 10 minutes \n\n\n\n\n\n\n\n\t\t\t\t\t:");
                Console.SetCursorPosition(43, 13);

                string downloadRateStr = Console.ReadLine();
                int downloadRateInt;
                bool intTest = int.TryParse(downloadRateStr, out downloadRateInt);
                if (intTest == false)
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\n\n\n\n\t\tRead instructions...");
                    Thread.Sleep(1100);
                    Console.Clear();
                    goto chooseDownloadRate;
                }
                else if (downloadRateInt > 10 || downloadRateInt <= 0)
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\n\n\n\n\t\tRead instructions...");
                    Thread.Sleep(1100);
                    Console.Clear();
                    goto chooseDownloadRate;
                }

                //All Checking Done Arrival Monitor Loops until 'M' is pressed'\\


                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.M))
                {

                    DateTime now = DateTime.Now;
                    string time = "\n\t ARRIVALS from Reykjavík-Kef Airport\t " + now.ToString("f") + "\t\n\t\t\t\t\t\t\t\t\t",
                            airL = "Airline\t",
                            goMainMenu = "\n\t\t  Press 'M' for the Menu\t",
                            arriHeader = "  Status   Time     \t\t  From\t" + airL.PadLeft(30);

                    using (var client = new WebClient())
                    {
                        Console.Clear();

                        colors.programHeaderAndFootColor(title + time);
                        colors.depaAndArriHeader(arriHeader);

                        var jsonFlightData = client.DownloadString("http://apis.is/flight?language=en&type=arrivals");
                        theArriList data = JsonConvert.DeserializeObject<theArriList>(jsonFlightData);

                        foreach (var flight in data.results)
                        {
                            if (flight.from.Length > maxLength)
                                flight.from = flight.from.Substring(0, maxLength);

                            if (flight.realArrival.Contains("Landed"))
                            {
                                colors.flightLandedColors("  Landed " + flight.realArrival.Remove(0, 6) + "  -  " + flight.flightNumber + "    \t" + flight.from.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Confirm"))
                            {
                                Console.WriteLine("Confirmed" + flight.realArrival.Remove(0, 8) + "  -  " + flight.flightNumber + "    \t" + flight.from.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Estimat"))
                            {
                                colors.flightDepaActionColors("Estimated");
                                Console.WriteLine(flight.realArrival.Remove(0, 8) + "  -  " + flight.flightNumber + "    \t" + flight.from.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else
                            {
                                Console.WriteLine("Scheduled " + flight.plannedArrival + "  -  " + flight.flightNumber + "    \t" + flight.from.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            Thread.Sleep(15);
                        }

                    }
                    colors.programHeaderAndFootColor(goMainMenu.PadLeft(0));
                    Console.CursorVisible = false;


                    int downloadRateIntSec = downloadRateInt * 60;

                    Console.WriteLine();
                    for (int sec = downloadRateIntSec; sec >= 0 ; sec -= 1)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.M)
                        {
                            goto menuStart;
                        }
                        else
                        colors.timeAndDownloadColor("\x000D\t\tNext update in < " + sec + " seconds " + "".PadLeft(28));
                        Thread.Sleep(1000 * 1);
                    }

                }
                goto menuStart;

            }


            //********************************   Departures   **************************************************************************************************************\\

            else if (userInput == "d" || userInput == "D")
            {

                Console.Clear();
                chooseDownloadRate:
                colors.programHeaderAndFootColor(title);
                Console.WriteLine("\n\n\tPlease choose an update interval from 1 to 10 minutes \n\n\n\n\n\n\n\n\t\t\t\t\t:");
                Console.SetCursorPosition(43, 13);

                string downloadRateStr = Console.ReadLine();
                int downloadRateInt;
                bool intTest = int.TryParse(downloadRateStr, out downloadRateInt);
                if (intTest == false)
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\n\n\n\n\t\tRead instructions...");
                    Thread.Sleep(1100);
                    Console.Clear();
                    goto chooseDownloadRate;
                }
                else if (downloadRateInt > 10 || downloadRateInt <= 0)
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("\n\n\n\n\t\tRead instructions...");
                    Thread.Sleep(1100);
                    Console.Clear();
                    goto chooseDownloadRate;
                }

                //All Checking Done Departure Monitor Loops\\


                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.M))
                {
                    DateTime now = DateTime.Now;
                    string time = "\n\tDepartures from Reykjavík-Kef Airport\t " + now.ToString("f") + "\t\n\t\t\t\t\t\t\t\t\t",
                            airL = "Airline\t",
                            goMainMenu = "\n\t\t  Press 'M' for the Menu\t",
                            depaHeader = "  Status   Time     \t\t   to \t" + airL.PadLeft(30);

                    using (var client = new WebClient())
                    {
                        Console.Clear();
                        colors.programHeaderAndFootColor(title + time);
                        colors.depaAndArriHeader(depaHeader);

                        var jsonFlightData = client.DownloadString("http://apis.is/flight?language=en&type=departures");
                        theDepaList data = JsonConvert.DeserializeObject<theDepaList>(jsonFlightData);

                        foreach (var flight in data.results)
                        {
                            if (flight.to.Length > maxLength)
                                flight.to = flight.to.Substring(0, maxLength);
                            if (flight.realArrival.Contains("Departed"))
                            {
                                colors.flightLandedColors(" Departed" +" "+ flight.realArrival.Remove(0,8) + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Closed"))
                            {
                                colors.flightClosedColors("* ");
                                colors.flightLandedColors(""+ flight.realArrival +  "   " + flight.plannedArrival +  "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Final"))
                            {
                                
                                colors.flightDepaActionColors("FinalCall  ");
                                colors.flightDepaActionColors(flight.plannedArrival + "  !");
                                colors.flightActionColors("  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Go to"))
                            {
                                colors.flightDepaActionColors("* ");
                                colors.flightActionColors("ToGate   " + flight.realArrival.Remove(0,10) + flight.plannedArrival + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Boarding"))
                            {
                                colors.flightDepaActionColors("*");
                                colors.flightActionColors(flight.realArrival + "  " +flight.plannedArrival + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("On Time"))
                            {
                                Console.WriteLine("  OnTime " + flight.realArrival.Remove(0,7) + "  " + flight.plannedArrival + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else if (flight.realArrival.Contains("Confirm"))
                            {
                                Console.WriteLine(" Confirmed" + flight.realArrival.Remove(0,8)  + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            else
                            {
                                Console.WriteLine("\t  " + flight.plannedArrival + "  -  " + flight.flightNumber + "\t" + flight.to.PadRight(14) + "\t    " + flight.airline.PadLeft(18) + "  ");
                            }
                            Thread.Sleep(15);
                        }
                    }


                    colors.programHeaderAndFootColor(goMainMenu);
                    Console.CursorVisible = false;

                    int downloadRateIntSec = downloadRateInt * 60;

                    Console.WriteLine();
                    for (int sec = downloadRateIntSec; sec >= 0; sec -= 1)
                    {
                        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.M)
                        {
                            goto menuStart;
                        }
                        else
                            colors.timeAndDownloadColor("\x000D\t\tNext update in < " + sec + " seconds " + "".PadLeft(28));
                        Thread.Sleep(1000 * 1);
                    }

                }

                goto menuStart;

            }

            //********************************    Quit     **************************************************************************************************************\\

            else if (userInput == "q" || userInput == "Q")
            {
                Environment.Exit(0);
            }

            //********************************   Invalid   **************************************************************************************************************\\

            else
            {
                Console.CursorVisible = false;
                colors.programHeaderAndFootColor(title);
                Console.WriteLine("\n\n\tA ) Monitor Arrivals \n\n\tD ) Monitor Departures \n\n\tor \n\n\tQ ) To Quit\n\n\t\t\t\t\t:");
                Console.WriteLine("\n\n\n\n\t\t\tNot an option...");
                Thread.Sleep(1100);
                Console.Clear();
                goto menuStart;
            }

        }



        


    }
}
