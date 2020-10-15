using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2º_Evaluacion__Entorno_Grafico_
{
    public partial class Principal : Form
    {
        int CasoAveria = 0;
        int CasoNormal = 0;
        int CasoPreferente = 0;
        int CasoInteligente = 0;
        int x1, x2, x3, x4, y1, y2, y3, y4;

        /// <summary>
        /// Estado del Programa al Ejecutarlo
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            CenterToScreen();

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            x1 = pictureBox1.Location.X;
            y1 = pictureBox1.Location.Y;

            x2 = pictureBox2.Location.X;
            y2 = pictureBox2.Location.Y;

            x3 = pictureBox3.Location.X;
            y3 = pictureBox3.Location.Y;

            x4 = pictureBox4.Location.X;
            y4 = pictureBox4.Location.Y;
        }       
        #region Averia
        private void ButtonAveria_Click(object sender, EventArgs e)
        {
            /* Temporizadores */
            TimerAveria.Enabled = true;
            TimerNormal.Enabled = false; 
            TimerPreferente.Enabled = false;
            TimerInteligente.Enabled = false;
            /* Botones Principales */
            ButtonAveria.Enabled = false;
            ButtonNormal.Enabled = true;
            ButtonPreferente.Enabled = true;
            ButtonInteligente.Enabled = true;
            /* Botones del modo Preferente */
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;           
            /* Temporizadores de los coches */
            TimerNormalCoches.Enabled = false;
            TimerPreferenteCoches.Enabled = false;
            TimerInteligenteCoches.Enabled = false;
        }
        private void TimerAveria_Tick(object sender, EventArgs e)
        {
            /*********************************** COCHE 1 ***************************************/
            if (Amarillo1.Visible == true && Amarillo2.Visible == true && Amarillo3.Visible == true && Amarillo4.Visible == true)
            { pictureBox1.Location = new Point(x1, y1 += 50); }
            if (y1 > 600) { pictureBox1.Location = new Point(x1 = 313, y1 = -50); }

            /*********************************** COCHE 2 ***************************************/
            if (Amarillo1.Visible == true && Amarillo2.Visible == true && Amarillo3.Visible == true && Amarillo4.Visible == true)
                pictureBox2.Location = new Point(x2 -= 75, y2);
            if (x2 < -120) { pictureBox2.Location = new Point(x2 = +800, y2 = 209); }

            /*********************************** COCHE 3 ***************************************/
            if (Amarillo1.Visible == true && Amarillo2.Visible == true && Amarillo3.Visible == true && Amarillo4.Visible == true)
                pictureBox3.Location = new Point(x3 += 75, y3);
            if (x3 > 850) { pictureBox3.Location = new Point(x3 = -50, y3 = 297); }

            /*********************************** COCHE 4 ***************************************/
            if (Amarillo1.Visible == true && Amarillo2.Visible == true && Amarillo3.Visible == true && Amarillo4.Visible == true)
            { pictureBox4.Location = new Point(x4, y4 -= 50); }
            if (y4 < -117) { pictureBox4.Location = new Point(x4 = 456, y4 = 500); }

            switch (CasoAveria)
            {
                case 0:
                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Rojo1.Visible = false;
                    Rojo2.Visible = false;
                    Rojo3.Visible = false;
                    Rojo4.Visible = false;

                    TimerAveria.Interval = 1000;
                    CasoAveria = 1;
                    break;

                case 1:
                    Amarillo1.Visible = true;
                    Amarillo2.Visible = true;
                    Amarillo3.Visible = true;
                    Amarillo4.Visible = true;

                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Rojo1.Visible = false;
                    Rojo2.Visible = false;
                    Rojo3.Visible = false;
                    Rojo4.Visible = false;

                    TimerAveria.Interval = 1000;
                    CasoAveria = 0;
                    break;
            }
        }
        #endregion
        #region Normal
        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            /* Temporizadores */
            TimerAveria.Enabled = false;
            TimerNormal.Enabled = true;
            TimerPreferente.Enabled = false;
            TimerInteligente.Enabled = false;
            /* Botones Principales */
            ButtonAveria.Enabled = true;
            ButtonNormal.Enabled = false;
            ButtonPreferente.Enabled = true;
            ButtonInteligente.Enabled = true;
            /* Botones del modo Preferente */
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            /* Resetea la Posicion de los Coches */
            pictureBox1.Location = new Point(313, 14);
            pictureBox2.Location = new Point(705, 209);
            pictureBox3.Location = new Point(21, 297);
            pictureBox4.Location = new Point(456, 433);
            /*********************************************/
            TimerCoches.Enabled = false;
            /* Temporizadores de los coches */
            TimerNormalCoches.Enabled = true;
            TimerPreferenteCoches.Enabled = false;
            TimerInteligenteCoches.Enabled = false;
        }
        private void TimerNormal_Tick(object sender, EventArgs e)
        {
            switch (CasoNormal)
            {
                case 0:
                    Verde1.Visible = false;
                    Verde2.Visible = true;
                    Verde3.Visible = true;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = false;
                    Rojo3.Visible = false;
                    Rojo4.Visible = true;

                    TimerNormal.Interval = 20000;
                    CasoNormal = 1;
                    break;

                case 1:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = true;
                    Amarillo3.Visible = true;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = false;
                    Rojo3.Visible = false;
                    Rojo4.Visible = true;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 2;
                    break;

                case 2:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = true;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 3;
                    break;

                case 3:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = true;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 4;
                    break;

                case 4:
                    Verde1.Visible = true;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = true;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = false;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = false;

                    TimerNormal.Interval = 20000;
                    CasoNormal = 5;
                    break;

                case 5:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = true;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = true;

                    Rojo1.Visible = false;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = false;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 6;
                    break;

                case 6:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = true;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 7;
                    break;

                case 7:
                    Verde1.Visible = false;
                    Verde2.Visible = false;
                    Verde3.Visible = false;
                    Verde4.Visible = false;

                    Amarillo1.Visible = false;
                    Amarillo2.Visible = false;
                    Amarillo3.Visible = false;
                    Amarillo4.Visible = false;

                    Rojo1.Visible = true;
                    Rojo2.Visible = true;
                    Rojo3.Visible = true;
                    Rojo4.Visible = true;
                    TimerNormal.Interval = 5000;
                    CasoNormal = 0;
                    break;
            }
        }
        private void TimerNormalCoches_Tick(object sender, EventArgs e)
        {
            TimerNormalCoches.Interval = 1000;

            if ((Verde2.Visible == true && Verde3.Visible == true) || (Amarillo2.Visible == true && Amarillo3.Visible == true))
            {
                pictureBox2.Location = new Point(x2 -= 75, y2);
                pictureBox3.Location = new Point(x3 += 75, y3);
            }
            if ((Verde1.Visible == true && Verde4.Visible == true) || (Amarillo1.Visible == true && Amarillo4.Visible == true))
            {
                pictureBox1.Location = new Point(x1, y1 += 50);
                pictureBox4.Location = new Point(x4, y4 -= 50);
            }

            if (y1 > 600) { pictureBox1.Location = new Point(x1 = 313, y1 = -50); }
            if (x2 < -120) { pictureBox2.Location = new Point(x2 = +800, y2 = 209); }
            if (x3 > 850) { pictureBox3.Location = new Point(x3 = -50, y3 = 297); }
            if (y4 < -117) { pictureBox4.Location = new Point(x4 = 456, y4 = 500); }
        }
        #endregion
        #region Preferente
        private void ButtonPreferente_Click(object sender, EventArgs e)
        {
            /* Temporizadores */
            TimerAveria.Enabled = false;
            TimerNormal.Enabled = false;
            TimerInteligente.Enabled = false;
            /* Botones Principales */
            ButtonAveria.Enabled = false;
            ButtonNormal.Enabled = false;
            ButtonInteligente.Enabled = false;            
            /* Botones del modo Preferente */
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            
            if (radioButton1.Checked) // Si esta pulsado hace: 
            {
                TimerPreferente.Enabled = true;
                /* Botones Principales */
                ButtonAveria.Enabled = true;
                ButtonNormal.Enabled = true;
                ButtonPreferente.Enabled = false;
                ButtonInteligente.Enabled = true;
                /* Temporizadores de los coches */
                TimerNormalCoches.Enabled = false;
                TimerPreferenteCoches.Enabled = true;
                TimerInteligenteCoches.Enabled = false;
            }
            else                
                if (radioButton2.Checked) // Si esta pulsado hace: 
            {
                TimerPreferente.Enabled = true;
                /* Botones Principales */
                ButtonAveria.Enabled = true;
                ButtonNormal.Enabled = true;
                ButtonPreferente.Enabled = false;
                ButtonInteligente.Enabled = true;
                /* Temporizadores de los coches */
                TimerNormalCoches.Enabled = false;
                TimerPreferenteCoches.Enabled = true;
                TimerInteligenteCoches.Enabled = false;
            }
            /* Temporizador */
            TimerCoches.Enabled = false;
            /* Resetea la Posicion de los Coches */
            pictureBox1.Location = new Point(313, 14);
            pictureBox2.Location = new Point(705, 209);
            pictureBox3.Location = new Point(21, 297);
            pictureBox4.Location = new Point(456, 433);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAveria.Enabled = false;
            ButtonNormal.Enabled = false;
            ButtonPreferente.Enabled = true;
            ButtonInteligente.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ButtonAveria.Enabled = false;
            ButtonNormal.Enabled = false;
            ButtonPreferente.Enabled = true;
            ButtonInteligente.Enabled = false;
        }
        private void TimerPreferente_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                switch (CasoPreferente)
                {
                    case 0:
                        Verde1.Visible = true;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = true;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerPreferente.Interval = 40000;
                        CasoPreferente = 1;
                        break;

                    case 1:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = true;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = true;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 2;
                        break;

                    case 2:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 3;
                        break;

                    case 3:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 4;
                        break;

                    case 4:
                        Verde1.Visible = false;
                        Verde2.Visible = true;
                        Verde3.Visible = true;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 20000;
                        CasoPreferente = 5;
                        break;

                    case 5:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = true;
                        Amarillo3.Visible = true;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 6;
                        break;

                    case 6:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 7;
                        break;

                    case 7:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 0;
                        break;
                }
            }
            else
                if (radioButton2.Checked)
            {
                switch (CasoPreferente)
                {
                    case 0:
                        Verde1.Visible = false;
                        Verde2.Visible = true;
                        Verde3.Visible = true;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 40000;
                        CasoPreferente = 1;
                        break;

                    case 1:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = true;
                        Amarillo3.Visible = true;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 2;
                        break;

                    case 2:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 3;
                        break;

                    case 3:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 4;
                        break;

                    case 4:
                        Verde1.Visible = true;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = true;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerPreferente.Interval = 20000;
                        CasoPreferente = 5;
                        break;

                    case 5:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = true;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = true;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 6;
                        break;

                    case 6:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 7;
                        break;

                    case 7:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerPreferente.Interval = 5000;
                        CasoPreferente = 0;
                        break;
                }
            }
        }
        private void TimerPreferenteCoches_Tick(object sender, EventArgs e)
        {
            TimerNormalCoches.Interval = 1000;

            if ((Verde2.Visible == true && Verde3.Visible == true) || (Amarillo2.Visible == true && Amarillo3.Visible == true))
            {
                pictureBox2.Location = new Point(x2 -= 40, y2);
                pictureBox3.Location = new Point(x3 += 40, y3);
            }
            if ((Verde1.Visible == true && Verde4.Visible == true) || (Amarillo1.Visible == true && Amarillo4.Visible == true))
            {
                pictureBox1.Location = new Point(x1, y1 += 20);
                pictureBox4.Location = new Point(x4, y4 -= 20);
            }
            if (y1 > 600) { pictureBox1.Location = new Point(x1 = 313, y1 = -50); }
            if (x2 < -120) { pictureBox2.Location = new Point(x2 = +800, y2 = 209); }
            if (x3 > 850) { pictureBox3.Location = new Point(x3 = -50, y3 = 297); }
            if (y4 < -117) { pictureBox4.Location = new Point(x4 = 456, y4 = 500); }
        }
        #endregion
        #region Inteligente
        private void ButtonInteligente_Click(object sender, EventArgs e)
        {
            /* Temporizadores */
            TimerAveria.Enabled = false;
            TimerNormal.Enabled = false;
            TimerPreferente.Enabled = false;
            TimerInteligente.Enabled = true;
            /* Temporizador */
            TimerCoches.Enabled = true;
            /* Botones Principales */
            ButtonAveria.Enabled = true;
            ButtonNormal.Enabled = true;
            ButtonPreferente.Enabled = true;
            ButtonInteligente.Enabled = false;
            /* Botones del modo Preferente */
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            /* Temporizadores de los coches */
            TimerNormalCoches.Enabled = false;
            TimerPreferenteCoches.Enabled = false;
            TimerInteligenteCoches.Enabled = true;
            /* Resetea la Posicion de los Coches */
            pictureBox1.Location = new Point(313, 14);
            pictureBox2.Location = new Point(705, 209);
            pictureBox3.Location = new Point(21, 297);
            pictureBox4.Location = new Point(456, 433);
        }
        private void TimerInteligente_Tick(object sender, EventArgs e)
        {
            if (((numericUpDown2.Value) == 0) && ((numericUpDown3.Value) == 0))
            {
                switch(CasoInteligente)
                {                   
                    case 0:
                        Verde1.Visible = true;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = true;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerInteligente.Interval++;
                        CasoInteligente = 0;
                        break;
                }
            }
            else
                if(((numericUpDown1.Value) == 0) && ((numericUpDown4.Value) == 0))
                {
                switch (CasoInteligente)
                {
                    case 0:
                        Verde1.Visible = false;
                        Verde2.Visible = true;
                        Verde3.Visible = true;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval++;
                        CasoInteligente = 0;
                        break;
                        }
                  }
            if ((numericUpDown1.Value + numericUpDown4.Value) > (numericUpDown2.Value + numericUpDown3.Value))
            {
                switch (CasoInteligente)
                {
                    case 0:
                        Verde1.Visible = true;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = true;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerInteligente.Interval = 40000;
                        CasoInteligente = 1;
                        break;

                    case 1:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = true;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = true;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 2;
                        break;

                    case 2:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000; 
                        CasoInteligente = 3;
                        break;

                    case 3:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 4;
                        break;

                    case 4:
                        Verde1.Visible = false;
                        Verde2.Visible = true;
                        Verde3.Visible = true;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 20000;
                        CasoInteligente = 5;
                        break;

                    case 5:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = true;
                        Amarillo3.Visible = true;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 6;
                        break;

                    case 6:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 7;
                        break;

                    case 7:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 0;
                        break;
                }
            }
            else
                if ((numericUpDown1.Value + numericUpDown4.Value) < (numericUpDown2.Value + numericUpDown3.Value))
            {
                switch (CasoInteligente)
                {
                    case 0:
                        Verde1.Visible = false;
                        Verde2.Visible = true;
                        Verde3.Visible = true;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 40000;
                        CasoInteligente = 1;
                        break;

                    case 1:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = true;
                        Amarillo3.Visible = true;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = false;
                        Rojo3.Visible = false;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 2;
                        break;

                    case 2:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 3;
                        break;

                    case 3:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 4;
                        break;

                    case 4:
                        Verde1.Visible = true;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = true;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerInteligente.Interval = 20000;
                        CasoInteligente = 5;
                        break;

                    case 5:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = true;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = true;

                        Rojo1.Visible = false;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = false;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 6;
                        break;

                    case 6:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 7;
                        break;

                    case 7:
                        Verde1.Visible = false;
                        Verde2.Visible = false;
                        Verde3.Visible = false;
                        Verde4.Visible = false;

                        Amarillo1.Visible = false;
                        Amarillo2.Visible = false;
                        Amarillo3.Visible = false;
                        Amarillo4.Visible = false;

                        Rojo1.Visible = true;
                        Rojo2.Visible = true;
                        Rojo3.Visible = true;
                        Rojo4.Visible = true;

                        TimerInteligente.Interval = 5000;
                        CasoInteligente = 0;
                        break;
                }
            }
        }
        private void TimerInteligenteCoches_Tick(object sender, EventArgs e)
        {
            TimerNormalCoches.Interval = 1000;

            if ((Verde2.Visible == true && Verde3.Visible == true) || (Amarillo2.Visible == true && Amarillo3.Visible == true))
            {
                pictureBox2.Location = new Point(x2 -= 40, y2);
                pictureBox3.Location = new Point(x3 += 40, y3);
            }
            if ((Verde1.Visible == true && Verde4.Visible == true) || (Amarillo1.Visible == true && Amarillo4.Visible == true))
            {
                pictureBox1.Location = new Point(x1, y1 += 20);
                pictureBox4.Location = new Point(x4, y4 -= 20);
            }
            if (y1 > 600) { pictureBox1.Location = new Point(x1 = 313, y1 = -50); }
            if (x2 < -120) { pictureBox2.Location = new Point(x2 = +800, y2 = 209); }
            if (x3 > 850) { pictureBox3.Location = new Point(x3 = -50, y3 = 297); }
            if (y4 < -117) { pictureBox4.Location = new Point(x4 = 456, y4 = 500); }
        }
        #endregion
        private void TimerCoches_Tick(object sender, EventArgs e)
        {
            TimerCoches.Interval = 2000;

            NumericUpDown v1 = numericUpDown1;
            NumericUpDown v2 = numericUpDown2;
            NumericUpDown v3 = numericUpDown3;
            NumericUpDown v4 = numericUpDown4; 
            
            if (((Verde1.Visible == true) || (Amarillo1.Visible == true)) && (v1.Value > 0))
            {
                v1.Value--;                
            }
            if (((Verde2.Visible == true) || (Amarillo2.Visible == true)) && (v2.Value > 0))
            {
                v2.Value--;
            }
            if (((Verde3.Visible == true) || (Amarillo3.Visible == true)) && (v3.Value > 0))
            {
                v3.Value--;
            }
            if (((Verde4.Visible == true) || (Amarillo4.Visible == true)) && (v4.Value > 0))
            {
                v4.Value--;
            }
        }
    }
}
