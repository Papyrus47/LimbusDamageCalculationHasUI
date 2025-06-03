using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbusDamageCalculationHasUI
{
    public class ClashCoin
    {
        public int baiscPower;
        public int coinNum;
        public int coinPower;
        public int clashPower;
        public int attackLevel;
        public int san;
        public int GetFinalPower(Random random,int targetAttackLevel)
        {
            int finalPower = baiscPower;
            for (int i = 0; i < coinNum; i++)
            {
                float rand = random.Next(100);
                if (rand < 50 + san)
                    finalPower += coinPower;
            }
            finalPower += clashPower;
            finalPower += Math.Max(0,(attackLevel - targetAttackLevel) / 3);
            return finalPower;
        }
    }
}
