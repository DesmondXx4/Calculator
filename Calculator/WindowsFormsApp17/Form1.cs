using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] xuanzhe = { 0, 1 };

        public double PI=3.1415926;

        private void button1_Click(object sender, EventArgs e)
        {
            string tuxing=" ";
            string danwei = " ";
            double s=0;
            switch (xuanzhe[1])
            {
                case 1:
                    tuxing = "正方形";
                    double l = Convert.ToDouble(textBox1.Text);
                    s = l * l;
                    break;
                case 2:
                    tuxing = "长方形";
                    double l1 = Convert.ToDouble(textBox1.Text);
                    double l2 = Convert.ToDouble(textBox2.Text);
                    s = l1 * l2;
                    break;
                case 3:
                    tuxing = "圆";
                    double d = Convert.ToDouble(textBox1.Text);
                    s = PI * (d / 2) * (d / 2);
                    break;
                case 4:
                    tuxing = "三角形";
                    double di = Convert.ToDouble(textBox1.Text);
                    double gao = Convert.ToDouble(textBox2.Text);
                    s = 0.5 * di * gao;
                    break;
            }
            switch (xuanzhe[0])
            {
                case 0:
                    danwei = "厘米";
                    s = s;
                    break;
                case 1:
                    danwei = "英寸";
                    s = s * 2.54 * 2.54;
                    break;
            }
            string mianji = s.ToString("f3");
            textBox3.Text = tuxing + "的面积是" + mianji + "立方厘米";

        }

        private void 正方形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入正方形边长，单位默认为厘米";
            xuanzhe[1] = 1;
        }

        private void 长方形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入长方形的长，在条件二中输入长方形的宽，单位默认为厘米";
            xuanzhe[1] = 2;
        }

        private void 圆形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件三中输入圆的直径，单位默认为厘米";
            xuanzhe[1] = 3;
        }

        private void 三角形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入三角形的底，在条件二中输入三角形的高，单位默认为厘米";
            xuanzhe[1] = 4;
        }

        private void 厘米ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuanzhe[0] = 0;
        }

        private void 英寸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuanzhe[0] = 1;
        }
    }
}
