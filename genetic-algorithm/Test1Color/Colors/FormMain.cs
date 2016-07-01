﻿using System;
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
        public byte goal;

        public void WriteLog(string text)
        {
            logText.AppendText(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Выбор цвета
            //colorDialog.ShowDialog();
            //goal = colorDialog.Color;
            //pChosenOne.BackColor = goal;
            //lbColorSelection.Visible = false;
            logText.Clear();

            byte channel = Convert.ToByte(tbGradation.Text);
            Algorithm main = new Algorithm(this, channel);
            tbResult.Text = main.Work().ToString();

            pColor.BackColor = Color.FromArgb(channel, channel, channel);
        }
    }
}
