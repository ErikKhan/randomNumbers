using System;

namespace exercise_week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generating random numbers. Exercise 1
            //double sum = 0;
            //Random random = new Random();
            //for (int i = 1; i < 10; i++)
            //{             
            //    double a = Convert.ToDouble(random.Next(1, 101));
            //    Console.WriteLine($"The Random numbers are: {a}");

            //    sum = sum + a;


            //    }
            //Console.WriteLine($"The Sum is, {sum}");

            // Generating random number Odd and Positive
            //Random random = new Random();


            //for (int i = 0; i < 10; i++)
            //{
            //    int a = random.Next(-10, 11);
            //    if (a % 2 == 0 && a < 0) { Console.WriteLine($"It is an negative/even  number {a}"); }
            //    else if((a % 2 != 0 && a > 0)) { Console.WriteLine($"It is an odd/Positive number: {a}"); }
            //}


            // Read postive integers

            
            Random random = new Random();
            Console.WriteLine("Enter Postive Integer: ");
            int ans = Convert.ToInt32(Console.ReadLine());
            
     ;      if(ans > 0)
            {
                int[] number = new int[ans];

                for (int i = 0; i < ans; i++)
                {
                    // generate in single line random numbers (1, 101)
                    number[i] = random.Next(1, 101);
                    Console.Write(number[i] + " ");

                }
                int max = 0, min = number[0], sum = 0;
                // Avg Value, Min value, Max value,
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] > max)
                        max = number[i];
                    if (number[i] < min)
                        min = number[i];
                    sum += number[i];
                }
                Console.WriteLine();
                Console.WriteLine("max = " + max + "   min =" + min + "    avg =" + (sum / number.Length));

            }

            else
            {
                Console.WriteLine("Invalid Input: ");
            }


            Console.ReadLine();

                  
                
                       
                
          

            
           
            
                 
            
                       
        }
    }
}
