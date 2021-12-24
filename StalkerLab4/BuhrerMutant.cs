namespace StalkerLab4
{
    public class BuhrerMutant : Mutant
    {
        public BuhrerMutant(int maxHP, int killReward) : base(maxHP, killReward)
        {
            IsProtectionActive = false;
        }
        
        public override void ReceiveDamage(int damage)
        {
            if (IsProtectionActive)
            {
                damage /= 2;
            }
            HealthPoints -= damage;
        }
        
        public bool IsProtectionActive { get; set; }
    }
}