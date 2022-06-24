using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            ToysPool pool = new ToysPool();
            pool.AddToy(new Doll("Medium", 100, 3, 7));
            pool.AddToy(new Doll("Small", 50, 10, 15));
            pool.AddToy(new Doll("Medium", 150, 6, 9));
            pool.AddToy(new Doll("Large", 200, 5, 10));
            pool.AddToy(new ToyCar("Small", 100, 3, 7));
            pool.AddToy(new ToyCar("Small", 50, 10, 15));
            pool.AddToy(new ToyCar("Medium", 150, 6, 9));
            pool.AddToy(new ToyCar("Large", 200, 5, 10));
            pool.AddToy(new Cube("Large", 200, 5, 18));
            pool.AddToy(new Cube("Large", 200, 5, 18));

            Playroom playroom1 = new Playroom(800, 5, 15);
            Playroom playroom2 = new Playroom(1000, 0, 10);

            playroom1.fillPlayroom(pool);
            playroom2.fillPlayroom(pool);

            Console.WriteLine("\nPlayroom 1\n");
            playroom1.PrintDetails();
            Console.WriteLine("\nPlayroom 2\n");
            playroom2.PrintDetails();

            Console.ReadKey();
        }
    }
}
