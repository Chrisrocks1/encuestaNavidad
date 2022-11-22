using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formulario : Form
    {
        private List<cuestion> encuesta = new List<cuestion>();
        private int val1 = 0;
        private int val2 = 5;
        private int val3 = 10;
        private int val4 = 15;
        private int numPreg = 0;
        private int sumResp = 0;
        public Formulario()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //  BackColor = Color.FromArgb(89, 34, 255);            BackColor = Color.MediumBlue;

            llenaEncuesta();
        }

        private void llenaEncuesta()
        {
            encuesta.Add(new cuestion
            {
                concepto = "¿Que tanto te gusta la navidad?",
                resp1 = "¿Que es la navidad?",
                valor1 = val1,
                resp2 = "No la celebro seguido",
                valor2 = val2,
                resp3 = "Pues me gusta el ponche",
                valor3 = val3,
                resp4 = "Me encanta :D",
                valor4 = val4
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Tienes un arbol de navidad?",
                resp1 = "No tengo;",
                valor1 = val1,
                resp2 = "No acostumbro ponerlo",
                valor2 = val2,
                resp3 = "Si tengo",
                valor3 = val3,
                resp4 = "Si tengo dos",
                valor4 = val4
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Que tan seguido te lleva regalos\n Santa Claus?",
                resp1 = "Ya nunca!",
                valor1 = val1,
                resp2 = "Rara vez",
                valor2 = val2,
                resp3 = "Cuando me porto bien",
                valor3 = val3,
                resp4 = "Cada año!",
                valor4 = val4
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Que frutas lleva el ponche?",
                resp4 = "Caña, manzana, guayaba",
                valor4 = val4,
                resp2 = "Platano, Pera, Caña",
                valor2 = val2,
                resp3 = "Mandarina, kiwi, manzaña",
                valor3 = val3,
                resp1 = "Naranja, piña, guayaba",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Consideras la navidad el festejo\n mas importante?",
                resp4 = "Obvio, simplemente sublime",
                valor4 = val4,
                resp2 = "Es bonito, pero no el mejor",
                valor2 = val2,
                resp3 = "tal vez!",
                valor3 = val3,
                resp1 = "No!",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Que se celebra el 25 de diciembre?",
                resp2 = "El nacimiento de Jesucristo!",
                valor2 = val2,
                resp4 = "Navidad!",
                valor4 = val4,
                resp3 = "Fiesta de regalos!",
                valor3 = val3,
                resp1 = "Año Nuevo!",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Como se llaman los 3 Reyes Magos?",
                resp4 = "Melchor, Gaspar y Baltazar",
                valor4 = val4,
                resp2 = "Gaspar, Bartolome y Baltazar",
                valor2 = val2,
                resp3 = "Baltazar, Gasparin y Melchor",
                valor3 = val3,
                resp1 = "Melchor, Gaspar y Bartolome",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿En el festejo de Navidad\n rompen piñatas?",
                resp4 = "Si, dos o mas!",
                valor4 = val4,
                resp3 = "Si, una!",
                valor3 = val3,
                resp2 = "Algunas veces!",
                valor2 = val2,
                resp1 = "Nunca!",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Tu familia se reunen en Navidad!?",
                resp4 = "Si, todos los años!",
                valor4 = val4,
                resp3 = "No toda la familia",
                valor3 = val3,
                resp2 = "No muy seguido",
                valor2 = val2,
                resp1 = "Nunca!",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Del 1 al 10 que tanto te gustan\n las personas vestidas de Santa?",
                resp4 = "20/10 y Good",
                valor4 = val4,
                resp3 = "Me gusta como se ven ",
                valor3 = val3,
                resp2 = "Una foto si les tomo",
                valor2 = val2,
                resp1 = "Se ven raros",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Te consideras feliz en este festejo?",
                resp4 = "Demasiado, Diciembre es un mes muy chido",
                valor4 = val4,
                resp3 = "Si, estoy con mi familia",
                valor3 = val3,
                resp2 = "Al menos no estoy triste",
                valor2 = val2,
                resp1 = "No!",
                valor1 = val1
            });
            encuesta.Add(new cuestion
            {
                concepto = "¿Has visto peliculas de Navidad!?",
                resp1 = "No!",
                valor1 = val1,
                resp2 = "Prefiero las de hallowen!",
                valor2 = val2,
                resp3 = "Solo unas cuantas",
                valor3 = val3,
                resp4 = "Si, y me encanta el grinch",
                valor4 = val4
            });
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        
        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.White;
            numPreg = 0;
            sumResp = 0;
            lblResultado.Visible = false;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            realizaPregunta();
            pictureBoxFinal.Visible = false;
            lblNombre.Visible = false;
        }
        private void realizaPregunta()
        {
            cuestion pregunta = new cuestion();
            pregunta = encuesta[numPreg];
            lblPregunta.Text = pregunta.concepto;
            lblPregunta.Visible = true;
            radioButton1.Text = pregunta.resp1;
            radioButton1.Checked = false;
            radioButton1.Visible = true;
            radioButton2.Text = pregunta.resp2;
            radioButton2.Checked = false;
            radioButton2.Visible = true;
            radioButton3.Text = pregunta.resp3;
            radioButton3.Checked = false;
            radioButton3.Visible = true;
            radioButton4.Text = pregunta.resp4;
            radioButton4.Checked = false;
            radioButton4.Visible = true;
            btnContinuar.Visible = true;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            cuestion pregunta = new cuestion();
            pregunta = encuesta[numPreg];
            if (radioButton1.Checked == true) { sumResp += pregunta.valor1; }
            if (radioButton2.Checked == true) { sumResp += pregunta.valor2; }
            if (radioButton3.Checked == true) { sumResp += pregunta.valor3; }
            if (radioButton4.Checked == true) { sumResp += pregunta.valor4; }
            if (numPreg < encuesta.Count() - 1)
            {
                numPreg++;
                realizaPregunta();
            }
            else
            { presentaResultado(); }

        }

        private void presentaResultado()
        {
            lblPregunta.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            btnContinuar.Visible = false;
            lblNombre.Text = dato.valor;
            numPreg++;
            int lim1 = numPreg * val1;
            int lim3 = numPreg * val2;
            int lim5 = numPreg * val3;
            int lim7 = numPreg * val4;
            int lim2 = (lim3 - lim1) / 2 + lim1;
            int lim4 = (lim5 - lim3) / 2 + lim3;
            int lim6 = (lim7 - lim5) + lim5;

            if (sumResp <= lim2)
            { lblResultado.Text = "Todo indica que eres un Grinch!!"; pictureBoxFinal.Image = WindowsFormsApp1.Properties.Resources.grinchN; }
            if (sumResp >= lim2 && sumResp <= lim4)
            { lblResultado.Text = "Te falta espirutu Navideño!!"; pictureBoxFinal.Image = WindowsFormsApp1.Properties.Resources.calamardoNavidad; }
            if (sumResp >= lim4 && sumResp <= lim6)
            { lblResultado.Text = "Tienes buen espiritu navideño!!"; pictureBoxFinal.Image = WindowsFormsApp1.Properties.Resources.renos; }
            if (sumResp >= lim6)
            { lblResultado.Text = "Acaso eres Santa Claus..?"; pictureBoxFinal.Image = WindowsFormsApp1.Properties.Resources.santaClaus; }
            lblResultado.Visible = true;
            double avance = (double)sumResp / (double)lim7 * 100.0;
            progressBar1.Value = (int)avance;
            progressBar1.Visible = true;
            pictureBoxFinal.Visible = true;
            lblNombre.Visible = true;
        }

        private static string NewMethod()
        {
            return @"\Resources\grinchN.gif";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }
    }
}

