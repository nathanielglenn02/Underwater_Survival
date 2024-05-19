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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }
    }
}
