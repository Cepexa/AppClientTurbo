using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClientTurbo
{
    public partial class Form2 : Form
    {
        public Form2(string quest,string btn1 = "Да",string btn2 ="Нет",string header = "Подтверждение действий")
        {
            InitializeComponent();
            textBox1.Text = quest;
            button1 .Text = btn1;
            button2 .Text = btn2;
            this.Text     = header;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes; 
            this.Close();
        }
    }
}
