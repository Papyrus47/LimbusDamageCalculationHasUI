using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static LimbusDamageCalculationHasUI.SettingDmgSkill;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LimbusDamageCalculationHasUI
{
    public partial class NormalDamageCalculation : Form
    {
        public List<bool> isAllSkillDmg = new();
        public List<float> allDamage = new();
        private List<DotBuffApplidHandler> _dotBuffApplied = new();
        public List<SaveData> saveDatas = new();
        public int showSaveData = -1;

        public delegate void DotBuffApplidHandler(DotBuff dotBuff, ref float maxDamage);

        public event DotBuffApplidHandler DotBuffApplied
        {
            add
            {
                if (!_dotBuffApplied.Contains(value))
                    _dotBuffApplied.Add(value);
            }

            remove => _dotBuffApplied.Remove(value);
        }
        public readonly static string skillSetting = AppDomain.CurrentDomain.BaseDirectory;
        // 修改SaveData类，使用可序列化的数据结构保存DataGridView数据
        public class SaveData : ICloneable
        {
            public decimal skillAddDmg;
            public decimal coinChange;
            public decimal coinNum;
            public decimal baseSkillPower;
            public decimal dmgDef;
            public decimal clashCoin;
            public decimal attackLevel;
            public decimal sinDef;
            public int breathingAccessoriesIndex;

            public List<Dictionary<string, (object, object)>> showCoinChangeData = new();
            public List<Dictionary<string, (object, object)>> dotCoinDataData = new();

            public decimal extraAddDmg;
            public decimal dmgDefMul;
            public decimal dmgDefAdd;
            public decimal startStrength;
            public decimal startCount;
            public decimal dotDef;
            public decimal targetDefLevel;
            public bool targetUseClashDefSkill;
            public decimal targetClashDef;
            public bool skill1Checked;
            public bool skill2Checked;
            public bool skill3Checked;
            public bool skillDefChecked;
            public bool isStrongSkillChecked;

            public object Clone()
            {
                SaveData saveData = new()
                {
                    skillAddDmg = skillAddDmg,
                    coinChange = coinChange,
                    coinNum = coinNum,
                    baseSkillPower = baseSkillPower,
                    dmgDef = dmgDef,
                    clashCoin = clashCoin,
                    attackLevel = attackLevel,
                    sinDef = sinDef,
                    breathingAccessoriesIndex = breathingAccessoriesIndex,
                    showCoinChangeData = showCoinChangeData,
                    dotCoinDataData = dotCoinDataData,
                    extraAddDmg = extraAddDmg,
                    dmgDefMul = dmgDefMul,
                    dmgDefAdd = dmgDefAdd,
                    startStrength = startStrength,
                    startCount = startCount,
                    dotDef = dotDef,
                    targetDefLevel = targetDefLevel,
                    targetUseClashDefSkill = targetUseClashDefSkill,
                    targetClashDef = targetClashDef,
                    skill1Checked = skill1Checked,
                    skill2Checked = skill2Checked,
                    skill3Checked = skill3Checked,
                    skillDefChecked = skillDefChecked,
                    isStrongSkillChecked = isStrongSkillChecked
                };
                return saveData;
            }
        }
        public NormalDamageCalculation()
        {
            InitializeComponent();
        }

        public void GetDmgData(string path)
        {
            List<SaveData> saveDatas = null;
            if (File.Exists(path)) // 加载数据
            {
                string json = File.ReadAllText(path);
                if (path.Contains("_dmgData") || path.EndsWith(".dmgData"))
                    saveDatas = JsonConvert.DeserializeObject<List<SaveData>>(json);
            }
            if (saveDatas != null)
            {
                foreach (var saveData in saveDatas)
                {
                    GetShowData(saveData);
                    this.saveDatas.Add(saveData);
                }
                showSaveData = saveDatas.Count - 1;
            }
        }

        public void GetShowData(SaveData saveData)
        {
            skillAddDmg.Value = saveData.skillAddDmg;
            coinChange.Value = saveData.coinChange;
            coinNum.Value = saveData.coinNum;
            baseSkillPower.Value = saveData.baseSkillPower;
            dmgDef.Value = saveData.dmgDef;
            clashCoin.Value = saveData.clashCoin;
            attackLevel.Value = saveData.attackLevel;
            sinDef.Value = saveData.sinDef;
            breathingAccessories.SelectedIndex = saveData.breathingAccessoriesIndex;

            // 加载DataGridView数据
            showCoinChange.Rows.Clear();
            foreach (var rowData in saveData.showCoinChangeData)
            {
                int newRowIndex = showCoinChange.Rows.Add();
                foreach (var columnData in rowData)
                {
                    int columnIndex = showCoinChange.Columns[columnData.Key].Index;
                    DataGridViewCell dataGridViewCell = showCoinChange.Rows[newRowIndex].Cells[columnIndex];
                    dataGridViewCell.ReadOnly = false;
                    if (columnData.Value.Item2 is Type type)
                    {
                        dataGridViewCell.ValueType = type;
                    }
                    else
                    {
                        // 如果是字符串，尝试获取类型
                        string typeName = columnData.Value.Item2 as string;
                        if (typeName != null)
                        {
                            dataGridViewCell.ValueType = Type.GetType(typeName);
                        }
                    }
                    if (dataGridViewCell.ValueType == typeof(int) && columnData.Value.Item1.GetType() == typeof(long))
                        dataGridViewCell.Value = (int)(long)columnData.Value.Item1;
                    else if (dataGridViewCell.ValueType == typeof(float) && columnData.Value.Item1.GetType() == typeof(double))
                        dataGridViewCell.Value = (float)(double)columnData.Value.Item1;
                    else
                        dataGridViewCell.Value = columnData.Value.Item1;
                }
            }
            dotCoinData.Rows.Clear();
            foreach (var rowData in saveData.dotCoinDataData)
            {
                int newRowIndex = dotCoinData.Rows.Add();
                foreach (var columnData in rowData)
                {
                    int columnIndex = dotCoinData.Columns[columnData.Key].Index;
                    DataGridViewCell dataGridViewCell = dotCoinData.Rows[newRowIndex].Cells[columnIndex];
                    dataGridViewCell.ReadOnly = false;
                    if (columnData.Value.Item2 is Type type)
                    {
                        dataGridViewCell.ValueType = type;
                    }
                    else
                    {
                        // 如果是字符串，尝试获取类型
                        string typeName = columnData.Value.Item2 as string;
                        if (typeName != null)
                        {
                            dataGridViewCell.ValueType = Type.GetType(typeName);
                        }
                    }
                    if (dataGridViewCell.ValueType == typeof(int))
                    {
                        if (columnData.Value.Item1 is int intValue)
                            dataGridViewCell.Value = intValue;

                        else if (columnData.Value.Item1 is long longValue)
                            dataGridViewCell.Value = (int)longValue;

                    }
                    else if (dataGridViewCell.ValueType == typeof(float))
                    {
                        if (columnData.Value.Item1 is float floatValue)
                            dataGridViewCell.Value = floatValue;

                        else if (columnData.Value.Item1 is double doubleValue)
                            dataGridViewCell.Value = (float)doubleValue;

                    }
                    else
                        dataGridViewCell.Value = columnData.Value.Item1;
                }
            }

            extraAddDmg.Value = saveData.extraAddDmg;
            dmgDefMul.Value = saveData.dmgDefMul;
            dmgDefAdd.Value = saveData.dmgDefAdd;
            startStrength.Value = saveData.startStrength;
            startCount.Value = saveData.startCount;
            dotDef.Value = saveData.dotDef;
            targetDefLevel.Value = saveData.targetDefLevel;
            targetUseClashDefSkill.Checked = saveData.targetUseClashDefSkill;
            targetClashDef.Value = saveData.targetClashDef;
            skill1.Checked = saveData.skill1Checked;
            skill2.Checked = saveData.skill2Checked;
            skill3.Checked = saveData.skill3Checked;
            skillDef.Checked = saveData.skillDefChecked;
            isStrongSkill.Checked = saveData.isStrongSkillChecked;
        }

        public void SaveDmgData()
        {
            try
            {
                List<SaveData> saveDatas = new();
                string result = Interaction.InputBox("保存的名字", "保存");
                foreach (var saveData in this.saveDatas)
                {
                    saveDatas.Add(saveData);
                }
                string json = JsonConvert.SerializeObject(saveDatas, Formatting.Indented);
                string path = Path.Combine(skillSetting, $"{result}.dmgData");
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存设置失败: {ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveShowData(SaveData saveData)
        {
            saveData.showCoinChangeData.Clear();
            saveData.dotCoinDataData.Clear();
            saveData.skillAddDmg = skillAddDmg.Value;
            saveData.coinChange = coinChange.Value;
            saveData.coinNum = coinNum.Value;
            saveData.baseSkillPower = baseSkillPower.Value;
            saveData.dmgDef = dmgDef.Value;
            saveData.clashCoin = clashCoin.Value;
            saveData.attackLevel = attackLevel.Value;
            saveData.sinDef = sinDef.Value;
            saveData.breathingAccessoriesIndex = breathingAccessories.SelectedIndex;

            // 保存DataGridView数据
            foreach (DataGridViewRow row in showCoinChange.Rows)
            {
                if (row.IsNewRow) continue;
                var rowData = new Dictionary<string, (object, object)>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.OwningColumn.Name, (cell.Value, cell.ValueType));
                }
                saveData.showCoinChangeData.Add(rowData);
            }
            foreach (DataGridViewRow row in dotCoinData.Rows)
            {
                if (row.IsNewRow) continue;
                var rowData = new Dictionary<string, (object, object)>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    rowData.Add(cell.OwningColumn.Name, (cell.Value, cell.ValueType));
                }
                saveData.dotCoinDataData.Add(rowData);
            }
            saveData.extraAddDmg = extraAddDmg.Value;
            saveData.dmgDefMul = dmgDefMul.Value;
            saveData.dmgDefAdd = dmgDefAdd.Value;
            saveData.startStrength = startStrength.Value;
            saveData.startCount = startCount.Value;
            saveData.dotDef = dotDef.Value;
            saveData.targetDefLevel = targetDefLevel.Value;
            saveData.targetUseClashDefSkill = targetUseClashDefSkill.Checked;
            saveData.targetClashDef = targetClashDef.Value;
            saveData.skill1Checked = skill1.Checked;
            saveData.skill2Checked = skill2.Checked;
            saveData.skill3Checked = skill3.Checked;
            saveData.skillDefChecked = skillDef.Checked;
            saveData.isStrongSkillChecked = isStrongSkill.Checked;
        }

        private void NormalDamageCalculation_Load(object sender, EventArgs e)
        {
            breathingAccessories.SelectedIndex = 0;
        }

        private void GetDamage()
        {
            GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int targetDefLevel, out int coinChange, out float maxDamage, out string coinDamageText, out DotBuff dotBuff);
            GetCoinDmg(coinNum, coinAdd, allCoinDamageAdd, attackLevel, targetDefLevel, ref coinChange, ref maxDamage, ref coinDamageText, dotBuff);

            var isOK = MessageBox.Show($"伤害:\n" +
                $"{coinDamageText}" +
                $"总伤害:{maxDamage}" +
                $"\n按下OK记录伤害", "伤害计算结果", MessageBoxButtons.OKCancel);
            if (isOK == DialogResult.OK)
            {
                allDamage.Add(maxDamage);
                isAllSkillDmg.Add(false);
            }
        }

        public void GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int targetDefLevel, out int coinChange, out float maxDamage, out string coinDamageText, out DotBuff dotBuff)
        {
            int baseCount = (int)baseSkillPower.Value;
            coinNum = (int)this.coinNum.Value;
            coinAdd = (int)this.coinChange.Value;
            allCoinDamageAdd = 1 + (float)skillAddDmg.Value;
            attackLevel = (int)this.attackLevel.Value;
            targetDefLevel = (int)this.targetDefLevel.Value;
            coinChange = baseCount;
            maxDamage = 0;
            coinDamageText = "";
            dotBuff = new()
            {
                Strength = (int)startStrength.Value,
                Count = (int)startCount.Value
            };
        }

        public void GetCoinDmg(int coinNum, int coinAdd, float allCoinDamageAdd, int attackLevel, int targetDefLevel, ref int coinChange, ref float maxDamage, ref string coinDamageText, DotBuff dotBuff)
        {
            for (int i = 0; i < coinNum; i++)
            {
                if (showCoinChange.RowCount <= i)
                    return;
                bool redCoin = (bool)showCoinChange["redCoinD", i].Value;
                if ((bool)showCoinChange["coinDestroy", i].Value && !redCoin)
                {
                    coinDamageText += $"第{i + 1}枚硬币被摧毁！\n";
                    continue;
                }
                float atkAndDefDel = attackLevel - targetDefLevel;
                float mulDamage = 1 + ((float)clashCoin.Value * 0.03f) + (atkAndDefDel / (Math.Abs(atkAndDefDel) + 25f));
                int chaos = int.Parse((string)showCoinChange["chaos", i].Value);
                float breathe = breathingAccessories.SelectedIndex switch
                {
                    1 => 0.7f,
                    2 => 1f,
                    3 => 1.5f,
                    _ => 0.2f,
                };
                if ((bool)showCoinChange["isBreathe", i].Value)
                    mulDamage += breathe;
                float dmgDef = (float)this.dmgDef.Value * ((float)dmgDefMul.Value) + (float)dmgDefAdd.Value;
                if (chaos > 0)
                    dmgDef = 2 + (chaos - 1) * 0.5f;
                mulDamage += dmgDef switch
                {
                    > 1 => dmgDef - 1,
                    > 0 => (dmgDef - 1) * 0.5f,
                    _ => -0.5f,
                };
                float sinDef = (float)this.sinDef.Value;
                mulDamage += sinDef switch
                {
                    > 1 => sinDef - 1,
                    > 0 => (sinDef - 1) * 0.5f,
                    _ => -0.5f,
                };

                if ((bool)showCoinChange["coinLight", i].Value)
                {
                    if (redCoin)
                        coinChange += Math.Sign(coinAdd);
                    else
                        coinChange += coinAdd;

                    if (showCoinChange.RowCount > i)
                        coinChange += (int)showCoinChange["extraCoinPower", i].Value * Math.Sign(coinAdd);
                }

                float aCoinDamageAdd = 0;
                aCoinDamageAdd = (float)showCoinChange["addDmg", i].Value;
                int targetClashDef = 0;
                if (targetUseClashDefSkill.Checked)
                    targetClashDef = (int)this.targetClashDef.Value;
                float coinDamage = (coinChange - targetClashDef) * (aCoinDamageAdd + allCoinDamageAdd + (float)extraAddDmg.Value) *
                    mulDamage;
                maxDamage += coinDamage;

                int dotUseCount = (int)dotCoinData["dotUseCount", i].Value;
                if (dotUseCount > 0)
                {
                    for (int j = 0; j < dotUseCount; j++)
                    {
                        coinDamage += dotBuff.DotDamage() * (float)dotDef.Value;
                        maxDamage += dotBuff.DotDamage() * (float)dotDef.Value;
                        dotBuff.Count += (int)dotCoinData["Count", i].Value;
                        dotBuff.Strength += (int)dotCoinData["Strength", i].Value;
                        if (dotBuff.Strength > 0)
                            dotBuff.Count = 1;
                        foreach (var x in _dotBuffApplied)
                        {
                            x?.Invoke(dotBuff, ref maxDamage);
                        }
                    }
                    _dotBuffApplied.Clear();
                }
                coinDamageText += $"第{i + 1}枚硬币的伤害{coinDamage}\n";
            }
        }

        private void ByCloneCoin_DefaultValuesNeeded(object? sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["extraCoinPower"].Value = 0;
            e.Row.Cells["addDmg"].Value = 0.00f;
        }
        public void ChangeData()
        {
            if (coinNum.Value <= 0)
                return;
            dotCoinData.RowCount = showCoinChange.RowCount = (int)coinNum.Value + 1;

            foreach (DataGridViewRow coinRow in showCoinChange.Rows)
            {
                coinRow.Cells["extraCoinPower"].Value = 0;
                coinRow.Cells["extraCoinPower"].ValueType = typeof(int);

                coinRow.Cells["addDmg"].Value = 0.0f;
                coinRow.Cells["addDmg"].ValueType = typeof(float);

                coinRow.Cells["coinLight"].Value = true;
                coinRow.Cells["isBreathe"].Value = false;

                coinRow.Cells["chaos"].Value = "0";
                coinRow.Cells["chaos"].ValueType = typeof(string);

                coinRow.Cells["redCoinD"].Value = false;
                coinRow.Cells["coinDestroy"].Value = false;

            }
            foreach (DataGridViewRow dotRow in dotCoinData.Rows)
            {
                dotRow.Cells["Strength"].Value = 0;
                dotRow.Cells["Strength"].ValueType = typeof(int);

                dotRow.Cells["Count"].Value = 0;
                dotRow.Cells["Count"].ValueType = typeof(int);

                dotRow.Cells["dotUseCount"].Value = 1;
                dotRow.Cells["dotUseCount"].ValueType = typeof(int);
            }
        }

        private void CoinNum_ValueChanged(object sender, EventArgs e)
        {
            ChangeData();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            HelpMessageBox helpMessageBox = new();
            helpMessageBox.Show();
        }
        private void NormalDamageCalculation_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawLine(Pens.Black, new Point(Width / 5 * 3, 0), new Point(Width / 5 * 3, Height));
        }

        private void NormalDamageCalculation_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Point screenPos = hlpevent.MousePos;
            Point clientPos = PointToClient(screenPos);
            Control? control = GetChildAtPoint(clientPos);
            ShowControlTooltip(control);
        }
        private void ShowControlTooltip(Control? control)
        {
            if (control == null)
                return;
            var tooltips = new Dictionary<Control, (string message, string title)>
            {
                { label1, ("技能的基础值\n根据巴士给出的硬币基础值来算，这里可以加上增加了基础值的技能", "技能基础值") },
                { label2, ("技能的数量\n修改这个会使右边的硬币面板自动更新数据", "硬币数量") },
                { label3, ("技能的显示的没有加成的硬币变动值\n如果有什么加成，移步到右边的硬币栏里面", "初始硬币变动值") },
                { label5, ("本次技能应该增加的伤害值\n如果中途给了易损之类的，请在硬币里面加成，这个和硬币加成都属于第二类乘算伤害", "本次技能加算伤害") },
                { label6, ("敌人已经挂有的易损之类的\n如果中途给了易损之类的，请在硬币里面加成，这个和硬币加成都属于第二类乘算伤害", "额外伤害增加") },
                { breathingAccessories, ("第一类乘算伤害的呼吸法,明镜止水加成倍率分别是1.2,1.7,2,2.5", "呼吸法伤害加成") },
                { label8, ("第一类乘算伤害的拼点次数,每拼点一次增加3%的伤害", "拼点加成") },
                { label9, ("第一类乘算伤害的攻防等级差,根据攻防等级差/(攻防等级差的绝对值+25)增加伤害", "攻防等级差加成") },
                { label4, ("硬币应该有的效果都放在这里,有缺什么的可以告诉我", "硬币加算伤害") },
                { label10, ("物理抗性的乘算增伤", "抗性乘算增伤") },
                { label13, ("物理抗性的加算增伤", "抗性加算增伤") },
                { dotStartValue,("Dot的初始值,与Dot的种类,可以计算硬币数量带有施加dot效果的硬币","Dot初始值") },
                { label17,("破裂默认填1.00,如果有破裂守护等另外说,这里这个是乘算,其他给出来的dot请自行乘以对应罪孽抗性","Dot抗性") }

            };

            if (tooltips.TryGetValue(control, out var tooltip))
                MessageBox.Show(tooltip.message, tooltip.title);
        }
        private void GetFinalDamage_Click(object sender, EventArgs e) => GetDamage();
        private void TargetUseClashDefSkill_CheckedChanged(object sender, EventArgs e)
        {
            label18.Visible = targetUseClashDefSkill.Checked;
            targetClashDef.Visible = targetUseClashDefSkill.Checked;
        }

        private void GetAllDamageSum_Chick(object sender, EventArgs e) => GetAllDamageSum();
        private void GetAllDamageSum()
        {
            float allDmg = 0;
            string allDmgText = "";
            for (int i = 0; i < allDamage.Count; i++)
            {
                allDmgText += $"第{i + 1}次伤害:{allDamage[i]}\n";
                allDmg += allDamage[i];
            }
            var chickType = MessageBox.Show(allDmgText +
                $"总伤害:{allDmg}" +
                $"\n点击确定后会清空伤害列表,点击取消后不会清空伤害列表", "总伤害显示", MessageBoxButtons.OKCancel);
            switch (chickType)
            {
                case DialogResult.OK:
                    allDamage.Clear();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void GetTimeDelayPayment_Click(object sender, EventArgs e) => GetTimeDelayPayment();
        private void GetTimeDelayPayment()
        {
            bool useTimeDelay = true;
            while (useTimeDelay)
            {
                try
                {
                    useTimeDelay = false;
                    string result = Interaction.InputBox("输入时间延付的强度", "时间延付");
                    float allDmg = 0;
                    string allDmgText = "";
                    for (int i = 0; i < allDamage.Count; i++)
                    {
                        float dmg = allDamage[i] * (100 + (int.Parse(result) * 15)) / 100f;
                        allDmgText += $"第{i + 1}次伤害:{dmg}\n";
                        allDmg += dmg;
                    }
                    var chickType = MessageBox.Show(allDmgText +
                        $"总伤害:{allDmg}" +
                        $"\n点击确定后会清空伤害列表,点击取消后不会清空伤害列表", "时间延付", MessageBoxButtons.OKCancel);
                    switch (chickType)
                    {
                        case DialogResult.OK:
                            allDamage.Clear();
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                catch
                {
                    useTimeDelay = true;
                }
            }
        }
        private void GetSkillDamage_Click(object sender, EventArgs e)
        {
            GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int targetDefLevel, out int coinChange, out float maxDamage, out string coinDamageText, out DotBuff dotBuff);
            GetCoinDmg(coinNum, coinAdd, allCoinDamageAdd, attackLevel, targetDefLevel, ref coinChange, ref maxDamage, ref coinDamageText, dotBuff);

            var isOK = MessageBox.Show($"伤害:\n" +
                        $"{coinDamageText}" +
                        $"总伤害:{maxDamage}" +
                        $"\n按下OK记录伤害", "伤害计算结果", MessageBoxButtons.OKCancel);
            if (isOK == DialogResult.OK)
            {
                isAllSkillDmg.Add(true);
            }
        }

        private void SettingSkillDmg_Click(object sender, EventArgs e)
        {
            SettingDmgSkill settingDmgSkill = new();
            settingDmgSkill.Show();
        }

        private void GetAllSkillDmg_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(SettingDmgSkill.settingsPath);
            SettingDmg settingDmg = JsonConvert.DeserializeObject<SettingDmg>(json);
            if (settingDmg != null)
            {
                string text = "";
                float dmg = 0;
                DotBuff dotBuff = new()
                {
                    Strength = (int)startStrength.Value,
                    Count = (int)startCount.Value
                };
                foreach (var data in saveDatas)
                {
                    GetShowData(data);
                    GetDmgSetting(out int coinNum, out int coinAdd, out float allCoinDamageAdd, out int attackLevel, out int targetDefLevel, out int coinChangeTemp, out float maxDamage, out string coinDamageText, out DotBuff dotBuffTemp);
                    GetCoinDmg(coinNum, coinAdd, allCoinDamageAdd, attackLevel, targetDefLevel, ref coinChangeTemp, ref maxDamage, ref coinDamageText, dotBuffTemp);
                    if (isStrongSkill.Checked)
                    {
                        if (skill1.Checked)
                        {
                            text += $"强化技能一伤害:{settingDmg.strongSkill1 * maxDamage}\n";
                            dmg += settingDmg.strongSkill1 * maxDamage;
                        }
                        if (skill2.Checked)
                        {
                            text += $"强化技能二伤害:{settingDmg.strongSkill2 * maxDamage}\n";
                            dmg += settingDmg.strongSkill2 * maxDamage;
                        }
                        if (skill3.Checked)
                        {
                            text += $"强化技能三伤害:{settingDmg.strongSkill3 * maxDamage}\n";
                            dmg += settingDmg.strongSkill3 * maxDamage;
                        }
                        if (skillDef.Checked)
                        {
                            text += $"强化反击伤害:{settingDmg.strongSkillDef * maxDamage}\n";
                            dmg += settingDmg.strongSkillDef * maxDamage;
                        }
                    }
                    else
                    {
                        if (skill1.Checked)
                        {
                            text += $"技能一伤害:{settingDmg.skill1 * maxDamage}\n";
                            dmg += settingDmg.skill1 * maxDamage;
                        }
                        if (skill2.Checked)
                        {
                            text += $"技能二伤害:{settingDmg.skill2 * maxDamage}\n";
                            dmg += settingDmg.skill2 * maxDamage;
                        }
                        if (skill3.Checked)
                        {
                            text += $"技能三伤害:{settingDmg.skill3 * maxDamage}\n";
                            dmg += settingDmg.skill3 * maxDamage;
                        }
                        if (skillDef.Checked)
                        {
                            text += $"反击伤害:{settingDmg.skillDef * maxDamage}\n";
                            dmg += settingDmg.skillDef * maxDamage;
                        }
                    }

                }
                GetShowData(saveDatas[showSaveData]);
                MessageBox.Show(text +
                    $"\n累计总伤{dmg}", "总伤计算结果", MessageBoxButtons.OK);
            }
        }

        private void NormalDamageCalculation_DragEnter(object sender, DragEventArgs e) => GetStringExtensionToCopy(e);

        public static void GetStringExtensionToCopy(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))  // 检查是否为文件拖放
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                bool allValid = true;

                foreach (string file in files)
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (ext != ".json" && !file.EndsWith(".dmgData"))  // 只允许.json
                    {
                        allValid = false;
                        break;
                    }
                }

                e.Effect = allValid ? DragDropEffects.Copy : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;  // 不支持的格式
            }
        }

        private void NormalDamageCalculation_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                saveDatas.Clear();
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    GetDmgData(file);
                }
            }
        }

        private void SaveData_Chick(object sender, EventArgs e)
        {
            SaveDmgData();
        }
        public void ChangeSaveData(Func<SaveData, bool> check)
        {
            showSaveData = saveDatas.FindIndex(check.Invoke);

            if (showSaveData == -1)
            {
                SaveData item = new();
                saveDatas.Add(item);
                showSaveData = saveDatas.Count - 1;
            }

            // 清空之前保存的DataGridView数据
            saveDatas[showSaveData].showCoinChangeData.Clear();
            saveDatas[showSaveData].dotCoinDataData.Clear();

            // 保存现在的数据
            SaveShowData(saveDatas[showSaveData]);

        }
        public void ChangeSaveData()
        {
            //// 检查索引是否有效
            //if (showSaveData >= 0 && showSaveData < saveDatas.Count)
            //    SaveShowData(saveDatas[showSaveData]);
            if (isStrongSkill.Checked)
            {
                if (skill1.Checked)
                    ChangeSaveData(x => x.isStrongSkillChecked && x.skill1Checked);
                else if (skill2.Checked)
                    ChangeSaveData(x => x.isStrongSkillChecked && x.skill2Checked);
                else if (skill3.Checked)
                    ChangeSaveData(x => x.isStrongSkillChecked && x.skill3Checked);
                else if (skillDef.Checked)
                    ChangeSaveData(x => x.isStrongSkillChecked && x.skillDefChecked);
            }
            else
            {
                if (skill1.Checked)
                    ChangeSaveData(x => !x.isStrongSkillChecked && x.skill1Checked);
                else if (skill2.Checked)
                    ChangeSaveData(x => !x.isStrongSkillChecked && x.skill2Checked);
                else if (skill3.Checked)
                    ChangeSaveData(x => !x.isStrongSkillChecked && x.skill3Checked);
                else if (skillDef.Checked)
                    ChangeSaveData(x => !x.isStrongSkillChecked && x.skillDefChecked);
            }
        }

        private void SaveSkillData_Click(object sender, EventArgs e)
        {
            ChangeSaveData();
        }

        private void GetSkillData_Click(object sender, EventArgs e)
        {
            Func<SaveData, bool> check = (_) => true;
            if (isStrongSkill.Checked)
            {
                if (skill1.Checked)
                    check = (x) => x.isStrongSkillChecked && x.skill1Checked;
                else if (skill2.Checked)
                    check = (x) => x.isStrongSkillChecked && x.skill2Checked;
                else if (skill3.Checked)
                    check = (x) => x.isStrongSkillChecked && x.skill3Checked;
                else if (skillDef.Checked)
                    check = (x) => x.isStrongSkillChecked && x.skillDefChecked;
            }
            else
            {
                if (skill1.Checked)
                    check = (x) => !x.isStrongSkillChecked && x.skill1Checked;
                else if (skill2.Checked)
                    check = (x) => !x.isStrongSkillChecked && x.skill2Checked;
                else if (skill3.Checked)
                    check = (x) => !x.isStrongSkillChecked && x.skill3Checked;
                else if (skillDef.Checked)
                    check = (x) => !x.isStrongSkillChecked && x.skillDefChecked;
            }
            showSaveData = saveDatas.FindIndex(check.Invoke);
            if (showSaveData >= 0 && showSaveData < saveDatas.Count)
                GetShowData(saveDatas[showSaveData]);
        }

        private void DamageComparator_Click(object sender, EventArgs e)
        {
            List<SaveData> saveDatas = new();
            foreach(var saveData in this.saveDatas)
            {
                saveDatas.Add(saveData.Clone() as SaveData);
            }
            ChartWindow chartWindow = new(saveDatas);
            chartWindow.Show();
        }
    }
}
