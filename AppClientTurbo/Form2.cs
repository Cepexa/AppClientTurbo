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
        List<Cash> listCash2;
        string name;
        public Form2(object listCash2,string quest,string name)
        {
            InitializeComponent();
            textBox1.Text = quest;
            this.listCash2 = (List<Cash>)listCash2;
            this.name = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCash2.Remove(listCash2.Find(x => x.Name == name));
            this.Close();
        }
    }
}
