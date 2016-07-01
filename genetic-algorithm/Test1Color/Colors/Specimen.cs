using System;
using System.Drawing;

namespace Genetic
{
    class Specimen
    {
        private const double MUTATE_PROBABILITY = 0.1d;
        private const byte MUTATE_INTERVAL = 5;

        public Color Color { get; set; }
        public double CrossoverProbability { get; set; }
        public int Fit { get; set; }

        private static Random random = new Random();
        
        public Specimen()
        {
            //rewrite for multichannel
            byte colorChannel = Utils.StayInByte(random.Next(0, 10));
            Color = Color.FromArgb(colorChannel, colorChannel, colorChannel);
            CrossoverProbability = 0;
            Fit = 0;
        }

        // Производит мутацию значения "цвета"
        // Пример: 100 и интервал_мутации = 5 -> 98-102
        public void Mutate()
        {
            byte channelValue = Color.B;
            int mutation = random.Next(MUTATE_INTERVAL) - (MUTATE_INTERVAL / 2);
            byte colorChannel = Utils.StayInByte(channelValue + mutation);
            Color = Color.FromArgb(colorChannel, colorChannel, colorChannel);
        }

        // Распечатать информацию о классе
        override public string ToString()
        {
            string text = "color:" + Color.ToString() + " ";
            text += "P:" + CrossoverProbability.ToString() + " ";
            text += "fit:" + Fit.ToString() + "\n";
            return text;
        }
    }
}
