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
        double luck;
        
        public Coach(string surname)
        {
            Surname=surname;

            Random rand = new Random();
            Thread.Sleep(100);
            luck = rand.Next(11 , 15)/10.0;
            
        }
        public double Luck
        {
            get { return luck; }
        }
        //public string SurnameOfCoach
        //{
        //    get { return Surname; }
        //}
    }
}
