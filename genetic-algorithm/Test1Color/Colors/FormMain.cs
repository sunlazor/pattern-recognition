using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Genetic
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Эталонный цвет к которому идет приближение
        Color goal;
        // Количество особей
        const int N = 10;
        // Сами особи
        List<Specimen> specimens = new List<Specimen>();
        List<Specimen> condidates = new List<Specimen>();
        // Количетсво итераций
        const int STEPS = 3000;
        // Для функции подсчета веротяности скрещивания
        const int DIVERSITY_COEFFICIENT = 750;
        // График
        Pen pen = new Pen(Color.FromArgb(0, 0, 0));
        Point ptFrom = new Point();
        Point ptTo = new Point();
        Graphics gr;

        private void DrawGraph(List<Specimen> specimens, int currentStep)
        {
            //double fitSum = 0;
            //foreach (Specimen specimen in specimens)
            //{
            //    fitSum += specimen.GetFit();
            //}
            //fitSum /= specimens.Count;
            //ptTo = new Point(Convert.ToInt32(currentStep * pGraph.Width / STEPS), Convert.ToInt32(fitSum / N * pGraph.Height / (byte.MaxValue * 3)));
            //if (currentStep == 0)
            //    ptFrom = ptTo;
            //gr.DrawLine(pen, ptFrom, ptTo);
            //ptFrom = ptTo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Выбор цвета
            colorDialog.ShowDialog();
            goal = colorDialog.Color;
            pChosenOne.BackColor = goal;
            lbColorSelection.Visible = false;
            Algorithm main = new Algorithm();
            main.Work();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; ++i)
            {
                logText.AppendText(i.ToString() + ":" + rnd.Next(10).ToString() + "\n");
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {

        }
    }
}
