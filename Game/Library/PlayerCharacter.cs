using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class PlayerCharacter : Character
    {
        public string characterName;
        public NormalAttack normalAttack;
        public SpecialAttack specialAttack;
        public PlayerCharacter(int baseDamage, int currentHealthPoints, int maxHealthPoints) : base(baseDamage, currentHealthPoints, maxHealthPoints)
        {
            this.characterName = "Fred";
        }

        public virtual int GetSpecialAttackDamage()
        {
            int damage = 0;
            damage = specialAttack.GetAttackDamage(baseDamage);
            return damage;
        }
    }
}
