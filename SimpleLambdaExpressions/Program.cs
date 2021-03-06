using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            Console.WriteLine("\nThis is LambdaExpressionSyntax() example:\n");
            LambdaExpressionSyntax();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Вызвать FindAll() с применением традиционного синтаксиса делегатов.
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
                Console.WriteLine("{0}\t", evenNumber);
            Console.WriteLine();
        }

        // Цель для делегата Predicate<>.
        static bool IsEvenNumber(int i) => i % 2 == 0;

        static void AnonymousMethodSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Теперь использовать анонимный метод.
            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2 == 0); });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
                Console.WriteLine("{0}\t", evenNumber);
            Console.WriteLine();
        }

        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Теперь использовать лямбда-выражение C#.
            List<int> evenNumbers = list.FindAll((i) =>
            {
                // текущее значение i
                Console.WriteLine("value of i is currently: {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });
            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
                Console.WriteLine("{0}\t", evenNumber);
            Console.WriteLine();
        }
    }
}
