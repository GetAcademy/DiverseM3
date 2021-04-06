using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseM3
{
    class Program2 : IHandler
    {
        static void Mainx(string[] args)
        {
            var program = new Program2();
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
            Console.WriteLine("#####");
        }
    }
}
