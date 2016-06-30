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
        }

        Network net = new Network(2, 1);

        int techNum;

        private void btTeach_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = 0;
                    //net.neurons[i].x[1] = 0;
                }
                techNum = 0;
                net.Teach(techNum);

                for (int j = 0; j < net.neurons.Count; j++)
                {
                    net.neurons[j].x[0] = 255;
                    //net.neurons[i].x[1] = 1;
                }
                techNum = 1;
                net.Teach(techNum);
            }
        }

        private void btBlack_Click(object sender, EventArgs e)
        {
            net.neurons[0].x[0] = 0;
            net.neurons[1].x[0] = 0;
            net.Work();
        }
    }
}
