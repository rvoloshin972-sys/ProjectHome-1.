using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjectHome1
{
    public class FootballTeam : IEnumerable<FootballPlayer>
    {
        private FootballPlayer?[] players;
        private int count;
        public string TeamName { get; set; }
        public FootballTeam(string teamName, int capacity) 
        {
            TeamName = teamName;
            players = new FootballPlayer[capacity];
            count = 0;
        }
        public void AddPlayer(FootballPlayer player)
        {
            int index = Array.FindIndex(players, p => p == null);
            bool added = index >= 0;
            players[index < 0 ? 0 : index] = added ? player : players[0];

            count += added ? 1 : 0;
            Console.WriteLine(added
                ? "Гравця додано!"
                : "Команда заповнена!");
        }
        public void RemovePlayer(int number)
        {
            int index = Array.FindIndex(players, p => p != null && p.Number == number);
            bool removed = index >= 0;
            for (int i = (index < 0 ? count : index);
                 i < count - 1; i++)
            {
                players[i] = players[i + 1];
            }
            players[removed ? count - 1 : count] = null;
            count -= removed ? 1 : 0;
            Console.WriteLine(removed
                ? "Гравця видалено!"
                : "Гравця не знайдено!");
        }
        public void ReplacePlayer(int number, FootballPlayer newPlayer)
        {
            int index = Array.FindIndex(players, p => p != null && p.Number == number);

            bool replaced = index >= 0;
            players[index < 0 ? 0 : index] = replaced ? newPlayer : players[index < 0 ? 0 : index];

            Console.WriteLine(replaced
                ? "Гравця замінено!"
                : "Гравця не знайдено!");
        }
        public void ShowTeam()
        {
            Console.WriteLine($"\nФутбольна команда: {TeamName}");
            foreach (FootballPlayer player in this)
            {
                Console.WriteLine(player);
            }
        }
        public IEnumerator<FootballPlayer> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return players[i]!;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
