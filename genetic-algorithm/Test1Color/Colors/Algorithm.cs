using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic
{
    class Algorithm
    {
        private const int GENERATION_COUNT = 3000;
        private const int GENERATION_SIZE = 10;

        private int currentGenerationNumber = 0;

        Generation currentGeneration;
        FormMain form;

        public Algorithm(FormMain logForm)
        {
            form = logForm;
        }

        private string PrintCurrentGeneration()
        {
            string result = "";
            result += "Current generation: #" + currentGenerationNumber.ToString() +"\n";
            result += currentGeneration.ToString();
            return result;
        }

        // Главная функция работы алгоритма
        public int Work()
        {
            for (currentGenerationNumber = 0; currentGenerationNumber < GENERATION_COUNT; currentGenerationNumber++)
            {
                if (currentGeneration == null)
                    currentGeneration = new Generation(GENERATION_SIZE);
                else
                    currentGeneration = new Generation(currentGeneration);
                currentGeneration.CalculateFitness();
                form.WriteLog(PrintCurrentGeneration());
                if (currentGeneration.MinFitness() == 0)
                    return currentGenerationNumber;
                currentGeneration.Crossover();
                currentGeneration.Mutate();
                currentGeneration.CalculateCrossoverProbability();
            }
            return 0;
        }
    }
}
