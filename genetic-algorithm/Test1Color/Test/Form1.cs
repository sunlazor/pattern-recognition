using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class testclass
        {
            int a;

            Bi ccc;

           

            public void gogog()
            {
                if (ccc == null)
                {
                    Console.WriteLine("ccc = null");
                }
            }
        }

        class Bi
        {
            int b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bi b;
            //if (b == null)
            //{
            //    Console.WriteLine("ccc = null");
            //}

            testclass a = new testclass();
            a.gogog();
        }
    }
}
