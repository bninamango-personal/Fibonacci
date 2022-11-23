﻿using System;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci : " + Fibonacci(3));
        }

        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;

            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}