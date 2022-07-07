using System;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            Console.WriteLine("This is TraditionalDelegateSyntax() example:\n");
            TraditionalDelegateSyntax();
            Console.WriteLine("\nThis is AnonymousMethodSyntax() example:\n");
            AnonymousMethodSyntax();
        }

        static void TraditionalDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Вызвать FindAll() с применением традиционного синтаксиса делегатов.
            Predicate<int> callback = IsEvenNumber;
            List<int> evenNumbers = list.FindAll(callback);
            Console.WriteLine("Here are your even numbers:");
            foreach(int evenNumber in evenNumbers)
                Console.WriteLine("{0}\t",evenNumber);
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
    }
}
