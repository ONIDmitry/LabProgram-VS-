using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProgram
{
    public partial class MainForm : Form
    {
       public static bool Lab1Done = false;
       public static bool Lab2Done = false;
       public static bool Lab3Done = false;
       public static bool Lab4Done = false;
       public static int Lab1Mark = 100;
       public static int Lab2Mark = 100;
       public static int Lab3Mark = 100;
       public static int Lab4Mark = 100;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DescribePRO dpro1 = new DescribePRO();
            dpro1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Lab1Tittle lb1ttl = new Lab1Tittle();
            lb1ttl.Show();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Lab2Tittle lb1ttl = new Lab2Tittle();
            lb1ttl.Show(); ;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Lab3Tittl lb1ttl = new Lab3Tittl();
            lb1ttl.Show(); ;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
