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
            this.groupBox_Kivalasztas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_aoznosito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.groupBox_Kivalasztas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Termek
            // 
            this.listBox_Termek.FormattingEnabled = true;
            this.listBox_Termek.Location = new System.Drawing.Point(113, 12);
            this.listBox_Termek.Name = "listBox_Termek";
            this.listBox_Termek.Size = new System.Drawing.Size(663, 82);
            this.listBox_Termek.TabIndex = 0;
            this.listBox_Termek.SelectedIndexChanged += new System.EventHandler(this.listBox_Termek_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.textBox_aoznosito);
            this.groupBox2.Controls.Add(this.label1);
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
            this.button_ujrendeles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.textBox_Temek_Nev.Size = new System.Drawing.Size(159, 20);
            this.textBox_Temek_Nev.TabIndex = 14;
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
            this.button_termek.BackColor = System.Drawing.Color.Transparent;
            this.button_termek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_termek.Enabled = false;
            this.button_termek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_termek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_termek.Location = new System.Drawing.Point(32, 13);
            this.button_termek.Name = "button_termek";
            this.button_termek.Size = new System.Drawing.Size(75, 23);
            this.button_termek.TabIndex = 16;
            this.button_termek.Text = "Feltöltés";
            this.button_termek.UseVisualStyleBackColor = false;
            // 
            // groupBox_Kivalasztas
            // 
            this.groupBox_Kivalasztas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox_Kivalasztas.Controls.Add(this.numericUpDown3);
            this.groupBox_Kivalasztas.Controls.Add(this.numericUpDown2);
            this.groupBox_Kivalasztas.Controls.Add(this.numericUpDown1);
            this.groupBox_Kivalasztas.Controls.Add(this.label4);
            this.groupBox_Kivalasztas.Controls.Add(this.label3);
            this.groupBox_Kivalasztas.Controls.Add(this.label2);
            this.groupBox_Kivalasztas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_Kivalasztas.Location = new System.Drawing.Point(393, 371);
            this.groupBox_Kivalasztas.Name = "groupBox_Kivalasztas";
            this.groupBox_Kivalasztas.Size = new System.Drawing.Size(395, 67);
            this.groupBox_Kivalasztas.TabIndex = 17;
            this.groupBox_Kivalasztas.TabStop = false;
            this.groupBox_Kivalasztas.Text = "Kiválasztott termék";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Termék azonosító";
            // 
            // textBox_aoznosito
            // 
            this.textBox_aoznosito.Location = new System.Drawing.Point(185, 35);
            this.textBox_aoznosito.Name = "textBox_aoznosito";
            this.textBox_aoznosito.Size = new System.Drawing.Size(170, 20);
            this.textBox_aoznosito.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Egységár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Takrát készlet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vásárolt darab";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 36);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(132, 36);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 4;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(258, 35);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 5;
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Kivalasztas);
            this.Controls.Add(this.button_termek);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox_Termek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVasarlas";
            this.Text = "FormVasarlas";
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Kivalasztas.ResumeLayout(false);
            this.groupBox_Kivalasztas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_Kivalasztas;
        private System.Windows.Forms.TextBox textBox_aoznosito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}