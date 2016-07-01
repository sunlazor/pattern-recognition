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
            net = new Network(3, 1, this);
        }

        Network net;

        public List<TextBox> output = new List<TextBox>();

        private void FillOutput()
        {
            output.Clear();
            output.Add(tbBlack);
            output.Add(tbGray);
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
                    //net.neurons[i].x[1] = 0;
                }
                techNum = 0;
                net.Teach(techNum);

                // Серый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(127);
                    //net.neurons[i].x[1] = 1;
                }
                techNum = 1;
                net.Teach(techNum);

                // Белый
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = Neuron.InputTransform(255);
                    //net.neurons[i].x[1] = 1;
                }
                techNum = 2;
                net.Teach(techNum);
            }
        }

        private void btBlack_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(0);
            }
            net.Work();
        }

        private void btGray_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(127);
            }
            net.Work();
        }

        private void btWhite_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < net.neurons.Count; j++)
            {
                net.neurons[j].x[0] = Neuron.InputTransform(255);
            }
            net.Work();
        }
    }
}
