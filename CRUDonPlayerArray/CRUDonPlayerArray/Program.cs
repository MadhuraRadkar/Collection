using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDonPlayerArray
{
    public class Program
    {
        static void Main(string[] args)
        {
          PlayerImplementation player = new PlayerImplementation();
            char ch = ' ';
            do
            {
                Console.WriteLine("1.Insert\n 2.Show\n 3.Update\n 4.Delete\n 5.Search");
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("How many player you want to add");
                        int n=Convert.ToInt32(Console.ReadLine());
                        player.AddPlayer(n);
                        break;
                    case 2:
                       
                        player.ShowAllPlayers();
                        break;
                    case 3:
                        Console.WriteLine("Enter the player id for update");
                        int pid=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter new runs");
                        int runs = int.Parse(Console.ReadLine());
                        player.UpdatePlayer(pid, runs);
                        Console.WriteLine("Player updated...");
                        break;
                    case 4:
                        Console.WriteLine("Enter the player id for delete");
                        int d =Convert.ToInt32(Console.ReadLine());
                        player.DeletePlayer(d);
                        Console.WriteLine("Player deleted...");
                        break;
                    case 5:
                        Console.WriteLine("Enter player id for search");
                        int id = Convert.ToInt32(Console.ReadLine());
                        player.SearchPlayerById(id);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Press y or Y if you want to continue....");
                ch=Convert.ToChar(Console.ReadLine());

            } while (ch=='y' || ch=='Y');
        }
    }
}
