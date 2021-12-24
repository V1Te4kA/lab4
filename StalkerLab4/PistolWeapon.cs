namespace StalkerLab4
{
    public class PistolWeapon : Weapon
    {
        public PistolWeapon(string name, int damage, int price) : base(name, damage, price)
        {
        }
        
        public override void Shoot(Mutant mutant)
        {
            mutant.ReceiveDamage(Damage);
        }
    }
}