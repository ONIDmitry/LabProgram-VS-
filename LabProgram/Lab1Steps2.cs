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

namespace LabProgram
{
    public partial class Lab1Steps2 : Form
    {
        public Lab1Steps2()
        {
            InitializeComponent();
        }

        private void Lab1Check_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "D:\\Проги\\Нов\\LabProgram\\LabProgram\\bin\\Debug";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Lab2Path.Text = dlg.FileName;
            }
        }

        private void Lab1Check2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg1 = new OpenFileDialog();
            dlg1.InitialDirectory = "D:\\Проги\\Нов\\LabProgram\\LabProgram\\bin\\Debug";

            if (dlg1.ShowDialog() == DialogResult.OK)
            {
                Lab2Path2.Text = dlg1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Lab2Path.Text.Contains(".dll"))
            {
                MessageBox.Show("Укажите файл ИМ, полученный в результате трансляции : выбран неверный файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LabProgram.MainForm.Lab2Mark -= 10;
            }
            else if (!Lab2Path2.Text.Contains("ResourceParameters.xml"))
            {
                MessageBox.Show("Укажите файл, полученный в результате работы с компонентом расчета состояний : выбран неверный файл!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LabProgram.MainForm.Lab2Mark -= 10;
            }
            else
            {
                MessageBox.Show("Лабораторная работа №1 выполнена! Ваша оценка : " + LabProgram.MainForm.Lab1Mark, "Успешно");
                LabProgram.MainForm.Lab2Done = true;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Steps1 lb1stp1 = new Lab1Steps1();
            lb1stp1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            MyProc.StartInfo.FileName = @"C:\Users\user\Desktop\Подсистема имитационного моделирования\Подсистема имитационного моделирования\Computation Model\ComputationModel.exe";
            MyProc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExTrans extr1 = new ExTrans();
            extr1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExRSost exrsst1 = new ExRSost();
            exrsst1.Show();
        }
    }
}
