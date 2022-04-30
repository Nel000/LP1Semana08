using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public override float Value { get => 5; }

        public SettlerUnit(int mov, int health) : base(mov, health)
        {

        }

        public void Settle(Vector2 v)
        {

        }
    }
}