using System;
using System.Text;

namespace ProjectHome1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            FootballTeam team = new FootballTeam("Динамо", 10);
            team.AddPlayer(new FootballPlayer("Андрій", 1, FootballRole.Goalkeeper, 70, 85));
            team.AddPlayer(new FootballPlayer("Олександр", 2, FootballRole.Defender, 75, 90));
            team.AddPlayer(new FootballPlayer("Максим", 3, FootballRole.Midfielder, 90, 80));
            team.AddPlayer(new FootballPlayer("Дмитро", 4, FootballRole.Forward, 95, 85));

            team.ShowTeam();
            Console.WriteLine("\nЗаміна гравця:");
            team.ReplacePlayer(3, new FootballPlayer("Віктор", 5, FootballRole.Midfielder, 88, 87));

            team.ShowTeam();
            Console.WriteLine("\nВидалення гравця:");
            team.RemovePlayer(2);
            team.ShowTeam();
            Console.WriteLine("\nПеревірка foreach:");
            foreach (FootballPlayer player in team)
            {
                Console.WriteLine(player);
            }
            Console.ReadKey();
        }
    }
}
