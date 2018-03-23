using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amigos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            valores();
        }

        public void valores()
        {
            for (int i = 1; i < 2000; i++)
                for (int j = 1; j < 2000; j++)
                    if (sonAmigos(i, j))
                        txtResultados.Text += i + " y " + j + " son amigos" + Environment.NewLine;
        }

        public bool sonAmigos(int x,int y)
        {
            bool resultado = false;
            if (x != y && sumaDiv(x) == y && sumaDiv(y) == x)
                resultado = true;
            return resultado;
        }

        public int sumaDiv(int num)
        {
            int suma = 0;
            for (int i = 1; i < num; i++)
                if (num % i == 0)
                    suma += i;
            return suma;
        }
    }
}
