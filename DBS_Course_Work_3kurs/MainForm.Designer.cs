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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
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
            BooksSearchLayout = new TableLayoutPanel();
            BookSearchText = new TextBox();
            BooksSearchButtonsLabel = new Label();
            BooksSearchTextLabel = new Label();
            BooksSearchTypeLabel = new Label();
            BooksSearchButtonsLayout = new TableLayoutPanel();
            BooksShowAllButton = new Button();
            BooksSearchButton = new Button();
            BooksSearchType = new ComboBox();
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
            BooksSearchLayout.SuspendLayout();
            BooksSearchButtonsLayout.SuspendLayout();
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
            Tabs.Size = new Size(1405, 752);
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
            tabPage1.Size = new Size(1397, 709);
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
            BooksMainPanel.Size = new Size(1141, 703);
            BooksMainPanel.TabIndex = 1;
            // 
            // BooksLowerPart
            // 
            BooksLowerPart.Controls.Add(BooksLowerPartLayout);
            BooksLowerPart.Dock = DockStyle.Fill;
            BooksLowerPart.Location = new Point(0, 166);
            BooksLowerPart.Name = "BooksLowerPart";
            BooksLowerPart.Size = new Size(1141, 537);
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
            BooksLowerPartLayout.Size = new Size(1141, 537);
            BooksLowerPartLayout.TabIndex = 1;
            // 
            // BooksTable
            // 
            BooksTable.AllowUserToAddRows = false;
            BooksTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle13.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(251, 234, 235);
            BooksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            BooksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BooksTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BooksTable.BackgroundColor = Color.FromArgb(251, 234, 235);
            BooksTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle14.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            BooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksTable.Columns.AddRange(new DataGridViewColumn[] { Book_Id, Book_Title, Book_Author, Book_Genre, Book_Value, Book_Quantity });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle16.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            BooksTable.DefaultCellStyle = dataGridViewCellStyle16;
            BooksTable.Dock = DockStyle.Fill;
            BooksTable.EnableHeadersVisualStyles = false;
            BooksTable.GridColor = Color.White;
            BooksTable.Location = new Point(3, 3);
            BooksTable.MultiSelect = false;
            BooksTable.Name = "BooksTable";
            BooksTable.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle17.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            BooksTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            BooksTable.RowHeadersVisible = false;
            BooksTable.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle18.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(251, 234, 235);
            BooksTable.RowsDefaultCellStyle = dataGridViewCellStyle18;
            BooksTable.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 234, 235);
            BooksTable.RowTemplate.DefaultCellStyle.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            BooksTable.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(47, 60, 126);
            BooksTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 60, 126);
            BooksTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(251, 234, 235);
            BooksTable.RowTemplate.Height = 29;
            BooksTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BooksTable.Size = new Size(1135, 468);
            BooksTable.TabIndex = 1;
            // 
            // Book_Id
            // 
            dataGridViewCellStyle15.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle15.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(251, 234, 235);
            Book_Id.DefaultCellStyle = dataGridViewCellStyle15;
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
            BooksPagesLayout.Location = new Point(3, 477);
            BooksPagesLayout.Name = "BooksPagesLayout";
            BooksPagesLayout.RowCount = 1;
            BooksPagesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            BooksPagesLayout.Size = new Size(1135, 57);
            BooksPagesLayout.TabIndex = 2;
            // 
            // BooksLastPageButton
            // 
            BooksLastPageButton.Dock = DockStyle.Fill;
            BooksLastPageButton.Location = new Point(814, 3);
            BooksLastPageButton.Name = "BooksLastPageButton";
            BooksLastPageButton.Size = new Size(116, 51);
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
            BooksNextPageButton.Size = new Size(116, 51);
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
            BooksPrevPageButton.Size = new Size(116, 51);
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
            BooksFirstPageButton.Size = new Size(116, 51);
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
            BooksPageLabel.Size = new Size(239, 57);
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
            BooksUpperPart.Size = new Size(1141, 166);
            BooksUpperPart.TabIndex = 0;
            // 
            // BooksUpperPartLayout
            // 
            BooksUpperPartLayout.ColumnCount = 1;
            BooksUpperPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksUpperPartLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksUpperPartLayout.Controls.Add(BooksMainTitle, 0, 0);
            BooksUpperPartLayout.Controls.Add(BooksSearchLayout, 0, 1);
            BooksUpperPartLayout.Dock = DockStyle.Fill;
            BooksUpperPartLayout.Location = new Point(0, 0);
            BooksUpperPartLayout.Name = "BooksUpperPartLayout";
            BooksUpperPartLayout.RowCount = 2;
            BooksUpperPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 37.8571434F));
            BooksUpperPartLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 62.1428566F));
            BooksUpperPartLayout.Size = new Size(1141, 166);
            BooksUpperPartLayout.TabIndex = 0;
            // 
            // BooksMainTitle
            // 
            BooksMainTitle.AutoSize = true;
            BooksMainTitle.Dock = DockStyle.Fill;
            BooksMainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            BooksMainTitle.Location = new Point(3, 0);
            BooksMainTitle.Name = "BooksMainTitle";
            BooksMainTitle.Size = new Size(1135, 62);
            BooksMainTitle.TabIndex = 0;
            BooksMainTitle.Text = "Книги";
            BooksMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksSearchLayout
            // 
            BooksSearchLayout.ColumnCount = 3;
            BooksSearchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            BooksSearchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            BooksSearchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            BooksSearchLayout.Controls.Add(BookSearchText, 1, 1);
            BooksSearchLayout.Controls.Add(BooksSearchButtonsLabel, 2, 0);
            BooksSearchLayout.Controls.Add(BooksSearchTextLabel, 1, 0);
            BooksSearchLayout.Controls.Add(BooksSearchTypeLabel, 0, 0);
            BooksSearchLayout.Controls.Add(BooksSearchButtonsLayout, 2, 1);
            BooksSearchLayout.Controls.Add(BooksSearchType, 0, 1);
            BooksSearchLayout.Dock = DockStyle.Fill;
            BooksSearchLayout.Location = new Point(3, 65);
            BooksSearchLayout.Name = "BooksSearchLayout";
            BooksSearchLayout.RowCount = 2;
            BooksSearchLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BooksSearchLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BooksSearchLayout.Size = new Size(1135, 98);
            BooksSearchLayout.TabIndex = 1;
            // 
            // BookSearchText
            // 
            BookSearchText.BackColor = Color.FromArgb(251, 234, 235);
            BookSearchText.BorderStyle = BorderStyle.FixedSingle;
            BookSearchText.Dock = DockStyle.Fill;
            BookSearchText.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookSearchText.ForeColor = Color.FromArgb(47, 60, 126);
            BookSearchText.Location = new Point(381, 52);
            BookSearchText.Name = "BookSearchText";
            BookSearchText.PlaceholderText = "Текст для пошуку";
            BookSearchText.Size = new Size(372, 43);
            BookSearchText.TabIndex = 8;
            // 
            // BooksSearchButtonsLabel
            // 
            BooksSearchButtonsLabel.AutoSize = true;
            BooksSearchButtonsLabel.Dock = DockStyle.Fill;
            BooksSearchButtonsLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BooksSearchButtonsLabel.Location = new Point(759, 0);
            BooksSearchButtonsLabel.Name = "BooksSearchButtonsLabel";
            BooksSearchButtonsLabel.Size = new Size(373, 49);
            BooksSearchButtonsLabel.TabIndex = 3;
            BooksSearchButtonsLabel.Text = "Пошук";
            BooksSearchButtonsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksSearchTextLabel
            // 
            BooksSearchTextLabel.AutoSize = true;
            BooksSearchTextLabel.Dock = DockStyle.Fill;
            BooksSearchTextLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BooksSearchTextLabel.Location = new Point(381, 0);
            BooksSearchTextLabel.Name = "BooksSearchTextLabel";
            BooksSearchTextLabel.Size = new Size(372, 49);
            BooksSearchTextLabel.TabIndex = 2;
            BooksSearchTextLabel.Text = "Текст для пошуку";
            BooksSearchTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksSearchTypeLabel
            // 
            BooksSearchTypeLabel.AutoSize = true;
            BooksSearchTypeLabel.Dock = DockStyle.Fill;
            BooksSearchTypeLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BooksSearchTypeLabel.Location = new Point(3, 0);
            BooksSearchTypeLabel.Name = "BooksSearchTypeLabel";
            BooksSearchTypeLabel.Size = new Size(372, 49);
            BooksSearchTypeLabel.TabIndex = 1;
            BooksSearchTypeLabel.Text = "Тип пошуку";
            BooksSearchTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BooksSearchButtonsLayout
            // 
            BooksSearchButtonsLayout.ColumnCount = 2;
            BooksSearchButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksSearchButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BooksSearchButtonsLayout.Controls.Add(BooksShowAllButton, 0, 0);
            BooksSearchButtonsLayout.Controls.Add(BooksSearchButton, 0, 0);
            BooksSearchButtonsLayout.Dock = DockStyle.Fill;
            BooksSearchButtonsLayout.Location = new Point(759, 52);
            BooksSearchButtonsLayout.Name = "BooksSearchButtonsLayout";
            BooksSearchButtonsLayout.RowCount = 1;
            BooksSearchButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BooksSearchButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BooksSearchButtonsLayout.Size = new Size(373, 43);
            BooksSearchButtonsLayout.TabIndex = 9;
            // 
            // BooksShowAllButton
            // 
            BooksShowAllButton.Dock = DockStyle.Fill;
            BooksShowAllButton.FlatAppearance.BorderSize = 4;
            BooksShowAllButton.FlatStyle = FlatStyle.Flat;
            BooksShowAllButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BooksShowAllButton.Location = new Point(189, 3);
            BooksShowAllButton.Name = "BooksShowAllButton";
            BooksShowAllButton.Size = new Size(181, 37);
            BooksShowAllButton.TabIndex = 7;
            BooksShowAllButton.Text = "Show All";
            BooksShowAllButton.UseVisualStyleBackColor = false;
            // 
            // BooksSearchButton
            // 
            BooksSearchButton.Dock = DockStyle.Fill;
            BooksSearchButton.FlatAppearance.BorderSize = 4;
            BooksSearchButton.FlatStyle = FlatStyle.Flat;
            BooksSearchButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BooksSearchButton.Location = new Point(3, 3);
            BooksSearchButton.Name = "BooksSearchButton";
            BooksSearchButton.Size = new Size(180, 37);
            BooksSearchButton.TabIndex = 6;
            BooksSearchButton.Text = "Search";
            BooksSearchButton.UseVisualStyleBackColor = false;
            // 
            // BooksSearchType
            // 
            BooksSearchType.BackColor = Color.FromArgb(251, 234, 235);
            BooksSearchType.Dock = DockStyle.Fill;
            BooksSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            BooksSearchType.Font = new Font("Bookman Old Style", 17F, FontStyle.Regular, GraphicsUnit.Point);
            BooksSearchType.ForeColor = Color.FromArgb(47, 60, 126);
            BooksSearchType.FormattingEnabled = true;
            BooksSearchType.Items.AddRange(new object[] { "ID", "Назва", "Автор", "Жанр", "Заставна вартість", "Кількість" });
            BooksSearchType.Location = new Point(3, 52);
            BooksSearchType.Name = "BooksSearchType";
            BooksSearchType.Size = new Size(372, 41);
            BooksSearchType.TabIndex = 10;
            // 
            // BooksControlPanel
            // 
            BooksControlPanel.BackColor = Color.FromArgb(47, 60, 126);
            BooksControlPanel.Controls.Add(BooksControlLayout);
            BooksControlPanel.Dock = DockStyle.Left;
            BooksControlPanel.Location = new Point(3, 3);
            BooksControlPanel.Name = "BooksControlPanel";
            BooksControlPanel.Size = new Size(250, 703);
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
            BooksControlLayout.Size = new Size(250, 703);
            BooksControlLayout.TabIndex = 0;
            // 
            // DeleteBookButton
            // 
            DeleteBookButton.Dock = DockStyle.Fill;
            DeleteBookButton.FlatAppearance.BorderSize = 3;
            DeleteBookButton.FlatStyle = FlatStyle.Flat;
            DeleteBookButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBookButton.Location = new Point(3, 588);
            DeleteBookButton.Name = "DeleteBookButton";
            DeleteBookButton.Size = new Size(244, 112);
            DeleteBookButton.TabIndex = 6;
            DeleteBookButton.Text = "Delete";
            DeleteBookButton.UseVisualStyleBackColor = false;
            DeleteBookButton.Click += DeleteBookButton_Click;
            // 
            // ChangeBookButton
            // 
            ChangeBookButton.Dock = DockStyle.Fill;
            ChangeBookButton.FlatAppearance.BorderSize = 3;
            ChangeBookButton.FlatStyle = FlatStyle.Flat;
            ChangeBookButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeBookButton.Location = new Point(3, 354);
            ChangeBookButton.Name = "ChangeBookButton";
            ChangeBookButton.Size = new Size(244, 111);
            ChangeBookButton.TabIndex = 5;
            ChangeBookButton.Text = "Change";
            ChangeBookButton.UseVisualStyleBackColor = false;
            ChangeBookButton.Click += ChangeBookButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 468);
            label3.Name = "label3";
            label3.Size = new Size(244, 117);
            label3.TabIndex = 3;
            label3.Text = "Видалити книгу";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 234);
            label2.Name = "label2";
            label2.Size = new Size(244, 117);
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
            AddBookLabel.Size = new Size(244, 117);
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
            AddBookButton.Location = new Point(3, 120);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(244, 111);
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
            tabPage2.Size = new Size(1397, 709);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 234, 235);
            ClientSize = new Size(1405, 752);
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
            BooksSearchLayout.ResumeLayout(false);
            BooksSearchLayout.PerformLayout();
            BooksSearchButtonsLayout.ResumeLayout(false);
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
        private TableLayoutPanel BooksPagesLayout;
        private Button BooksLastPageButton;
        private Button BooksNextPageButton;
        private Button BooksPrevPageButton;
        private Button BooksFirstPageButton;
        public DataGridView BooksTable;
        private DataGridViewTextBoxColumn Book_Id;
        private DataGridViewTextBoxColumn Book_Title;
        private DataGridViewTextBoxColumn Book_Author;
        private DataGridViewTextBoxColumn Book_Genre;
        private DataGridViewTextBoxColumn Book_Value;
        private DataGridViewTextBoxColumn Book_Quantity;
        private TableLayoutPanel BooksSearchLayout;
        private Label BooksSearchButtonsLabel;
        private Label BooksSearchTextLabel;
        private Label BooksSearchTypeLabel;
        private TableLayoutPanel BooksSearchButtonsLayout;
        private Button BooksShowAllButton;
        private Button BooksSearchButton;
        public Label BooksPageLabel;
        public TextBox BookSearchText;
        public ComboBox BooksSearchType;
    }
}