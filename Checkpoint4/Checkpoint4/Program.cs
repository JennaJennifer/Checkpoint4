using System;
using System.Linq;

namespace Checkpoint4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n\nBest movies ever:\n");

            var bestMoviesEver = new Title[]
            {
                new Title {MoveTitle = "Trouble of vendetta"},
                new Title {MoveTitle = "Reflex Blood"},
                new Title {MoveTitle = "Master of Glory"},
                new Title {MoveTitle = "Extreme Blood"},
                new Title {MoveTitle = "Battle of Jeopardy"}
            };

            var orderBme = bestMoviesEver
                .OrderBy(e => e.MoveTitle);

            foreach (var title in orderBme)
            {
                Console.WriteLine(title.MoveTitle);
            }

            Console.WriteLine("\nCopyright Jennifer 2018\n");
        }
    }
}
