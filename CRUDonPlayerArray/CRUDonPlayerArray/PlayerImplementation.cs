using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonPlayerArray
{
    internal class PlayerImplementation
    {
        Player[] player;
        int count;
        public PlayerImplementation()
        {
            player = new Player[3];
            count = 0;
        }
        public void AddPlayer(int n)
        {
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter the id");
                int pid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter player name");
                string playername = Console.ReadLine();
                Console.WriteLine("Enter player runs");
                int runs =Convert.ToInt32( Console.ReadLine());
                player[count]=new Player(pid, playername, runs);
                count++;
            }
        }
        public void ShowAllPlayers()
        {
            for(int i=0;i<count;i++)
            {
                if (player[i] != null)
                {
                    Console.WriteLine(player[i]);
                }
            }
        }
        public void SearchPlayerById(int id)
        {
            for(int i=0;i<player.Length;i++)
            {
                if (player[i] != null)
                {
                    if (player[i].Player_Id == id)
                    {
                        Console.WriteLine(player[i]);
                    }
                }
            }
        }
        public void UpdatePlayer(int id,int newruns)
        {
            for(int i=0; i<player.Length;i++)
            {
                if (player[i] != null)
                {
                    if (player[i].Player_Id == id)
                    {
                        player[i].Runs = newruns;
                    }
                }
            }
        }
        public void DeletePlayer(int id)
        {
            for(int i=0;i< player.Length; i++)
            {
                if (player[i] != null)
                {
                    if (player[i].Player_Id == id)
                    {
                        player[i]= null;
                    }
                }
            }
        }
    }
}
