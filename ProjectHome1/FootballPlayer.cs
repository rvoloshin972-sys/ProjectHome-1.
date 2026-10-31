using System;

namespace ProjectHome1
{
    public class FootballPlayer
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public FootballRole Role { get; set; }
        public int Speed { get; set; }
        public int Strength { get; set; }
        public FootballPlayer(string name, int number,FootballRole role, int speed, int strength)
        {
            Name = name;
            Number = number;
            Role = role;
            Speed = speed;
            Strength = strength;
        }
        public override string ToString()
        {
            return $"Ім'я: {Name}, Номер: {Number}, " +
                   $"Роль: {Role}, Швидкість: {Speed}, " +
                   $"Сила: {Strength}";
        }
    }
}
