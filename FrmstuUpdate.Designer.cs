namespace WindowsFormsApp2
{
    partial class FrmstuUpdate
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
            this.tbssex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsdept = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsno
            // 
            this.tbsno.Location = new System.Drawing.Point(77, 12);
            this.tbsno.Name = "tbsno";
            this.tbsno.ReadOnly = true;
            this.tbsno.Size = new System.Drawing.Size(166, 25);
            this.tbsno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // tbsname
            // 
            this.tbsname.Location = new System.Drawing.Point(77, 43);
            this.tbsname.Name = "tbsname";
            this.tbsname.Size = new System.Drawing.Size(166, 25);
            this.tbsname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // tbssex
            // 
            this.tbssex.Location = new System.Drawing.Point(78, 74);
            this.tbssex.Name = "tbssex";
            this.tbssex.Size = new System.Drawing.Size(166, 25);
            this.tbssex.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别";
            // 
            // tbsage
            // 
            this.tbsage.Location = new System.Drawing.Point(77, 105);
            this.tbsage.Name = "tbsage";
            this.tbsage.Size = new System.Drawing.Size(166, 25);
            this.tbsage.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "年龄";
            // 
            // tbsdept
            // 
            this.tbsdept.Location = new System.Drawing.Point(78, 136);
            this.tbsdept.Name = "tbsdept";
            this.tbsdept.Size = new System.Drawing.Size(166, 25);
            this.tbsdept.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "所在系";
            // 
            // FrmstuUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 215);
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
            this.Name = "FrmstuUpdate";
            this.Text = "FrmstuUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbsno;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbsname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbssex;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbsage;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbsdept;
        private System.Windows.Forms.Label label5;
    }
}