namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Diag = new System.Windows.Forms.TextBox();
            this.Cont = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Questions = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.TextBox();
            this.Q2 = new System.Windows.Forms.TextBox();
            this.Q1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Questions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Diag
            // 
            this.Diag.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diag.Location = new System.Drawing.Point(30, 22);
            this.Diag.Multiline = true;
            this.Diag.Name = "Diag";
            this.Diag.Size = new System.Drawing.Size(735, 78);
            this.Diag.TabIndex = 0;
            this.Diag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cont
            // 
            this.Cont.BackColor = System.Drawing.Color.Olive;
            this.Cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cont.Location = new System.Drawing.Point(370, 116);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(75, 23);
            this.Cont.TabIndex = 1;
            this.Cont.Text = "Continuar";
            this.Cont.UseVisualStyleBackColor = false;
            this.Cont.Click += new System.EventHandler(this.Cont_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.Transparent;
            this.Questions.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Pbg;
            this.Questions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Questions.Controls.Add(this.label2);
            this.Questions.Controls.Add(this.label1);
            this.Questions.Controls.Add(this.Ans);
            this.Questions.Controls.Add(this.Q2);
            this.Questions.Controls.Add(this.Q1);
            this.Questions.Location = new System.Drawing.Point(301, 162);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(342, 140);
            this.Questions.TabIndex = 3;
            this.Questions.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ans
            // 
            this.Ans.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(151, 96);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(68, 30);
            this.Ans.TabIndex = 2;
            // 
            // Q2
            // 
            this.Q2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2.Location = new System.Drawing.Point(36, 60);
            this.Q2.Name = "Q2";
            this.Q2.ReadOnly = true;
            this.Q2.Size = new System.Drawing.Size(280, 25);
            this.Q2.TabIndex = 1;
            // 
            // Q1
            // 
            this.Q1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q1.Location = new System.Drawing.Point(36, 18);
            this.Q1.Name = "Q1";
            this.Q1.ReadOnly = true;
            this.Q1.Size = new System.Drawing.Size(280, 25);
            this.Q1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Pbg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Cont);
            this.panel1.Controls.Add(this.Diag);
            this.panel1.Location = new System.Drawing.Point(89, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 155);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.I0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Questions);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Questions.ResumeLayout(false);
            this.Questions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Diag;
        private System.Windows.Forms.Button Cont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Questions;
        private System.Windows.Forms.TextBox Ans;
        private System.Windows.Forms.TextBox Q2;
        private System.Windows.Forms.TextBox Q1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

