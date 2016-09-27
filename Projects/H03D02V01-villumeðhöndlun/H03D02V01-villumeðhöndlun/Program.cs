using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H03D02V01_villumeðhöndlun
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] j = new int[5];
            try
            {
                //   Console.WriteLine(5 / i);
                j[6] = 5;
                Console.WriteLine(j[6]);
            }
            catch(DivideByZeroException dbzes)
            {
                Console.WriteLine("you should't try to divide by zero");
            }
            catch(IndexOutOfRangeException ioorEX)
            {
                Console.WriteLine(ioorEX.ToString());

                Console.WriteLine("the array isn't big enough");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("hér gæti komið loka tiltekt");
            }
            Console.ReadKey();
        }
    }
}
