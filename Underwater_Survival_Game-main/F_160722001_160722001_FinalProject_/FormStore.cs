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
    public partial class FormStore : Form
    {
        FormMenu formMenu = null;
        public FormStore()
        {
            InitializeComponent();
        }

        private void FormStore_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
            int score = formMenu.score;
            labelTotalCoin.Text = score.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBuy1_Click(object sender, EventArgs e)
        {
            if (formMenu.score < int.Parse(labelHargaIkan.Text))
            {
                MessageBox.Show("Sorry, your coin amount is not enough!");
            }
            else
            {
                MessageBox.Show("You already purchase this item");
            }
            
        }

        private void buttonBuy2_Click(object sender, EventArgs e)
        {
            if (formMenu.score < int.Parse(labelHargaCumi.Text))
            {
                MessageBox.Show("Sorry, your coin amount is not enough!");
            }
            else
            {
                MessageBox.Show("You already purchase this item");
            }
        }

        private void buttonBuy3_Click(object sender, EventArgs e)
        {
            if (formMenu.score < int.Parse(labelHargaHiu.Text))
            {
                MessageBox.Show("Sorry, your coin amount is not enough!");
            }
            else
            {
                MessageBox.Show("You already purchase this item");
            }
        }

        private void buttonBuy4_Click(object sender, EventArgs e)
        {
            if (formMenu.score < int.Parse(labelHargaGurun.Text))
            {
                MessageBox.Show("Sorry, your coin amount is not enough!");
            }
            else
            {
                MessageBox.Show("You already purchase this item");
            }
        }

        private void buttonBuy5_Click(object sender, EventArgs e)
        {
            if (formMenu.score < int.Parse(labelHargaSalju.Text))
            {
                MessageBox.Show("Sorry, your coin amount is not enough!");
            }
        }
    }
}
