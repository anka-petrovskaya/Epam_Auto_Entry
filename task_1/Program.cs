using System;
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            var first = calculator.SetFirstNumber();
            var second = calculator.SetSecondNumber();
            var result = calculator.Calculate(first, second);
            calculator.ShowResult(result);

            var Girls = new string[] { "Hanna", "Katerina", "Olga", "Volga", "Alexandra" };
            Revert revert = new Revert();
            var newGirls = revert.RevertArray(Girls);
            revert.ShowResult(newGirls);
        }
    }
}