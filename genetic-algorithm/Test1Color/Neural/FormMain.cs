using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Neural
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            FillOutput();
            net = new Network(9, 3, this);
        }

        Network net;

        public List<TextBox> output = new List<TextBox>();

        private void FillOutput()
        {
            output.Clear();
            output.Add(tbBlack);
            output.Add(tbRed);
            output.Add(tbOrange);
            output.Add(tbYellow);
            output.Add(tbGreen);
            output.Add(tbLightBlue);
            output.Add(tbBlue);
            output.Add(tbViolette);
            output.Add(tbWhite);
        }

        private void btTeach_Click(object sender, EventArgs e)
        {
            int techNum;

            for (int i = 0; i < 500; i++)
            {
                // Черный
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(0);
                    net.neurons[j].x[1] = Neuron.InputTransform(0);
                    net.neurons[j].x[2] = Neuron.InputTransform(0);
                }
                techNum = 0;
                net.Teach(techNum);

                // Красный
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(255);
                    net.neurons[j].x[1] = Neuron.InputTransform(0);
                    net.neurons[j].x[2] = Neuron.InputTransform(0);
                }
                techNum = 1;
                net.Teach(techNum);

                // Оранжевый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(255);
                    net.neurons[j].x[1] = Neuron.InputTransform(165);
                    net.neurons[j].x[2] = Neuron.InputTransform(0);
                }
                techNum = 2;
                net.Teach(techNum);

                // Желтый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(255);
                    net.neurons[j].x[1] = Neuron.InputTransform(255);
                    net.neurons[j].x[2] = Neuron.InputTransform(0);
                }
                techNum = 3;
                net.Teach(techNum);

                // Зеленый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(0);
                    net.neurons[j].x[1] = Neuron.InputTransform(255);
                    net.neurons[j].x[2] = Neuron.InputTransform(0);
                }
                techNum = 4;
                net.Teach(techNum);

                // Голубой
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(66);
                    net.neurons[j].x[1] = Neuron.InputTransform(170);
                    net.neurons[j].x[2] = Neuron.InputTransform(255);
                }
                techNum = 5;
                net.Teach(techNum);

                // Синий
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(0);
                    net.neurons[j].x[1] = Neuron.InputTransform(0);
                    net.neurons[j].x[2] = Neuron.InputTransform(255);
                }
                techNum = 6;
                net.Teach(techNum);

                // Фиолетовый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(139);
                    net.neurons[j].x[1] = Neuron.InputTransform(0);
                    net.neurons[j].x[2] = Neuron.InputTransform(255);
                }
                techNum = 7;
                net.Teach(techNum);

                // Белый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(255);
                    net.neurons[j].x[1] = Neuron.InputTransform(255);
                    net.neurons[j].x[2] = Neuron.InputTransform(255);
                }
                techNum = 8;
                net.Teach(techNum);
            }
        }

        private void btBlack_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(0);
                net.neurons[j].x[1] = Neuron.InputTransform(0);
                net.neurons[j].x[2] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btRed_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(255);
                net.neurons[j].x[1] = Neuron.InputTransform(0);
                net.neurons[j].x[2] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btOrange_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(255);
                net.neurons[j].x[1] = Neuron.InputTransform(165);
                net.neurons[j].x[2] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btYellow_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(255);
                net.neurons[j].x[1] = Neuron.InputTransform(255);
                net.neurons[j].x[2] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btGreen_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(0);
                net.neurons[j].x[1] = Neuron.InputTransform(255);
                net.neurons[j].x[2] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btLightBlue_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(66);
                net.neurons[j].x[1] = Neuron.InputTransform(170);
                net.neurons[j].x[2] = Neuron.InputTransform(255);
            }
            net.Work();
        }

        private void btBlue_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(0);
                net.neurons[j].x[1] = Neuron.InputTransform(0);
                net.neurons[j].x[2] = Neuron.InputTransform(255);
            }
            net.Work();
        }

        private void btViolette_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(139);
                net.neurons[j].x[1] = Neuron.InputTransform(0);
                net.neurons[j].x[2] = Neuron.InputTransform(255);
            }
            net.Work();
        }

        private void btWhite_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(255);
                net.neurons[j].x[1] = Neuron.InputTransform(255);
                net.neurons[j].x[2] = Neuron.InputTransform(255);
            }
            net.Work();
        }
    }
}
