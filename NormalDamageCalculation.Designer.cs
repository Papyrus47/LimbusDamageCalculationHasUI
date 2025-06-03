
namespace LimbusDamageCalculationHasUI
{
    partial class NormalDamageCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label label12;
            Label label19;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NormalDamageCalculation));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            skillAddDmg = new NumericUpDown();
            coinChange = new NumericUpDown();
            coinNum = new NumericUpDown();
            baseSkillPower = new NumericUpDown();
            label7 = new Label();
            dmgDef = new NumericUpDown();
            clashCoin = new NumericUpDown();
            label8 = new Label();
            label9 = new Label();
            attackLevel = new NumericUpDown();
            help = new Button();
            sinDef = new NumericUpDown();
            label11 = new Label();
            breathingAccessories = new ComboBox();
            showCoinChange = new DataGridView();
            extraCoinPower = new DataGridViewTextBoxColumn();
            addDmg = new DataGridViewTextBoxColumn();
            chaos = new DataGridViewComboBoxColumn();
            coinLight = new DataGridViewCheckBoxColumn();
            isBreathe = new DataGridViewCheckBoxColumn();
            coinDestroy = new DataGridViewCheckBoxColumn();
            redCoinD = new DataGridViewCheckBoxColumn();
            extraAddDmg = new NumericUpDown();
            dmgDefMul = new NumericUpDown();
            label10 = new Label();
            label13 = new Label();
            dmgDefAdd = new NumericUpDown();
            startStrength = new NumericUpDown();
            startCount = new NumericUpDown();
            dotStartValue = new Label();
            label14 = new Label();
            label15 = new Label();
            dotCoinData = new DataGridView();
            Strength = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            dotUseCount = new DataGridViewTextBoxColumn();
            coinAddDot = new Label();
            dotDef = new NumericUpDown();
            label17 = new Label();
            getAllDamageAndSave = new Button();
            label16 = new Label();
            targetDefLevel = new NumericUpDown();
            targetUseClashDefSkill = new CheckBox();
            targetClashDef = new NumericUpDown();
            label18 = new Label();
            getAllDamgeSum = new Button();
            panel1 = new Panel();
            damageComparator = new Button();
            getTimeDelayPayment = new Button();
            skill1 = new RadioButton();
            skillType = new GroupBox();
            isStrongSkill = new CheckBox();
            skillDef = new RadioButton();
            skill3 = new RadioButton();
            skill2 = new RadioButton();
            getAllSkillDmg = new Button();
            settingSkillDmg = new Button();
            saveData = new Button();
            generalTooltip = new ToolTip(components);
            saveSkillData = new Button();
            getSkillData = new Button();
            label12 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)skillAddDmg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coinChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coinNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)baseSkillPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dmgDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clashCoin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attackLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)showCoinChange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)extraAddDmg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dmgDefMul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dmgDefAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dotCoinData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dotDef).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetDefLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetClashDef).BeginInit();
            panel1.SuspendLayout();
            skillType.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(245, 7);
            label12.Name = "label12";
            label12.Size = new Size(104, 68);
            label12.TabIndex = 39;
            label12.Text = "不会的可以使用\r\n右上角的问号点点\r\n所有等于这个东西\r\n的标题栏\r\n";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = SystemColors.Control;
            label19.Location = new Point(158, 367);
            label19.Name = "label19";
            label19.Size = new Size(80, 51);
            label19.TabIndex = 70;
            label19.Text = "可以拖动面板\r\n数据到本界面\r\n自动读取\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 48);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "硬币数量";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 89);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 4;
            label3.Text = "初始硬币变动值";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 9);
            label4.Name = "label4";
            label4.Size = new Size(92, 51);
            label4.TabIndex = 9;
            label4.Text = "硬币加算伤害\r\n（根据硬币\r\n数量填写这个）";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 128);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 10;
            label5.Text = "本次技能加算伤害";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 155);
            label6.Name = "label6";
            label6.Size = new Size(80, 34);
            label6.TabIndex = 37;
            label6.Text = "额外伤害增加\r\n/减少";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "技能初始面板";
            // 
            // skillAddDmg
            // 
            skillAddDmg.DecimalPlaces = 2;
            skillAddDmg.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            skillAddDmg.Location = new Point(103, 126);
            skillAddDmg.Name = "skillAddDmg";
            skillAddDmg.Size = new Size(120, 23);
            skillAddDmg.TabIndex = 11;
            // 
            // coinChange
            // 
            coinChange.Location = new Point(103, 87);
            coinChange.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            coinChange.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            coinChange.Name = "coinChange";
            coinChange.Size = new Size(120, 23);
            coinChange.TabIndex = 12;
            // 
            // coinNum
            // 
            coinNum.Location = new Point(103, 46);
            coinNum.Name = "coinNum";
            coinNum.Size = new Size(120, 23);
            coinNum.TabIndex = 13;
            coinNum.ValueChanged += CoinNum_ValueChanged;
            // 
            // baseSkillPower
            // 
            baseSkillPower.Location = new Point(103, 7);
            baseSkillPower.Name = "baseSkillPower";
            baseSkillPower.Size = new Size(120, 23);
            baseSkillPower.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(242, 84);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 16;
            label7.Text = "物理抗性";
            // 
            // dmgDef
            // 
            dmgDef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dmgDef.DecimalPlaces = 2;
            dmgDef.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            dmgDef.Location = new Point(242, 104);
            dmgDef.Name = "dmgDef";
            dmgDef.Size = new Size(79, 23);
            dmgDef.TabIndex = 17;
            dmgDef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // clashCoin
            // 
            clashCoin.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clashCoin.Location = new Point(103, 240);
            clashCoin.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            clashCoin.Name = "clashCoin";
            clashCoin.Size = new Size(111, 23);
            clashCoin.TabIndex = 18;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(12, 240);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 19;
            label8.Text = "拼点次数";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(12, 269);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 21;
            label9.Text = "自身攻击等级";
            // 
            // attackLevel
            // 
            attackLevel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            attackLevel.Location = new Point(103, 269);
            attackLevel.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            attackLevel.Name = "attackLevel";
            attackLevel.Size = new Size(111, 23);
            attackLevel.TabIndex = 20;
            // 
            // help
            // 
            help.Location = new Point(12, 198);
            help.Name = "help";
            help.Size = new Size(75, 23);
            help.TabIndex = 24;
            help.Text = "公式帮助";
            help.UseVisualStyleBackColor = true;
            help.Click += Help_Click;
            // 
            // sinDef
            // 
            sinDef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sinDef.DecimalPlaces = 2;
            sinDef.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            sinDef.Location = new Point(355, 104);
            sinDef.Name = "sinDef";
            sinDef.Size = new Size(79, 23);
            sinDef.TabIndex = 26;
            sinDef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(355, 84);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 25;
            label11.Text = "罪孽抗性";
            // 
            // breathingAccessories
            // 
            breathingAccessories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            breathingAccessories.DisplayMember = "0";
            breathingAccessories.DropDownStyle = ComboBoxStyle.DropDownList;
            breathingAccessories.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            breathingAccessories.FormattingEnabled = true;
            breathingAccessories.Items.AddRange(new object[] { "普通暴击", "明镜止水", "明镜止水+", "明镜止水++" });
            breathingAccessories.Location = new Point(109, 198);
            breathingAccessories.Name = "breathingAccessories";
            breathingAccessories.RightToLeft = RightToLeft.No;
            breathingAccessories.Size = new Size(105, 25);
            breathingAccessories.TabIndex = 27;
            breathingAccessories.ValueMember = "0";
            // 
            // showCoinChange
            // 
            showCoinChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showCoinChange.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            showCoinChange.Columns.AddRange(new DataGridViewColumn[] { extraCoinPower, addDmg, chaos, coinLight, isBreathe, coinDestroy, redCoinD });
            showCoinChange.Location = new Point(453, 9);
            showCoinChange.Name = "showCoinChange";
            showCoinChange.Size = new Size(214, 475);
            showCoinChange.TabIndex = 36;
            showCoinChange.DefaultValuesNeeded += ByCloneCoin_DefaultValuesNeeded;
            // 
            // extraCoinPower
            // 
            extraCoinPower.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            extraCoinPower.HeaderText = "额外硬币威力";
            extraCoinPower.Name = "extraCoinPower";
            extraCoinPower.Resizable = DataGridViewTriState.False;
            extraCoinPower.SortMode = DataGridViewColumnSortMode.NotSortable;
            extraCoinPower.ToolTipText = "额外的硬币威力加成(点击后记得随便点个别的东西更新一下)";
            extraCoinPower.Width = 86;
            // 
            // addDmg
            // 
            addDmg.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            addDmg.HeaderText = "硬币伤害加算";
            addDmg.Name = "addDmg";
            addDmg.Resizable = DataGridViewTriState.False;
            addDmg.SortMode = DataGridViewColumnSortMode.NotSortable;
            addDmg.ToolTipText = "硬币里面增加的伤害，若有硬币造成抗性减少影响下一个硬币的伤害也放在这里面(点击后记得随便点个别的东西更新一下)";
            addDmg.Width = 86;
            // 
            // chaos
            // 
            chaos.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            chaos.HeaderText = "混乱级别";
            chaos.Items.AddRange(new object[] { "0", "1", "2" });
            chaos.Name = "chaos";
            chaos.ToolTipText = "(点击后记得随便点个别的东西更新一下)";
            chaos.Width = 62;
            // 
            // coinLight
            // 
            coinLight.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            coinLight.HeaderText = "硬币正面与反面";
            coinLight.Name = "coinLight";
            coinLight.ToolTipText = "(点击后记得随便点个别的东西更新一下)";
            coinLight.Width = 98;
            // 
            // isBreathe
            // 
            isBreathe.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            isBreathe.HeaderText = "呼吸法暴击";
            isBreathe.Name = "isBreathe";
            isBreathe.Resizable = DataGridViewTriState.True;
            isBreathe.SortMode = DataGridViewColumnSortMode.Automatic;
            isBreathe.ToolTipText = "(点击后记得随便点个别的东西更新一下)";
            isBreathe.Width = 93;
            // 
            // coinDestroy
            // 
            coinDestroy.HeaderText = "硬币被摧毁";
            coinDestroy.Name = "coinDestroy";
            coinDestroy.Resizable = DataGridViewTriState.True;
            coinDestroy.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // redCoinD
            // 
            redCoinD.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            redCoinD.HeaderText = "不可摧毁硬币";
            redCoinD.Name = "redCoinD";
            redCoinD.Resizable = DataGridViewTriState.True;
            redCoinD.SortMode = DataGridViewColumnSortMode.Automatic;
            redCoinD.ToolTipText = "如果勾选，则默认为已经摧毁，额外硬币威力会加到变动值里面，请注意";
            redCoinD.Width = 105;
            // 
            // extraAddDmg
            // 
            extraAddDmg.DecimalPlaces = 2;
            extraAddDmg.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            extraAddDmg.Location = new Point(103, 166);
            extraAddDmg.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            extraAddDmg.Name = "extraAddDmg";
            extraAddDmg.Size = new Size(120, 23);
            extraAddDmg.TabIndex = 38;
            // 
            // dmgDefMul
            // 
            dmgDefMul.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dmgDefMul.DecimalPlaces = 2;
            dmgDefMul.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            dmgDefMul.Location = new Point(242, 150);
            dmgDefMul.Name = "dmgDefMul";
            dmgDefMul.Size = new Size(79, 23);
            dmgDefMul.TabIndex = 40;
            dmgDefMul.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(242, 130);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 41;
            label10.Text = "物理乘算增伤";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(242, 178);
            label13.Name = "label13";
            label13.Size = new Size(80, 17);
            label13.TabIndex = 43;
            label13.Text = "物理加算增伤";
            // 
            // dmgDefAdd
            // 
            dmgDefAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dmgDefAdd.DecimalPlaces = 2;
            dmgDefAdd.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            dmgDefAdd.Location = new Point(242, 198);
            dmgDefAdd.Name = "dmgDefAdd";
            dmgDefAdd.Size = new Size(79, 23);
            dmgDefAdd.TabIndex = 42;
            // 
            // startStrength
            // 
            startStrength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startStrength.Location = new Point(728, 42);
            startStrength.Name = "startStrength";
            startStrength.Size = new Size(120, 23);
            startStrength.TabIndex = 45;
            // 
            // startCount
            // 
            startCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            startCount.Location = new Point(728, 75);
            startCount.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            startCount.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            startCount.Name = "startCount";
            startCount.Size = new Size(120, 23);
            startCount.TabIndex = 44;
            // 
            // dotStartValue
            // 
            dotStartValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dotStartValue.AutoSize = true;
            dotStartValue.Location = new Point(750, 13);
            dotStartValue.Name = "dotStartValue";
            dotStartValue.Size = new Size(67, 17);
            dotStartValue.TabIndex = 46;
            dotStartValue.Text = "Dot初始值";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(690, 44);
            label14.Name = "label14";
            label14.Size = new Size(32, 17);
            label14.TabIndex = 47;
            label14.Text = "强度";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(690, 77);
            label15.Name = "label15";
            label15.Size = new Size(32, 17);
            label15.TabIndex = 48;
            label15.Text = "层数";
            // 
            // dotCoinData
            // 
            dotCoinData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dotCoinData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dotCoinData.Columns.AddRange(new DataGridViewColumn[] { Strength, Count, dotUseCount });
            dotCoinData.Location = new Point(728, 111);
            dotCoinData.Name = "dotCoinData";
            dotCoinData.Size = new Size(120, 373);
            dotCoinData.TabIndex = 52;
            // 
            // Strength
            // 
            Strength.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Strength.HeaderText = "强度增加";
            Strength.Name = "Strength";
            Strength.Width = 81;
            // 
            // Count
            // 
            Count.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Count.HeaderText = "层数增加";
            Count.Name = "Count";
            Count.Width = 81;
            // 
            // dotUseCount
            // 
            dotUseCount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dotUseCount.HeaderText = "触发次数";
            dotUseCount.Name = "dotUseCount";
            dotUseCount.Width = 81;
            // 
            // coinAddDot
            // 
            coinAddDot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            coinAddDot.AutoSize = true;
            coinAddDot.Location = new Point(690, 111);
            coinAddDot.Name = "coinAddDot";
            coinAddDot.Size = new Size(32, 34);
            coinAddDot.TabIndex = 53;
            coinAddDot.Text = "硬币\r\n施加";
            // 
            // dotDef
            // 
            dotDef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dotDef.DecimalPlaces = 2;
            dotDef.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            dotDef.Location = new Point(355, 198);
            dotDef.Name = "dotDef";
            dotDef.Size = new Size(79, 23);
            dotDef.TabIndex = 55;
            dotDef.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(355, 178);
            label17.Name = "label17";
            label17.Size = new Size(55, 17);
            label17.TabIndex = 54;
            label17.Text = "Dot抗性";
            // 
            // getAllDamageAndSave
            // 
            getAllDamageAndSave.Location = new Point(22, 336);
            getAllDamageAndSave.Name = "getAllDamageAndSave";
            getAllDamageAndSave.Size = new Size(130, 23);
            getAllDamageAndSave.TabIndex = 56;
            getAllDamageAndSave.Text = "获取伤害并储存伤害";
            getAllDamageAndSave.UseVisualStyleBackColor = true;
            getAllDamageAndSave.Click += GetAllDamageAndSave_Click;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(12, 298);
            label16.Name = "label16";
            label16.Size = new Size(80, 17);
            label16.TabIndex = 58;
            label16.Text = "目标防御等级";
            // 
            // targetDefLevel
            // 
            targetDefLevel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            targetDefLevel.Location = new Point(103, 298);
            targetDefLevel.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            targetDefLevel.Name = "targetDefLevel";
            targetDefLevel.Size = new Size(111, 23);
            targetDefLevel.TabIndex = 57;
            // 
            // targetUseClashDefSkill
            // 
            targetUseClashDefSkill.AutoSize = true;
            targetUseClashDefSkill.Location = new Point(275, 234);
            targetUseClashDefSkill.Name = "targetUseClashDefSkill";
            targetUseClashDefSkill.Size = new Size(116, 21);
            targetUseClashDefSkill.TabIndex = 59;
            targetUseClashDefSkill.Text = "目标-可拼点防御";
            targetUseClashDefSkill.UseVisualStyleBackColor = true;
            targetUseClashDefSkill.CheckedChanged += TargetUseClashDefSkill_CheckedChanged;
            // 
            // targetClashDef
            // 
            targetClashDef.Location = new Point(276, 283);
            targetClashDef.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            targetClashDef.Name = "targetClashDef";
            targetClashDef.Size = new Size(115, 23);
            targetClashDef.TabIndex = 60;
            targetClashDef.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(276, 258);
            label18.Name = "label18";
            label18.Size = new Size(116, 17);
            label18.TabIndex = 61;
            label18.Text = "目标可拼点防御点数";
            label18.TextAlign = ContentAlignment.TopCenter;
            label18.Visible = false;
            // 
            // getAllDamgeSum
            // 
            getAllDamgeSum.Location = new Point(22, 364);
            getAllDamgeSum.Name = "getAllDamgeSum";
            getAllDamgeSum.Size = new Size(132, 23);
            getAllDamgeSum.TabIndex = 62;
            getAllDamgeSum.Text = "获取储存伤害之和";
            getAllDamgeSum.UseVisualStyleBackColor = true;
            getAllDamgeSum.Click += GetAllDamageSum_Chick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(damageComparator);
            panel1.Controls.Add(getTimeDelayPayment);
            panel1.Location = new Point(392, 336);
            panel1.Name = "panel1";
            panel1.Size = new Size(42, 148);
            panel1.TabIndex = 63;
            // 
            // damageComparator
            // 
            damageComparator.FlatStyle = FlatStyle.System;
            damageComparator.Font = new Font("微软雅黑", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            damageComparator.Location = new Point(4, 37);
            damageComparator.Name = "damageComparator";
            damageComparator.Size = new Size(33, 33);
            damageComparator.TabIndex = 1;
            damageComparator.Text = "伤害比较器";
            damageComparator.UseVisualStyleBackColor = true;
            damageComparator.Click += DamageComparator_Click;
            // 
            // getTimeDelayPayment
            // 
            getTimeDelayPayment.BackgroundImage = (Image)resources.GetObject("getTimeDelayPayment.BackgroundImage");
            getTimeDelayPayment.BackgroundImageLayout = ImageLayout.Zoom;
            getTimeDelayPayment.Location = new Point(3, -2);
            getTimeDelayPayment.Name = "getTimeDelayPayment";
            getTimeDelayPayment.Size = new Size(33, 33);
            getTimeDelayPayment.TabIndex = 0;
            getTimeDelayPayment.TextImageRelation = TextImageRelation.TextBeforeImage;
            getTimeDelayPayment.UseVisualStyleBackColor = true;
            getTimeDelayPayment.Click += GetTimeDelayPayment_Click;
            // 
            // skill1
            // 
            skill1.AutoSize = true;
            skill1.Location = new Point(6, 21);
            skill1.Name = "skill1";
            skill1.Size = new Size(62, 21);
            skill1.TabIndex = 64;
            skill1.TabStop = true;
            skill1.Text = "技能一";
            skill1.UseVisualStyleBackColor = true;
            // 
            // skillType
            // 
            skillType.Controls.Add(isStrongSkill);
            skillType.Controls.Add(skillDef);
            skillType.Controls.Add(skill3);
            skillType.Controls.Add(skill2);
            skillType.Controls.Add(skill1);
            skillType.Location = new Point(254, 365);
            skillType.Name = "skillType";
            skillType.Size = new Size(132, 122);
            skillType.TabIndex = 65;
            skillType.TabStop = false;
            skillType.Text = "技能类型";
            // 
            // isStrongSkill
            // 
            isStrongSkill.AutoSize = true;
            isStrongSkill.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            isStrongSkill.Location = new Point(14, 77);
            isStrongSkill.Name = "isStrongSkill";
            isStrongSkill.Size = new Size(112, 42);
            isStrongSkill.TabIndex = 69;
            isStrongSkill.Text = "强化技能\r\n（强化反击）";
            isStrongSkill.UseVisualStyleBackColor = true;
            // 
            // skillDef
            // 
            skillDef.AutoSize = true;
            skillDef.Location = new Point(68, 39);
            skillDef.Name = "skillDef";
            skillDef.Size = new Size(50, 21);
            skillDef.TabIndex = 68;
            skillDef.TabStop = true;
            skillDef.Text = "反击";
            skillDef.UseVisualStyleBackColor = true;
            // 
            // skill3
            // 
            skill3.AutoSize = true;
            skill3.Location = new Point(6, 39);
            skill3.Name = "skill3";
            skill3.Size = new Size(62, 21);
            skill3.TabIndex = 66;
            skill3.TabStop = true;
            skill3.Text = "技能三";
            skill3.UseVisualStyleBackColor = true;
            // 
            // skill2
            // 
            skill2.AutoSize = true;
            skill2.Location = new Point(68, 21);
            skill2.Name = "skill2";
            skill2.Size = new Size(62, 21);
            skill2.TabIndex = 65;
            skill2.TabStop = true;
            skill2.Text = "技能二";
            skill2.UseVisualStyleBackColor = true;
            // 
            // getAllSkillDmg
            // 
            getAllSkillDmg.Location = new Point(22, 463);
            getAllSkillDmg.Name = "getAllSkillDmg";
            getAllSkillDmg.Size = new Size(226, 24);
            getAllSkillDmg.TabIndex = 67;
            getAllSkillDmg.Text = "获取暂存所有技能伤害之和\r\n";
            getAllSkillDmg.UseVisualStyleBackColor = true;
            getAllSkillDmg.Click += GetAllSkillDmg_Click;
            // 
            // settingSkillDmg
            // 
            settingSkillDmg.Location = new Point(22, 442);
            settingSkillDmg.Name = "settingSkillDmg";
            settingSkillDmg.Size = new Size(226, 23);
            settingSkillDmg.TabIndex = 68;
            settingSkillDmg.Text = "设置伤害之和的统计方法";
            settingSkillDmg.UseVisualStyleBackColor = true;
            settingSkillDmg.Click += SettingSkillDmg_Click;
            // 
            // saveData
            // 
            saveData.Location = new Point(158, 336);
            saveData.Name = "saveData";
            saveData.Size = new Size(90, 23);
            saveData.TabIndex = 69;
            saveData.Text = "保存面板数据";
            saveData.UseVisualStyleBackColor = true;
            saveData.Click += SaveData_Chick;
            // 
            // saveSkillData
            // 
            saveSkillData.Location = new Point(22, 421);
            saveSkillData.Name = "saveSkillData";
            saveSkillData.Size = new Size(226, 23);
            saveSkillData.TabIndex = 71;
            saveSkillData.Text = "暂存目前技能面板";
            saveSkillData.UseVisualStyleBackColor = true;
            saveSkillData.Click += SaveSkillData_Click;
            // 
            // getSkillData
            // 
            getSkillData.Location = new Point(254, 336);
            getSkillData.Name = "getSkillData";
            getSkillData.Size = new Size(132, 23);
            getSkillData.TabIndex = 72;
            getSkillData.Text = "加载暂存的技能类型";
            getSkillData.UseVisualStyleBackColor = true;
            getSkillData.Click += GetSkillData_Click;
            // 
            // NormalDamageCalculation
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(860, 499);
            Controls.Add(getSkillData);
            Controls.Add(saveSkillData);
            Controls.Add(label19);
            Controls.Add(saveData);
            Controls.Add(settingSkillDmg);
            Controls.Add(getAllSkillDmg);
            Controls.Add(skillType);
            Controls.Add(panel1);
            Controls.Add(getAllDamgeSum);
            Controls.Add(label18);
            Controls.Add(targetClashDef);
            Controls.Add(targetUseClashDefSkill);
            Controls.Add(label16);
            Controls.Add(targetDefLevel);
            Controls.Add(getAllDamageAndSave);
            Controls.Add(dotDef);
            Controls.Add(label17);
            Controls.Add(coinAddDot);
            Controls.Add(dotCoinData);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dotStartValue);
            Controls.Add(startStrength);
            Controls.Add(startCount);
            Controls.Add(label13);
            Controls.Add(dmgDefAdd);
            Controls.Add(label10);
            Controls.Add(dmgDefMul);
            Controls.Add(label12);
            Controls.Add(extraAddDmg);
            Controls.Add(label6);
            Controls.Add(showCoinChange);
            Controls.Add(breathingAccessories);
            Controls.Add(sinDef);
            Controls.Add(label11);
            Controls.Add(help);
            Controls.Add(label9);
            Controls.Add(attackLevel);
            Controls.Add(label8);
            Controls.Add(clashCoin);
            Controls.Add(dmgDef);
            Controls.Add(label7);
            Controls.Add(baseSkillPower);
            Controls.Add(coinNum);
            Controls.Add(coinChange);
            Controls.Add(skillAddDmg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "NormalDamageCalculation";
            ShowIcon = false;
            Text = "巴士伤害计算器1.4.2";
            Load += NormalDamageCalculation_Load;
            DragDrop += NormalDamageCalculation_DragDrop;
            DragEnter += NormalDamageCalculation_DragEnter;
            HelpRequested += NormalDamageCalculation_HelpRequested;
            Paint += NormalDamageCalculation_Paint;
            ((System.ComponentModel.ISupportInitialize)skillAddDmg).EndInit();
            ((System.ComponentModel.ISupportInitialize)coinChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)coinNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)baseSkillPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)dmgDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)clashCoin).EndInit();
            ((System.ComponentModel.ISupportInitialize)attackLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)showCoinChange).EndInit();
            ((System.ComponentModel.ISupportInitialize)extraAddDmg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dmgDefMul).EndInit();
            ((System.ComponentModel.ISupportInitialize)dmgDefAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)startStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)startCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dotCoinData).EndInit();
            ((System.ComponentModel.ISupportInitialize)dotDef).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetDefLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetClashDef).EndInit();
            panel1.ResumeLayout(false);
            skillType.ResumeLayout(false);
            skillType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown skillAddDmg;
        private NumericUpDown coinChange;
        private NumericUpDown coinNum;
        private NumericUpDown baseSkillPower;
        private Label label7;
        private NumericUpDown dmgDef;
        private NumericUpDown clashCoin;
        private Label label8;
        private Label label9;
        private NumericUpDown attackLevel;
        private Button help;
        private NumericUpDown sinDef;
        private Label label11;
        private ComboBox breathingAccessories;
        private DataGridView showCoinChange;
        private NumericUpDown extraAddDmg;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown dmgDefMul;
        private Label label10;
        private Label label13;
        private NumericUpDown dmgDefAdd;
        private NumericUpDown startStrength;
        private NumericUpDown startCount;
        private Label dotStartValue;
        private Label label14;
        private Label label15;
        private DataGridView dotCoinData;
        private Label coinAddDot;
        private NumericUpDown dotDef;
        private Label label17;
        private DataGridViewTextBoxColumn Strength;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn dotUseCount;
        private Button getAllDamageAndSave;
        private Label label16;
        private NumericUpDown targetDefLevel;
        private CheckBox targetUseClashDefSkill;
        private NumericUpDown targetClashDef;
        private Label label18;
        private Button getAllDamgeSum;
        private Panel panel1;
        private Button getTimeDelayPayment;
        private RadioButton skill1;
        private GroupBox skillType;
        private RadioButton skillDef;
        private RadioButton skill3;
        private RadioButton skill2;
        private CheckBox isStrongSkill;
        private Button getAllSkillDmg;
        private Button settingSkillDmg;
        private DataGridViewTextBoxColumn extraCoinPower;
        private DataGridViewTextBoxColumn addDmg;
        private DataGridViewComboBoxColumn chaos;
        private DataGridViewCheckBoxColumn coinLight;
        private DataGridViewCheckBoxColumn isBreathe;
        private DataGridViewCheckBoxColumn coinDestroy;
        private DataGridViewCheckBoxColumn redCoinD;
        private Button saveData;
        private ToolTip generalTooltip;
        private Button saveSkillData;
        private Button getSkillData;
        private Button damageComparator;
    }
}