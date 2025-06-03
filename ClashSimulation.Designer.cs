namespace LimbusDamageCalculationHasUI
{
    partial class ClashSimulation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            myBasicPower = new NumericUpDown();
            myCoinPower = new NumericUpDown();
            myClashPower = new NumericUpDown();
            myAtkLevel = new NumericUpDown();
            label5 = new Label();
            mySan = new NumericUpDown();
            targetSan = new NumericUpDown();
            label6 = new Label();
            targetAtkLevel = new NumericUpDown();
            targetClashPower = new NumericUpDown();
            targetCoinPower = new NumericUpDown();
            targetBasicPower = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            finalClash = new Label();
            label13 = new Label();
            myCoinNum = new NumericUpDown();
            targetCoinNum = new NumericUpDown();
            label14 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)myBasicPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myCoinPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myClashPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myAtkLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mySan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetSan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetAtkLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetClashPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetCoinPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetBasicPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myCoinNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targetCoinNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 31);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 0;
            label1.Text = "基础点数大小";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "硬币威力大小";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 132);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 2;
            label3.Text = "拼点威力增加";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 168);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 3;
            label4.Text = "攻击等级";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // myBasicPower
            // 
            myBasicPower.Location = new Point(155, 29);
            myBasicPower.Name = "myBasicPower";
            myBasicPower.Size = new Size(120, 23);
            myBasicPower.TabIndex = 4;
            // 
            // myCoinPower
            // 
            myCoinPower.Location = new Point(155, 95);
            myCoinPower.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            myCoinPower.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            myCoinPower.Name = "myCoinPower";
            myCoinPower.Size = new Size(120, 23);
            myCoinPower.TabIndex = 5;
            // 
            // myClashPower
            // 
            myClashPower.Location = new Point(155, 130);
            myClashPower.Name = "myClashPower";
            myClashPower.Size = new Size(120, 23);
            myClashPower.TabIndex = 6;
            // 
            // myAtkLevel
            // 
            myAtkLevel.Location = new Point(155, 166);
            myAtkLevel.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            myAtkLevel.Name = "myAtkLevel";
            myAtkLevel.Size = new Size(120, 23);
            myAtkLevel.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 201);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 8;
            label5.Text = "理智值";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // mySan
            // 
            mySan.Location = new Point(155, 199);
            mySan.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            mySan.Minimum = new decimal(new int[] { 45, 0, 0, int.MinValue });
            mySan.Name = "mySan";
            mySan.Size = new Size(120, 23);
            mySan.TabIndex = 9;
            // 
            // targetSan
            // 
            targetSan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetSan.Location = new Point(947, 195);
            targetSan.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            targetSan.Minimum = new decimal(new int[] { 45, 0, 0, int.MinValue });
            targetSan.Name = "targetSan";
            targetSan.Size = new Size(120, 23);
            targetSan.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(840, 197);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 18;
            label6.Text = "理智值";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // targetAtkLevel
            // 
            targetAtkLevel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetAtkLevel.Location = new Point(947, 162);
            targetAtkLevel.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            targetAtkLevel.Name = "targetAtkLevel";
            targetAtkLevel.Size = new Size(120, 23);
            targetAtkLevel.TabIndex = 17;
            // 
            // targetClashPower
            // 
            targetClashPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetClashPower.Location = new Point(947, 126);
            targetClashPower.Name = "targetClashPower";
            targetClashPower.Size = new Size(120, 23);
            targetClashPower.TabIndex = 16;
            // 
            // targetCoinPower
            // 
            targetCoinPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetCoinPower.Location = new Point(947, 91);
            targetCoinPower.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            targetCoinPower.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            targetCoinPower.Name = "targetCoinPower";
            targetCoinPower.Size = new Size(120, 23);
            targetCoinPower.TabIndex = 15;
            // 
            // targetBasicPower
            // 
            targetBasicPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetBasicPower.Location = new Point(947, 31);
            targetBasicPower.Name = "targetBasicPower";
            targetBasicPower.Size = new Size(120, 23);
            targetBasicPower.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(840, 164);
            label7.Name = "label7";
            label7.Size = new Size(56, 17);
            label7.TabIndex = 13;
            label7.Text = "攻击等级";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(840, 128);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 12;
            label8.Text = "拼点威力增加";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(840, 93);
            label9.Name = "label9";
            label9.Size = new Size(80, 17);
            label9.TabIndex = 11;
            label9.Text = "硬币威力大小";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(840, 33);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 10;
            label10.Text = "基础点数大小";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(120, 240);
            label11.Name = "label11";
            label11.Size = new Size(32, 17);
            label11.TabIndex = 20;
            label11.Text = "我方";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(924, 232);
            label12.Name = "label12";
            label12.Size = new Size(32, 17);
            label12.TabIndex = 21;
            label12.Text = "敌方";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(515, 348);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 22;
            button1.Text = "模拟1000次";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // finalClash
            // 
            finalClash.Anchor = AnchorStyles.Bottom;
            finalClash.AutoSize = true;
            finalClash.Location = new Point(219, 424);
            finalClash.Name = "finalClash";
            finalClash.Size = new Size(56, 17);
            finalClash.TabIndex = 23;
            finalClash.Text = "模拟结果";
            finalClash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 62);
            label13.Name = "label13";
            label13.Size = new Size(56, 17);
            label13.TabIndex = 24;
            label13.Text = "硬币数量";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // myCoinNum
            // 
            myCoinNum.Location = new Point(155, 62);
            myCoinNum.Name = "myCoinNum";
            myCoinNum.Size = new Size(120, 23);
            myCoinNum.TabIndex = 25;
            // 
            // targetCoinNum
            // 
            targetCoinNum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            targetCoinNum.Location = new Point(947, 60);
            targetCoinNum.Name = "targetCoinNum";
            targetCoinNum.Size = new Size(120, 23);
            targetCoinNum.TabIndex = 27;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(840, 62);
            label14.Name = "label14";
            label14.Size = new Size(56, 17);
            label14.TabIndex = 26;
            label14.Text = "硬币数量";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(502, 377);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 28;
            button2.Text = "模拟100000次";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ClashSimulation
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 450);
            Controls.Add(button2);
            Controls.Add(targetCoinNum);
            Controls.Add(label14);
            Controls.Add(myCoinNum);
            Controls.Add(label13);
            Controls.Add(finalClash);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(targetSan);
            Controls.Add(label6);
            Controls.Add(targetAtkLevel);
            Controls.Add(targetClashPower);
            Controls.Add(targetCoinPower);
            Controls.Add(targetBasicPower);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(mySan);
            Controls.Add(label5);
            Controls.Add(myAtkLevel);
            Controls.Add(myClashPower);
            Controls.Add(myCoinPower);
            Controls.Add(myBasicPower);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClashSimulation";
            ShowIcon = false;
            Text = "拼点模拟器";
            Load += ClashSimulation_Load;
            ((System.ComponentModel.ISupportInitialize)myBasicPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myCoinPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myClashPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myAtkLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)mySan).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetSan).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetAtkLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetClashPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetCoinPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetBasicPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myCoinNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)targetCoinNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown myBasicPower;
        private NumericUpDown myCoinPower;
        private NumericUpDown myClashPower;
        private NumericUpDown myAtkLevel;
        private Label label5;
        private NumericUpDown mySan;
        private NumericUpDown targetSan;
        private Label label6;
        private NumericUpDown targetAtkLevel;
        private NumericUpDown targetClashPower;
        private NumericUpDown targetCoinPower;
        private NumericUpDown targetBasicPower;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Label finalClash;
        private Random random = new();
        private Label label13;
        private NumericUpDown myCoinNum;
        private NumericUpDown targetCoinNum;
        private Label label14;
        private Button button2;
    }
}