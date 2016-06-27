using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
    class NeuronNetwork
    {
	    double ActiveSigm(float x);
        double ActiveSigmPro(float x);
        void ProcNeuro(Neuron& n);
        int Process();
        //int Teach(int Num);

        private int _neuroCount;
        Neuron m_Neuro = new Neuron(_neuroCount);

        public void Teach(int Num)
        {
            Process();
            for (int i = 0; i < _neuroCount; i++)
            {
                float t = 0;
                if (Num == i)// t=1
                    t = 1;
                float deltaRes = m_Neuro[i].y - t;// res - t
                float delta = ActiveSigmPro(m_Neuro[i].sum) * deltaRes;
                for (int j = 0; j < INCOUNT; j++)
                {
                    m_Neuro[i].w[j] = m_Neuro[i].w[j] - m_Neuro[i].h * delta * m_Neuro[i].x[j];
                }
                m_Neuro[i].w0 = m_Neuro[i].w0 - m_Neuro[i].h * delta;
            }
            return 0;
        }
    }
}
