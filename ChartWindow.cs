using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static LimbusDamageCalculationHasUI.NormalDamageCalculation;

namespace LimbusDamageCalculationHasUI
{
    public partial class ChartWindow : Form
    {
        private List<NormalDamageCalculation.SaveData> saveDatas;
        private List<NormalDamageCalculation> normalDamageCalculations;

        public Chart chart;

        public ChartWindow(List<NormalDamageCalculation.SaveData> saveDatas)
        {
            this.saveDatas = saveDatas;
            normalDamageCalculations = [new()];
            InitializeComponent();
            chart = new Chart
            {
                Dock = DockStyle.Fill
            };
            chart.ChartAreas.Add(new ChartArea("Default"));
            chart.Series.Add(new Series("SaveData 1"));
            chart.Series.Add(new Series("SaveData 2"));
            chart.Series["SaveData 1"].ChartType = SeriesChartType.Column;
            chart.Series["SaveData 2"].ChartType = SeriesChartType.Column;
            chart.Visible = true;
            Controls.Add(chart);
        }

        private void ChartWindow_Load(object sender, EventArgs e)
        {
            foreach (var saveData in saveDatas)
            {
                NormalDamageCalculation normalDamageCalculation = normalDamageCalculations.First();
                normalDamageCalculation.GetShowData(saveData);
                normalDamageCalculation.GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int coinChange, out float maxDamage, out string coinDamageText, out DotBuff dotBuff);
                normalDamageCalculation.GetCoinDmg(coinNum, coinAdd, allCoinDamageAdd, attackLevel, ref coinChange, ref maxDamage, ref coinDamageText, dotBuff);

                string text = "";
                if (saveData.isStrongSkillChecked)
                {
                    if (saveData.skill1Checked)
                        text = "强化1技能";
                    else if (saveData.skill2Checked)
                        text = "强化2技能";
                    else if (saveData.skill3Checked)
                        text = "强化3技能";
                    else if (saveData.skillDefChecked)
                        text = "强化反击";
                }
                else
                {
                    if (saveData.skill1Checked)
                        text = "普通1技能";
                    else if (saveData.skill2Checked)
                        text = "普通2技能";
                    else if (saveData.skill3Checked)
                        text = "普通3技能";
                    else if (saveData.skillDefChecked)
                        text = "反击";
                }
                // 添加数据点到图表
                DataPoint dataPoint = new();
                dataPoint.YValues = [maxDamage];
                // 设置数据点的标签为最大伤害值
                dataPoint.Label = text + ": " + maxDamage.ToString();
                chart.Series["SaveData 1"].Points.Add(dataPoint);
            }
        }

        private void ChartWindow_DragEnter(object sender, DragEventArgs e) => NormalDamageCalculation.GetStringExtensionToCopy(e);

        private void ChartWindow_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                label1.Visible = false;
                saveDatas.Clear();
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (normalDamageCalculations.Count < 2)
                        normalDamageCalculations.Add(new NormalDamageCalculation());
                    
                    else
                    {
                        chart.Series["SaveData 2"].Points.Clear();
                        normalDamageCalculations[^1] = new();
                    }

                    NormalDamageCalculation normalDamageCalculation = normalDamageCalculations.Last();
                    normalDamageCalculation.GetDmgData(file);
                    
                    foreach (var saveData in normalDamageCalculation.saveDatas)
                    {
                        normalDamageCalculation.GetShowData(saveData);
                        normalDamageCalculation.GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int coinChange, out float maxDamage, out string coinDamageText, out DotBuff dotBuff);
                        normalDamageCalculation.GetCoinDmg(coinNum, coinAdd, allCoinDamageAdd, attackLevel, ref coinChange, ref maxDamage, ref coinDamageText, dotBuff);
                        string text = "";
                        if (saveData.isStrongSkillChecked)
                        {
                            if (saveData.skill1Checked)
                                text = "强化1技能";
                            else if (saveData.skill2Checked)
                                text = "强化2技能";
                            else if (saveData.skill3Checked)
                                text = "强化3技能";
                            else if (saveData.skillDefChecked)
                                text = "强化反击";
                        }
                        else
                        {
                            if (saveData.skill1Checked)
                                text = "普通1技能";
                            else if (saveData.skill2Checked)
                                text = "普通2技能";
                            else if (saveData.skill3Checked)
                                text = "普通3技能";
                            else if (saveData.skillDefChecked)
                                text = "反击";
                        }
                        // 添加数据点到图表
                        DataPoint dataPoint = new();
                        dataPoint.YValues = [maxDamage];
                        // 设置数据点的标签为最大伤害值
                        dataPoint.Label = Path.GetFileNameWithoutExtension(file) + text + ": " + maxDamage.ToString();
                        chart.Series["SaveData 2"].Points.Add(dataPoint);
                    }
                }
            }
        }
    }
}