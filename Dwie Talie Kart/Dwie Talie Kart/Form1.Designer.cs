namespace Dwie_Talie_Kart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.reset1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zestaw 1. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zestaw 2.";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(29, 42);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(120, 212);
            this.ListBox1.TabIndex = 2;
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.Location = new System.Drawing.Point(260, 42);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(120, 212);
            this.ListBox2.TabIndex = 3;
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(178, 86);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(55, 23);
            this.moveToDeck2.TabIndex = 4;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(178, 141);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(55, 23);
            this.moveToDeck1.TabIndex = 5;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(29, 279);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(120, 23);
            this.reset1.TabIndex = 6;
            this.reset1.Text = "Przywróć zestaw 1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(260, 278);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(120, 23);
            this.reset2.TabIndex = 7;
            this.reset2.Text = "Przywróć zestaw 2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(29, 327);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(120, 23);
            this.shuffle1.TabIndex = 8;
            this.shuffle1.Text = "Wymieszaj zestaw 1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(260, 327);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(120, 23);
            this.shuffle2.TabIndex = 9;
            this.shuffle2.Text = "Wymieszaj zestaw 2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 392);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dwie talie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button shuffle2;
    }
}

