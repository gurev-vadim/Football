using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Football
{
    class Coach
    {
        public string Surname { get; set; }
        //public int Age { get; set; }
        double luck;

        public Coach(string surname)
        {
            surname = Surname;

            Random rand = new Random();
            Thread.Sleep(100);
            luck = rand.Next(10 , 15)/10.0;
        }
        public double Luck
        {
            get { return luck; }

        }
    }
}
