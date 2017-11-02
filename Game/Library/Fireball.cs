using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Fireball : SpecialAttack
    {
        public override int GetAttackDamage(int baseDamage)
        {
            Random r = new Random();
            int damage = r.Next(1, 2);

            if (damage == 1)
            {
                damage = baseDamage * 4;
            }
            else
            {
                damage = baseDamage - (baseDamage * 2);
            }

            return damage;
        }
    }
}
