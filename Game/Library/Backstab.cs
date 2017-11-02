using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Backstab : SpecialAttack
    {
        public override int GetAttackDamage(int baseDamage)
        {
            Random r = new Random();
            int damage = r.Next(1, 3);

            if (damage == 1)
            {
                damage = baseDamage * 2;
            }
            else
            {
                damage = baseDamage / 2;
            }

            return damage;
        }
    }
}
