using F_160722001_160722001_FinalProject_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace F_160722001_160722001_FinalProject_
{
    public partial class FormGame : Form
    {
        WindowsMediaPlayer point;
        WindowsMediaPlayer hit;
        WindowsMediaPlayer jump;
        WindowsMediaPlayer formGame;

        FormMenu formMenu = null;
        
        public FormGame()
        {
            InitializeComponent();
        }
        private void GameOver()
        {
            timerGame.Stop();
        }
        
        List<int> listOfScore = new List<int>();

        int pipeSpeed = 9;
        int fall = 5;
        int score = 0;
        
        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jump.controls.play();
                fall = -5;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jump.controls.play();
                fall = 5;
            }
        }
        
        // step 3
        // pergerakan burung keatas
        public void timerGame_Tick_1(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            pictureBoxBird.Top += fall;
            pictureBoxPipeBottom.Left -= pipeSpeed;
            pictureBoxPipeTop.Left -= pipeSpeed;
            labelScore.Text = score.ToString();

            if (pictureBoxPipeBottom.Left < -1)
            {
                pictureBoxPipeBottom.Left = 600;
                point.controls.play();
                score++;
                

            }
            if (pictureBoxPipeTop.Left < -1)
            {
                pictureBoxPipeTop.Left = 750;
                point.controls.play();
                score++;
            }

            
            if (pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeBottom.Bounds) || pictureBoxBird.Bounds.IntersectsWith(pictureBoxPipeTop.Bounds) || pictureBoxBird.Bounds.IntersectsWith(pictureBoxGround.Bounds))
            {
                hit.controls.play();
                GameOver();
                labelScoreGameOver.Text = "SCORE : " + score.ToString();

                pictureBoxGameOver.Visible = true;
                labelScoreGameOver.Visible = true;
                buttonExit.Visible = true;
                buttonBackToMenu.Visible = true;

                formMenu.listScore.Add(score);
                formMenu.score += score;
            }
        }

        
        private void FormGame_Load(object sender, EventArgs e)
        {
            pictureBoxGameOver.Visible = false;
            labelScoreGameOver.Visible = false;
            buttonExit.Visible = false;
            buttonBackToMenu.Visible = false;

            point = new WindowsMediaPlayer();
            point.URL = "song\\point.mp3";

            hit = new WindowsMediaPlayer();
            hit.URL = "song\\hit.mp3";

            jump = new WindowsMediaPlayer();
            jump.URL = "song\\wing.mp3";

            formGame = new WindowsMediaPlayer();
            formGame.settings.setMode("loop", true);
            formGame.URL = "song\\backsound3.mp3";
            formGame.controls.play();

        }
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenu.FormMenu_Load(sender, null);
        }
    }
}
