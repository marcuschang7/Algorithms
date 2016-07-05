using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Algorithms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            return View();
        }




        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        private static bool primeNumberTest1(int i)
        {
            return i > 3 ? ((Enumerable.Range(2, (i / 2) + 1).Where(x => (i % x == 0))).Count() > 0 ? false : true) : i == 2 || i == 3 ? true : false;
        }
        public static bool IsPrimeTest2(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
        #region Selection Algorithm
        // Below is a simple c# code for selection algorithm.
        // array of integers to hold values

        private static int[] a = new int[4] { 2, 8, 0, 3 };

        static void Main(string[] args)
        {

            Sort();

            foreach (int temp in a)
            {

                Console.WriteLine(temp);

            }

            Console.ReadLine();

        }

        public static void Sort()
        {

            int i, j;
            int min, temp;

            for (i = 0; i < a.Count() - 1; i++) // Loop through each element
            //for (i = 0; i < a.Count() – 1; i++) // Loop through each element
            {
                min = i; // Assume that he is the smallest

                for (j = i + 1; j < a.Count(); j++) // Loop through the remaining element
                {
                    if (a[j] < a[min]) // If the current value smaller than the min
                    {
                        min = j; // Swap the values
                    }
                }
                temp = a[i]; // Store the current value in temp variable
                a[i] = a[min]; // Swap the minimum  value to the current position
                a[min] = temp; // Swap the current value to the minimum value position

            }

        }
        #endregion
    }
}
