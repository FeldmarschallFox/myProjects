using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MatrixGame
{
    class Program
    {
        static void Game()
        {
            Console.Clear();

            //INIT VARIABLES:
            const int maxNumbers = 10; //CHANGE THIS IF YOU WANT TO CHANGE HOW LARGE MATRIX VALUES ARE!!!
            const int minNumbers = -1 * maxNumbers;

            double a = 1;
            double b = 1;
            double c = 1;
            double d = 1;
            double e = 1;
            double f = 1;
            double g = 1;
            double h = 1;
            double i = 1;
            string response = "well hello there!";


            //GET A QUESTION 4 U:
            string[] questionArray = new string[5];
            questionArray[0] = "Find the inverse of the matrix. Leave as 0 for a singular matrix:";
            questionArray[1] = "Square the Matrix:";
            questionArray[2] = "Add these two matrices together:";
            questionArray[3] = "Multiply these two matrices together:";
            questionArray[4] = "Find the inverse of the matrix. Leave as 0 for a singular matrix:";

            Thread.Sleep(20);
            Random randomQuestionGen = new Random(DateTime.Now.Millisecond);
            var questionNumber = randomQuestionGen.Next(1, questionArray.Length);
            Thread.Sleep(20);
            
            //FIRST MATRIX
            Thread.Sleep(20);
            Random randomNum1a = new Random(DateTime.Now.Millisecond);
            a = randomNum1a.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum1b = new Random(DateTime.Now.Millisecond);
            b = randomNum1b.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum1c = new Random(DateTime.Now.Millisecond);
            c = randomNum1c.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum1d = new Random(DateTime.Now.Millisecond);
            d = randomNum1d.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);

            //SECOND MATRIX
            Thread.Sleep(20);
            Random randomNum2a = new Random(DateTime.Now.Millisecond);
            e = randomNum2a.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum2b = new Random(DateTime.Now.Millisecond);
            f = randomNum2b.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum2c = new Random(DateTime.Now.Millisecond);
            g = randomNum2c.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);
            Random randomNum2d = new Random(DateTime.Now.Millisecond);
            h = randomNum2d.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);

            //3x3 MATRIX:
            Thread.Sleep(20);
            Random randomNum3a = new Random(DateTime.Now.Millisecond);
            f = randomNum3a.Next(minNumbers, maxNumbers);
            Thread.Sleep(20);


            //Print to the user:
            Console.WriteLine(questionArray[questionNumber]);
            if (questionNumber == 0 || questionNumber == 1)
            {
                Console.WriteLine("/ " + a + " " + b + " \\");
                Console.WriteLine("\\ " + c + " " + d + " /");

                
                Console.Write("a=");
                double userAnswerForA = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("b=");
                double userAnswerForB = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("c=");
                double userAnswerForC = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("d=");
                double userAnswerForD = Convert.ToDouble(Console.ReadLine());
                

                //Calculate Right Answer:
                if (questionNumber == 0)
                {
                    double differential = (a * d) - (c * d);
                    if (differential == 0)
                    {
                        double correctAnswerA = 0;
                        double correctAnswerB = 0;
                        double correctAnswerC = 0;
                        double correctAnswerD = 0;

                        if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD)
                        {
                            Console.Clear();
                            Console.WriteLine("You have gotten the answer wrong! :(");
                            Console.WriteLine("Correct Answer:");
                            Console.WriteLine("The matrix is singular (leave answer as 0 for all values, if the matrix is singular.");
                            response = Console.ReadLine();
                            if (response == "r")
                            {
                                Game();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You have gotten the answer right! :)");
                            Console.WriteLine("Correct Answer:");
                            Console.WriteLine("The matrix is singular.");
                            response = Console.ReadLine();
                            if (response == "r")
                            {
                                Game();
                            }
                        }
                    }
                    else
                    {
                        double tempAnswerA = d;
                        double tempAnswerB = -1 * b;
                        double tempAnswerC = -1 * c;
                        double tempAnswerD = a;

                        double correctAnswerA = tempAnswerA / differential;
                        double correctAnswerB = tempAnswerB / differential;
                        double correctAnswerC = tempAnswerC / differential;
                        double correctAnswerD = tempAnswerD / differential;

                        if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD)
                        {
                            Console.Clear();
                            Console.WriteLine("You have gotten the answer wrong! :(");
                            Console.WriteLine("Correct Answer:");
                            Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                            Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                            response = Console.ReadLine();
                            if (response == "r")
                            {
                                Game();
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You have gotten the answer right! :)");
                            Console.WriteLine("Correct Answer:");
                            Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                            Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                            response = Console.ReadLine();
                            if (response == "r")
                            {
                                Game();
                            }
                        }
                    }
                }
                else if (questionNumber == 1)
                {
                    double correctAnswerA = Math.Pow(a, 2) + (b * c);
                    double correctAnswerB = (a * b) + (b * d);
                    double correctAnswerC = (c * a) + (d * c);
                    double correctAnswerD = (c * b) + Math.Pow(d, 2);

                    if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD)
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer wrong! :(");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer right! :)");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                }
            }
            else if(questionNumber == 2 || questionNumber == 3)
            {
                Console.WriteLine("/ " + a + " " + b + " \\");
                Console.WriteLine("\\ " + c + " " + d + " /");
                Console.WriteLine("----------------------");
                Console.WriteLine("/ " + e + " " + f + " \\");
                Console.WriteLine("\\ " + g + " " + h + " /");

                Console.Write("a=");
                double userAnswerForA = Convert.ToDouble(Console.ReadLine());

                Console.Write("b=");
                double userAnswerForB = Convert.ToDouble(Console.ReadLine());

                Console.Write("c=");
                double userAnswerForC = Convert.ToDouble(Console.ReadLine());

                Console.Write("d=");
                double userAnswerForD = Convert.ToDouble(Console.ReadLine());

                if (questionNumber == 2)
                {
                    double correctAnswerA = a + e;
                    double correctAnswerB = b + f;
                    double correctAnswerC = c + g;
                    double correctAnswerD = d + h;

                    if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD)
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer wrong! :(");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer right! :)");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                }
                else if (questionNumber == 3)
                {
                    double correctAnswerA = (a * e) + (b * g);
                    double correctAnswerB = (a * f) + (b * h);
                    double correctAnswerC = (c * e) + (d * g);
                    double correctAnswerD = (c * f) + (d * h);

                    if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD)
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer wrong! :(");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer right! :)");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + correctAnswerA + " " + correctAnswerB + " \\");
                        Console.WriteLine("\\ " + correctAnswerC + " " + correctAnswerD + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                }
            }
            else if (questionNumber == 4)
            {
                Console.WriteLine("/ " + a + " " + b + " " + c + " \\");
                Console.WriteLine("| " + d + " " + e + " " + f + " |");
                Console.WriteLine("\\ " + g + " " + h + " " + i + " /");

                Console.Write("a=");
                double userAnswerForA = Convert.ToDouble(Console.ReadLine());

                Console.Write("b=");
                double userAnswerForB = Convert.ToDouble(Console.ReadLine());

                Console.Write("c=");
                double userAnswerForC = Convert.ToDouble(Console.ReadLine());

                Console.Write("d=");
                double userAnswerForD = Convert.ToDouble(Console.ReadLine());

                Console.Write("e=");
                double userAnswerForE = Convert.ToDouble(Console.ReadLine());

                Console.Write("f=");
                double userAnswerForF = Convert.ToDouble(Console.ReadLine());

                Console.Write("g=");
                double userAnswerForG = Convert.ToDouble(Console.ReadLine());

                Console.Write("h=");
                double userAnswerForH = Convert.ToDouble(Console.ReadLine());

                Console.Write("i=");
                double userAnswerForI = Convert.ToDouble(Console.ReadLine());

                //MATHS FOR 3x3 MATRIX wish me luck this'll be hard :(
                //CALC DETERMINANT:
                double det1temp = a * ((e * i) - (f * h));
                double det2temp = b * ((d * i) - (f * g));
                double det3temp = c * ((d * g) - (e * f));
                double finalDeterminant = det1temp - det2temp + det3temp;
                if (finalDeterminant == 0)
                {
                    double correctAnswerA = 0;
                    double correctAnswerB = 0;
                    double correctAnswerC = 0;
                    double correctAnswerD = 0;
                    double correctAnswerE = 0;
                    double correctAnswerF = 0;
                    double correctAnswerG = 0;
                    double correctAnswerH = 0;
                    double correctAnswerI = 0;

                    if (correctAnswerA != userAnswerForA || correctAnswerB != userAnswerForB || correctAnswerC != userAnswerForC || correctAnswerD != userAnswerForD || correctAnswerE != userAnswerForE || correctAnswerF != userAnswerForF || correctAnswerG != userAnswerForG || correctAnswerH != userAnswerForH || correctAnswerI != userAnswerForI)
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer wrong! :(");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The matrix is singular (leave answer as 0 for all values, if the matrix is singular.");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer right! :)");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("The matrix is singular.");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                }
                else if (finalDeterminant != 0)
                {
                    //MATRIX OF MINORS CALC:
                    double minorA = (e * i) - (f * h);
                    double minorB = (d * i) - (f * g);
                    double minorC = (d * h) - (e * g);
                    double minorD = (b * i) - (c * h);
                    double minorE = (a * i) - (c * g);
                    double minorF = (a * h) - (b * g);
                    double minorG = (b * f) - (c * e);
                    double minorH = (a * f) - (c * d);
                    double minorI = (a * e) - (b * d);

                    //Cofactors Stuff:
                    minorB = -1 * minorB;
                    minorD = -1 * minorC;
                    minorF = -1 * minorF;
                    minorH = -1 * minorH;

                    //Transpose Stuff:
                    double finalA = minorA;
                    double finalB = minorD;
                    double finalC = minorG;
                    double finalD = minorB;
                    double finalE = minorE;
                    double finalF = minorH;
                    double finalG = minorC;
                    double finalH = minorF;
                    double finalI = minorI;

                    //FINAL CALCULATIONS (Finally):
                    double okThisIsTheRealFinalA = finalA / finalDeterminant;
                    double okThisIsTheRealFinalB = finalB / finalDeterminant;
                    double okThisIsTheRealFinalC = finalC / finalDeterminant;
                    double okThisIsTheRealFinalD = finalD / finalDeterminant;
                    double okThisIsTheRealFinalE = finalE / finalDeterminant;
                    double okThisIsTheRealFinalF = finalF / finalDeterminant;
                    double okThisIsTheRealFinalG = finalG / finalDeterminant;
                    double okThisIsTheRealFinalH = finalH / finalDeterminant;
                    double okThisIsTheRealFinalI = finalI / finalDeterminant;

                    if (okThisIsTheRealFinalA != userAnswerForA || okThisIsTheRealFinalB != userAnswerForB || okThisIsTheRealFinalC != userAnswerForC || okThisIsTheRealFinalD != userAnswerForD || okThisIsTheRealFinalE != userAnswerForE || okThisIsTheRealFinalF != userAnswerForF || okThisIsTheRealFinalG != userAnswerForG || okThisIsTheRealFinalH != userAnswerForH || okThisIsTheRealFinalI != userAnswerForI)
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer wrong! :(");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + okThisIsTheRealFinalA + " " + okThisIsTheRealFinalB + " " + okThisIsTheRealFinalC + " \\");
                        Console.WriteLine("| " + okThisIsTheRealFinalD + " " + okThisIsTheRealFinalE + " " + okThisIsTheRealFinalF + " |");
                        Console.WriteLine("\\ " + okThisIsTheRealFinalG + " " + okThisIsTheRealFinalH + " " + okThisIsTheRealFinalI + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have gotten the answer right! :)");
                        Console.WriteLine("Correct Answer:");
                        Console.WriteLine("/ " + okThisIsTheRealFinalA + " " + okThisIsTheRealFinalB + " " + okThisIsTheRealFinalC + " \\");
                        Console.WriteLine("| " + okThisIsTheRealFinalD + " " + okThisIsTheRealFinalE + " " + okThisIsTheRealFinalF + " |");
                        Console.WriteLine("\\ " + okThisIsTheRealFinalG + " " + okThisIsTheRealFinalH + " " + okThisIsTheRealFinalI + " /");
                        response = Console.ReadLine();
                        if (response == "r")
                        {
                            Game();
                        }
                    }
                }
            }
            response = Console.ReadLine();
            if (response == "r")
            {
                Game();
            }
        }


        static void Main(string[] args)
        {
            Game();
        }
    }
}
