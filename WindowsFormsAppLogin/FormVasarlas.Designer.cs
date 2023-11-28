namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBox_Termek = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Megvasarlas = new System.Windows.Forms.Button();
            this.button_ujrendeles = new System.Windows.Forms.Button();
            this.textBox_Temek_Nev = new System.Windows.Forms.TextBox();
            this.label_Pizza_Nev = new System.Windows.Forms.Label();
            this.button_termek = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Termek
            // 
            this.listBox_Termek.FormattingEnabled = true;
            this.listBox_Termek.Location = new System.Drawing.Point(113, 12);
            this.listBox_Termek.Name = "listBox_Termek";
            this.listBox_Termek.Size = new System.Drawing.Size(663, 82);
            this.listBox_Termek.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.button_Megvasarlas);
            this.groupBox2.Controls.Add(this.button_ujrendeles);
            this.groupBox2.Controls.Add(this.textBox_Temek_Nev);
            this.groupBox2.Controls.Add(this.label_Pizza_Nev);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox2.Location = new System.Drawing.Point(12, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 113);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termék igénylés és mennyisége választás";
            // 
            // button_Megvasarlas
            // 
            this.button_Megvasarlas.BackColor = System.Drawing.Color.Orange;
            this.button_Megvasarlas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Megvasarlas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Megvasarlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Megvasarlas.Location = new System.Drawing.Point(20, 61);
            this.button_Megvasarlas.Name = "button_Megvasarlas";
            this.button_Megvasarlas.Size = new System.Drawing.Size(130, 43);
            this.button_Megvasarlas.TabIndex = 17;
            this.button_Megvasarlas.Text = "Megvásárlás";
            this.button_Megvasarlas.UseVisualStyleBackColor = false;
            this.button_Megvasarlas.Click += new System.EventHandler(this.button_Megvasarlas_Click);
            // 
            // button_ujrendeles
            // 
            this.button_ujrendeles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_ujrendeles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ujrendeles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ujrendeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_ujrendeles.Location = new System.Drawing.Point(156, 62);
            this.button_ujrendeles.Name = "button_ujrendeles";
            this.button_ujrendeles.Size = new System.Drawing.Size(199, 42);
            this.button_ujrendeles.TabIndex = 16;
            this.button_ujrendeles.Text = "Új rendelés";
            this.button_ujrendeles.UseVisualStyleBackColor = false;
            this.button_ujrendeles.Click += new System.EventHandler(this.button_ujrendeles_Click);
            // 
            // textBox_Temek_Nev
            // 
            this.textBox_Temek_Nev.Location = new System.Drawing.Point(20, 35);
            this.textBox_Temek_Nev.Name = "textBox_Temek_Nev";
            this.textBox_Temek_Nev.Size = new System.Drawing.Size(130, 20);
            this.textBox_Temek_Nev.TabIndex = 14;
            this.textBox_Temek_Nev.Text = "Termék_név";
            // 
            // label_Pizza_Nev
            // 
            this.label_Pizza_Nev.AutoSize = true;
            this.label_Pizza_Nev.Location = new System.Drawing.Point(17, 16);
            this.label_Pizza_Nev.Name = "label_Pizza_Nev";
            this.label_Pizza_Nev.Size = new System.Drawing.Size(144, 13);
            this.label_Pizza_Nev.TabIndex = 13;
            this.label_Pizza_Nev.Text = "Termék neve kiválaztás után";
            // 
            // button_termek
            // 
            this.button_termek.BackColor = System.Drawing.Color.Black;
            this.button_termek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_termek.Enabled = false;
            this.button_termek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_termek.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_termek.Location = new System.Drawing.Point(32, 13);
            this.button_termek.Name = "button_termek";
            this.button_termek.Size = new System.Drawing.Size(75, 23);
            this.button_termek.TabIndex = 16;
            this.button_termek.Text = "Feltöltés";
            this.button_termek.UseVisualStyleBackColor = false;
            this.button_termek.Click += new System.EventHandler(this.button_termek_Click);
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_termek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Termek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVasarlas";
            this.Text = "FormVasarlas";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Termek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Megvasarlas;
        private System.Windows.Forms.Button button_ujrendeles;
        private System.Windows.Forms.TextBox textBox_Temek_Nev;
        private System.Windows.Forms.Label label_Pizza_Nev;
        private System.Windows.Forms.Button button_termek;
    }
}