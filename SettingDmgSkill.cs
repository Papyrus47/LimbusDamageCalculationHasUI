using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LimbusDamageCalculationHasUI
{
    public partial class SettingDmgSkill : Form
    {
        public class SettingDmg
        {
            public int skill1;
            public int skill2;
            public int skill3;
            public int skillDef;
            public int strongSkill1;
            public int strongSkill2;
            public int strongSkill3;
            public int strongSkillDef;
        }
        public static readonly string settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
        public SettingDmg settingDmg;
        public SettingDmgSkill()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SettingDmgSkill_Load(object sender, EventArgs e)
        {
            if (File.Exists(settingsPath)) // 加载数据
            {
                string json = File.ReadAllText(settingsPath);
                settingDmg = JsonConvert.DeserializeObject<SettingDmg>(json);
            }
            else
                settingDmg = new();

            if (settingDmg != null)
            {
                numericUpDown1.Value = settingDmg.skill1;
                numericUpDown2.Value = settingDmg.skill2;
                numericUpDown3.Value = settingDmg.skill3;
                numericUpDown4.Value = settingDmg.skillDef;
                numericUpDown5.Value = settingDmg.strongSkill1;
                numericUpDown6.Value = settingDmg.strongSkill2;
                numericUpDown7.Value = settingDmg.strongSkill3;
                numericUpDown8.Value = settingDmg.strongSkillDef;
            }
        }

        private void SettingDmgSkill_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                settingDmg.skill1 = (int)numericUpDown1.Value;
                settingDmg.skill2 = (int)numericUpDown2.Value;
                settingDmg.skill3 = (int)numericUpDown3.Value;
                settingDmg.skillDef = (int)numericUpDown4.Value;
                settingDmg.strongSkill1 = (int)numericUpDown5.Value;
                settingDmg.strongSkill2 = (int)numericUpDown6.Value;
                settingDmg.strongSkill3 = (int)numericUpDown7.Value;
                settingDmg.strongSkillDef = (int)numericUpDown8.Value;

                // 保存到文件
                string json = JsonConvert.SerializeObject(settingDmg, Formatting.Indented);
                Directory.CreateDirectory(Path.GetDirectoryName(settingsPath));
                File.WriteAllText(settingsPath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存设置失败: {ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
