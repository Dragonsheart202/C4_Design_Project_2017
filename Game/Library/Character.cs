using System;

namespace Library
{
    public class Character
    {
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character(int baseDamage, int currentHealthPoints, int maxHealthPoints)
        {
            this.baseDamage = baseDamage;
            this.maxHealthPoints = maxHealthPoints;
            this.currentHealthPoints = maxHealthPoints;
        }

        public int GetNormalAttackDamage()
        {
            int damage;
            damage = baseDamage;

            return damage;
        }
        public int TakeDamage(int dmgAmt)
        {
            currentHealthPoints = currentHealthPoints - dmgAmt;
            return currentHealthPoints;
        }
    }
}
