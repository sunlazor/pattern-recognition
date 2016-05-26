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
