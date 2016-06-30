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
    }
}
