using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Library;



namespace Game
{
    public class GameController
    {
        public PlayerCharacter player;
        public NonPlayerCharacter enemy;

        public void ChooseClass(string Setclass)
        {
            if (Setclass == "Warrior")
            {
                player = new Warrior(10, 50, 50);
            }
            else if (Setclass == "Mage")
            {
                player = new Mage(10, 50, 50);
            }
            else if (Setclass == "Thief")
            {
                player = new Thief(10, 50, 50);
            }

            Random r = new Random();
            int foe = r.Next(1, 5);
            if (foe == 1)
            {
                enemy = new NonPlayerCharacter("Goblin", 5, 25, 25);
            }
            else if (foe == 2)
            {
                enemy = new NonPlayerCharacter("Giant", 10, 50, 50);
            }
            else if (foe == 3)
            {
                enemy = new NonPlayerCharacter("Archer", 12, 40, 40);
            }
            else if (foe == 4)
            {
                enemy = new NonPlayerCharacter("Dragon", 18, 60, 60);
            }
            else if (foe == 5)
            {
                enemy = new NonPlayerCharacter("Demon", 20, 70, 70);
            }
        }

        public void AttackNPC(string attackType)
        {
            if (player.currentHealthPoints >= 1 && enemy.currentHealthPoints >= 1)
            {
                if (player.currentHealthPoints >= 1)
                {
                    int dmgAmt = 0;

                    if (attackType == "normal")
                    {
                        dmgAmt = player.GetNormalAttackDamage();
                    }
                    else if (attackType == "special")
                    {
                        dmgAmt = player.GetSpecialAttackDamage();
                    }

                    if (dmgAmt >= 0)
                    {
                        enemy.TakeDamage(dmgAmt);
                    }
                    else if (dmgAmt < 0)
                    {
                        dmgAmt = dmgAmt * -1;
                        player.TakeDamage(dmgAmt);
                    }

                }
                else if (player.currentHealthPoints <= 0)
                {
                    MessageBox.Show("You lose...");
                }

                if (enemy.currentHealthPoints >= 1)
                {
                    int dmgAmt = enemy.GetNormalAttackDamage();

                    player.TakeDamage(dmgAmt);

                }
                else if (enemy.currentHealthPoints <= 0)
                {
                    MessageBox.Show("You win!");
                }
            }
        }
    }


}
