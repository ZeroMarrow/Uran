using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uran
{
    class Computer
    {
        public string Name { get; }
        public float Memory { get; }
        public Computer(string name, float memory)
        {
            Name = name;
            Memory = memory;
        }
    }
}
