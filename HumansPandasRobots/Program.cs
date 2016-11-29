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
           

            var Human = new Friend();
            Human.Name = "Mike";
            Console.WriteLine(Human.DisplayName());
            
            var Hello = new Friend();
            Hello.Greeting = "Hello Everyone!";
            Console.WriteLine(Hello.DisplayGreeting());
            Console.ReadLine();

           
            panda.Eat("Bamboo");
            Console.ReadLine();
                            
            
        }
    }
}
