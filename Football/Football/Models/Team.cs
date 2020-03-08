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

        public Team(string name, List<int> team_strong, double coach_luck, List<string> names )
        {
            Name = name;
            for (int i = 0; i < team_strong.Count; i++)
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
