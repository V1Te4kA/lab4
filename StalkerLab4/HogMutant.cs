namespace StalkerLab4
{
    public class HogMutant : Mutant
    {
        public HogMutant(int maxHP, int killReward) : base(maxHP, killReward)
        {
        }
        
        public override void ReceiveDamage(int damage)
        {
            HealthPoints -= damage;
        }
    }
}