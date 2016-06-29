using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic
{
    class Generation
    {
        public readonly byte GoalColor;

        private const int DEFAULT_SIZE = 10;

        private List<Specimen> generation;
        
        private int Size
        {
            get
            {
                return generation.Count;
            }
        }

        // Начальное поколение
        public Generation() : this(DEFAULT_SIZE)
        {
        }

        public Generation(int size, byte goal = 120) //byte.MaxValue) //!!!!!!!!
        {
            generation = new List<Specimen>(size);
            if (size <= 0 || size >= int.MaxValue)
            {
                size = DEFAULT_SIZE;
            }
            else if (size % 2 != 0)
            {
                size += 1;
            }
            for (int i = 0; i < size; i++)
            {
                generation.Add(new Specimen());
            }
            GoalColor = goal;
        }

        // Последующие поколения
        public Generation(Generation previous) : this(previous.Size, previous.GoalColor)
        {
            for (int i = 0; i < Size; i++)
            {
                generation[i].Color = previous.generation[i].Color;
                generation[i].CrossoverProbability = previous.generation[i].CrossoverProbability;
                generation[i].Fit = previous.generation[i].Fit;
            }
        }

        // Мутация
        public void Mutate()
        {
            for (int i = 0; i < Size; i++)
            {
                generation[i].Mutate();
            }
        }

        // Скрещивание особей
        public void Crossover()
        {
            for (int i = 0; i < Size; i += 2)
            {
                byte value1 = generation[i].Color;
                byte value2 = generation[i + 1].Color;

                int tmp1 = value1 & 240; // 11110000
                int tmp2 = value2 & 31; // 00001111
                int res = tmp1 | tmp2;
                generation[i].Color = Utils.StayInByte(res);

                tmp1 = value2 & 240; // 11110000
                tmp2 = value1 & 31; // 00001111
                res = tmp1 | tmp2;
                generation[i + 1].Color = Utils.StayInByte(res);
            }
        }

        public void CalculateFitness()
        {
            for (int i = 0; i < Size; i++)
            {
                generation[i].Fit = Math.Abs(GoalColor - generation[i].Color);
            }
        }

        // Возвращает минимальное значение приспособленности 
        public int MinFitness()
        {
            int minFit = int.MaxValue;
            for (int i = 0; i < Size; i++)
            {
                if (minFit > generation[i].Fit)
                {
                    minFit = generation[i].Fit;
                }
            }
            return minFit;
        }

        public void CalculateCrossoverProbability()
        {
            double value = 0;
            if (GoalColor > byte.MaxValue / 2)
            {
                value = GoalColor;
            }
            else
                value = byte.MaxValue - GoalColor;

            double probabilitySum = 0;

            for (int i = 0; i < Size; i++)
            {
                generation[i].CrossoverProbability = 1 - generation[i].Fit / value;
                probabilitySum += generation[i].CrossoverProbability;
            }
            for (int i = 0; i < Size; i++)
            {
                generation[i].CrossoverProbability /= probabilitySum;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Size; i++)
            {
                result += generation[i].ToString();
            }
            return result;
        }
    }
}
