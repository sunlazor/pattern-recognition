using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colors
{
    class Specimen
    {
        private Color color;
        private double crossoverProbability;
        private int fit;

        // Распечатать информацию о классе
        public string ToString(int num)
        {
            string text = "#" + num.ToString() + ": ";
            text += "R:" + color.R.ToString() + " ";
            text += "G:" + color.R.ToString() + " ";
            text += "B:" + color.R.ToString() + " ";
            text += "P():" + crossoverProbability.ToString().Substring(0, 7) + " ";
            text += "fit:" + fit.ToString();
            return text;
        }

        public Specimen(int count)
        {
            Random rnd = new Random();
            color = Color.FromArgb(rnd.Next(10) + 118, rnd.Next(10) + 118, rnd.Next(10) + 118);
            crossoverProbability = 1d / (double)count;
            fit = 0;
        }

        // Функции для цвета
        public void setColor(Color color)
        {
            this.color = color;
        }
        public int getRed()
        {
            return color.R;
        }
        public int getGreen()
        {
            return color.G;
        }
        public int getBlue()
        {
            return color.B;
        }

        // Функции вероятности скрещивания

        // Возвращает true в случае удачного присваивания
        public bool setCP(double value)
        {
            if ((value <= 1d) && (value >= 0d))
            {
                crossoverProbability = value;
                return true;
            }
            else
                return false;
        }

        public double getCP()
        {
            return crossoverProbability;
        }

        // Коэффициент соответствия
        public int Fit
        {
            get; set;
        }
    }
}
