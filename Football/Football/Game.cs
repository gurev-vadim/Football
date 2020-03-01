using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public string NameTeam1 { get; set; }
        public string NameTeam2 { get; set; }
        public Game(string name_team1, double skill_team1, string name_team2, double skill_team2)
        {
            if (Math.Abs((skill_team1 - skill_team2)) < (skill_team1 * 0.1))
                Console.WriteLine("Ничья {0} {1}", skill_team1, skill_team2);

            else
            if (skill_team1 > skill_team2) Console.WriteLine("Победила команда {0} {1} {2}", name_team1, skill_team1, skill_team2);
            else
                Console.WriteLine("Победила команда {0} {1} {2}", name_team2, skill_team1, skill_team2);
        }
    }
}
