using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumansPandasRobots
{
    public class Program
    {
        
        public static Friend Name { get; set; }
        static void Main(string[] args)
        {

            var human = new Human();
            var robot = new Robot();
            var panda = new Panda();

            var Mike = new Friend();
            Mike.Name = "Mike";
            Console.WriteLine(Mike.DisplayName());
            
            var Hello = new Friend();
            Hello.Greeting = "Hello Everyone!";
            Console.WriteLine(Hello.DisplayGreeting());
            Console.ReadLine();

            
            panda.Eat("Bamboo");
            Console.ReadLine();
                            
            
        }
    }
}
