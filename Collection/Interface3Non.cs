using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Interface3Non
    {       // IComparer Interface in Non-Generic.
        public class Player
        {
            private int runs;
            private string name;
            public Player(int runs , string name)
            {
                this.runs = runs;
                this.name = name;
            }
            public int Runs
            {
                get { return runs; }
            }
        }
        public class CheckRuns : IComparer
        {
            public int Compare(object x, object y)
            {
               Player p1 = (Player)x;
               Player p2 = (Player)y;
               
                if(p1.Runs > p2.Runs)
                {
                    return 1;
                }
                else if(p1.Runs < p2.Runs)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Player sachin = new Player(2000, "Sachin");
            Player virat = new Player(5000, "Virat");
            CheckRuns c1 = new CheckRuns();
            int result = c1.Compare(sachin, virat);
            if(result == 1)
            {
                Console.WriteLine("Sachin has more runs than Virat ");
            }
            else if(result == -1)
            {
                Console.WriteLine("Sachin has less runs than Virat");
            }
            else
            {
                Console.WriteLine("Sachin $ Virat has euqal runs");
            }
        }
    }
}
