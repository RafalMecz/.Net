namespace Serializacja_Zabawa_Franklina_i_Ździcha
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
            this.joelCashLabel = new System.Windows.Forms.TextBox();
            this.bobCashLabel = new System.Windows.Forms.TextBox();
            this.bankCashLabel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JoeGiveToBob = new System.Windows.Forms.Button();
            this.BobGiveToJoe = new System.Windows.Forms.Button();
            this.saveFranklin = new System.Windows.Forms.Button();
            this.loadZdzich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joelCashLabel
            // 
            this.joelCashLabel.Location = new System.Drawing.Point(13, 13);
            this.joelCashLabel.Name = "joelCashLabel";
            this.joelCashLabel.Size = new System.Drawing.Size(100, 20);
            this.joelCashLabel.TabIndex = 0;
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.Location = new System.Drawing.Point(13, 40);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(100, 20);
            this.bobCashLabel.TabIndex = 1;
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.Location = new System.Drawing.Point(13, 67);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(100, 20);
            this.bankCashLabel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Daj 10 zl Franklinowi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Weź 5 zl od Żdzicha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // JoeGiveToBob
            // 
            this.JoeGiveToBob.Location = new System.Drawing.Point(13, 172);
            this.JoeGiveToBob.Name = "JoeGiveToBob";
            this.JoeGiveToBob.Size = new System.Drawing.Size(100, 36);
            this.JoeGiveToBob.TabIndex = 5;
            this.JoeGiveToBob.Text = "Franklin daje 15 zl Żdzichowi";
            this.JoeGiveToBob.UseVisualStyleBackColor = true;
            this.JoeGiveToBob.Click += new System.EventHandler(this.JoeGiveToBob_Click);
            // 
            // BobGiveToJoe
            // 
            this.BobGiveToJoe.Location = new System.Drawing.Point(141, 172);
            this.BobGiveToJoe.Name = "BobGiveToJoe";
            this.BobGiveToJoe.Size = new System.Drawing.Size(107, 36);
            this.BobGiveToJoe.TabIndex = 6;
            this.BobGiveToJoe.Text = "Żdzich daj 10 zl Franklinowi";
            this.BobGiveToJoe.UseVisualStyleBackColor = true;
            this.BobGiveToJoe.Click += new System.EventHandler(this.BobGiveToJoe_Click);
            // 
            // saveFranklin
            // 
            this.saveFranklin.Location = new System.Drawing.Point(13, 227);
            this.saveFranklin.Name = "saveFranklin";
            this.saveFranklin.Size = new System.Drawing.Size(100, 23);
            this.saveFranklin.TabIndex = 7;
            this.saveFranklin.Text = "Zapisz Franklina";
            this.saveFranklin.UseVisualStyleBackColor = true;
            this.saveFranklin.Click += new System.EventHandler(this.saveFranklin_Click);
            // 
            // loadZdzich
            // 
            this.loadZdzich.Location = new System.Drawing.Point(141, 227);
            this.loadZdzich.Name = "loadZdzich";
            this.loadZdzich.Size = new System.Drawing.Size(107, 23);
            this.loadZdzich.TabIndex = 8;
            this.loadZdzich.Text = "Wczytaj Żdzicha";
            this.loadZdzich.UseVisualStyleBackColor = true;
            this.loadZdzich.Click += new System.EventHandler(this.loadZdzich_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.loadZdzich);
            this.Controls.Add(this.saveFranklin);
            this.Controls.Add(this.BobGiveToJoe);
            this.Controls.Add(this.JoeGiveToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joelCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zabawa z Franklinem i Żdzichem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox joelCashLabel;
        private System.Windows.Forms.TextBox bobCashLabel;
        private System.Windows.Forms.TextBox bankCashLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button JoeGiveToBob;
        private System.Windows.Forms.Button BobGiveToJoe;
        private System.Windows.Forms.Button saveFranklin;
        private System.Windows.Forms.Button loadZdzich;
    }
}

