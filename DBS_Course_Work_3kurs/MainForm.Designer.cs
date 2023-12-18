namespace DBS_Course_Work_3kurs
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Tabs = new TabControl();
            tabPage1 = new TabPage();
            BooksMainPanel = new Panel();
            BooksLowerPart = new Panel();
            BooksLowerPartLayout = new TableLayoutPanel();
            BooksTable = new DataGridView();
            Book_Id = new DataGridViewTextBoxColumn();
            Book_Title = new DataGridViewTextBoxColumn();
            Book_Author = new DataGridViewTextBoxColumn();
            Book_Genre = new DataGridViewTextBoxColumn();
            Book_Value = new DataGridViewTextBoxColumn();
            Book_Quantity = new DataGridViewTextBoxColumn();
            BooksPagesLayout = new TableLayoutPanel();
            BooksLastPageButton = new Button();
            BooksNextPageButton = new Button();
            BooksPrevPageButton = new Button();
            BooksFirstPageButton = new Button();
            BooksPageLabel = new Label();
            BooksUpperPart = new Panel();
            BooksUpperPartLayout = new TableLayoutPanel();
            BooksMainTitle = new Label();
            BooksControlPanel = new Panel();
            BooksControlLayout = new TableLayoutPanel();
            DeleteBookButton = new Button();
            ChangeBookButton = new Button();
            label3 = new Label();
            label2 = new Label();
            AddBookLabel = new Label();
            AddBookButton = new Button();
            tabPage2 = new TabPage();
            Tabs.SuspendLayout();
            tabPage1.SuspendLayout();
            BooksMainPanel.SuspendLayout();
            BooksLowerPart.SuspendLayout();
            BooksLowerPartLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BooksTable).BeginInit();
            BooksPagesLayout.SuspendLayout();
            BooksUpperPart.SuspendLayout();
            BooksUpperPartLayout.SuspendLayout();
            BooksControlPanel.SuspendLayout();
            BooksControlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(tabPage1);
            Tabs.Controls.Add(tabPage2);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Tabs.ItemSize = new Size(74, 35);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1405, 710);
            Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(251, 234, 235);
            tabPage1.Controls.Add(BooksMainPanel);
            tabPage1.Controls.Add(BooksControlPanel);
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1397, 667);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Книги";
            // 
            // BooksMainPanel
            // 
            BooksMainPanel.Controls.Add(BooksLowerPart);
            BooksMainPanel.Controls.Add(BooksUpperPart);
            BooksMainPanel.Dock = DockStyle.Fill;
            BooksMainPanel.Location = new Point(253, 3);
            BooksMainPanel.Name = "BooksMainPanel";
            BooksMainPanel.Size = new Size(1141, 661);
            BooksMainPanel.TabIndex = 1;
            // 
            // BooksLowerPart
            // 
            BooksLowerPart.Controls.Add(BooksLowerPartLayout);
            BooksLowerPart.Dock = DockStyle.Fill;
            BooksLowerPart.Location = new Point(0, 140);
            BooksLowerPart.Name = "BooksLowerPart";
            BooksLowerPart.Size = new Size(1141, 521);
            BooksLowerPart.TabIndex = 1;
            // 
            // BooksLowerPartLayout
            // 
            BooksLowerPartLayout.ColumnCount = 1;
            BooksLowerPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksLowerPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksLowerPartLayout.Controls.Add(BooksTable, 0, 0);
            BooksLowerPartLayout.Controls.Add(BooksPagesLayout, 0, 1);
            BooksLowerPartLayout.Dock = DockStyle.Fill;
            BooksLowerPartLayout.Location = new Point(0, 0);
            BooksLowerPartLayout.Name = "BooksLowerPartLayout";
            BooksLowerPartLayout.RowCount = 2;
            BooksLowerPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 88.29175F));
            BooksLowerPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7082529F));
            BooksLowerPartLayout.Size = new Size(1141, 521);
            BooksLowerPartLayout.TabIndex = 1;
            // 
            // BooksTable
            // 
            BooksTable.AllowUserToAddRows = false;
            BooksTable.AllowUserToDeleteRows = false;
            BooksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BooksTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BooksTable.BackgroundColor = Color.FromArgb(251, 234, 235);
            BooksTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            BooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksTable.Columns.AddRange(new DataGridViewColumn[] { Book_Id, Book_Title, Book_Author, Book_Genre, Book_Value, Book_Quantity });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            BooksTable.DefaultCellStyle = dataGridViewCellStyle2;
            BooksTable.Dock = DockStyle.Fill;
            BooksTable.EnableHeadersVisualStyles = false;
            BooksTable.GridColor = Color.White;
            BooksTable.Location = new Point(3, 3);
            BooksTable.MultiSelect = false;
            BooksTable.Name = "BooksTable";
            BooksTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            BooksTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            BooksTable.RowHeadersVisible = false;
            BooksTable.RowHeadersWidth = 51;
            BooksTable.RowTemplate.Height = 29;
            BooksTable.Size = new Size(1135, 454);
            BooksTable.TabIndex = 1;
            // 
            // Book_Id
            // 
            Book_Id.FillWeight = 25F;
            Book_Id.HeaderText = "ID";
            Book_Id.MinimumWidth = 6;
            Book_Id.Name = "Book_Id";
            Book_Id.ReadOnly = true;
            // 
            // Book_Title
            // 
            Book_Title.HeaderText = "Назва";
            Book_Title.MinimumWidth = 6;
            Book_Title.Name = "Book_Title";
            Book_Title.ReadOnly = true;
            // 
            // Book_Author
            // 
            Book_Author.HeaderText = "Автор";
            Book_Author.MinimumWidth = 6;
            Book_Author.Name = "Book_Author";
            Book_Author.ReadOnly = true;
            // 
            // Book_Genre
            // 
            Book_Genre.HeaderText = "Жанр";
            Book_Genre.MinimumWidth = 6;
            Book_Genre.Name = "Book_Genre";
            Book_Genre.ReadOnly = true;
            // 
            // Book_Value
            // 
            Book_Value.FillWeight = 65F;
            Book_Value.HeaderText = "Заставна вартість";
            Book_Value.MinimumWidth = 6;
            Book_Value.Name = "Book_Value";
            Book_Value.ReadOnly = true;
            // 
            // Book_Quantity
            // 
            Book_Quantity.FillWeight = 55F;
            Book_Quantity.HeaderText = "Кількість";
            Book_Quantity.MinimumWidth = 6;
            Book_Quantity.Name = "Book_Quantity";
            Book_Quantity.ReadOnly = true;
            // 
            // BooksPagesLayout
            // 
            BooksPagesLayout.ColumnCount = 7;
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            BooksPagesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            BooksPagesLayout.Controls.Add(BooksLastPageButton, 5, 0);
            BooksPagesLayout.Controls.Add(BooksNextPageButton, 4, 0);
            BooksPagesLayout.Controls.Add(BooksPrevPageButton, 2, 0);
            BooksPagesLayout.Controls.Add(BooksFirstPageButton, 1, 0);
            BooksPagesLayout.Controls.Add(BooksPageLabel, 3, 0);
            BooksPagesLayout.Dock = DockStyle.Fill;
            BooksPagesLayout.Location = new Point(3, 463);
            BooksPagesLayout.Name = "BooksPagesLayout";
            BooksPagesLayout.RowCount = 1;
            BooksPagesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BooksPagesLayout.Size = new Size(1135, 55);
            BooksPagesLayout.TabIndex = 2;
            // 
            // BooksLastPageButton
            // 
            BooksLastPageButton.Dock = DockStyle.Fill;
            BooksLastPageButton.Location = new Point(814, 3);
            BooksLastPageButton.Name = "BooksLastPageButton";
            BooksLastPageButton.Size = new Size(116, 49);
            BooksLastPageButton.TabIndex = 3;
            BooksLastPageButton.Text = "Last";
            BooksLastPageButton.UseVisualStyleBackColor = true;
            BooksLastPageButton.Click += BooksLastPageButton_Click;
            // 
            // BooksNextPageButton
            // 
            BooksNextPageButton.Dock = DockStyle.Fill;
            BooksNextPageButton.Location = new Point(692, 3);
            BooksNextPageButton.Name = "BooksNextPageButton";
            BooksNextPageButton.Size = new Size(116, 49);
            BooksNextPageButton.TabIndex = 2;
            BooksNextPageButton.Text = "Next";
            BooksNextPageButton.UseVisualStyleBackColor = true;
            BooksNextPageButton.Click += BooksNextPageButton_Click;
            // 
            // BooksPrevPageButton
            // 
            BooksPrevPageButton.Dock = DockStyle.Fill;
            BooksPrevPageButton.Location = new Point(325, 3);
            BooksPrevPageButton.Name = "BooksPrevPageButton";
            BooksPrevPageButton.Size = new Size(116, 49);
            BooksPrevPageButton.TabIndex = 1;
            BooksPrevPageButton.Text = "Prev";
            BooksPrevPageButton.UseVisualStyleBackColor = true;
            BooksPrevPageButton.Click += BooksPrevPageButton_Click;
            // 
            // BooksFirstPageButton
            // 
            BooksFirstPageButton.Dock = DockStyle.Fill;
            BooksFirstPageButton.Location = new Point(203, 3);
            BooksFirstPageButton.Name = "BooksFirstPageButton";
            BooksFirstPageButton.Size = new Size(116, 49);
            BooksFirstPageButton.TabIndex = 0;
            BooksFirstPageButton.Text = "First";
            BooksFirstPageButton.UseVisualStyleBackColor = true;
            BooksFirstPageButton.Click += BooksFirstPageButton_Click;
            // 
            // BooksPageLabel
            // 
            BooksPageLabel.AutoSize = true;
            BooksPageLabel.Dock = DockStyle.Fill;
            BooksPageLabel.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPageLabel.Location = new Point(447, 0);
            BooksPageLabel.Name = "BooksPageLabel";
            BooksPageLabel.Size = new Size(239, 55);
            BooksPageLabel.TabIndex = 4;
            BooksPageLabel.Text = "Page: 0";
            BooksPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksUpperPart
            // 
            BooksUpperPart.Controls.Add(BooksUpperPartLayout);
            BooksUpperPart.Dock = DockStyle.Top;
            BooksUpperPart.Location = new Point(0, 0);
            BooksUpperPart.Name = "BooksUpperPart";
            BooksUpperPart.Size = new Size(1141, 140);
            BooksUpperPart.TabIndex = 0;
            // 
            // BooksUpperPartLayout
            // 
            BooksUpperPartLayout.ColumnCount = 1;
            BooksUpperPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksUpperPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksUpperPartLayout.Controls.Add(BooksMainTitle, 0, 0);
            BooksUpperPartLayout.Dock = DockStyle.Fill;
            BooksUpperPartLayout.Location = new Point(0, 0);
            BooksUpperPartLayout.Name = "BooksUpperPartLayout";
            BooksUpperPartLayout.RowCount = 2;
            BooksUpperPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 37.8571434F));
            BooksUpperPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62.1428566F));
            BooksUpperPartLayout.Size = new Size(1141, 140);
            BooksUpperPartLayout.TabIndex = 0;
            // 
            // BooksMainTitle
            // 
            BooksMainTitle.AutoSize = true;
            BooksMainTitle.Dock = DockStyle.Fill;
            BooksMainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            BooksMainTitle.Location = new Point(3, 0);
            BooksMainTitle.Name = "BooksMainTitle";
            BooksMainTitle.Size = new Size(1135, 53);
            BooksMainTitle.TabIndex = 0;
            BooksMainTitle.Text = "Книги";
            BooksMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksControlPanel
            // 
            BooksControlPanel.BackColor = Color.FromArgb(47, 60, 126);
            BooksControlPanel.Controls.Add(BooksControlLayout);
            BooksControlPanel.Dock = DockStyle.Left;
            BooksControlPanel.Location = new Point(3, 3);
            BooksControlPanel.Name = "BooksControlPanel";
            BooksControlPanel.Size = new Size(250, 661);
            BooksControlPanel.TabIndex = 0;
            // 
            // BooksControlLayout
            // 
            BooksControlLayout.BackColor = Color.FromArgb(47, 60, 126);
            BooksControlLayout.ColumnCount = 1;
            BooksControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            BooksControlLayout.Controls.Add(DeleteBookButton, 0, 5);
            BooksControlLayout.Controls.Add(ChangeBookButton, 0, 3);
            BooksControlLayout.Controls.Add(label3, 0, 4);
            BooksControlLayout.Controls.Add(label2, 0, 2);
            BooksControlLayout.Controls.Add(AddBookLabel, 0, 0);
            BooksControlLayout.Controls.Add(AddBookButton, 0, 1);
            BooksControlLayout.Dock = DockStyle.Fill;
            BooksControlLayout.ForeColor = Color.FromArgb(251, 234, 235);
            BooksControlLayout.Location = new Point(0, 0);
            BooksControlLayout.Name = "BooksControlLayout";
            BooksControlLayout.RowCount = 6;
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            BooksControlLayout.Size = new Size(250, 661);
            BooksControlLayout.TabIndex = 0;
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.Dock = DockStyle.Fill;
            DeleteBookButton.FlatAppearance.BorderSize = 3;
            DeleteBookButton.FlatStyle = FlatStyle.Flat;
            DeleteBookButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBookButton.Location = new Point(3, 553);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(244, 105);
            DeleteBookButton.TabIndex = 6;
            DeleteBookButton.Text = "Delete";
            DeleteBookButton.UseVisualStyleBackColor = false;
            // 
            // ChangeBookButton
            // 
            ChangeBookButton.Dock = DockStyle.Fill;
            ChangeBookButton.FlatAppearance.BorderSize = 3;
            ChangeBookButton.FlatStyle = FlatStyle.Flat;
            ChangeBookButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeBookButton.Location = new Point(3, 333);
            ChangeBookButton.Name = "ChangeBookButton";
            ChangeBookButton.Size = new Size(244, 104);
            ChangeBookButton.TabIndex = 5;
            ChangeBookButton.Text = "Change";
            ChangeBookButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 440);
            label3.Name = "label3";
            label3.Size = new Size(244, 110);
            label3.TabIndex = 3;
            label3.Text = "Видалити книгу";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 220);
            label2.Name = "label2";
            label2.Size = new Size(244, 110);
            label2.TabIndex = 2;
            label2.Text = "Змінити книгу";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddBookLabel
            // 
            AddBookLabel.AutoSize = true;
            AddBookLabel.Dock = DockStyle.Fill;
            AddBookLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookLabel.Location = new Point(3, 0);
            AddBookLabel.Name = "AddBookLabel";
            AddBookLabel.Size = new Size(244, 110);
            AddBookLabel.TabIndex = 1;
            AddBookLabel.Text = "Додати книгу";
            AddBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddBookButton
            // 
            AddBookButton.Dock = DockStyle.Fill;
            AddBookButton.FlatAppearance.BorderSize = 4;
            AddBookButton.FlatStyle = FlatStyle.Flat;
            AddBookButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookButton.Location = new Point(3, 113);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(244, 104);
            AddBookButton.TabIndex = 4;
            AddBookButton.Text = "Add";
            AddBookButton.UseVisualStyleBackColor = false;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1397, 667);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 234, 235);
            ClientSize = new Size(1405, 710);
            Controls.Add(Tabs);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(47, 60, 126);
            Name = "MainForm";
            Text = "LibrarianHelper";
            Load += MainForm_Load;
            Tabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            BooksMainPanel.ResumeLayout(false);
            BooksLowerPart.ResumeLayout(false);
            BooksLowerPartLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BooksTable).EndInit();
            BooksPagesLayout.ResumeLayout(false);
            BooksPagesLayout.PerformLayout();
            BooksUpperPart.ResumeLayout(false);
            BooksUpperPartLayout.ResumeLayout(false);
            BooksUpperPartLayout.PerformLayout();
            BooksControlPanel.ResumeLayout(false);
            BooksControlLayout.ResumeLayout(false);
            BooksControlLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage tabPage1;
        private Panel BooksMainPanel;
        private Panel BooksLowerPart;
        private Panel BooksUpperPart;
        private TableLayoutPanel BooksUpperPartLayout;
        private Label BooksMainTitle;
        private Panel BooksControlPanel;
        private TabPage tabPage2;
        private TableLayoutPanel BooksControlLayout;
        private Label label3;
        private Label label2;
        private Label AddBookLabel;
        private Button AddBookButton;
        private Button ChangeBookButton;
        private Button DeleteBookButton;
        private TableLayoutPanel BooksLowerPartLayout;
        private DataGridViewTextBoxColumn Book_Id;
        private DataGridViewTextBoxColumn Book_Title;
        private DataGridViewTextBoxColumn Book_Author;
        private DataGridViewTextBoxColumn Book_Genre;
        private DataGridViewTextBoxColumn Book_Value;
        private DataGridViewTextBoxColumn Book_Quantity;
        private TableLayoutPanel BooksPagesLayout;
        private Button BooksLastPageButton;
        private Button BooksNextPageButton;
        private Button BooksPrevPageButton;
        private Button BooksFirstPageButton;
        private Label BooksPageLabel;
        public DataGridView BooksTable;
    }
}