namespace Arithmetic2._0
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubNum = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtOPNum = new System.Windows.Forms.TextBox();
            this.gb_OP = new System.Windows.Forms.GroupBox();
            this.cbMultiply = new System.Windows.Forms.CheckBox();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.gb_Brackets = new System.Windows.Forms.GroupBox();
            this.rbNoBrackets = new System.Windows.Forms.RadioButton();
            this.rbBrackets = new System.Windows.Forms.RadioButton();
            this.gb_Fraction = new System.Windows.Forms.GroupBox();
            this.rbNoFraction = new System.Windows.Forms.RadioButton();
            this.rbFraction = new System.Windows.Forms.RadioButton();
            this.but_Start = new System.Windows.Forms.Button();
            this.but_Close = new System.Windows.Forms.Button();
            this.gb_OP.SuspendLayout();
            this.gb_Brackets.SuspendLayout();
            this.gb_Fraction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "题目数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "数值范围：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "运算符个数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "是否包含括号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否包含分数：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "运算符选择：";
            // 
            // txtSubNum
            // 
            this.txtSubNum.Location = new System.Drawing.Point(121, 14);
            this.txtSubNum.Name = "txtSubNum";
            this.txtSubNum.Size = new System.Drawing.Size(59, 21);
            this.txtSubNum.TabIndex = 6;
            this.txtSubNum.Text = "10";
            this.txtSubNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(121, 50);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(59, 21);
            this.txtMin.TabIndex = 7;
            this.txtMin.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16F);
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(213, 50);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(59, 21);
            this.txtMax.TabIndex = 9;
            this.txtMax.Text = "100";
            // 
            // txtOPNum
            // 
            this.txtOPNum.Location = new System.Drawing.Point(122, 92);
            this.txtOPNum.Name = "txtOPNum";
            this.txtOPNum.Size = new System.Drawing.Size(58, 21);
            this.txtOPNum.TabIndex = 10;
            this.txtOPNum.Text = "1";
            this.txtOPNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.number_KeyPress);
            // 
            // gb_OP
            // 
            this.gb_OP.Controls.Add(this.cbMultiply);
            this.gb_OP.Controls.Add(this.cbAdd);
            this.gb_OP.Location = new System.Drawing.Point(121, 125);
            this.gb_OP.Name = "gb_OP";
            this.gb_OP.Size = new System.Drawing.Size(200, 42);
            this.gb_OP.TabIndex = 11;
            this.gb_OP.TabStop = false;
            // 
            // cbMultiply
            // 
            this.cbMultiply.AutoSize = true;
            this.cbMultiply.Font = new System.Drawing.Font("宋体", 12F);
            this.cbMultiply.Location = new System.Drawing.Point(104, 16);
            this.cbMultiply.Name = "cbMultiply";
            this.cbMultiply.Size = new System.Drawing.Size(75, 20);
            this.cbMultiply.TabIndex = 2;
            this.cbMultiply.Text = "乘除法";
            this.cbMultiply.UseVisualStyleBackColor = true;
            this.cbMultiply.CheckedChanged += new System.EventHandler(this.cbAdd_CheckedChanged);
            // 
            // cbAdd
            // 
            this.cbAdd.AutoSize = true;
            this.cbAdd.Checked = true;
            this.cbAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.cbAdd.Location = new System.Drawing.Point(6, 16);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(75, 20);
            this.cbAdd.TabIndex = 0;
            this.cbAdd.Text = "加减法";
            this.cbAdd.UseVisualStyleBackColor = true;
            this.cbAdd.CheckedChanged += new System.EventHandler(this.cbAdd_CheckedChanged);
            // 
            // gb_Brackets
            // 
            this.gb_Brackets.Controls.Add(this.rbNoBrackets);
            this.gb_Brackets.Controls.Add(this.rbBrackets);
            this.gb_Brackets.Location = new System.Drawing.Point(122, 173);
            this.gb_Brackets.Name = "gb_Brackets";
            this.gb_Brackets.Size = new System.Drawing.Size(97, 42);
            this.gb_Brackets.TabIndex = 12;
            this.gb_Brackets.TabStop = false;
            // 
            // rbNoBrackets
            // 
            this.rbNoBrackets.AutoSize = true;
            this.rbNoBrackets.Checked = true;
            this.rbNoBrackets.Font = new System.Drawing.Font("宋体", 12F);
            this.rbNoBrackets.Location = new System.Drawing.Point(53, 12);
            this.rbNoBrackets.Name = "rbNoBrackets";
            this.rbNoBrackets.Size = new System.Drawing.Size(42, 20);
            this.rbNoBrackets.TabIndex = 1;
            this.rbNoBrackets.TabStop = true;
            this.rbNoBrackets.Text = "无";
            this.rbNoBrackets.UseVisualStyleBackColor = true;
            this.rbNoBrackets.CheckedChanged += new System.EventHandler(this.rbBrackets_CheckedChanged);
            // 
            // rbBrackets
            // 
            this.rbBrackets.AutoSize = true;
            this.rbBrackets.Font = new System.Drawing.Font("宋体", 12F);
            this.rbBrackets.Location = new System.Drawing.Point(5, 12);
            this.rbBrackets.Name = "rbBrackets";
            this.rbBrackets.Size = new System.Drawing.Size(42, 20);
            this.rbBrackets.TabIndex = 0;
            this.rbBrackets.Text = "有";
            this.rbBrackets.UseVisualStyleBackColor = true;
            this.rbBrackets.CheckedChanged += new System.EventHandler(this.rbBrackets_CheckedChanged);
            // 
            // gb_Fraction
            // 
            this.gb_Fraction.Controls.Add(this.rbNoFraction);
            this.gb_Fraction.Controls.Add(this.rbFraction);
            this.gb_Fraction.Location = new System.Drawing.Point(121, 221);
            this.gb_Fraction.Name = "gb_Fraction";
            this.gb_Fraction.Size = new System.Drawing.Size(98, 42);
            this.gb_Fraction.TabIndex = 13;
            this.gb_Fraction.TabStop = false;
            // 
            // rbNoFraction
            // 
            this.rbNoFraction.AutoSize = true;
            this.rbNoFraction.Checked = true;
            this.rbNoFraction.Font = new System.Drawing.Font("宋体", 12F);
            this.rbNoFraction.Location = new System.Drawing.Point(54, 12);
            this.rbNoFraction.Name = "rbNoFraction";
            this.rbNoFraction.Size = new System.Drawing.Size(42, 20);
            this.rbNoFraction.TabIndex = 1;
            this.rbNoFraction.TabStop = true;
            this.rbNoFraction.Text = "无";
            this.rbNoFraction.UseVisualStyleBackColor = true;
            this.rbNoFraction.CheckedChanged += new System.EventHandler(this.rbFraction_CheckedChanged);
            // 
            // rbFraction
            // 
            this.rbFraction.AutoSize = true;
            this.rbFraction.Font = new System.Drawing.Font("宋体", 12F);
            this.rbFraction.Location = new System.Drawing.Point(6, 12);
            this.rbFraction.Name = "rbFraction";
            this.rbFraction.Size = new System.Drawing.Size(42, 20);
            this.rbFraction.TabIndex = 0;
            this.rbFraction.Text = "有";
            this.rbFraction.UseVisualStyleBackColor = true;
            this.rbFraction.CheckedChanged += new System.EventHandler(this.rbFraction_CheckedChanged);
            // 
            // but_Start
            // 
            this.but_Start.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Start.Location = new System.Drawing.Point(36, 303);
            this.but_Start.Name = "but_Start";
            this.but_Start.Size = new System.Drawing.Size(119, 46);
            this.but_Start.TabIndex = 14;
            this.but_Start.Text = "开始答题";
            this.but_Start.UseVisualStyleBackColor = true;
            this.but_Start.Click += new System.EventHandler(this.but_Start_Click);
            // 
            // but_Close
            // 
            this.but_Close.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Close.Location = new System.Drawing.Point(190, 303);
            this.but_Close.Name = "but_Close";
            this.but_Close.Size = new System.Drawing.Size(119, 46);
            this.but_Close.TabIndex = 15;
            this.but_Close.Text = "退出程序";
            this.but_Close.UseVisualStyleBackColor = true;
            this.but_Close.Click += new System.EventHandler(this.but_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 387);
            this.Controls.Add(this.but_Close);
            this.Controls.Add(this.but_Start);
            this.Controls.Add(this.gb_Fraction);
            this.Controls.Add(this.gb_Brackets);
            this.Controls.Add(this.gb_OP);
            this.Controls.Add(this.txtOPNum);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtSubNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "数值设置";
            this.gb_OP.ResumeLayout(false);
            this.gb_OP.PerformLayout();
            this.gb_Brackets.ResumeLayout(false);
            this.gb_Brackets.PerformLayout();
            this.gb_Fraction.ResumeLayout(false);
            this.gb_Fraction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_OP;
        private System.Windows.Forms.GroupBox gb_Brackets;
        private System.Windows.Forms.GroupBox gb_Fraction;
        private System.Windows.Forms.Button but_Start;
        private System.Windows.Forms.Button but_Close;
        public System.Windows.Forms.TextBox txtOPNum;
        public System.Windows.Forms.TextBox txtMax;
        public System.Windows.Forms.TextBox txtMin;
        public System.Windows.Forms.TextBox txtSubNum;
        public System.Windows.Forms.RadioButton rbFraction;
        public System.Windows.Forms.RadioButton rbNoFraction;
        public System.Windows.Forms.RadioButton rbBrackets;
        public System.Windows.Forms.RadioButton rbNoBrackets;
        public System.Windows.Forms.CheckBox cbAdd;
        public System.Windows.Forms.CheckBox cbMultiply;
    }
}

