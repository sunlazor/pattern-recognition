using System;

namespace Neural
{
    class Neuron
    {
        int InputCount { get; set; }

        static Random random = new Random();

        public double[] x;   // Значение входа нейрона
        public double[] w; // Веса входов
        public double y; // Выходы
        public double sum; // Значащая сумма
        public double h;   // Коэффициент обучения
        public double w0;  // Дополнительный вес

        public Neuron(int inputCount)
        {
            InputCount = inputCount;
            x = new double[InputCount];
            w = new double[InputCount];
            for (int i = 0; i < InputCount; i++)
            {
                x[i] = 0;
                w[i] = random.NextDouble();// - 0.5d;
            }
            y = 0;
            sum = 0;
            h = 1;
            w0 = 1;
        }
    }
}
