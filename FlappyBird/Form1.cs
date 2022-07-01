using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gravidade = 5;
        int pipeSpeed = 10;
        int placar = 0;
        Random pos = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravidade;
            pipeTop.Left -= pipeSpeed;
            pipeDown.Left -= pipeSpeed;

            
                
            if (pipeTop.Left < -100)
            {
                pipeTop.Left = 710;
                
            }
            if (pipeDown.Left < -100)
            {
                pipeDown.Left = 710;
                placar++;
            }
            lblPlacar.Text = placar.ToString();
            if(flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                fimJogo();
            }
            if (flappyBird.Bounds.IntersectsWith(pipeDown.Bounds))
            {
                fimJogo();
            }
            if (flappyBird.Bounds.IntersectsWith(chao.Bounds))
            {
                fimJogo();
            }
            if (flappyBird.Bounds.IntersectsWith(ceu.Bounds))
            {
                fimJogo();
            }
        }

        private void fimJogo()
        {
            timer1.Stop();
            lblFim.Text = "Fim de jogo!";
            lblReiniciar.Text = "reiniciar?";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravidade = -10;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravidade = 5;

        }

        private void lblReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
            placar = 0;
            pipeSpeed = 5;
            pipeTop.Left = 710;
            pipeDown.Left = 710;
            lblFim.Text = " ";
            lblReiniciar.Text = "";
            flappyBird.Top = 250;
        

        }
    }
}
