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

namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public string path = @"C:\save_txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (File.Exists(path + @"\save.txt")) metroTextBox1.Text = File.ReadAllText(path + @"\save.txt");
            else File.Create(path + @"\save.txt").Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(path + @"\save.txt", metroTextBox1.Text.ToString());
        }
    }
}
