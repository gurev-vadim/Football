using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Football
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
        int skill;
        
        public Player(string name, int age)
        {
            Name = name;
            Age = age;
            Random rand = new Random();
            Thread.Sleep(100);
            skill = rand.Next(1, 100);
        }
        public int Skill
        {
            get { return skill; }

        }

    }
}
