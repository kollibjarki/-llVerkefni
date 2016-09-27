using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCar
{
    class Car
    {

        private int distancedriven = -1;
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

        public void DriveBackwards()
        {
            ////niður
            //var top = bill.Margin.Top;
            //var left = bill.Margin.Left;
            //var right = bill.Margin.Right;
            //var bottom = bill.Margin.Bottom;

            //bill.Margin = new System.Windows.Thickness(left, top + 10, right, bottom + 10);

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
      

    }
}
