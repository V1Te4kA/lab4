namespace StalkerLab4
{
    public abstract class Mutant
    {
        protected Mutant(int maxHP, int killReward)
        {
            HealthPoints = maxHP;
            KillReward = killReward;
        }
        
        public abstract void ReceiveDamage(int damage);
        public int HealthPoints { get; set; }
        public int KillReward { get; }
    }
}