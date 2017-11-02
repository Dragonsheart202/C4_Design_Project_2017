using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Mage : PlayerCharacter
    {
        public Mage(int baseDamage, int currentHealthPoints, int maxHealthPoints) : base(baseDamage, currentHealthPoints, maxHealthPoints)
        {
            specialAttack = new Fireball();
        }
    }
}
