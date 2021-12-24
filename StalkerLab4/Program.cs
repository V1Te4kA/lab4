using System;
using System.Collections.Generic;

namespace StalkerLab4
{
    class Program
    {
        public static void Main(String[] args)
        {
            var gun = new RiffleWeapon("AK-47", 28, 2700, 30);
            var player = new Player(gun);
            var mutant = new BuhrerMutant(180, 1000);
            var pistols = new List<PistolWeapon>()
            {
                new PistolWeapon("PM", 16, 256),
            };
            var riffles = new List<RiffleWeapon>()
            {
                new RiffleWeapon("M16", 32, 1024, 24),
            };
            var snipers = new List<SniperWeapon>()
            {
                new SniperWeapon("SVD", 128, 4096),
                new SniperWeapon("SVD-U", 96, 2048)
            };
            var seller = new Seller(pistols, riffles, snipers);
            
            Console.WriteLine(player.PrintState() + '\n');
            Console.WriteLine(player.Attack(mutant) + '\n');
            gun.BulletsToShoot = 3;
            Console.WriteLine(player.Attack(mutant) + '\n');
            gun.BulletsToShoot = 2;
            Console.WriteLine(player.Attack(mutant) + '\n');
            Console.WriteLine(player.Attack(mutant) + '\n');
            Console.WriteLine(player.Attack(mutant) + '\n');
            Console.WriteLine(player.PrintState() + '\n');
            
            Console.WriteLine(seller.PrintProducts());
            var newGun1 = seller.SellPistolWeapon(player, 1);
            var newGun5 = seller.SellPistolWeapon(player, 1);
            if (newGun1 == null)
            {
                Console.WriteLine("Insufficient funds or no such product in assortment\n");
            }
            else
            {
                player.SetWeapon(newGun1);
            }
            Console.WriteLine(player.PrintState() + '\n');
            Console.WriteLine(seller.PrintProducts());

            var newGun2 = seller.SellSniperWeapon(player, 2);
            if (newGun2 == null)
            {
                Console.WriteLine("Insufficient funds or no such product in assortment\n");
            }
            else
            {
                player.SetWeapon(newGun2);
            }
            Console.WriteLine(player.PrintState() + '\n');
            Console.WriteLine(seller.PrintProducts());
        }
    }
}