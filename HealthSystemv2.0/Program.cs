using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv2._0
{
    internal class Program
    {
        static Player player;
        static ConsoleKeyInfo input;
        static string storageString;
        static int storageInt;

        static void Main(string[] args)
        {
            player = new Player();

            Console.WriteLine("Welcome to Health System v2.0");
            Console.WriteLine("A player has been created for us to test with.");
            Pause();

            while (input.Key != ConsoleKey.D0)
            {
                Console.Clear();
                Console.WriteLine("Please choose from the following options: ");
                Console.WriteLine();
                Console.WriteLine("(1) Display Player Stats");
                Console.WriteLine("(2) Simulate Damage");
                Console.WriteLine("(3) Simulate Heal");
                Console.WriteLine("(4) Revive Player");
                Console.WriteLine("(0) Quit");
                Console.WriteLine();

                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.D1)
                {
                    player.ShowHUD();
                    Pause();
                }

                if (input.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("How much damage to simulate?");
                    Console.Write("Enter harm: ");

                    storageString = Console.ReadLine();
                    bool isNumber = int.TryParse(storageString, out storageInt);

                    if (isNumber == false)
                    {
                        Console.WriteLine("That is not a valid value for harm.");
                        Pause();
                    }

                    if (isNumber == true)
                    {
                        player.TakeDamage(storageInt);
                        Pause();
                    }
                }

                if (input.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("How much healing to simulate?");
                    Console.Write("Enter heal: ");

                    storageString = Console.ReadLine();
                    bool isNumber = int.TryParse(storageString, out storageInt);

                    if (isNumber == false)
                    {
                        Console.WriteLine("That is not a valid value for heal.");
                        Pause();
                    }

                    if (isNumber == true)
                    {
                        player.Heal(storageInt);
                        Pause();
                    }
                }

                if (input.Key == ConsoleKey.D4)
                {
                    player.Revive();
                    Pause();
                }
            }
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
        }
    }
}
