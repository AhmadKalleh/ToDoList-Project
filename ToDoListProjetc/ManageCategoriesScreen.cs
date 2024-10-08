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
    public partial class ManageCategoriesScreen : Form
    {
        HomeScreen Screen = new HomeScreen();
        public ManageCategoriesScreen(HomeScreen screen)
        {
            InitializeComponent();
            Screen = screen;
        }

    

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtAddCategory.Text == string.Empty)
            {
                MessageBox.Show("you must Enter a Category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (MessageBox.Show("Are you sure to add this Category?", "Conifrm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataGridView dataGridView = new DataGridView();

                Screen.ConstructDataGridView(dataGridView);

                Screen.dictionary.Add(Screen.createTabButton(txtAddCategory.Text.Trim()), dataGridView);
            }

            txtAddCategory.Text = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAddCategory.Text = string.Empty;
        }

        private void ManageCategoriesScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
