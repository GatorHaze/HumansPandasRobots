using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Robot : Friend
    {
        public bool ShutDown { get; set; } = true;
        public bool StartUp { get; set; }

        public void Shutdown()
        {
            Console.WriteLine("Shutdown...");
            IsAsleep = true;
        }

        public void StrarUp ()
        {
            Console.WriteLine("Started...");
            IsAsleep = false;
        }
        



	}     
    
}
