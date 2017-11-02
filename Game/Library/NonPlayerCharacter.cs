using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class NonPlayerCharacter : Character
    {
        public string enemyType;
        public NormalAttack normalAttack;

        public NonPlayerCharacter(string enemyType, int baseDamage, int currentHealthPoints, int maxHealthPoints) : base(baseDamage, currentHealthPoints, maxHealthPoints)
        {
            this.enemyType = enemyType;
        }
    }
}
