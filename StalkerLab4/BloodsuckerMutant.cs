namespace StalkerLab4
{
    public class BloodsuckerMutant : Mutant
    {
        public BloodsuckerMutant(int maxHP, int killReward) : base(maxHP, killReward)
        {
            IsInvisible = false;
        }
        
        public override void ReceiveDamage(int damage)
        {
            if (IsInvisible)
            {
                return;
            }
            HealthPoints -= damage;
        }
        
        public bool IsInvisible { get; set; }
    }
}