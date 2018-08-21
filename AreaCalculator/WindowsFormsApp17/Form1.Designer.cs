namespace WindowsFormsApp17
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正方形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.长方形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.圆形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三角形ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.厘米ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英寸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图形ToolStripMenuItem,
            this.单位ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图形ToolStripMenuItem
            // 
            this.图形ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.正方形ToolStripMenuItem,
            this.长方形ToolStripMenuItem,
            this.圆形ToolStripMenuItem,
            this.三角形ToolStripMenuItem});
            this.图形ToolStripMenuItem.Name = "图形ToolStripMenuItem";
            this.图形ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.图形ToolStripMenuItem.Text = "图形";
            // 
            // 正方形ToolStripMenuItem
            // 
            this.正方形ToolStripMenuItem.Name = "正方形ToolStripMenuItem";
            this.正方形ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.正方形ToolStripMenuItem.Text = "正方形";
            this.正方形ToolStripMenuItem.Click += new System.EventHandler(this.正方形ToolStripMenuItem_Click);
            // 
            // 长方形ToolStripMenuItem
            // 
            this.长方形ToolStripMenuItem.Name = "长方形ToolStripMenuItem";
            this.长方形ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.长方形ToolStripMenuItem.Text = "长方形";
            this.长方形ToolStripMenuItem.Click += new System.EventHandler(this.长方形ToolStripMenuItem_Click);
            // 
            // 圆形ToolStripMenuItem
            // 
            this.圆形ToolStripMenuItem.Name = "圆形ToolStripMenuItem";
            this.圆形ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.圆形ToolStripMenuItem.Text = "圆形";
            this.圆形ToolStripMenuItem.Click += new System.EventHandler(this.圆形ToolStripMenuItem_Click);
            // 
            // 三角形ToolStripMenuItem
            // 
            this.三角形ToolStripMenuItem.Name = "三角形ToolStripMenuItem";
            this.三角形ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.三角形ToolStripMenuItem.Text = "三角形";
            this.三角形ToolStripMenuItem.Click += new System.EventHandler(this.三角形ToolStripMenuItem_Click);
            // 
            // 单位ToolStripMenuItem
            // 
            this.单位ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.厘米ToolStripMenuItem,
            this.英寸ToolStripMenuItem});
            this.单位ToolStripMenuItem.Name = "单位ToolStripMenuItem";
            this.单位ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.单位ToolStripMenuItem.Text = "单位";
            // 
            // 厘米ToolStripMenuItem
            // 
            this.厘米ToolStripMenuItem.Name = "厘米ToolStripMenuItem";
            this.厘米ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.厘米ToolStripMenuItem.Text = "厘米";
            this.厘米ToolStripMenuItem.Click += new System.EventHandler(this.厘米ToolStripMenuItem_Click);
            // 
            // 英寸ToolStripMenuItem
            // 
            this.英寸ToolStripMenuItem.Name = "英寸ToolStripMenuItem";
            this.英寸ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.英寸ToolStripMenuItem.Text = "英寸";
            this.英寸ToolStripMenuItem.Click += new System.EventHandler(this.英寸ToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 28);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 28);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 28);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 63);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 66);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "条件一";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "条件二";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "提示信息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "图形计算器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正方形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 长方形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 圆形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三角形ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单位ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 厘米ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英寸ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

