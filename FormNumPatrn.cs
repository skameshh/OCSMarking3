using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***
 * https://www.youtube.com/watch?v=xzstcj3Cuso
 */
namespace OCSMarking3
{
    public partial class FormNumPatrn : Form
    {
        public FormNumPatrn()
        {
            InitializeComponent();
        }


        //Increasing Triangle
        //Decreasing Triab
        private void print5x5Pattern(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }

                //next row
                Console.WriteLine("");
            }

        }

        /**
        * 
        * * 
        * * * 
        * * * * 
        * * * * * 
         * 
         */
        private void printIncreasingTriangle5Pattern(int n)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                //next row
                Console.WriteLine("");
            }

        }

        /**
            * * * * * 
            * * * * 
            * * * 
            * * 
            * 
         * 
         * 
         */
        private void printDecreasingTriangle5Pattern(int n)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                //next row
                Console.WriteLine("");
            }

        }

        private void printDecreasingTriangle5Pattern2(int n)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("* ");
                }
                //next row
                Console.WriteLine("");
            }
        }

        /**
         * 
         * Make sure both innner for got same printing chars count
         * 
         *            * 
                    * * 
                  * * * 
                * * * * 
              * * * * * 
         * 
         */

        private void printRightSidedPattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                //next row
                Console.WriteLine("");
            }


        }

        /***
         * * * * * 
           * * * * 
             * * * 
               * * 
                 * 
         * 
         */

        private void printRightSidedPattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = i; j <= n; j++)
                {
                    Console.Write("* ");
                }

                //next row
                Console.WriteLine("");
            }


        }

        private void printHillPattern2(int n)
        {
            for(int i = 1; i <= n; i++)
            {


                Console.WriteLine("");
            }
        }


        /**
            1
            2 2
            3 3 3
            4 4 4 4
            5 5 5 5 5
         * 
         */
        private void printIncTriangleNumber(int n)
        {
            for(int i = 1, p=1; i <=n; i++,p++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(""+p+" ");
                }

                //next line
                Console.WriteLine("");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            print5x5Pattern(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printIncreasingTriangle5Pattern(5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDecreasingTriangle5Pattern2(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printRightSidedPattern1(5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printRightSidedPattern2(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printIncTriangleNumber(5);
        }
    }
}
