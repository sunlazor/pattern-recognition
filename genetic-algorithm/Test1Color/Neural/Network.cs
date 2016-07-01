using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    class Network
    {
        // Нейроны
        public List<Neuron> neurons;
        // Количество нейронов в сети
        private int NeuronCount { get; set; }
        // Количество входов нейронов
        private int InputCount { get; set; }
        // Форма для вывода
        FormMain outForm;

        public Network(int neuronCount, int neuronInputCount, FormMain outputForm)
        {
            NeuronCount = neuronCount;
            InputCount = neuronInputCount;
            outForm = outputForm;
            neurons = new List<Neuron>(NeuronCount);
            for (int i = 0; i < NeuronCount; ++i)
            {
                neurons.Add(new Neuron(InputCount));
            }
        }

        // Расчет для каждого нейрона
        void CalculateNeuron(int neuronNumber)
        {
            double Net = 0;// взвешенная сумма входных сигналов,
            for (int i = 0; i < InputCount; ++i)
            {
                // Функция взвешенной  суммы (сумматор)
                Net += (neurons[neuronNumber].x[i] - 0.5) * neurons[neuronNumber].w[i];
            }
            Net += neurons[neuronNumber].w0;
            neurons[neuronNumber].sum = Net;
            neurons[neuronNumber].y = Activation(Net);
        }

        // Определние образа
        // Возвращает номер нейрона  с макс выходом
        public int Work()
        {
            double Max = 0;
            int Num = 0;
            for (int i = 0; i < NeuronCount; i++)
            {
                CalculateNeuron(i);
                //switch (i)
                //{
                //    case 0: form.output[i].Text = neurons[i].y.ToString(); break;
                //    case 1: Console.WriteLine(neurons[1].y); break;
                //    default: break;
                //}
                outForm.output[i].Text = neurons[i].y.ToString();
                if (neurons[i].y > Max)
                {
                    Max = neurons[i].y;
                    Num = i;
                }
            }
            return Num;
        }

        // Num - номер нейрона
        public int Teach(int Num)
        {
            // Расчет весов
            Work();
            for (int i = 0; i < NeuronCount; ++i)
            {
                double t = 0;
                if (Num == i)
                    t = 1;
                double deltaRes = neurons[i].y - t;
                double delta = ActivationDerevative(neurons[i].sum) * deltaRes;
                for (int j = 0; j < InputCount; j++)
                {
                    neurons[i].w[j] = neurons[i].w[j] - neurons[i].h * delta * neurons[i].x[j];
                }
                neurons[i].w0 = neurons[i].w0 - neurons[i].h * delta;
            }
            return 0;
        }

        public static double Activation(double x)
        {
            return 1d / (1 + Math.Pow(Math.E, -x)) - 0.5;
        }

        public static double ActivationDerevative(double x)
        {
            return Math.Pow(Math.E, -x) / Math.Pow((1 + Math.Pow(Math.E, -x)), 2);
        }
    }
}
