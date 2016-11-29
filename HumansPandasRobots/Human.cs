using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Human : IBeing
    {
        public string food = "taco";

        public void Eat(string food)
        {
            Console.WriteLine($"Yum I ate {food}");
        }

    }
             
    }

   
}
