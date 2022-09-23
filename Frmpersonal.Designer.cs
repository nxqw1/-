namespace WindowsFormsApp2
{
    partial class Frmpersonal
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbpwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbage = new System.Windows.Forms.TextBox();
            this.tbsex = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "密码";
            // 
            // tbpwd
            // 
            this.tbpwd.Location = new System.Drawing.Point(66, 149);
            this.tbpwd.Name = "tbpwd";
            this.tbpwd.Size = new System.Drawing.Size(166, 25);
            this.tbpwd.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "年龄";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "学号";
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(67, 118);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(166, 25);
            this.tbage.TabIndex = 18;
            // 
            // tbsex
            // 
            this.tbsex.Location = new System.Drawing.Point(67, 87);
            this.tbsex.Name = "tbsex";
            this.tbsex.Size = new System.Drawing.Size(166, 25);
            this.tbsex.TabIndex = 19;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(66, 56);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(166, 25);
            this.tbname.TabIndex = 20;
            // 
            // tbno
            // 
            this.tbno.Location = new System.Drawing.Point(66, 25);
            this.tbno.Name = "tbno";
            this.tbno.ReadOnly = true;
            this.tbno.Size = new System.Drawing.Size(166, 25);
            this.tbno.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "修改个人信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frmpersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 238);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbpwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.tbsex);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbno);
            this.Controls.Add(this.button1);
            this.Name = "Frmpersonal";
            this.Text = "Frmpersonal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbpwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbage;
        public System.Windows.Forms.TextBox tbsex;
        public System.Windows.Forms.TextBox tbname;
        public System.Windows.Forms.TextBox tbno;
        private System.Windows.Forms.Button button1;
    }
}