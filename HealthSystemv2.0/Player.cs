using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemv2._0
{
    internal class Player
    {
        // fields

        int health = 100;
        int healthMax = 100;
        int lives = 3;

        public void TakeDamage(int harm)
        {
            if (health == 0)
            {
                Console.WriteLine("Player is DEAD!");
            }

            else
            {
                health -= harm;

                if (health <= 0)
                {
                    Console.WriteLine("Health has dropped to zero! Player has DIED!");
                    health = 0;
                    lives--;

                    if (lives == 0)
                    {
                        Console.WriteLine("Player is out of lives!");
                    }
                }

                else
                {
                    Console.WriteLine("Player took " + harm + " damage! Health is now " + health + "!");
                }
            }
        }

        public void Heal(int heal)
        {
            if (health == 0)
            {
                Console.WriteLine("Player is dead and cannot be healed!");
            }

            else if (health != 0)
            {
                if (health == healthMax)
                {
                    Console.WriteLine("Health is already full!");
                }

                else if (health + heal >= healthMax)
                {
                    Console.WriteLine("Health is restored to full!");
                    health = healthMax;
                }

                else
                {
                    health += heal;
                    Console.WriteLine("Player is healed for " + heal + " points! Health is now " + health + ".");
                }
            }
        }

        public void Revive()
        {
            if (health != 0)
            {
                Console.WriteLine("Player does not need to be revived, added 1 life!");
                lives++;
            }

            else if (health == 0)
            {
                Console.WriteLine("Player has been revived!");
                health = healthMax;
            }
        }
        public void ShowHUD()
        {
            Console.WriteLine("Player Stats:");
            Console.WriteLine();
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
        }
    }
}
