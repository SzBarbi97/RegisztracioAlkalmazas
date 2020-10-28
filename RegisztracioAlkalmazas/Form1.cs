using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class RegisztracioAlkalmazas : Form
    {
        public RegisztracioAlkalmazas()
        {
            InitializeComponent();
        }


        private void hozzaad_Click(object sender, EventArgs e)
        {
            string ujhobbi = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(ujhobbi))
            {
                MessageBox.Show("A hobbi kötelező mező!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox3.Focus();
            }
            else if (hobbi.Items.Contains(ujhobbi)) 
            {
                MessageBox.Show("Már van a listában ilyen hobbi!", "", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox3.Focus();
            }
            else
            {
                hobbi.Items.Add(ujhobbi);
            }
            
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("A név kötelező mező!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox1.Focus();
            }
            else if (!no.Checked && !ferfi.Checked)
            {
                MessageBox.Show("Válasszon ki nemet!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(hobbi.SelectedIndex < 0 )
            {
                MessageBox.Show("Válasszon ki egy hobbit!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Nem = ferfi.Checked ? "Férfi" : "Nő";

                List<string> Hobbik = new List<string>();

                for (int i = 0; i < hobbi.Items.Count; i++)
                {
                    Hobbik.Add(hobbi.Items[i].ToString());
                }

                Ugyfel ugyfel = new Ugyfel(textBox1.Text.Trim(), Convert.ToInt32(numericUpDown1.Value.ToString()), Nem, hobbi.SelectedItem.ToString(), 
                    Hobbik);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fajl = saveFileDialog1.FileName;
                    using (StreamWriter sw = new StreamWriter(fajl))
                    {
                        sw.WriteLine(ugyfel);
                    }
                   
                }

                textBox1.Clear();
                textBox3.Clear();
                numericUpDown1.Value = numericUpDown1.Minimum;
                hobbi.Items.Clear();
                hobbi.SelectedIndex = -1;
                ferfi.Checked = false;
                no.Checked = false;
            }
        }

        private void betoltes_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    if (!sr.EndOfStream)
                    {
                        Ugyfel ugyfel = new Ugyfel(sr.ReadLine());

                        textBox1.Text = ugyfel.Nev;
                        numericUpDown1.Value = ugyfel.SzuletesiEv;

                        hobbi.Items.Clear();

                        foreach (string h in ugyfel.Hobbik)
                        {
                            hobbi.Items.Add(h.Trim());
                        }

                        if (ugyfel.Nem.Equals("Férfi"))
                        {
                            ferfi.Checked = true;
                        }
                        else
                        {
                            no.Checked = true;
                        }

                        hobbi.SelectedItem = ugyfel.KedvencHobbi;
                    }
                }
            }
        }
    }
}
