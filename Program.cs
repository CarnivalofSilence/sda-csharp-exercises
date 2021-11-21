using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Conan";
            /* player.Stats = new PlayerStats();
             player.Stats.XP = 60;*/
            player.XP = 60;
            Item sword = new Item();
            sword.Name = "Exalibur";
            player.Items.Add(sword);
            /*  Console.WriteLine(player.Stats.XP);*/
            Console.WriteLine(player.XP);
            foreach (var item in player.Items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
