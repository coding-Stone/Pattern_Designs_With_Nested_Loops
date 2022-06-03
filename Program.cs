using System;
using System.Collections.Generic;
using System.IO;

namespace Pattern
{
    class Program
    {
        static void Main (string[] args)
        {
            // In This Programme, I will be using a Nested Loops to Draw Some design
            // Star Patterns

            // Declare your variables
            int row, col, numb;
            numb = 10;

            // We Draw the Square Pattern first
            // This will serve as the base Idea for the subsequent codes.
            
                        // * * * * *
                        // * * * * *
                        // * * * * *
                        // * * * * *
            // This outer loop, is responsible for printing the spaces in the rows
            for(row=0; row < numb; row++)
            {
                // this inner loop is responsible for printing stars on each row
                for(col=0; col < numb; col++)
                {
                    Console.Write("* "); //here we use 'console.write' to print on the same line
                }
                Console.WriteLine("");// this is the code responsible for printing spaces in row
            }

            // Right Angled Triangle
                    // *          
                    // * * 
                    // * * * 
                    // * * * *
            for(row =0; row < numb; row++)
            {
                for(col=0; col <=row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

                Console.WriteLine("\n"); //separating the diagrams
            
            //Inverted Right Angled Triangle
                // * * * 
                // * * 
                // * 
            for(row = 0; row < numb; row++)
            {
                for(col=row; col < numb; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            // Left Angled Triangle
            // Since we have the inverted Right Angled Triangle, problem 
            // becomes easy
            //       * 
            //     * * 
            //   * * * 
            // * * * * 

            for(row = 0; row < numb; row++)
            {
                // the inner loop for inverted right angled triangle printed as space
                for(col = row; col <= numb; col++)
                {
                    Console.Write("  ");
                }

                for(col =0; col < row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
                Console.WriteLine("\n");
            // Inverted Left Angled Triangle
                    //    * * * * 
                    //      * * * 
                    //        * * 
                    //          * 
            // Since we have the code for the Right Angled triangle
            // Drawing this becomes easier

            for(row = 0; row < numb; row ++)
            {   
                //the inner loop of a right angled triangle printed with space
                for(col =0; col < row; col++)
                {
                    Console.Write("  ");
                }
                for(col=row; col <numb; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }

            // PYRAMID
            //       * 
            //      * * 
            //     * * * 
            //    * * * * 

             for(row = 0; row < numb; row ++)
            {   
                // the inner loop for inverted right angled triangle printed as space
                for(col = row; col < numb; col++)
                {
                    Console.Write("  ");
                }

                for(col=0; col <row; col++)
                {
                    Console.Write("* ");
                }

                for(col=0; col <row-1; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            
              Console.WriteLine("\n");

            for(row=0; row < numb ; row++)
            {
                for(col =0; col < row; col++)
                {
                    Console.Write("  ");
                }
                for(col=row; col < numb-1; col++)
                {
                    Console.Write("* ");
                }
                for(col=row; col < numb; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
          
        }
    }
}