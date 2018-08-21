using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        public int[] choose = { 0, 1 };//用于记录图形和单位的选择，第一个元素记录单位，第二个元素记录图形

        public double PI=3.1415926;

        protected bool isNumberic(string message)
        {
            System.Text.RegularExpressions.Regex rex =
            new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (rex.IsMatch(message))
            {
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string graph=" ";
            string unit = "厘米";
            double area=0;
            switch (choose[1])
            {
                case 1:
                    if (!(isNumberic(textBox1.Text)))
                        MessageBox.Show("请输入数字");
                    else
                    {
                        graph = "正方形";
                        double length = Convert.ToDouble(textBox1.Text);
                        area = length * length;
                    }
                    break;
                case 2:
                    if (!(isNumberic(textBox1.Text) && isNumberic(textBox2.Text)))
                        MessageBox.Show("请输入数字");
                    else
                    {
                        graph = "长方形";
                        double length1 = Convert.ToDouble(textBox1.Text);
                        double length2 = Convert.ToDouble(textBox2.Text);
                        area = length1 * length2;
                    }
                    break;
                case 3:
                    if (!(isNumberic(textBox1.Text)))
                        MessageBox.Show("请输入数字");
                    else
                    {
                        graph = "圆";
                        double diameter = Convert.ToDouble(textBox1.Text);
                        area = PI * (diameter / 2) * (diameter / 2);
                    }
                    break;
                case 4:
                    if (!(isNumberic(textBox1.Text) && isNumberic(textBox2.Text)))
                        MessageBox.Show("请输入数字");
                    else
                    {
                        graph = "三角形";
                        double bottom = Convert.ToDouble(textBox1.Text);
                        double high = Convert.ToDouble(textBox2.Text);
                        area = 0.5 * bottom * high;
                    }
                    break;
            }
            switch (choose[0])
            {
                case 0:
                    unit = "厘米";
                    break;
                case 1:
                    unit = "英寸";
                    area = area * 2.54 * 2.54;
                    break;
            }
            string mianji = area.ToString("f3");
            textBox3.Text = graph + "的面积是" + mianji + "平方厘米";
        }

        private void ZFXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入正方形边长，单位默认为厘米";
            choose[1] = 1;
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Text = "边长";
        }

        private void CFXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入长方形的长，在条件二中输入长方形的宽，单位默认为厘米";
            choose[1] = 2;
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Text = "长";
            label2.Text = "宽";
        }

        private void YXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入圆的直径，单位默认为厘米";
            choose[1] = 3;
            label2.Visible = false;
            textBox2.Visible = false;
            label1.Text = "直径";
        }

        private void SJXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = "请在条件一中输入三角形的底，在条件二中输入三角形的高，单位默认为厘米";
            choose[1] = 4;
            label2.Visible = true;
            textBox2.Visible = true;
            label1.Text = "底";
            label2.Text = "高";
        }

        private void LMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose[0] = 0;
        }

        private void YCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choose[0] = 1;
        }
    }
}
