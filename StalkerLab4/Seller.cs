using System.Collections.Generic;

namespace StalkerLab4
{
    public class Seller
    {
        public Seller(List<PistolWeapon> productsPistolWeapons, List<RiffleWeapon> productsRiffleWeapons, 
            List<SniperWeapon> productsSniperWeapons)
        {
            ProductsPistolWeapons = productsPistolWeapons;
            ProductsRiffleWeapons = productsRiffleWeapons;
            ProductsSniperWeapons = productsSniperWeapons;
        }

        public PistolWeapon SellPistolWeapon(Player player, int productNumber)
        {
            if (productNumber > ProductsPistolWeapons.Count || productNumber <= 0)
            {
                return null;
            }
            var product = ProductsPistolWeapons[productNumber-1];
            if (player.Money < product.Price)
            {
                return null;
            }
            ProductsPistolWeapons.Remove(product);
            player.Money -= product.Price;
            return product;
        }
       
        public RiffleWeapon SellRiffleWeapon(Player player, int productNumber)
        {
            if (productNumber > ProductsRiffleWeapons.Count || productNumber <= 0)
            {
                return null;
            }
            var product = ProductsRiffleWeapons[productNumber-1];
            if (player.Money < product.Price)
            {
                return null;
            }
            ProductsRiffleWeapons.Remove(product);
            player.Money -= product.Price;
            return product;
        }
        
        public SniperWeapon SellSniperWeapon(Player player, int productNumber)
        {
            if (productNumber > ProductsSniperWeapons.Count || productNumber <= 0)
            {
                return null;
            }
            var product = ProductsSniperWeapons[productNumber-1];
            if (player.Money < product.Price)
            {
                return null;
            }
            ProductsSniperWeapons.Remove(product);
            player.Money -= product.Price;
            return product;
        }
        
        public string PrintProducts()
        {
            string pistols = "Pistols:\n";
            for (int i = 0; i < ProductsPistolWeapons.Count; i++)
            {
                var pistol = ProductsPistolWeapons[i];
                pistols += (i+1) + ". " + pistol.Name + ' ' + pistol.Damage 
                           + "dmg " + pistol.Price + "$ (" + pistol.GetType().Name + ")\n";
            }
            if (pistols.Equals("Pistols:\n"))
            {
                pistols = "No pistols in store\n";
            }
            string riffles = "Riffles:\n";
            for (int i = 0; i < ProductsRiffleWeapons.Count; i++)
            {
                var riffle = ProductsRiffleWeapons[i];
                riffles += (i+1) + ". " + riffle.Name + ' ' + riffle.Price 
                           + "dmg " + riffle.Price + "$ (" + riffle.GetType().Name + ")\n";
            }
            if (riffles.Equals("Riffles:\n"))
            {
                riffles = "No riffles in store\n";
            }
            string snipers = "Snipers:\n";
            for (int i = 0; i < ProductsSniperWeapons.Count; i++)
            {
                var sniper = ProductsSniperWeapons[i];
                snipers += (i+1) + ". " + sniper.Name + ' ' + sniper.Damage 
                           + "dmg " + sniper.Price + "$ (" + sniper.GetType().Name + ")\n";
            }
            if (snipers.Equals("Snipers:\n"))
            {
                snipers = "No snipers in store\n";
            }
            return pistols + riffles + snipers;
        }

        private List<PistolWeapon> ProductsPistolWeapons;
        private List<RiffleWeapon> ProductsRiffleWeapons;
        private List<SniperWeapon> ProductsSniperWeapons;
    }
}