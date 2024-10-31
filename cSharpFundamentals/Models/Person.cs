using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cSharpFundamentals.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Presentation()
        {
            Console.WriteLine($"Hello! I am {Name} and I am {Age} years old");
            //Another possibility
            Console.WriteLine($"Hello! I am {Name} " +
                                $"and I am {Age} years old");

        }
    }
}