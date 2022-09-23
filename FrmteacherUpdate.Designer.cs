namespace WindowsFormsApp2
{
    partial class FrmteacherUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbtno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtsalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbtprofession = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "教工号";
            // 
            // tbtno
            // 
            this.tbtno.Location = new System.Drawing.Point(105, 33);
            this.tbtno.Name = "tbtno";
            this.tbtno.ReadOnly = true;
            this.tbtno.Size = new System.Drawing.Size(169, 25);
            this.tbtno.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // tbtname
            // 
            this.tbtname.Location = new System.Drawing.Point(105, 80);
            this.tbtname.Name = "tbtname";
            this.tbtname.Size = new System.Drawing.Size(169, 25);
            this.tbtname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "工资";
            // 
            // tbtsalary
            // 
            this.tbtsalary.Location = new System.Drawing.Point(105, 127);
            this.tbtsalary.Name = "tbtsalary";
            this.tbtsalary.Size = new System.Drawing.Size(169, 25);
            this.tbtsalary.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "职称";
            // 
            // tbtprofession
            // 
            this.tbtprofession.Location = new System.Drawing.Point(105, 174);
            this.tbtprofession.Name = "tbtprofession";
            this.tbtprofession.Size = new System.Drawing.Size(169, 25);
            this.tbtprofession.TabIndex = 2;
            // 
            // FrmteacherUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 279);
            this.Controls.Add(this.tbtprofession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtsalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbtno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmteacherUpdate";
            this.Text = "FrmteacherUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbtno;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbtname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbtsalary;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbtprofession;
    }
}