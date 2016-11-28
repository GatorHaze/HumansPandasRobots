using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Panda : IBeing
    {
        public void Eat()
        {
            var food = "taco";
            Console.WriteLine($"Yum I ate {food}"); 
        }
    }
}
