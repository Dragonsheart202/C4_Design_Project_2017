using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;
using Game;

namespace Test
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetNormalAttackDamage()
        {
            //Arrange
            var vTest = new PlayerCharacter(10, 50, 50, "Warrior");

            //Act
            int vResult = vTest.GetNormalAttackDamage();

            //Assert
            Assert.AreEqual(vResult, 10);
        }

        [TestMethod]
        public void TakeDamage()
        {
            //Arrange
            var vTest = new PlayerCharacter(10, 50, 50, "Warrior");

            //Act
            vTest.TakeDamage(10);

            //Assert
            Assert.AreEqual(40, vTest.currentHealthPoints);
        }

        [TestMethod]
        public void GetSpecialAttackDamage()
        {
            //Arrange
            var vTest = new PlayerCharacter(10, 50, 50, "Warrior");
            var vTestController = new GameController();

            //Act
            vTestController.ChooseClass("Warrior");
            int vResult = vTest.GetSpecialAttackDamage();

            //Assert
            Assert.AreEqual(vResult, 30);
        }

        [TestMethod]
        public void AttackNPC()
        {
            //Arrange
            var vTest = new PlayerCharacter(10, 50, 50, "Warrior");
            var vTestEnemy = new NonPlayerCharacter(10, 50, 50, "Goblin");

            //Act
            int vResult = vTestEnemy.TakeDamage(10);

            //Assert
            Assert.AreEqual(40, vTest.currentHealthPoints);
        }

        [TestMethod]
        public void AttackNPC()
        {
            //Arrange
            var vTestController = new GameController();

            //Act
            vTestController.ChooseClass("Warrior");

            //Assert
            Assert.AreEqual('thief', vTestController.player);
        }
    }
}
