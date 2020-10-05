using NUnit.Framework;
using Test.Library;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTest
    {
        private Archer elf;
        private Bow bow;
        private Helmet helmet;

        [SetUp]
        public void SetUp()
        {
            bow = new Bow();
            helmet = new Helmet();
            elf = new Archer("Legolas");
            elf.Bow = bow;
            elf.Helmet = helmet;
        }
        [Test]
        public void AtaqueTotalTest()
        {
            Assert.AreEqual(this.elf.AttackValue, this.bow.AttackValue);
        }
        [Test]
        public void DefensaTotalTest()
        {
            Assert.AreEqual(this.elf.DefenseValue, this.helmet.DefenseValue);
        }
        [Test]
        public void CurarTest()
        {
            int attack = 30;
            this.elf.ReceiveAttack(attack);
            Assert.AreEqual(this.elf.Health, (100 - (attack - this.elf.DefenseValue)) );

            this.elf.Cure();
            Assert.AreEqual(this.elf.Health, 100);
        }
        [Test]
        public void RecibirAtaqueTest()
        {
            int attack = 40;
            this.elf.ReceiveAttack(attack);
            Assert.AreEqual(this.elf.Health, (100 - (attack - this.elf.DefenseValue)) );
        }
    }
}
