//Grading ID: S0941
//CIS 199-02
//Lab 6
//Due: (3/21/21)
//This program creates four different patterns of stars
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            const string STAR = "*"; //constant for stars
            const string SPACE = " "; //constant for spaces
            const int MAX = 10; //Max length of each row

            {
                //A
                WriteLine("Pattern A");
                for (int row = 0; row <= MAX; row++) //starts star pattern in top left corner, increasing down and to the right
                {
                    for (int column = 1; column <= row; column++) //creates stars each interval
                    {
                        Write(STAR);
                    }

                    WriteLine();
                }
                WriteLine(); //space between pattern A and B
                //B
                WriteLine("Pattern B");
                WriteLine(); //Creates Space between header and code output
                for (int row = MAX; row > 0; row--) //starts star pattern at the top, decreasing down and to the left
                {
                    for (int column = 0; column < row; column++) //creates stars each interval
                    {
                        Write(STAR);
                    }

                    WriteLine();
                }
                WriteLine(); //space between pattern B and C
                //C
                WriteLine("Pattern C");
                WriteLine(); //Creates Space between header and code output
                for (int row = MAX; row > 0; row--) //starts star pattern at the top, decreasing down and to the right
                {
                    for (int star = 1; star <= MAX - row; star++) //creates spaces each interval
                        Write(SPACE);
                    for (int space = 1; space <= row; space++) //creates stars each interval
                        Write(STAR);
                    WriteLine();
                }
                WriteLine(); //space between pattern C and D
                //D
                WriteLine("Pattern D");
                for (int row = MAX; row > 0; row--) //starts star pattern in top right corner, increasing down and to the left
                {
                    for (int column = 0; column < row; column++) //creates spaces each interval
                        Write(SPACE);

                    for (int column = 0; column < MAX - row; column++) //creates stars each interval
                        Write(STAR);
                    WriteLine();
                }
            }
        }
    }
}