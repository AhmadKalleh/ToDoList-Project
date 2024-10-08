using Guna.UI2.WinForms;
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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        HomeScreen screen = new HomeScreen();
        private void LoadScreen(object sender)
        {
            if (guna2GradientPanel1.Controls.Count > 0)
                guna2GradientPanel1.Controls.Clear();

            Form form = sender as Form;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();

            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScreen(screen);   
        }


        private void moveimage(object sender)
        {
            Guna2Button button = (Guna2Button)sender;
            pictureBox2.Location = new Point(button.Location.X + 136, button.Location.Y-33);
            pictureBox2.SendToBack();
        }
   
        
        private void HomeScreen_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            LoadScreen(screen);
        }

        private void StartATimerScreen_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            LoadScreen(new StartATimerScreen());
        }

        private void PercentageofAhievmentGoalsScreen_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            if (guna2GradientPanel1.Controls.Count > 0)
                guna2GradientPanel1.Controls.Clear();

            CalculatePrecentageScreen form = new CalculatePrecentageScreen(screen);
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
           
        }

        private void ManageCategoriesScreen_Click(object sender, EventArgs e)
        {
            moveimage(sender);
            if (guna2GradientPanel1.Controls.Count > 0)
                guna2GradientPanel1.Controls.Clear();

            ManageCategoriesScreen form = new ManageCategoriesScreen(screen);
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            guna2GradientPanel1.Controls.Add(form);
            form.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new GoToMainScreen();
            form.Show();
        }
    }
}
