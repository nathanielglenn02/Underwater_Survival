using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F_160722001_160722001_FinalProject_
{
    public partial class FormHighestScore : Form
    {
        FormMenu formMenu = null;
        
        public FormHighestScore()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            labelHighestScore.Text = "";
            formMenu = (FormMenu)this.Owner;
            int max = formMenu.listScore[0];

            for (int i = 0; i < formMenu.listScore.Count; i++)
            {
                if (formMenu.listScore[i] > max)
                {
                    max = formMenu.listScore[i];
                }
            }

            labelHighestScore.Text = "Highest Score : " + max.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
