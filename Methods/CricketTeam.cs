using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectc1.Methods
{
    internal class CricketTeam
    {
        string player1;
        string player2; 
        string player3; 
        string player4; 
        string player5; 
        string player6; 
        string player7;
        string player8; 
        string player9; 
        string player10;
        string player11;
    public void TopOrder(string player1,string player2,string player3)
        {
            Console.WriteLine(this.player1=player1);
            Console.WriteLine(this.player2=player2);    
            Console.WriteLine(this.player3=player3);    
        }
        public void MidOrder(string player4,string player5)
        {
            Console.WriteLine(this.player4=player4);    
            Console.WriteLine(this.player5=player5);
        }
        static void Main2()
        {
            CricketTeam team = new CricketTeam();
            team.TopOrder("rahul","kl","sachin");
            team.MidOrder("ss", "dhoni");
        }
    }
}
