using System;

namespace SwordDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            SwordDamage swordDamage = new SwordDamage();


            while (true)
            {
                
                Console.WriteLine("\n0 for no magic/flaming\n1 for magic\n2 for flaming\n3 for both\n**Hit any other key to quit**");
                char key = Console.ReadKey().KeyChar;
                Console.Clear();
                
                if (key != '0' && key !='1' && key != '2' && key != '3')
                {
                    
                    return;
                }

                int roll = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);
                swordDamage.roll = roll;
                swordDamage.SetMagic(key == '1' || key == '3');
                swordDamage.SetFlaming(key == '2' || key == '3');
                Console.WriteLine("\nRolled " + roll + " for " + swordDamage.damage + " HP\n");
                Console.ReadLine();
                Console.Clear();


            }

        }
    }
}
