using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListProjetc
{
    public partial class GoToMainScreen : Form
    {
        public GoToMainScreen()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form MainScreen = new MainScreen();
            MainScreen.Show();
            this.Visible = false;
        }
    }
}
