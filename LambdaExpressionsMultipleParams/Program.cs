using System;

namespace LambdaExpressionsMultipleParams
{
    class Program
    {
        public delegate string VerySimpleDelegate();
        static void Main(string[] args)
        {
            // Зарегистрировать делегат как лямбда-выражеие.
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
            {
                Console.WriteLine("Message: {0}, Result: {1}", msg, result);
            });
            // Выполнение лямбда-выражения.
            m.Add(10, 25);
            Console.WriteLine();
            VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Here could be your advertisement! :)"; });
            Console.WriteLine(d());
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
