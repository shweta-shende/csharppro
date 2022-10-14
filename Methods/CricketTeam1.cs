using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Methods
{
    internal class CricketTeam1
    {
       public string player1;
       public string player2;
        int player3;
        string player4;
        string player5;
        string player6;
        string player7;
        string player8;
        string player9;
        string player10;
        string player11;

        public void Batsman(string player1, string player2)
        {
            Console.WriteLine(this.player1 = player1);
            Console.WriteLine(this.player2 = player2);
        }
        public void Batsman(string player1, string player2, int player3)
        {
            Console.WriteLine(this.player2 = player2);
            Console.WriteLine(this.player3 = player3);

        }
        public void Batsman(int player3, string player4)
        {
            Console.WriteLine(this.player3 = player3);
            Console.WriteLine(this.player4 = player4);
        }
        public void Batsman(string player5, int player3)
        {
            Console.WriteLine(this.player5 = player5);
            Console.WriteLine(this.player3 = player3);
        }
    }
    class ExtraTeamPlayer : CricketTeam1
    {
        public void Batsman(string player1,string player2)
        {
            Console.WriteLine(base.player1=player1);
            Console.WriteLine(base.player2=player2);
        }
        static void Main1()
        {
     ExtraTeamPlayer tt=new ExtraTeamPlayer();
            tt.Batsman("ff", "uu");
            CricketTeam1 tt1 = new ExtraTeamPlayer();
            tt1.Batsman("saaaa", 3);

        }
}
    
             
            




            
    
}
