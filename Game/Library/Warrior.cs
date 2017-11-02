using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Warrior : PlayerCharacter
    {
        public Warrior(int baseDamage, int currentHealthPoints, int maxHealthPoints) : base(baseDamage, currentHealthPoints, maxHealthPoints)
        {
            specialAttack = new Berserk();
        }
    }
}
