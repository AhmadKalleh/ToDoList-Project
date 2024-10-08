using Guna.UI2.HtmlRenderer.Core;
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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        int buttonWidth = 130;
        int buttonHeight = 30;
        int buttonSpacing = 1;
        int nextButton = 274;
        int TaskCounter = 0;
        string TextBeforeEditing = string.Empty;


        public Dictionary<Guna2Button,DataGridView> dictionary = new Dictionary<Guna2Button, DataGridView> ();
        Guna2Button currentButton = new Guna2Button ();

        private void ShowTabButtons()
        {
            
             for (int i = 2; i < this.guna2GradientPanel1.Controls.Count; i++)
             {
                 this.guna2GradientPanel1.Controls[i].Visible = true;
             }
            
        }

        private void ConstructDGVPersonal()
        {
            DataGridView DGVPersonal = new DataGridView();           
            ConstructDataGridView(DGVPersonal);           
            dictionary.Add(btnPersonal, DGVPersonal);
        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            btnAddTask.Visible = false;
            btnDeleteTask.Visible = false;
            cbFilter.SelectedIndex = -1;
            cbFilter.Text = string.Empty;
            currentButton = btnAll;
          


            ConstructDGVPersonal();
            if (dictionary.Count > 1)
            ShowTabButtons();

            lbTaskCount.Text = DGVAllTask.Rows.Count.ToString() + " All Tasks";

        }

        public void ConstructDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns[0].FillWeight = 200;
            dataGridView.Columns.Add("Category", "Category");
            dataGridView.Columns[1].FillWeight = 150;
            dataGridView.Columns.Add("Start Date", "Start Date");
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.Columns[2].FillWeight = 100;
            dataGridView.Columns.Add("End Date", "End Date");
            dataGridView.Columns[3].FillWeight = 100;
            dataGridView.Columns.Add("Status", "Status");
            dataGridView.Columns[4].FillWeight = 100;
            dataGridView.Columns[2].ValueType = typeof(DateTime);
            dataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView.Columns[3].ValueType = typeof(DateTime);
            dataGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView.Columns[4].DefaultCellStyle.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridView.ColumnHeadersDefaultCellStyle = DGVAllTask.ColumnHeadersDefaultCellStyle;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.DefaultCellStyle = DGVAllTask.DefaultCellStyle;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 40;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.ScrollBars = ScrollBars.Vertical;
            dataGridView.Size = DGVAllTask.Size;
            dataGridView.CellEndEdit += DGVClick_CellEndEdit;
            dataGridView.CellMouseClick += DGVTask_CellMouseClick;
            dataGridView.AlternatingRowsDefaultCellStyle = DGVAllTask.AlternatingRowsDefaultCellStyle;



        }
        public Guna2Button createTabButton(string Text)
        {
            Guna2Button guna2Button = new Guna2Button();
            guna2Button.Size = new Size(buttonWidth, buttonHeight);
            guna2Button.Location = new Point(nextButton, 7);
            guna2Button.Text = Text;
            guna2Button.ForeColor = Color.Black;
            guna2Button.FillColor = Color.White;
            guna2Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;


            guna2Button.CustomBorderThickness = new Padding(0, 0, 0, 2);
            guna2Button.CheckedState.CustomBorderColor = Color.FromArgb(98, 62, 208);
            guna2Button.HoverState.FillColor = Color.White;
            guna2Button.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            guna2Button.Click += Button_Click;
            guna2Button.Cursor = Cursors.Hand;
          

            guna2GradientPanel1.Controls.Add(guna2Button);

            nextButton += buttonWidth + buttonSpacing;

            return  guna2Button;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            btnAddTask.Visible = true;
            btnDeleteTask.Visible = true;
            cbFilter.SelectedIndex = -1;
            cbFilter.Text = string.Empty;

            if (this.Continar.Controls.Count > 0)
                this.Continar.Controls.Clear();


            currentButton = (Guna2Button)sender;
            lbTaskCount.Text = dictionary[currentButton].Rows.Count.ToString() + " " + currentButton.Text.ToString() + " Task";
            dictionary[currentButton].Dock = DockStyle.Fill;
            this.Continar.Controls.Add(dictionary[currentButton]);

            for (int i = 0; i < dictionary[currentButton].Rows.Count; i++)
            {
                dictionary[currentButton].Rows[i].Visible = true;
            }

        }

        private void ShowAllTasks_Click(object sender, EventArgs e)
        {
            btnAddTask.Visible = false;
            btnDeleteTask.Visible = false;
            cbFilter.SelectedIndex = -1;
            cbFilter.Text = string.Empty;


            if (this.Continar.Controls.Count > 0)
                this.Continar.Controls.Clear();

            currentButton = (Guna2Button)sender;
            lbTaskCount.Text = DGVAllTask.Rows.Count.ToString() + " All Tasks";
            DGVAllTask.Dock = DockStyle.Fill;
            this.Continar.Controls.Add(DGVAllTask);

            for(int i=0;i< DGVAllTask.Rows.Count;i++)
            {
                DGVAllTask.Rows[i].Visible = true;
            }
           
        }

        

        private int GetSelectedRowIndex(int rowindex)
        {
            int counter = 0;

            foreach(var tab in dictionary)
            {
                if(tab.Key.Text != currentButton.Text)
                {
                    for(int i=0;i<tab.Value.Rows.Count;i++)
                    {
                        counter++;
                    }
                }
                else
                {
                    for(int i=0;i<tab.Value.Rows.Count;i++)
                    {
                        counter++;
                        if (i == rowindex )
                            return --counter;

                    }
                }
            }

            return --counter;
        }

        private bool isRight(DateTime startDate,DateTime endDate,bool endBeforStart = true)
        {
            if(endBeforStart && endDate < startDate)
            {
                return false;
            }
            else if(startDate > endDate)
            {
                return false;
            }

            return true;
        }
        private void DGVClick_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            

            if (currentButton.Text != "All")
            {
                int rowIndex = GetSelectedRowIndex(e.RowIndex);
                if (e.ColumnIndex == 4 && dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "Pending")
                {
                    dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Green;
                    DGVAllTask.Rows[rowIndex].Cells[4].Value = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    DGVAllTask.Rows[rowIndex].Cells[4].Style.ForeColor = Color.Green;
                }
                else if (e.ColumnIndex == 4)
                {
                    dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.FromArgb(192, 0, 0);

                    DGVAllTask.Rows[rowIndex].Cells[4].Value = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    DGVAllTask.Rows[rowIndex].Cells[4].Style.ForeColor = Color.FromArgb(192, 0, 0);

                }
                else if(e.ColumnIndex == 0)
                {
                    DGVAllTask.Rows[rowIndex].Cells[0].Value = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                }
                else if(e.ColumnIndex==2) 
                {
                    if (isRight(Convert.ToDateTime(dictionary[currentButton].Rows[e.RowIndex].Cells[2].Value),
                        Convert.ToDateTime(dictionary[currentButton].Rows[e.RowIndex].Cells[3].Value),false))

                    { 
                        DGVAllTask.Rows[rowIndex].Cells[2].Value = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        DGVAllTask.Sort(DGVAllTask.Columns[2], ListSortDirection.Descending);
                        dictionary[currentButton].Sort(dictionary[currentButton].Columns[2], ListSortDirection.Descending);
                    }
                    else
                    {
                        dictionary[currentButton].Rows[e.RowIndex].Cells[2].Value = Convert.ToDateTime(TextBeforeEditing);
                        MessageBox.Show("The End Date may not be earlier than The Start Date ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if(e.ColumnIndex == 3)
                {
                    if (isRight(Convert.ToDateTime(dictionary[currentButton].Rows[e.RowIndex].Cells[2].Value),
                        Convert.ToDateTime(dictionary[currentButton].Rows[e.RowIndex].Cells[3].Value)))

                    {
                        DGVAllTask.Rows[rowIndex].Cells[3].Value = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    }
                    else
                    {
                        dictionary[currentButton].Rows[e.RowIndex].Cells[3].Value = Convert.ToDateTime(TextBeforeEditing);
                        MessageBox.Show("The Start Date may not be later than The End Date ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                       
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
           
            if (currentButton.Text != "All")
            {
                int rowIndex = dictionary[currentButton].Rows.Add(currentButton.Text.ToString()+" Task ", currentButton.Text.ToString(), DateTime.Now, DateTime.Now.AddDays(1), "Pending");
                DGVAllTask.Rows.Add(currentButton.Text.ToString() + " Task ", currentButton.Text.ToString(), DateTime.Now, DateTime.Now.AddDays(1), "Pending");
                lbTaskCount.Text = dictionary[currentButton].Rows.Count.ToString() + " " + currentButton.Text.ToString() + " Task";
            }

            
        }

        private void DeleteSelectedTask_Click(object sender, EventArgs e)
        {
            if (currentButton.Text != "All")
            {

                if (MessageBox.Show("Are You Sure To delete this Row ? ", "Conifrm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int rowindex = dictionary[currentButton].SelectedRows[0].Index;
                    DGVAllTask.Rows.RemoveAt(GetSelectedRowIndex(rowindex));
                    dictionary[currentButton].Rows.RemoveAt(rowindex);
                    lbTaskCount.Text = dictionary[currentButton].Rows.Count.ToString() + " " + currentButton.Text.ToString() + " Task";
                }
            }
            
        }

        private void Search(DataGridView dataGridView)
        {
            string TaskSearch = txtSearch.Text.ToLower().Trim();

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string text = dataGridView.Rows[i].Cells[0].Value.ToString().ToLower().Trim();
                if (text.Contains(TaskSearch) || text.Equals(TaskSearch))
                {
                    dataGridView.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView.Rows[i].Visible = false;
                }
            }

            txtSearch.Text = "";
        }
        
        private void Serach_Click(object sender, EventArgs e)
        {
            if(currentButton.Text != "All")
            {
                Search(dictionary[currentButton]);
            }
            else
            {
                Search(DGVAllTask);
            }
            
        }



        
        private void ShowAllTasks(DataGridView dataGridView)
        {
            
            for(int i=0;i<dataGridView.Rows.Count;i++)
            {
                dataGridView.Rows[i].Visible = true;
                
            }

            lbTaskCount.Text = dataGridView.Rows.Count.ToString() + " " + currentButton.Text.ToString() + " Tasks ";
        }
       
        private void ShowCompletedTasks(DataGridView dataGridView)
        {
            for(int i=0; i<dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[4].Value.ToString().ToLower().Equals("Completed".ToLower()))
                {
                    dataGridView.Rows[i].Visible = true;
                    TaskCounter++;
                }
                else
                {
                    dataGridView.Rows[i].Visible = false;
                }
            }

            lbTaskCount.Text = TaskCounter.ToString() + " " + currentButton.Text.ToString() + " Completed Task";
            TaskCounter = 0;
        }

        private void ShowPendingTasks(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (dataGridView.Rows[i].Cells[4].Value.ToString().ToLower().Equals("Pending".ToLower()))
                {
                    dataGridView.Rows[i].Visible = true;
                    TaskCounter++;
                }
                else
                {
                    dataGridView.Rows[i].Visible = false;
                }
            }

            lbTaskCount.Text = TaskCounter.ToString() + " " + currentButton.Text.ToString() + " Pending Task";
            TaskCounter = 0;
        }

        
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(cbFilter.SelectedIndex)
           {
                case 0:

                    if (currentButton.Text != "All")
                    {
                        ShowAllTasks(dictionary[currentButton]);
                    }
                    else
                    {
                        ShowAllTasks(DGVAllTask);
                    }

                break;

                case 1:

                    if (currentButton.Text != "All")
                    {
                        ShowCompletedTasks(dictionary[currentButton]);
                    }
                    else
                    {
                        ShowCompletedTasks(DGVAllTask);
                    }
                   
                break;

                case 2:

                    if (currentButton.Text != "All")
                    {
                        ShowPendingTasks(dictionary[currentButton]);
                    }
                    else
                    {
                        ShowPendingTasks(DGVAllTask);
                    }


                  
                break;
           }
        }

        private void DGVTask_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(currentButton.Text !="All")
            TextBeforeEditing = dictionary[currentButton].Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim();
        }
    }
}

