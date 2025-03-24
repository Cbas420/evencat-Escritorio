using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace evencat
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lado izquierdo: Centrar labelEvencat y pictureBoxLogoWhite en el espacio a la izquierda del panel
            int espacioIzquierda = panel1.Left;  // El espacio a la izquierda del panel (0 a 398)

            // Centrar labelEvencat y pictureBoxLogoWhite horizontalmente en el espacio disponible
            labelEvencat.Left = (espacioIzquierda - labelEvencat.Width) / 2;
            pictureBoxLogoWhite.Left = (espacioIzquierda - pictureBoxLogoWhite.Width) / 2;



        }
    }
}





