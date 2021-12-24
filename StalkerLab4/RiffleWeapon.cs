namespace StalkerLab4
{
    public class RiffleWeapon : Weapon
    {
        public RiffleWeapon(string name, int damage, int price, int clip) : base(name, damage, price)
        {
            Clip = clip;
            BulletsToShoot = 1;
        }
        
        public override void Shoot(Mutant mutant)
        {
            if (BulletsToShoot > Clip)
            {
                BulletsToShoot = Clip;
            }
            if (BulletsToShoot <= 0)
            {
                BulletsToShoot = 1;
            }
            mutant.ReceiveDamage(Damage * BulletsToShoot);
        }
        
        public int BulletsToShoot { get; set; }
        
        private int Clip { get; }
    }
}