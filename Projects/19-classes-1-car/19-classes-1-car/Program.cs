using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_classes_1_car
{
    class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.bílnúmer = "KH847";
            car1.enginetype = "3000 turbo";
            car1.setnumbersofwheels(4);
            car1.Setdistancedriven(15042);
            car1.numOfPeople = 4;

            Console.WriteLine("car1.bílnúmer: {0}", car1.bílnúmer);

            car1.bílnúmer = "MX512";
            Console.WriteLine("car1.bílnúmer: {0}",car1.bílnúmer);


            car car2 = new car()

            {
                bílnúmer = "GG555",
                enginetype= "1,8t",
                //wheels=4,
                //distancedriven= 182564,
                numOfPeople= 3
                


            };
            car2.Setdistancedriven(182564);
            car2.setnumbersofwheels(4);
            Console.WriteLine("car2.bílnúmer: {0}", car2.bílnúmer);
            Console.WriteLine("car2.distancedriven: {0}", car2.Getdistancedriven());
            Console.WriteLine("car2.numberofwheels: {0}", car2.Getnumbersofwheels());

            car2.Setdistancedriven(5000);
            while (true)
            {
                string key = Console.ReadKey().Key.ToString();

                //Console.WriteLine("press key : {0}", key);
                if (key == "UpArrow")
                {
                    car2.DriveForward();
                    Console.WriteLine("car2.distancedriven: {0}", car2.Getdistancedriven());

                }
                else if (key == "LeftArrow")
                {
                    Console.WriteLine( car2.TurnLeft());
                }
                else if (key == "RightArrow")
                {
                    Console.WriteLine(car2.TurnRight());
                }




            }

            
         



            

        }
    }
    class car
    {
        public string bílnúmer;
        public string enginetype;
        private int numbersofwheels;
        private int distancedriven = -1;
        public int numOfPeople;
        private char direction = 'N';
        //method
        public void Setdistancedriven(int distance)
        {
            if (distancedriven < 0)
            {
                distancedriven = distance;
            }


        }
        public void DriveForward()
        {
            distancedriven++;
        }

        public char TurnLeft()
        {
            if (direction == 'N')
            {
                direction = 'W';
            }
            else if (direction == 'W')
            {
                direction = 'S';
            }
            else if (direction == 'S')
            {
                direction = 'E';
            }
            else if (direction == 'E')
            {
                direction = 'N';
            }
            return direction;
        }
        public char TurnRight()
        {
            if (direction == 'N')
            {
                direction = 'W';
            }
            else if (direction == 'W')
            {
                direction = 'S';
            }
            else if (direction == 'S')
            {
                direction = 'E';
            }
            else if (direction == 'E')
            {
                direction = 'N';
            }
            return direction;
        }


        public int Getdistancedriven()
        {
            return distancedriven;
        }
        public void setnumbersofwheels(int wheels)
        {
            numbersofwheels = wheels;
        }
        public int Getnumbersofwheels()
        {
            return numbersofwheels;
        }
       
        


    }

}

