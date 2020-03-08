using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Football
{
    ////////
    public delegate void Message(string message);
    public class Game
    {
        public string NameTeam1 { get; set; }
        public string NameTeam2 { get; set; }

        ////////////
        
        public event Message Notify;

        public void Goal(string name_team1, double skill_team1, string name_team2, double skill_team2)
        {

            if (Math.Abs((skill_team1 - skill_team2)) < (skill_team1 * 0.1))
            {
                //Console.WriteLine("Ничья \nОбщий скил команды {0} = {2} \nОбщий скил команды {1} = {3}", name_team1, name_team2, skill_team1, skill_team2);
                Notify?.Invoke("Ничья");
            }
            else
            if (skill_team1 > skill_team2)
                Notify?.Invoke("Победила Барселона");
            //Goal("Барса забила");
            //Console.WriteLine("Победила команда {0} \nОбщий скил команды {0} = {2} \nОбщий скил команды {1} = {3}", name_team1, name_team2, skill_team1, skill_team2);
            else
                Notify?.Invoke("Победил Реал");
            Notify?.Invoke("Матч окончен");

            //double max = skill_team1 + skill_team2;
            //int max_value = (int)max;
            //Random rand = new Random();
            //Thread.Sleep(100);
            //int goals = rand.Next(0, 5);
            //double goal=0;
            //for (int i = 0; i == goals; i++)
            //{
            //    goal = rand.Next(0, max_value);
            //    if(goal)
            //}
        }
        public  Game()
        {

            //if (Math.Abs((skill_team1 - skill_team2)) < (skill_team1 * 0.1))
            //    Console.WriteLine("Ничья \nОбщий скил команды {0} = {2} \nОбщий скил команды {1} = {3}", name_team1, name_team2, skill_team1, skill_team2);

            //else
            //if (skill_team1 > skill_team2)
            //    Notify?.Invoke("Барса забила");
            ////Goal("Барса забила");
            ////Console.WriteLine("Победила команда {0} \nОбщий скил команды {0} = {2} \nОбщий скил команды {1} = {3}", name_team1, name_team2, skill_team1, skill_team2);
            //else
            //    Notify?.Invoke("Рееал забила");
            ////Goal("Реал забила");
            ////Console.WriteLine("Победила команда {1} \nОбщий скил команды {0} = {2} \nОбщий скил команды {1} =  {3}", name_team1, name_team2, skill_team1, skill_team2);
        }
      
    }
}
