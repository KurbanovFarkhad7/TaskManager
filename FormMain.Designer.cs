namespace TaskManager
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSide = new Panel();
            groupBoxTask = new GroupBox();
            dataGridViewCategories = new DataGridView();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryBindingSource = new BindingSource(components);
            labelLogo = new Label();
            pictureBoxLogo = new PictureBox();
            button1 = new Button();
            buttonNewTask = new Button();
            panelHeader = new Panel();
            buttonExit = new Button();
            panelMain = new Panel();
            buttonSave = new Button();
            dataGridViewProducts = new DataGridView();
            productsBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            panelSide.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.DimGray;
            panelSide.Controls.Add(groupBoxTask);
            panelSide.Controls.Add(labelLogo);
            panelSide.Controls.Add(pictureBoxLogo);
            panelSide.Dock = DockStyle.Left;
            panelSide.Location = new Point(0, 30);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(249, 420);
            panelSide.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewCategories);
            groupBoxTask.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxTask.Location = new Point(12, 70);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(220, 338);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Task";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            dataGridViewCategories.DataSource = categoryBindingSource;
            dataGridViewCategories.Location = new Point(6, 32);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(208, 230);
            dataGridViewCategories.TabIndex = 0;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(GetStartedWinForms.Category);
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelLogo.Location = new Point(56, 15);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(111, 32);
            labelLogo.TabIndex = 1;
            labelLogo.Text = "Pomelo";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.Logo;
            pictureBoxLogo.Location = new Point(3, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(47, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 385);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonNewTask
            // 
            buttonNewTask.BackColor = Color.DimGray;
            buttonNewTask.FlatStyle = FlatStyle.Flat;
            buttonNewTask.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNewTask.ForeColor = Color.White;
            buttonNewTask.Location = new Point(108, 375);
            buttonNewTask.Name = "buttonNewTask";
            buttonNewTask.Size = new Size(75, 33);
            buttonNewTask.TabIndex = 1;
            buttonNewTask.Text = "New";
            buttonNewTask.UseVisualStyleBackColor = false;
            buttonNewTask.Click += buttonNewTask_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Gray;
            panelHeader.Controls.Add(buttonExit);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 30);
            panelHeader.TabIndex = 1;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DimGray;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(764, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(36, 30);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(buttonNewTask);
            panelMain.Controls.Add(button1);
            panelMain.Controls.Add(buttonSave);
            panelMain.Controls.Add(dataGridViewProducts);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(249, 30);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(551, 420);
            panelMain.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DimGray;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(452, 370);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1 });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.Location = new Point(6, 3);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(533, 361);
            dataGridViewProducts.TabIndex = 1;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = categoryBindingSource;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            productIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelSide);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "TaskManager";
            panelSide.ResumeLayout(false);
            panelSide.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSide;
        private Panel panelHeader;
        private PictureBox pictureBoxLogo;
        private Panel panelMain;
        private Button button1;
        private Button buttonExit;
        private Label labelLogo;
        private GroupBox groupBoxTask;
        private Button buttonNewTask;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCategories;
        private Button buttonSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource productsBindingSource;
        private BindingSource categoryBindingSource;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    }
}
