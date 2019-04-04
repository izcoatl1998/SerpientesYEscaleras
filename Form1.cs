using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_Y_escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dado dice = new dado();
            Jugador J1 = new Jugador(1);
            Jugador J2 = new Jugador(2);
            do
            {
                J1.Avanzar(dice.tirar());
                J2.Avanzar(dice.tirar());
                textBox1.Text += J1.ToString() + "  y  "+J2.ToString()+ Environment.NewLine;
            } while (J1.Posicion < 100 && J2.Posicion < 100);
            if (J1.Posicion >= 100)
            {
                textBox1.Text += "El jugador 1 es el ganador";
            }
            else
            {
                textBox1.Text += "El jugador 2 es el ganador";
            }
        }
        
    }
}
