using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListProjetc.Properties;

namespace ToDoListProjetc
{
    public partial class CalculatePrecentageScreen : Form
    {
        HomeScreen homeScreen =new HomeScreen();
        Guna2Button button = new Guna2Button();
        TimeSpan time = new TimeSpan(24,0,0);
        
        int integerPrecentageForOneTask = 0;             
        int AllTask = 0;
        short peried = 1;

        private void loadCategories()
        {
            foreach(var category in homeScreen.dictionary.Keys)
            {
                cbCategories.Items.Add(category.Text.ToString());
            }
        }
        public CalculatePrecentageScreen(HomeScreen screen)
        {
            InitializeComponent();
            homeScreen = screen;
            loadCategories();
            lbTime.Text = DateTime.Now.ToString("MMMM yyyy",CultureInfo.InvariantCulture);
            cbCategories.SelectedIndex = -1;
            cbCategories.Text= string.Empty;
            cbTime.SelectedIndex = -1;
            cbTime.Text= string.Empty;
        }

        private void getTime()
        {
            switch(cbTime.SelectedIndex)
            {

                case 0:
                    peried = 1;
                    AllTask = CalaculatelAllTaskCompletedCountByPeried();
                    break;
             
                case 2:
                    time = time.Add(new TimeSpan(144,0,0));
                    peried = 7;
                    AllTask = CalaculatelAllTaskCompletedCountByPeried();
                    break;

                case 1:
                    time = time.Add(new TimeSpan(696, 0, 0));
                    peried = 30;
                    AllTask = CalaculatelAllTaskCompletedCountByPeried();
                    break;


            }
        }

        private  Guna2Button GetCategory()
        {
            foreach (var item in homeScreen.dictionary.Keys)
            {
                if (item.Text == cbCategories.Text)
                    return item;
            }
            return null;
        }

        private int CalaculatelAllTaskCompletedCountByPeried()
        {
            int counter = 0;
            for(int i= 0;i< homeScreen.dictionary[button].Rows.Count;i++)
            {
                DateTime startDate = Convert.ToDateTime(homeScreen.dictionary[button].Rows[i].Cells[2].Value);               ;
                DateTime endDate = Convert.ToDateTime(homeScreen.dictionary[button].Rows[i].Cells[3].Value);
                TimeSpan subtrctBetwennStartAndEnd = endDate.Subtract(startDate);

                if(subtrctBetwennStartAndEnd.TotalDays >= peried && subtrctBetwennStartAndEnd.TotalDays <= peried+1)

                {
                    counter++;
                }

            }

            return counter;
        }

        
        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            button = GetCategory();
            getTime();

            if (AllTask != 0)
            {
                integerPrecentageForOneTask = 100 / AllTask;               
                int MaxmiumLimt = 0;              
               

                for (int i = 0; i < homeScreen.dictionary[button].Rows.Count; i++)
                {
                    DateTime startDate = Convert.ToDateTime(homeScreen.dictionary[button].Rows[i].Cells[2].Value);                        ;
                    DateTime endDate = Convert.ToDateTime(homeScreen.dictionary[button].Rows[i].Cells[3].Value);                       
                    TimeSpan subtrctBetwennStartAndEnd = endDate.Subtract(startDate);

                    if (homeScreen.dictionary[button].Rows[i].Cells[4].Value.ToString().Trim().Equals("Completed")
                       && subtrctBetwennStartAndEnd.TotalDays >= peried)
                    {
                        
                        MaxmiumLimt += integerPrecentageForOneTask;
                        
                    }
                }

                if (MaxmiumLimt == 0)
                {
                    MessageBox.Show("you dont have any completed Task By this time  ", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    guna2CircleProgressBar1.Maximum = MaxmiumLimt;
                    timer1.Start();
                }
            }

            else
            {
                MessageBox.Show("You dont have any task in this Category","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                guna2CircleProgressBar1.Value++;
                lbPrecentage.Text = guna2CircleProgressBar1.Value.ToString() + " %";

                if (guna2CircleProgressBar1.Value == 10)
                    pictureBox1.Image = Resources.FullStar;
                else if(guna2CircleProgressBar1.Value ==30 )
                    pictureBox2.Image = Resources.FullStar;
                else if(guna2CircleProgressBar1.Value == 50)
                    pictureBox3.Image = Resources.FullStar;
                else if( guna2CircleProgressBar1.Value == 80 )
                    pictureBox4.Image = Resources.FullStar;
                else if(guna2CircleProgressBar1.Value ==100)
                    pictureBox5.Image = Resources.FullStar;


            if (guna2CircleProgressBar1.Value == guna2CircleProgressBar1.Maximum)
            {
                timer1.Stop();
                cbTime.Enabled = false;
                cbCategories.Enabled = false;
                lbProgress.Text = guna2CircleProgressBar1.Value.ToString()+" %";                
                MessageBox.Show("The precenatge is : " + lbProgress.Text, "Congrulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
