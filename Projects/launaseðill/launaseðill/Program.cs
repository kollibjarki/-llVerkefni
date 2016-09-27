using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launaseðill
{
    class Program
    {
        static void Main(string[] args)
        {
            int laun;
            double skattur;
            int timakaup;
            int yfirvinna;
            double lífeyrisjóður;
            double stéttarfelag;
            double utborgad;
            double fyrirskatt;
            int persónuafsláttur;


            laun = 300000;
            skattur = 0.37;
            timakaup = 1500;
            yfirvinna = 2500;
            lífeyrisjóður = 0.04;
            stéttarfelag = 0.01;
            persónuafsláttur = 50000;


            fyrirskatt =laun - (laun * lífeyrisjóður) - (laun * stéttarfelag);
            utborgad = (fyrirskatt * skattur) + persónuafsláttur;



            Console.WriteLine(utborgad);
            Console.ReadKey();


        }
    }
}
