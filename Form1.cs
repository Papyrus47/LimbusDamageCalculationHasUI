using Newtonsoft.Json;
using System.Diagnostics;
using static LimbusDamageCalculationHasUI.NormalDamageCalculation;

namespace LimbusDamageCalculationHasUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form = new NormalDamageCalculation();
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 检查命令行参数
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                // 打开指定文件
                foreach (string arg in args)
                {
                    if (arg.EndsWith(".json") || arg.EndsWith(".dmgData"))
                    {
                        var form = new NormalDamageCalculation();
                        form.GetDmgData(arg);
                        form.Show();
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new ClashSimulation();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 打开浏览器,跳链接到 https://space.bilibili.com/325032498
            Process.Start(new ProcessStartInfo("https://space.bilibili.com/325032498") { UseShellExecute = true });
        }
    }
}
