using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neural
{
    class Neuron
    {
        int InputCount { get; set; }

        static Random random = new Random();

        double[] x;   // Значение входа нейрона
        double[] w; // Веса входов
        double y; // Выходы
        double sum; // Значащая сумма
        double h;   // хз
        double w0;  // хз, дополнительный вес

        public Neuron(int inputCount)
        {
            InputCount = inputCount;
            x = new double[InputCount];
            w = new double[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                x[i] = 0;
                w[i] = random.NextDouble() - 0.5d;
            }
            y = 0;
            sum = 0;
            h = 1;
            w0 = 1;
        }
    }
}
