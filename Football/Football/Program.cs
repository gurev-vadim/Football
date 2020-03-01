using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1_t1 = new Player("Messi", 31);
            Player player2_t1 = new Player("Suarez", 31);
            Player player3_t1 = new Player("Neymar", 26);
            Player player4_t1 = new Player("Iniesta", 34);
            Player player5_t1 = new Player("Xavi", 38);
            int[] mas_strong1 = { player1_t1.Skill, player2_t1.Skill, player3_t1.Skill, player4_t1.Skill, player5_t1.Skill };
            List<string> names1 = new List<string>() { player1_t1.Name, player2_t1.Name, player3_t1.Name, player4_t1.Name, player5_t1.Name };
            Player player1_t2 = new Player("Ronaldo", 33);
            Player player2_t2 = new Player("Benzema", 31);
            Player player3_t2 = new Player("Bale", 29);
            Player player4_t2 = new Player("Modric", 33);
            Player player5_t2 = new Player("Ramos", 32);
            int[] mas_strong2 = { player1_t2.Skill, player2_t2.Skill, player3_t2.Skill, player4_t2.Skill, player5_t2.Skill };
            List<string> names2 = new List<string>() { player1_t2.Name, player2_t2.Name, player3_t2.Name, player4_t2.Name, player5_t2.Name };
            Coach coach1 = new Coach("surname");
            Coach coach2 = new Coach("surname");
            Team team1 = new Team("Barcelona", mas_strong1, coach1.Luck,names1);
            Team team2 = new Team("Real Madrid", mas_strong2, coach2.Luck,names2);
            Console.WriteLine("тренер 1 {0}",coach1.Luck);
            Console.WriteLine("тренер 2 {0}",coach2.Luck);
            
            Game game = new Game(team1.Name, team1.Team_skill, team2.Name, team2.Team_skill);
            Console.ReadLine();
        }
    }
}
