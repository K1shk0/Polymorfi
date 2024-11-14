using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    internal class Sheep : Animals
    {
        public Sheep(string name) : base(name) { }

        public override string MakeSound()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "Lydfil", "sheep.wav");
            SoundPlayer player = new SoundPlayer(filePath);
            player.PlaySync();
            return "Baaah";
        }
    }
}
