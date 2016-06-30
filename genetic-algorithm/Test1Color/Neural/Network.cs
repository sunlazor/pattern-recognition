using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    class Network
    {
        // Нейроны
        List<Neuron> neurons;
        // Количество нейронов в сети
        private int NeuronCount { get; set; }
        // Количество входов нейронов
        private int InputCount { get; set; }

        public Network(int neuronCount, int neuronInputCount)
        {
            NeuronCount = neuronCount;
            InputCount = neuronInputCount;
            neurons = new List<Neuron>(NeuronCount);
            for (int i = 0; i < NeuronCount; ++i)
            {
                neurons.Add(new Neuron(InputCount));
            }
        }

        // Расчет для каждого нейрона
        void CalculateNeurons()
        {
            double Net = 0;// взвешенная сумма входных сигналов,
            for (int j = 0; j < neurons.Count; j++)
            {
                for (int i = 0; i < InputCount; ++i)
                {
                    // Функция взвешенной  суммы (сумматор)
                    Net += (neurons[j].x[i] - 0.5/*В случае бинарных входов нужно 0.5*/) * neurons[j].w[i];
                }
                Net += neurons[j].w0;
                neurons[j].sum = Net;
                neurons[j].y = Activation(Net);
            }
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
