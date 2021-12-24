namespace StalkerLab4
{
    public class SniperWeapon : Weapon
    {
        public SniperWeapon(string name, int damage, int price) : base(name, damage, price)
        {
            IsInSniperScope = false;
        }

        public override void Shoot(Mutant mutant)
        {
            int damage = Damage;
            if (IsInSniperScope)
            {
                damage *= 2;
            }
            mutant.ReceiveDamage(damage);
        }
        
        public bool IsInSniperScope { get; set; }
    }
}