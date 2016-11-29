using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Panda : IBeing
    {
        public string food = "Bamboo";
        public void Eat(string food)
        {
            Console.WriteLine($"Yum I ate {food}"); 
        }
    }
}
