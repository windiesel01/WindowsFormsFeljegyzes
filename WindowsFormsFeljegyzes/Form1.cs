using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFeljegyzes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBox_szoveg.Text))
            {
                MessageBox.Show("Nem adott meg szöveget!");
                return;
            }

            saveFileDialog.Filter = "Egyszerű szöveg fájl| *.txt|Vesszővel tagolt szövegfájl (*.csv)|*.csv|Minden fájl|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", textBox_nev.Text, richTextBox_szoveg.Text, dateTimePicker_datum.Text);
                string kivFile = saveFileDialog.FileName;
                File.AppendAllText(kivFile, szoveg+"\n");
                textBox_nev.Text = "";
                richTextBox_szoveg.Text = "";

            }
            else
            {
                MessageBox.Show("Nincs kiválasztva fájl");
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string kiviFile = openFileDialog.FileName;
                string beolvasottSzoveg = File.ReadAllText(kiviFile);
                string[] adatok = beolvasottSzoveg.Split(';');
                foreach (string sor in adatok)
                {
                    richTextBox_szoveg.Text += Convert.ToString(sor) + "  ";
                }
            }
        }
    }
}
