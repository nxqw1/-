namespace WindowsFormsApp2
{
    partial class FrmstuInsert
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsdept = new System.Windows.Forms.TextBox();
            this.tbsage = new System.Windows.Forms.TextBox();
            this.tbssex = new System.Windows.Forms.TextBox();
            this.tbsname = new System.Windows.Forms.TextBox();
            this.tbsno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbspwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "所在系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "学号";
            // 
            // tbsdept
            // 
            this.tbsdept.Location = new System.Drawing.Point(66, 144);
            this.tbsdept.Name = "tbsdept";
            this.tbsdept.Size = new System.Drawing.Size(166, 25);
            this.tbsdept.TabIndex = 4;
            // 
            // tbsage
            // 
            this.tbsage.Location = new System.Drawing.Point(65, 113);
            this.tbsage.Name = "tbsage";
            this.tbsage.Size = new System.Drawing.Size(166, 25);
            this.tbsage.TabIndex = 5;
            // 
            // tbssex
            // 
            this.tbssex.Location = new System.Drawing.Point(66, 82);
            this.tbssex.Name = "tbssex";
            this.tbssex.Size = new System.Drawing.Size(166, 25);
            this.tbssex.TabIndex = 6;
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(65, 51);
            this.tbsname.Name = "tbsname";
            this.tbsname.Size = new System.Drawing.Size(166, 25);
            this.tbsname.TabIndex = 7;
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(65, 20);
            this.tbsno.Name = "tbsno";
            this.tbsno.Size = new System.Drawing.Size(166, 25);
            this.tbsno.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbspwd
            // 
            this.tbspwd.Location = new System.Drawing.Point(66, 178);
            this.tbspwd.Name = "tbspwd";
            this.tbspwd.Size = new System.Drawing.Size(166, 25);
            this.tbspwd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "密码";
            // 
            // FrmstuInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 269);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbspwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsdept);
            this.Controls.Add(this.tbsage);
            this.Controls.Add(this.tbssex);
            this.Controls.Add(this.tbsname);
            this.Controls.Add(this.tbsno);
            this.Controls.Add(this.button1);
            this.Name = "FrmstuInsert";
            this.Text = "FrmstuInsert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbsdept;
        public System.Windows.Forms.TextBox tbsage;
        public System.Windows.Forms.TextBox tbssex;
        public System.Windows.Forms.TextBox tbsname;
        public System.Windows.Forms.TextBox tbsno;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbspwd;
        private System.Windows.Forms.Label label6;
    }
}