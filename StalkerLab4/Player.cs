namespace StalkerLab4
{
    public class Player
    {
        public Player(Weapon weapon)
        {
            PlayersWeapon = weapon;
            Money = 0;
        }

        public string Attack(Mutant mutant)
        {
            if (mutant.HealthPoints <= 0) {
                return "This mutant is dead";
            }
            var healthPointsBeforeDamage = mutant.HealthPoints;
            PlayersWeapon.Shoot(mutant);
            if (mutant.HealthPoints <= 0)
            {
               Money += mutant.KillReward;
               return "Mutant killed. Killer received " + mutant.KillReward + '$';
            }
            return "Mutant damaged for " + (healthPointsBeforeDamage - mutant.HealthPoints) + "hp";
        }
        
        public string PrintState()
        {
            return "Money: " + Money + "$\nWeapon: " + PlayersWeapon.Name + ' ' + PlayersWeapon.Damage + "dmg (" + PlayersWeapon.GetType().Name + ')';
        }

        public void SetWeapon(Weapon weapon)
        {
            PlayersWeapon = weapon;
        }
        
        public int Money { get; set; }
        
        private Weapon PlayersWeapon { get; set; }
    }
}