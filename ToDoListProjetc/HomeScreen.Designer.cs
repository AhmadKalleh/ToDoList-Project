namespace ToDoListProjetc
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPersonal = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.lbTaskCount = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DGVAllTask = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Continar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.btnDeleteTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllTask)).BeginInit();
            this.Continar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(62, 298);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1212, 13);
            this.guna2Separator1.TabIndex = 4;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btnPersonal);
            this.guna2GradientPanel1.Controls.Add(this.btnAll);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(62, 259);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1201, 45);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.White;
            this.btnPersonal.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPersonal.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnPersonal.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            this.btnPersonal.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPersonal.CheckedState.Parent = this.btnPersonal;
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.CustomBorderColor = System.Drawing.Color.White;
            this.btnPersonal.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnPersonal.CustomImages.Parent = this.btnPersonal;
            this.btnPersonal.FillColor = System.Drawing.Color.White;
            this.btnPersonal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.Black;
            this.btnPersonal.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnPersonal.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPersonal.HoverState.Parent = this.btnPersonal;
            this.btnPersonal.Location = new System.Drawing.Point(155, 4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.ShadowDecoration.Parent = this.btnPersonal;
            this.btnPersonal.Size = new System.Drawing.Size(146, 42);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAll.Checked = true;
            this.btnAll.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnAll.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            this.btnAll.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAll.CheckedState.Parent = this.btnAll;
            this.btnAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAll.CustomBorderColor = System.Drawing.Color.White;
            this.btnAll.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnAll.CustomImages.Parent = this.btnAll;
            this.btnAll.FillColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.HoverState.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnAll.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAll.HoverState.Parent = this.btnAll;
            this.btnAll.Location = new System.Drawing.Point(3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.ShadowDecoration.Parent = this.btnAll;
            this.btnAll.Size = new System.Drawing.Size(146, 42);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.ShowAllTasks_Click);
            // 
            // lbTaskCount
            // 
            this.lbTaskCount.AutoSize = true;
            this.lbTaskCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskCount.Location = new System.Drawing.Point(73, 359);
            this.lbTaskCount.Name = "lbTaskCount";
            this.lbTaskCount.Size = new System.Drawing.Size(104, 41);
            this.lbTaskCount.TabIndex = 7;
            this.lbTaskCount.Text = "label2";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(858, 365);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(90, 28);
            this.lbFilter.TabIndex = 9;
            this.lbFilter.Text = "Filter by";
            // 
            // cbFilter
            // 
            this.cbFilter.Animated = true;
            this.cbFilter.AutoCompleteCustomSource.AddRange(new string[] {
            "All",
            "Completed",
            "Pending"});
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderRadius = 17;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.cbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbFilter.FocusedState.Parent = this.cbFilter;
            this.cbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            this.cbFilter.HoverState.Parent = this.cbFilter;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Pending"});
            this.cbFilter.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(954, 359);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(292, 36);
            this.cbFilter.TabIndex = 11;
            this.cbFilter.TextOffset = new System.Drawing.Point(8, 0);
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // DGVAllTask
            // 
            this.DGVAllTask.AllowUserToAddRows = false;
            this.DGVAllTask.AllowUserToDeleteRows = false;
            this.DGVAllTask.AllowUserToResizeColumns = false;
            this.DGVAllTask.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVAllTask.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAllTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAllTask.BackgroundColor = System.Drawing.Color.White;
            this.DGVAllTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAllTask.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAllTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAllTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVAllTask.ColumnHeadersHeight = 30;
            this.DGVAllTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Category,
            this.StartDate,
            this.EndDate,
            this.Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVAllTask.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVAllTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVAllTask.EnableHeadersVisualStyles = false;
            this.DGVAllTask.Location = new System.Drawing.Point(0, 0);
            this.DGVAllTask.MultiSelect = false;
            this.DGVAllTask.Name = "DGVAllTask";
            this.DGVAllTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAllTask.RowHeadersVisible = false;
            this.DGVAllTask.RowHeadersWidth = 51;
            this.DGVAllTask.RowTemplate.Height = 40;
            this.DGVAllTask.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVAllTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAllTask.Size = new System.Drawing.Size(1198, 340);
            this.DGVAllTask.TabIndex = 12;
            this.DGVAllTask.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClick_CellEndEdit);
      
            // 
            // Description
            // 
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.FillWeight = 150F;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // StartDate
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.EndDate.HeaderText = "End Date";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Continar
            // 
            this.Continar.AutoScroll = true;
            this.Continar.Controls.Add(this.DGVAllTask);
            this.Continar.Location = new System.Drawing.Point(65, 436);
            this.Continar.Name = "Continar";
            this.Continar.ShadowDecoration.Parent = this.Continar;
            this.Continar.Size = new System.Drawing.Size(1198, 340);
            this.Continar.TabIndex = 13;
            // 
            // pbFilter
            // 
            this.pbFilter.Image = ((System.Drawing.Image)(resources.GetObject("pbFilter.Image")));
            this.pbFilter.Location = new System.Drawing.Point(826, 369);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(26, 26);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilter.TabIndex = 10;
            this.pbFilter.TabStop = false;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Animated = true;
            this.btnDeleteTask.BorderRadius = 20;
            this.btnDeleteTask.CheckedState.Parent = this.btnDeleteTask;
            this.btnDeleteTask.CustomImages.Parent = this.btnDeleteTask;
            this.btnDeleteTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.HoverState.Parent = this.btnDeleteTask;
            this.btnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.Image")));
            this.btnDeleteTask.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteTask.Location = new System.Drawing.Point(1001, 190);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.ShadowDecoration.Parent = this.btnDeleteTask;
            this.btnDeleteTask.Size = new System.Drawing.Size(273, 63);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete Selected Task";
            this.btnDeleteTask.TextOffset = new System.Drawing.Point(5, 0);
            this.btnDeleteTask.Click += new System.EventHandler(this.DeleteSelectedTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Animated = true;
            this.btnAddTask.BorderRadius = 20;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            this.btnAddTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.ImageOffset = new System.Drawing.Point(-15, 0);
            this.btnAddTask.Location = new System.Drawing.Point(1000, 104);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(273, 63);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add New Task";
            this.btnAddTask.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnAddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderRadius = 27;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(62)))), ((int)(((byte)(208)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearch.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(93, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Task ...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(442, 69);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(15, 0);
            this.txtSearch.IconRightClick += new System.EventHandler(this.Serach_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 1100);
            this.Controls.Add(this.Continar);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.pbFilter);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.lbTaskCount);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAllTask)).EndInit();
            this.Continar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTask;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2Button btnPersonal;
        private System.Windows.Forms.Label lbTaskCount;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.PictureBox pbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private System.Windows.Forms.DataGridView DGVAllTask;
        private Guna.UI2.WinForms.Guna2GradientPanel Continar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        public Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}