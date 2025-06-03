using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbusDamageCalculationHasUI
{
    public class DotBuff
    {
        public int Strength;
        public int Count;
        public int DotDamage()
        {
            if (Count > 99)
                Count = 99;
            if (Strength > 99)
                Strength = 99;

            if (Count <= 0)
                Strength = 0;
            Count--;
            return Strength;
        }
    }
}
