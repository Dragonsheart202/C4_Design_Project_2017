using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Thief : PlayerCharacter
    {
        public Thief(int baseDamage, int currentHealthPoints, int maxHealthPoints) : base(baseDamage, currentHealthPoints, maxHealthPoints)
        {
            specialAttack = new Backstab();
        }
    }
}
