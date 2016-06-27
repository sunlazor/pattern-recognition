using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic
{
    class Generation
    {
        List<Specimen> generation;

        // Начальное поколение
        public Generation()
        { }

        // Последующие поколения
        public Generation(Generation previous)
        { }

        void Crossover()
        { }

        public void CalculateFitness()
        { }

        public void CheckFitness()
        { }

        public void CalculateCrossoverProbability()
        { }

        public override string ToString()
        {
            return "Generation";
        }
    }
}
