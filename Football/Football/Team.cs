using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Team
    {
        public string Name { get; set; }
        public double Luck { get; set; }

        double team_skill;
        public void AddPlayer(int[] team_strong)
        {
            Player player6 = new Player("name6", 21);
            team_skill = player6.Skill;
            Console.WriteLine(player6.Skill);
        }
        public Team(string name, int[] team_strong, double coach_luck, List<string> names)
        {
            Name = name;
            for (int i = 0; i < team_strong.Length; i++)
            {
                team_skill += team_strong[i];
            }
            team_skill = team_skill * coach_luck;
        }
        public double Team_skill
        {
            get { return team_skill; }
        }

    }
}
