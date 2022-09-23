namespace WindowsFormsApp2
{
    partial class FrmInsertgradeInsert
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbsno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbgrade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(100, 12);
            this.tbsno.Name = "tbsno";
            this.tbsno.ReadOnly = true;
            this.tbsno.Size = new System.Drawing.Size(130, 25);
            this.tbsno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(100, 58);
            this.tbsname.Name = "tbsname";
            this.tbsname.ReadOnly = true;
            this.tbsname.Size = new System.Drawing.Size(130, 25);
            this.tbsname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // tbcno
            // 
            this.tbcno.Location = new System.Drawing.Point(100, 108);
            this.tbcno.Name = "tbcno";
            this.tbcno.ReadOnly = true;
            this.tbcno.Size = new System.Drawing.Size(130, 25);
            this.tbcno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "课程号";
            // 
            // tbcname
            // 
            this.tbcname.Location = new System.Drawing.Point(100, 160);
            this.tbcname.Name = "tbcname";
            this.tbcname.ReadOnly = true;
            this.tbcname.Size = new System.Drawing.Size(130, 25);
            this.tbcname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "课程名";
            // 
            // tbgrade
            // 
            this.tbgrade.Location = new System.Drawing.Point(100, 210);
            this.tbgrade.Name = "tbgrade";
            this.tbgrade.Size = new System.Drawing.Size(130, 25);
            this.tbgrade.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "录入成绩";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "姓名";
            // 
            // FrmInsertgradeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 325);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbgrade);
            this.Controls.Add(this.tbcname);
            this.Controls.Add(this.tbcno);
            this.Controls.Add(this.tbsname);
            this.Controls.Add(this.tbsno);
            this.Controls.Add(this.button1);
            this.Name = "FrmInsertgradeInsert";
            this.Text = "FrmInsertgradeInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbsno;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbsname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbcno;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbcname;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}