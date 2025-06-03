using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimbusDamageCalculationHasUI
{
    public partial class ClashSimulation : Form
    {
        public ClashSimulation()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRandomWinOrLose(1000);
        }

        private void GetRandomWinOrLose(int randomNum)
        {
            float clashWin = 0;
            float clashLost = 0;
            ClashCoin myCoin = new()
            {
                attackLevel = (int)myAtkLevel.Value,
                baiscPower = (int)myBasicPower.Value,
                clashPower = (int)myClashPower.Value,
                coinNum = (int)myCoinNum.Value,
                coinPower = (int)myCoinPower.Value,
                san = (int)mySan.Value,
            };
            ClashCoin targetCoin = new()
            {
                attackLevel = (int)targetAtkLevel.Value,
                baiscPower = (int)targetBasicPower.Value,
                clashPower = (int)targetClashPower.Value,
                coinNum = (int)targetCoinNum.Value,
                coinPower = (int)targetCoinPower.Value,
                san = (int)targetSan.Value,
            };
            for (int i = 0; i < randomNum; i++)
            {
                int myFinalPower = myCoin.GetFinalPower(random, targetCoin.attackLevel);
                int targetFinalPower = targetCoin.GetFinalPower(random, myCoin.attackLevel);
                if (myFinalPower > targetFinalPower)
                    clashWin++;
                else if (myFinalPower < targetFinalPower)
                    clashLost++;
            }
            clashWin = clashWin / randomNum * 100f;
            clashLost = clashLost / randomNum * 100f;
            finalClash.Text = $"模拟结果:成功概率(频率){clashWin}%,失败概率(频率){clashLost}%,拼点打平概率(频率){100 - clashWin - clashLost}%";
        }

        private void ClashSimulation_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetRandomWinOrLose(100000);
        }
    }
}
