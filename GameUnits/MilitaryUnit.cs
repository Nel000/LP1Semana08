using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public override int Health { get; set => base.Health + XP; }
        public int AttackPower { get; }
        public int XP { get; set; }
        public override float Value { get => AttackPower + XP; }

        public MilitaryUnit(
            int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {

        }
    }
}