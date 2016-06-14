﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Colors
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
        const int N = 4;
        // Сами особи
        List<Specimen> specimens = new List<Specimen>();
        List<Specimen> condidates = new List<Specimen>();
        // Количетсво итераций
        const int STEPS = 1000;

        private int Fitness(Color goal, Specimen candidate)
        {
            int result = 
                Math.Abs(goal.R - candidate.GetRed())
                + Math.Abs(goal.G - candidate.GetGreen())
                + Math.Abs(goal.B - candidate.GetBlue());
            return result;
        }

        private int StayInByte(int num)
        {
            if (num < byte.MinValue)
                return byte.MinValue;
            else if (num > byte.MaxValue)
                return byte.MaxValue;
            else
                return num;
        }

        private void InitSpecimens(int count, List<Specimen> specimens)
        {
            for (int i = 0; i < count; i++)
            {
                specimens.Add(new Specimen(count));
                condidates.Add(new Specimen(count));
            }
        }

        private void ShowSpecimens(List<Specimen> specimens)
        {
            for (int i = 0; i < specimens.Count; i++)
            {
                logText.AppendText(specimens[i].ToString(i));
            }
        }

        private void SetFitness(List<Specimen> specimens)
        {
            for (int i = 0; i < specimens.Count; i++)
            {
                specimens[i].SetFit(Fitness(goal, specimens[i]));
            }
        }

        private void TeachSpecimens(List<Specimen> specimens)
        {
            Random random = new Random();
            // Итерации обучения
            for (int step = 0; step < STEPS; ++step)
            {
                // Отбор
                double sumProbability;   // Сумма вероятностей для определения нынешнего номера особи
                int godFinger;  // Выбор особи
                int currentSelection = 0;   // Номер особи

                for (int j = 0; j < N; ++j)
                {
                    sumProbability = 0;
                    godFinger = random.Next(100);
                    for (int i = 0; i < N; ++i)
                    {
                        sumProbability += specimens[i].GetCP();
                        if ((sumProbability * 100) > godFinger)
                        {
                            currentSelection = i;
                            break;
                        }
                    }
                    condidates[j] = specimens[currentSelection];
                }

                if ((step + 1) % N == 0)
                {
                    logText.AppendText("Pre calc:\n");
                    logText.AppendText("Step:" + (step + 1).ToString() + "\n");
                    logText.AppendText("Specimens:\n");
                    ShowSpecimens(specimens);
                    logText.AppendText("Condidates:\n");
                    ShowSpecimens(condidates);
                }

                CrossoverAndMutateSpecimens(specimens);
                SetFitness(specimens);
                CalcProbability(specimens);

                if ((step + 1) % N == 0)  //???
                {
                    logText.AppendText("Step:" + (step + 1).ToString() + "\n");
                    logText.AppendText("Specimens:\n");
                    ShowSpecimens(specimens);
                    logText.AppendText("Condidates:\n");
                    ShowSpecimens(condidates);
                }
            }
        }

        // Скрещивание
        private void CrossoverAndMutateSpecimens(List<Specimen> pretenders)
        {
            Random random;
            int godFinger;
            
            int R1, R2, G1, G2, B1, B2;
            for (int i = 0; i < N / 2; ++i)
            {
                random = new Random();
                // Скрещивание
                godFinger = random.Next(100);
                R1 = pretenders[i + (godFinger < 50 ? 0 : 1)].GetRed();
                R2 = pretenders[i + (godFinger < 50 ? 1 : 0)].GetRed();
                godFinger = random.Next(100);
                G1 = pretenders[i + (godFinger < 50 ? 0 : 1)].GetGreen();
                G2 = pretenders[i + (godFinger < 50 ? 1 : 0)].GetGreen();
                godFinger = random.Next(100);
                B1 = pretenders[i + (godFinger < 50 ? 0 : 1)].GetBlue();
                B2 = pretenders[i + (godFinger < 50 ? 1 : 0)].GetBlue();
                // Мутация
                random = new Random();
                godFinger = random.Next(300);
                if (godFinger < 5)
                    R1 = Mutate(R1, godFinger);
                else if (godFinger < 10)
                    R2 = Mutate(R2, godFinger);
                else if (godFinger < 15)
                    G1 = Mutate(G1, godFinger);
                else if (godFinger < 20)
                    G2 = Mutate(G2, godFinger);
                else if (godFinger < 25)
                    B1 = Mutate(B1, godFinger);
                else if (godFinger < 30)
                    B2 = Mutate(B2, godFinger);
            }
        }

        // Мутация
        private int Mutate(int from, int mutation)
        {
            mutation = (mutation % 5) - 2;
            return StayInByte(from + mutation);
        }

        // Приспособленность
        private bool TestSpecimens(List<Specimen> specimens)
        {
            for (int i = 0; i < specimens.Count; i++)
            {
                specimens[i].SetFit(Fitness(goal, specimens[i]));
                if (specimens[i].GetFit() == 0)
                    return true;
            }
            return false;
        }

        // Вычисление выроятности скрещивания
        private void CalcProbability(List<Specimen> specimens)
        {
            double sumFitness = 0;
            double sumProbability = 0;
            for (int i = 0; i < specimens.Count; i++)
            {
                sumFitness += specimens[i].GetFit();
            }
            for (int i = 0; i < specimens.Count; i++)
            {
                specimens[i].SetCP(Math.Exp(specimens[i].GetFit() / sumFitness));
                sumProbability += specimens[i].GetCP();
            }
            for (int i = 0; i < specimens.Count; i++)
            {
                specimens[i].SetCP(specimens[i].GetCP() / sumProbability);
            }
        }

        private bool FindColor()
        {
            // Создание начальной популяции
            InitSpecimens(N, specimens);
            ShowSpecimens(specimens);
            TeachSpecimens(specimens);
            return false;
        }

        private void ClearAll()
        {
            // Очистка предыдущей попытки
            specimens.Clear();
            logText.Clear();
            pFoundOne.BackColor = Color.FromKnownColor(KnownColor.Control);
            pGraph.BackColor = Color.FromKnownColor(KnownColor.Control);
            lbColorSelection.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
            // Выбор цвета
            colorDialog.ShowDialog();
            goal = colorDialog.Color;
            pChosenOne.BackColor = goal;
            lbColorSelection.Visible = false;

            FindColor();
            
            //Pen pen = new Pen(Color.FromArgb(0, 0, 0));
            //Point ptFrom = new Point();
            //Point ptTo = new Point();


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