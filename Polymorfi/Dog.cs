using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class Dog : Animals
    {
        public Dog(string name) : base(name) { }

        public override string MakeSound()
        {
            string opgaveDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(opgaveDirectory, "Lydfil", "dog.wav");
            SoundPlayer player = new SoundPlayer(filePath);
            player.PlaySync();
            return "Vow";
        }
    }
}
