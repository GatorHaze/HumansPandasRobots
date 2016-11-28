using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Friend
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public bool IsAsleep { get; set; } = true;
        

        public Friend()
        {
            this.Name = Name;
            this.Greeting = Greeting;
        }

        public string DisplayName()
        {
            return Name;
        }

        public string DisplayGreeting()
        {
            return Greeting;
        }

        

    }
}
