namespace Arithmetic2._0
{
    partial class Form2
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
            this.lb_Topic = new System.Windows.Forms.ListBox();
            this.lb_Ans = new System.Windows.Forms.ListBox();
            this.txt_Ans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_Topic = new System.Windows.Forms.Button();
            this.but_Ans = new System.Windows.Forms.Button();
            this.but_Judge = new System.Windows.Forms.Button();
            this.but_Error = new System.Windows.Forms.Button();
            this.but_Clear = new System.Windows.Forms.Button();
            this.but_Return = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Topic
            // 
            this.lb_Topic.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_Topic.FormattingEnabled = true;
            this.lb_Topic.ItemHeight = 16;
            this.lb_Topic.Location = new System.Drawing.Point(33, 47);
            this.lb_Topic.Name = "lb_Topic";
            this.lb_Topic.Size = new System.Drawing.Size(200, 404);
            this.lb_Topic.TabIndex = 0;
            // 
            // lb_Ans
            // 
            this.lb_Ans.Font = new System.Drawing.Font("宋体", 12F);
            this.lb_Ans.FormattingEnabled = true;
            this.lb_Ans.ItemHeight = 16;
            this.lb_Ans.Location = new System.Drawing.Point(433, 47);
            this.lb_Ans.Name = "lb_Ans";
            this.lb_Ans.Size = new System.Drawing.Size(100, 404);
            this.lb_Ans.TabIndex = 1;
            // 
            // txt_Ans
            // 
            this.txt_Ans.Font = new System.Drawing.Font("宋体", 12F);
            this.txt_Ans.Location = new System.Drawing.Point(285, 47);
            this.txt_Ans.Multiline = true;
            this.txt_Ans.Name = "txt_Ans";
            this.txt_Ans.Size = new System.Drawing.Size(100, 404);
            this.txt_Ans.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "出题栏";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(310, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "答题栏";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(455, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "答案栏";
            // 
            // but_Topic
            // 
            this.but_Topic.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Topic.Location = new System.Drawing.Point(577, 66);
            this.but_Topic.Name = "but_Topic";
            this.but_Topic.Size = new System.Drawing.Size(93, 30);
            this.but_Topic.TabIndex = 6;
            this.but_Topic.Text = "出题";
            this.but_Topic.UseVisualStyleBackColor = true;
            this.but_Topic.Click += new System.EventHandler(this.but_Topic_Click);
            // 
            // but_Ans
            // 
            this.but_Ans.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Ans.Location = new System.Drawing.Point(577, 132);
            this.but_Ans.Name = "but_Ans";
            this.but_Ans.Size = new System.Drawing.Size(93, 30);
            this.but_Ans.TabIndex = 7;
            this.but_Ans.Text = "显示答案";
            this.but_Ans.UseVisualStyleBackColor = true;
            this.but_Ans.Click += new System.EventHandler(this.but_Ans_Click);
            // 
            // but_Judge
            // 
            this.but_Judge.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Judge.Location = new System.Drawing.Point(577, 194);
            this.but_Judge.Name = "but_Judge";
            this.but_Judge.Size = new System.Drawing.Size(93, 30);
            this.but_Judge.TabIndex = 8;
            this.but_Judge.Text = "判断";
            this.but_Judge.UseVisualStyleBackColor = true;
            this.but_Judge.Click += new System.EventHandler(this.but_Judge_Click);
            // 
            // but_Error
            // 
            this.but_Error.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Error.Location = new System.Drawing.Point(577, 256);
            this.but_Error.Name = "but_Error";
            this.but_Error.Size = new System.Drawing.Size(93, 30);
            this.but_Error.TabIndex = 9;
            this.but_Error.Text = "错题本";
            this.but_Error.UseVisualStyleBackColor = true;
            this.but_Error.Click += new System.EventHandler(this.but_Error_Click);
            // 
            // but_Clear
            // 
            this.but_Clear.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Clear.Location = new System.Drawing.Point(577, 325);
            this.but_Clear.Name = "but_Clear";
            this.but_Clear.Size = new System.Drawing.Size(93, 30);
            this.but_Clear.TabIndex = 10;
            this.but_Clear.Text = "清空";
            this.but_Clear.UseVisualStyleBackColor = true;
            this.but_Clear.Click += new System.EventHandler(this.but_Clear_Click);
            // 
            // but_Return
            // 
            this.but_Return.Font = new System.Drawing.Font("宋体", 12F);
            this.but_Return.Location = new System.Drawing.Point(577, 390);
            this.but_Return.Name = "but_Return";
            this.but_Return.Size = new System.Drawing.Size(93, 30);
            this.but_Return.TabIndex = 11;
            this.but_Return.Text = "返回";
            this.but_Return.UseVisualStyleBackColor = true;
            this.but_Return.Click += new System.EventHandler(this.but_Return_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(39, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "正确数量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(120, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.but_Return);
            this.Controls.Add(this.but_Clear);
            this.Controls.Add(this.but_Error);
            this.Controls.Add(this.but_Judge);
            this.Controls.Add(this.but_Ans);
            this.Controls.Add(this.but_Topic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ans);
            this.Controls.Add(this.lb_Ans);
            this.Controls.Add(this.lb_Topic);
            this.Name = "Form2";
            this.Text = "答题界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Topic;
        private System.Windows.Forms.Button but_Ans;
        private System.Windows.Forms.Button but_Judge;
        private System.Windows.Forms.Button but_Error;
        private System.Windows.Forms.Button but_Clear;
        private System.Windows.Forms.Button but_Return;
        public System.Windows.Forms.TextBox txt_Ans;
        public System.Windows.Forms.ListBox lb_Ans;
        public System.Windows.Forms.ListBox lb_Topic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}