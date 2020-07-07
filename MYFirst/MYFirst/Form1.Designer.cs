namespace MYFirst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dengyu = new System.Windows.Forms.Button();
            this.chu = new System.Windows.Forms.Button();
            this.cheng = new System.Windows.Forms.Button();
            this.jian = new System.Windows.Forms.Button();
            this.jia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.op2 = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(33, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 516);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.result);
            this.panel4.Location = new System.Drawing.Point(92, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 146);
            this.panel4.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(73, 57);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(96, 39);
            this.result.TabIndex = 0;
            this.result.Text = "result";
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dengyu);
            this.panel3.Controls.Add(this.chu);
            this.panel3.Controls.Add(this.cheng);
            this.panel3.Controls.Add(this.jian);
            this.panel3.Controls.Add(this.jia);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(579, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 457);
            this.panel3.TabIndex = 1;
            // 
            // dengyu
            // 
            this.dengyu.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dengyu.Location = new System.Drawing.Point(51, 331);
            this.dengyu.Name = "dengyu";
            this.dengyu.Size = new System.Drawing.Size(94, 29);
            this.dengyu.TabIndex = 4;
            this.dengyu.Text = "=";
            this.dengyu.UseVisualStyleBackColor = true;
            // 
            // chu
            // 
            this.chu.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chu.Location = new System.Drawing.Point(51, 241);
            this.chu.Name = "chu";
            this.chu.Size = new System.Drawing.Size(94, 29);
            this.chu.TabIndex = 3;
            this.chu.Text = "/";
            this.chu.UseVisualStyleBackColor = true;
            this.chu.Click += new System.EventHandler(this.chu_Click);
            // 
            // cheng
            // 
            this.cheng.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cheng.Location = new System.Drawing.Point(51, 183);
            this.cheng.Name = "cheng";
            this.cheng.Size = new System.Drawing.Size(94, 29);
            this.cheng.TabIndex = 2;
            this.cheng.Text = "*";
            this.cheng.UseVisualStyleBackColor = true;
            this.cheng.Click += new System.EventHandler(this.cheng_Click);
            // 
            // jian
            // 
            this.jian.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jian.Location = new System.Drawing.Point(51, 129);
            this.jian.Name = "jian";
            this.jian.Size = new System.Drawing.Size(94, 29);
            this.jian.TabIndex = 1;
            this.jian.Text = "-";
            this.jian.UseVisualStyleBackColor = true;
            this.jian.Click += new System.EventHandler(this.jian_Click);
            // 
            // jia
            // 
            this.jia.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jia.Location = new System.Drawing.Point(51, 66);
            this.jia.Name = "jia";
            this.jia.Size = new System.Drawing.Size(94, 29);
            this.jia.TabIndex = 0;
            this.jia.Text = "+";
            this.jia.UseVisualStyleBackColor = true;
            this.jia.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.op2);
            this.panel2.Controls.Add(this.op1);
            this.panel2.Location = new System.Drawing.Point(92, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 174);
            this.panel2.TabIndex = 0;
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(29, 111);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(260, 27);
            this.op2.TabIndex = 1;
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(29, 31);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(260, 27);
            this.op1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 577);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "MyComputer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button dengyu;
        private System.Windows.Forms.Button chu;
        private System.Windows.Forms.Button cheng;
        private System.Windows.Forms.Button jian;
        private System.Windows.Forms.Button jia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox op2;
        private System.Windows.Forms.TextBox op1;
    }
}

