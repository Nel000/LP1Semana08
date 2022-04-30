using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        private int movement;
        public override float Value { get => 5; }

        public SettlerUnit(int mov, int health) : base(mov, health)
        {
            movement = mov;
        }

        public override string Move()
        {
            return $"{this.GetType()} Moved {movement} units";
        }
    }
}