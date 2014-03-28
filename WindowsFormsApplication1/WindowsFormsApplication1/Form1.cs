using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //comment
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked();
        }

        private void isChecked()
        {
            if (checkBox1.Checked)
            {
                label1.Text = "Checked";
            }
            else
            {
                label1.Text = "Not Checked";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isChecked();
        }

    }
}
