using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    
    class Being : Friend
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Yum, I ate {food}");

        }
    }
    public interface IBeing
    {

    }
}
