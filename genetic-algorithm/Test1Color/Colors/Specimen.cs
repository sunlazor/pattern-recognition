using System;
using System.Drawing;

namespace Genetic
{
    class Specimen
    {
        private const double MUTATE_PROBABILITY = 0.1d;
        private const byte MUTATE_INTERVAL = 5;

        private byte color;
        private double crossoverProbability;
        private int fit;

        private static Random random = new Random();

        // Производит мутацию значения "цвета"
        // Пример: 100 и интервал_мутации = 5 -> 98-102
        public void Mutate()
        {
            int mutation = random.Next(MUTATE_INTERVAL) - (MUTATE_INTERVAL / 2);
            color = Utils.StayInByte(color + mutation);
        }

        override public string ToString()
        {
            return "Specimen";
        }

        //// Распечатать информацию о классе
        //public string ToString(int num)
        //{
        //    string text = "#" + num.ToString() + ": ";
        //    text += "R:" + color.R.ToString() + " ";
        //    text += "G:" + color.G.ToString() + " ";
        //    text += "B:" + color.B.ToString() + " ";
        //    text += "P:" + crossoverProbability.ToString().PadRight(5) + " ";
        //    text += "fit:" + fit.ToString() + "\n";
        //    return text;
        //}

        //public Specimen(int count)
        //{
        //    color = Color.FromArgb(random.Next(120, 135), random.Next(120, 135), random.Next(120, 135));
        //    crossoverProbability = 1d / (double)count;
        //    fit = 0;
        //}

        //// Функции для цвета
        //public void SetColor(Color color)
        //{
        //    this.color = color;
        //}
        //public Color GetColor()
        //{
        //    return color;
        //}
        //public int GetRed()
        //{
        //    return color.R;
        //}
        //public int GetGreen()
        //{
        //    return color.G;
        //}
        //public int GetBlue()
        //{
        //    return color.B;
        //}

        //// Функции вероятности скрещивания

        //// Возвращает true в случае удачного присваивания
        //public bool SetCP(double value)
        //{
        //        crossoverProbability = value;
        //        return true;
        //}

        //public double GetCP()
        //{
        //    return crossoverProbability;
        //}

        //// Коэффициент соответствия
        //public void SetFit(int fit)
        //{
        //    this.fit = fit;
        //}

        //public int GetFit()
        //{
        //    return fit;
        //}
    }
}
