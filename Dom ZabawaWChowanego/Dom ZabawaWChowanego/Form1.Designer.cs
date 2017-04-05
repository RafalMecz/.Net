namespace Dom_ZabawaWChowanego
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
            this.description = new System.Windows.Forms.TextBox();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughtTheDoor = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hiden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(473, 151);
            this.description.TabIndex = 0;
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(166, 178);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(305, 21);
            this.exits.TabIndex = 1;
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(36, 178);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(103, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Idź tutaj";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughtTheDoor
            // 
            this.goThroughtTheDoor.Location = new System.Drawing.Point(36, 218);
            this.goThroughtTheDoor.Name = "goThroughtTheDoor";
            this.goThroughtTheDoor.Size = new System.Drawing.Size(435, 23);
            this.goThroughtTheDoor.TabIndex = 3;
            this.goThroughtTheDoor.Text = "Przejdz przez drzwi";
            this.goThroughtTheDoor.UseVisualStyleBackColor = true;
            this.goThroughtTheDoor.Click += new System.EventHandler(this.goThroughtTheDoor_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(36, 261);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(435, 23);
            this.check.TabIndex = 4;
            this.check.Text = "sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hiden
            // 
            this.hiden.Location = new System.Drawing.Point(36, 302);
            this.hiden.Name = "hiden";
            this.hiden.Size = new System.Drawing.Size(435, 23);
            this.hiden.TabIndex = 5;
            this.hiden.Text = "Kryj się!";
            this.hiden.UseVisualStyleBackColor = true;
            this.hiden.Click += new System.EventHandler(this.hiden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 364);
            this.Controls.Add(this.hiden);
            this.Controls.Add(this.check);
            this.Controls.Add(this.goThroughtTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zbadaj Dom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughtTheDoor;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hiden;
    }
}

