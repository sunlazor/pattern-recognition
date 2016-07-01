using System;
using System.Collections.Generic;
using System.Drawing;

namespace Genetic
{
    class Generation
    {
        public readonly Color GoalColor;
        private readonly static Color defaultColor = Color.FromKnownColor(KnownColor.Aqua);

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
        public Generation() : this(DEFAULT_SIZE, defaultColor)
        {
        }

        public Generation(int size, Color goalColor)
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
            GoalColor = goalColor;
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
                byte number1 = 170; // 10101010
                byte number2 = 85;  // 01010101

                // R
                byte value1 = generation[i].Color.R;
                byte value2 = generation[i + 1].Color.R;

                int tmp1 = value1 & number1;
                int tmp2 = value2 & number2;
                byte colorChannelR1 = Utils.StayInByte(tmp1 | tmp2);

                tmp1 = value2 & number1;
                tmp2 = value1 & number2;
                byte colorChannelR2 = Utils.StayInByte(tmp1 | tmp2);

                // G
                value1 = generation[i].Color.G;
                value2 = generation[i + 1].Color.G;

                tmp1 = value1 & number1;
                tmp2 = value2 & number2;
                byte colorChannelG1 = Utils.StayInByte(tmp1 | tmp2);

                tmp1 = value2 & number1;
                tmp2 = value1 & number2;
                byte colorChannelG2 = Utils.StayInByte(tmp1 | tmp2);

                // B
                value1 = generation[i].Color.B;
                value2 = generation[i + 1].Color.B;

                tmp1 = value1 & number1;
                tmp2 = value2 & number2;
                byte colorChannelB1 = Utils.StayInByte(tmp1 | tmp2);

                tmp1 = value2 & number1;
                tmp2 = value1 & number2;
                byte colorChannelB2 = Utils.StayInByte(tmp1 | tmp2);
                
                generation[i].Color = Color.FromArgb(colorChannelR1, colorChannelG1, colorChannelB1);
                generation[i + 1].Color = Color.FromArgb(colorChannelR2, colorChannelG2, colorChannelB2);
            }
        }

        public void CalculateFitness()
        {
            for (int i = 0; i < Size; i++)
            {
                generation[i].Fit = 
                    Math.Abs(GoalColor.R - generation[i].Color.R) +
                    Math.Abs(GoalColor.G - generation[i].Color.G) +
                    Math.Abs(GoalColor.B - generation[i].Color.B);
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

            double midValue =
                Convert.ToDouble(GoalColor.B + GoalColor.R + GoalColor.G) / 3;

            if (midValue > byte.MaxValue / 2)
                value = midValue;
            else
                value = byte.MaxValue - midValue;

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
