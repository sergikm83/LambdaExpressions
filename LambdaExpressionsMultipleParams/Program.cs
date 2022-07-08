﻿using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class SimpleMath
    {
        public delegate void MathMessage(string msg, int result);
        private MathMessage mmDelegate;

        public void SetMathHandler(MathMessage target)
        {
            mmDelegate = target;
        }
        public void Add(int x, int y)
        {
            mmDelegate?.Invoke("Adding has completed!", x + y);
        }
    }
}
