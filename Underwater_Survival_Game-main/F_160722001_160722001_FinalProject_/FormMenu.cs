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
    public partial class FormMenu : Form
    {
        public List<int> listScore = new List<int>();
        public int score = 0;

        WindowsMediaPlayer formMenu;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.Owner = this;
            formGame.Show();     
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            FormStore formStore = new FormStore();
            formStore.Owner = this;
            formStore.Show();
        }

        public void FormMenu_Load(object sender, EventArgs e)
        {
            labelCoin.Text = "";
            formMenu = new WindowsMediaPlayer();
            formMenu.settings.setMode("Loop", true);
            formMenu.URL = "song\\backsound7.mp3";

            labelCoin.Text = "Coin " + score; 
        }
        private void buttonHighestScore_Click(object sender, EventArgs e)
        {
            FormHighestScore formHighestScore = new FormHighestScore();
            formHighestScore.Owner = this;
            formHighestScore.Show();
        }
    }
}
