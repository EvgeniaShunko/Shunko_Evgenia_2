using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_1.Data
{
    class ToysPool
    {
        public List<Toy> allToys { get; private set; } = new List<Toy>();

        public void AddToy(Toy toy)
        {
            allToys.Add(toy);
        }
    }
}
