/*http://www.c-sharpcorner.com/UploadFile/d0e913/the-fibonacci-numbers/
 * Created by SharpDevelop.
 * User: skorir002
 * Date: 10/17/2016
 * Time: 11:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Fibonacci
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Console.WriteLine("Hello World!");
			Fibonacci_Iterative(9999999999999999);
			
			//Console.Write(FibonacciSeries(46));  
			/* print
			 int n= 47;  
			for (int i = 0; i < n; i++)  
            {  
                Console.Write("{0} ", FibonacciSeries(i));  
            }  
            */
			
			Console.ReadKey(true);
		}
		public static int FibonacciSeries(int n)   // recursive
            {  
                  if (n == 0) return 0; //To return the first Fibonacci number   
                  if (n == 1) return 1; //To return the second Fibonacci number   
                  return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);  
                  
            }  
		public static void Fibonacci_Iterative(double len)
        {
            double a = 0, b = 1, c = 0;
            
            Console.Write("{0} {1}", a,b);
 
            for (int i = 2; i < len; i++)
            {
                c= a + b;
                Console.Write(" {0}", c);
                a= b;
                b= c;
            }
       }
	}
}