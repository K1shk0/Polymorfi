using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class Animals
    {
        public string Name { get; set; }

        protected Animals(string name)
        {
            Name = name;
        }

        public abstract string MakeSound();
    }
}
