using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
    class Neuron
    {
        double[] x;           // входные сигналы
        double[] w;           // весовые коэффициенты
        double w0;          // доп вес
        double sum;         // сумма
        double y;           // выход аксон
        double h;
        public Neuron(int neuronCount)
        {
            x = new double[neuronCount];
            w = new double[neuronCount];
        }
    }
}
