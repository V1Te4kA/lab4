namespace StalkerLab4
{
    public abstract class Weapon
    {
        protected Weapon(string name, int damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;
        }
        
        public abstract void Shoot(Mutant mutant);
        
        public string Name { get; }
        public int Damage { get; }
        public int Price { get; }
    }
}