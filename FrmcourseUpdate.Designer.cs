namespace WindowsFormsApp2
{
    partial class FrmcourseUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbccredit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程号";
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(73, 26);
            this.tbcno.Name = "tbcno";
            this.tbcno.ReadOnly = true;
            this.tbcno.Size = new System.Drawing.Size(136, 25);
            this.tbcno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程名";
            // 
            // tbcname
            // 
            this.tbcname.Location = new System.Drawing.Point(73, 66);
            this.tbcname.Name = "tbcname";
            this.tbcname.Size = new System.Drawing.Size(136, 25);
            this.tbcname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "教师编号";
            // 
            // tbtno
            // 
            this.tbtno.Location = new System.Drawing.Point(73, 107);
            this.tbtno.Name = "tbtno";
            this.tbtno.Size = new System.Drawing.Size(136, 25);
            this.tbtno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "学分";
            // 
            // tbccredit
            // 
            this.tbccredit.Location = new System.Drawing.Point(73, 151);
            this.tbccredit.Name = "tbccredit";
            this.tbccredit.Size = new System.Drawing.Size(136, 25);
            this.tbccredit.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmcourseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbccredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbcname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.label1);
            this.Name = "FrmcourseUpdate";
            this.Text = "FrmcourseUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbcname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbtno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbccredit;
        private System.Windows.Forms.Button button1;
    }
}