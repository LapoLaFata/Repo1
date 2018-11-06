using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsGitLapo
{
    public partial class Form1 : Form
    {
        int[] V = new int[10];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCreaArray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                V[i] = rand.Next(100);
            }

            textBox1.Text = V[0].ToString();
            textBox2.Text = V[1].ToString();
            textBox3.Text = V[2].ToString();
            textBox4.Text = V[3].ToString();
            textBox5.Text = V[4].ToString();
            textBox6.Text = V[5].ToString();
            textBox7.Text = V[6].ToString();
            textBox8.Text = V[7].ToString();
            textBox9.Text = V[8].ToString();
            textBox10.Text = V[9].ToString();
            txtbMax.Text = "";
            txtbMin.Text = "";
        }

        private void bCalcolo_Click(object sender, EventArgs e)
        {
            txtbMax.Text = V.Max().ToString();
            MessageBox.Show("Bailuri");
            txtbMin.Text = V.Min().ToString();
        }
        
    }
                
}

    