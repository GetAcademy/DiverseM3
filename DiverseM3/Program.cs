using System;

namespace DiverseM3
{
    class Program : IHandler
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
        }

        private void Run()
        {
            var game = new ClickerGame(this);
            while (true)
            {
                game.Click();
                Console.WriteLine(game.Count);
                Console.ReadKey(true);
            }
        }

        public void Show10()
        {
            Console.WriteLine("******");
        }

    }
}
