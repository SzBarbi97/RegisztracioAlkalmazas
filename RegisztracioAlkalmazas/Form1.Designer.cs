namespace RegisztracioAlkalmazas
{
    partial class RegisztracioAlkalmazas
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
            this.components = new System.ComponentModel.Container();
            this.nev = new System.Windows.Forms.Label();
            this.szuldatum = new System.Windows.Forms.Label();
            this.nem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.RadioButton();
            this.ferfi = new System.Windows.Forms.RadioButton();
            this.hobbi = new System.Windows.Forms.ListBox();
            this.kedvenchobbi = new System.Windows.Forms.Label();
            this.ujhobbi = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.hozzaad = new System.Windows.Forms.Button();
            this.betoltes = new System.Windows.Forms.Button();
            this.mentes = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.hobbi_lista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(98, 47);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(30, 13);
            this.nev.TabIndex = 0;
            this.nev.Text = "Név:";
            // 
            // szuldatum
            // 
            this.szuldatum.AutoSize = true;
            this.szuldatum.Location = new System.Drawing.Point(98, 91);
            this.szuldatum.Name = "szuldatum";
            this.szuldatum.Size = new System.Drawing.Size(65, 13);
            this.szuldatum.TabIndex = 1;
            this.szuldatum.Text = "Szül. dátum:";
            // 
            // nem
            // 
            this.nem.AutoSize = true;
            this.nem.Location = new System.Drawing.Point(98, 130);
            this.nem.Name = "nem";
            this.nem.Size = new System.Drawing.Size(32, 13);
            this.nem.TabIndex = 2;
            this.nem.Text = "Nem:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(174, 126);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(39, 17);
            this.no.TabIndex = 5;
            this.no.TabStop = true;
            this.no.Text = "Nő";
            this.no.UseVisualStyleBackColor = true;
            // 
            // ferfi
            // 
            this.ferfi.AutoSize = true;
            this.ferfi.Location = new System.Drawing.Point(229, 126);
            this.ferfi.Name = "ferfi";
            this.ferfi.Size = new System.Drawing.Size(45, 17);
            this.ferfi.TabIndex = 6;
            this.ferfi.TabStop = true;
            this.ferfi.Text = "Férfi";
            this.ferfi.UseVisualStyleBackColor = true;
            // 
            // hobbi
            // 
            this.hobbi.FormattingEnabled = true;
            this.hobbi.Location = new System.Drawing.Point(319, 66);
            this.hobbi.Name = "hobbi";
            this.hobbi.Size = new System.Drawing.Size(100, 108);
            this.hobbi.TabIndex = 7;
            // 
            // kedvenchobbi
            // 
            this.kedvenchobbi.AutoSize = true;
            this.kedvenchobbi.Location = new System.Drawing.Point(316, 50);
            this.kedvenchobbi.Name = "kedvenchobbi";
            this.kedvenchobbi.Size = new System.Drawing.Size(85, 13);
            this.kedvenchobbi.TabIndex = 8;
            this.kedvenchobbi.Text = "Kedvenc hobbi: ";
            // 
            // ujhobbi
            // 
            this.ujhobbi.AutoSize = true;
            this.ujhobbi.Location = new System.Drawing.Point(264, 191);
            this.ujhobbi.Name = "ujhobbi";
            this.ujhobbi.Size = new System.Drawing.Size(49, 13);
            this.ujhobbi.TabIndex = 9;
            this.ujhobbi.Text = "Új hobbi:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // hozzaad
            // 
            this.hozzaad.Location = new System.Drawing.Point(344, 223);
            this.hozzaad.Name = "hozzaad";
            this.hozzaad.Size = new System.Drawing.Size(75, 23);
            this.hozzaad.TabIndex = 11;
            this.hozzaad.Text = "Hozzáad";
            this.hozzaad.UseVisualStyleBackColor = true;
            this.hozzaad.Click += new System.EventHandler(this.hozzaad_Click);
            // 
            // betoltes
            // 
            this.betoltes.Location = new System.Drawing.Point(344, 262);
            this.betoltes.Name = "betoltes";
            this.betoltes.Size = new System.Drawing.Size(75, 23);
            this.betoltes.TabIndex = 12;
            this.betoltes.Text = "Betöltés";
            this.betoltes.UseVisualStyleBackColor = true;
            this.betoltes.Click += new System.EventHandler(this.betoltes_Click);
            // 
            // mentes
            // 
            this.mentes.Location = new System.Drawing.Point(263, 262);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 23);
            this.mentes.TabIndex = 13;
            this.mentes.Text = "Mentés";
            this.mentes.UseVisualStyleBackColor = true;
            this.mentes.Click += new System.EventHandler(this.mentes_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(174, 89);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // hobbi_lista
            // 
            this.hobbi_lista.Name = "hobbi_lista";
            this.hobbi_lista.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RegisztracioAlkalmazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 307);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.betoltes);
            this.Controls.Add(this.hozzaad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ujhobbi);
            this.Controls.Add(this.kedvenchobbi);
            this.Controls.Add(this.hobbi);
            this.Controls.Add(this.ferfi);
            this.Controls.Add(this.no);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nem);
            this.Controls.Add(this.szuldatum);
            this.Controls.Add(this.nev);
            this.Name = "RegisztracioAlkalmazas";
            this.Text = "RegisztracioAlkalmazas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label szuldatum;
        private System.Windows.Forms.Label nem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton no;
        private System.Windows.Forms.RadioButton ferfi;
        private System.Windows.Forms.ListBox hobbi;
        private System.Windows.Forms.Label kedvenchobbi;
        private System.Windows.Forms.Label ujhobbi;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button hozzaad;
        private System.Windows.Forms.Button betoltes;
        private System.Windows.Forms.Button mentes;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ContextMenuStrip hobbi_lista;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

