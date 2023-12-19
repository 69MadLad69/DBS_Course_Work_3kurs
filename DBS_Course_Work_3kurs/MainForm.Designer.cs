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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            Tabs = new TabControl();
            BooksTab = new TabPage();
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
            CustomersTab = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            CustomersTable = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerFullName = new DataGridViewTextBoxColumn();
            CustomerAddress = new DataGridViewTextBoxColumn();
            CustomerPhone = new DataGridViewTextBoxColumn();
            CustomerDiscountId = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            CustomersLastPageButton = new Button();
            CustomersNextPageButton = new Button();
            CustomersPrevPageButton = new Button();
            CustomersFirstPageButton = new Button();
            CustomerPageLabel = new Label();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            CustomersMainTitle = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            CustomerSearchText = new TextBox();
            CustomerSearchLabel = new Label();
            CustomerSearchTextLabel = new Label();
            CustomerSearchTypeLabel = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            CustomerShowAllButton = new Button();
            CustomerSearchButton = new Button();
            CustomerSearchType = new ComboBox();
            CustomerControlPanel = new Panel();
            CustomerControlLayout = new TableLayoutPanel();
            DeleteCustomerButton = new Button();
            ChangeCustomerButton = new Button();
            DeleteCusomerLabel = new Label();
            ChangeCustomerLabel = new Label();
            AddCustomerLabel = new Label();
            AddCustomerButton = new Button();
            Tabs.SuspendLayout();
            BooksTab.SuspendLayout();
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
            CustomersTab.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersTable).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            CustomerControlPanel.SuspendLayout();
            CustomerControlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // Tabs
            // 
            Tabs.Controls.Add(BooksTab);
            Tabs.Controls.Add(CustomersTab);
            Tabs.Dock = DockStyle.Fill;
            Tabs.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Tabs.ItemSize = new Size(74, 35);
            Tabs.Location = new Point(0, 0);
            Tabs.Name = "Tabs";
            Tabs.SelectedIndex = 0;
            Tabs.Size = new Size(1405, 752);
            Tabs.TabIndex = 0;
            // 
            // BooksTab
            // 
            BooksTab.BackColor = Color.FromArgb(251, 234, 235);
            BooksTab.Controls.Add(BooksMainPanel);
            BooksTab.Controls.Add(BooksControlPanel);
            BooksTab.Location = new Point(4, 39);
            BooksTab.Name = "BooksTab";
            BooksTab.Padding = new Padding(3);
            BooksTab.Size = new Size(1397, 709);
            BooksTab.TabIndex = 0;
            BooksTab.Text = "Книги";
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(251, 234, 235);
            BooksTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            BooksTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BooksTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            BooksTable.BackgroundColor = Color.FromArgb(251, 234, 235);
            BooksTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle2.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            BooksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            BooksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BooksTable.Columns.AddRange(new DataGridViewColumn[] { Book_Id, Book_Title, Book_Author, Book_Genre, Book_Value, Book_Quantity });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle4.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            BooksTable.DefaultCellStyle = dataGridViewCellStyle4;
            BooksTable.Dock = DockStyle.Fill;
            BooksTable.EnableHeadersVisualStyles = false;
            BooksTable.GridColor = Color.White;
            BooksTable.Location = new Point(3, 3);
            BooksTable.MultiSelect = false;
            BooksTable.Name = "BooksTable";
            BooksTable.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle5.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            BooksTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            BooksTable.RowHeadersVisible = false;
            BooksTable.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle6.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(251, 234, 235);
            BooksTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle3.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle3.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(251, 234, 235);
            Book_Id.DefaultCellStyle = dataGridViewCellStyle3;
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
            BooksShowAllButton.Click += BooksShowAllButton_Click;
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
            BooksSearchButton.Click += BooksSearchButton_Click;
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
            label2.Text = "Змінити дані книги";
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
            // CustomersTab
            // 
            CustomersTab.BackColor = Color.FromArgb(251, 234, 235);
            CustomersTab.Controls.Add(panel2);
            CustomersTab.Controls.Add(CustomerControlPanel);
            CustomersTab.Location = new Point(4, 39);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(1397, 709);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Картотека";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(253, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1141, 703);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(1141, 537);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CustomersTable, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 88.29175F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7082529F));
            tableLayoutPanel2.Size = new Size(1141, 537);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // CustomersTable
            // 
            CustomersTable.AllowUserToAddRows = false;
            CustomersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle7.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(251, 234, 235);
            CustomersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            CustomersTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            CustomersTable.BackgroundColor = Color.FromArgb(251, 234, 235);
            CustomersTable.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle8.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            CustomersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            CustomersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersTable.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerFullName, CustomerAddress, CustomerPhone, CustomerDiscountId });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle10.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            CustomersTable.DefaultCellStyle = dataGridViewCellStyle10;
            CustomersTable.Dock = DockStyle.Fill;
            CustomersTable.EnableHeadersVisualStyles = false;
            CustomersTable.GridColor = Color.White;
            CustomersTable.Location = new Point(3, 3);
            CustomersTable.MultiSelect = false;
            CustomersTable.Name = "CustomersTable";
            CustomersTable.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle11.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            CustomersTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            CustomersTable.RowHeadersVisible = false;
            CustomersTable.RowHeadersWidth = 51;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle12.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(251, 234, 235);
            CustomersTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            CustomersTable.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(251, 234, 235);
            CustomersTable.RowTemplate.DefaultCellStyle.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersTable.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(47, 60, 126);
            CustomersTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 60, 126);
            CustomersTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(251, 234, 235);
            CustomersTable.RowTemplate.Height = 29;
            CustomersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomersTable.Size = new Size(1135, 468);
            CustomersTable.TabIndex = 1;
            // 
            // CustomerID
            // 
            dataGridViewCellStyle9.BackColor = Color.FromArgb(251, 234, 235);
            dataGridViewCellStyle9.Font = new Font("Bookman Old Style", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(47, 60, 126);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(251, 234, 235);
            CustomerID.DefaultCellStyle = dataGridViewCellStyle9;
            CustomerID.FillWeight = 15F;
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // CustomerFullName
            // 
            CustomerFullName.HeaderText = "Повне ім`я";
            CustomerFullName.MinimumWidth = 6;
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.ReadOnly = true;
            // 
            // CustomerAddress
            // 
            CustomerAddress.FillWeight = 65F;
            CustomerAddress.HeaderText = "Адреса";
            CustomerAddress.MinimumWidth = 6;
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.ReadOnly = true;
            // 
            // CustomerPhone
            // 
            CustomerPhone.FillWeight = 55F;
            CustomerPhone.HeaderText = "Телефон";
            CustomerPhone.MinimumWidth = 6;
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.ReadOnly = true;
            // 
            // CustomerDiscountId
            // 
            CustomerDiscountId.FillWeight = 30F;
            CustomerDiscountId.HeaderText = "Знижка";
            CustomerDiscountId.MinimumWidth = 6;
            CustomerDiscountId.Name = "CustomerDiscountId";
            CustomerDiscountId.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel3.Controls.Add(CustomersLastPageButton, 5, 0);
            tableLayoutPanel3.Controls.Add(CustomersNextPageButton, 4, 0);
            tableLayoutPanel3.Controls.Add(CustomersPrevPageButton, 2, 0);
            tableLayoutPanel3.Controls.Add(CustomersFirstPageButton, 1, 0);
            tableLayoutPanel3.Controls.Add(CustomerPageLabel, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 477);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1135, 57);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // CustomersLastPageButton
            // 
            CustomersLastPageButton.Dock = DockStyle.Fill;
            CustomersLastPageButton.Location = new Point(814, 3);
            CustomersLastPageButton.Name = "CustomersLastPageButton";
            CustomersLastPageButton.Size = new Size(116, 51);
            CustomersLastPageButton.TabIndex = 3;
            CustomersLastPageButton.Text = "Last";
            CustomersLastPageButton.UseVisualStyleBackColor = true;
            CustomersLastPageButton.Click += CustomersLastPageButton_Click;
            // 
            // CustomersNextPageButton
            // 
            CustomersNextPageButton.Dock = DockStyle.Fill;
            CustomersNextPageButton.Location = new Point(692, 3);
            CustomersNextPageButton.Name = "CustomersNextPageButton";
            CustomersNextPageButton.Size = new Size(116, 51);
            CustomersNextPageButton.TabIndex = 2;
            CustomersNextPageButton.Text = "Next";
            CustomersNextPageButton.UseVisualStyleBackColor = true;
            CustomersNextPageButton.Click += CustomersNextPageButton_Click;
            // 
            // CustomersPrevPageButton
            // 
            CustomersPrevPageButton.Dock = DockStyle.Fill;
            CustomersPrevPageButton.Location = new Point(325, 3);
            CustomersPrevPageButton.Name = "CustomersPrevPageButton";
            CustomersPrevPageButton.Size = new Size(116, 51);
            CustomersPrevPageButton.TabIndex = 1;
            CustomersPrevPageButton.Text = "Prev";
            CustomersPrevPageButton.UseVisualStyleBackColor = true;
            CustomersPrevPageButton.Click += CustomersPrevPageButton_Click;
            // 
            // CustomersFirstPageButton
            // 
            CustomersFirstPageButton.Dock = DockStyle.Fill;
            CustomersFirstPageButton.Location = new Point(203, 3);
            CustomersFirstPageButton.Name = "CustomersFirstPageButton";
            CustomersFirstPageButton.Size = new Size(116, 51);
            CustomersFirstPageButton.TabIndex = 0;
            CustomersFirstPageButton.Text = "First";
            CustomersFirstPageButton.UseVisualStyleBackColor = true;
            CustomersFirstPageButton.Click += CustomersFirstPageButton_Click;
            // 
            // CustomerPageLabel
            // 
            CustomerPageLabel.AutoSize = true;
            CustomerPageLabel.Dock = DockStyle.Fill;
            CustomerPageLabel.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPageLabel.Location = new Point(447, 0);
            CustomerPageLabel.Name = "CustomerPageLabel";
            CustomerPageLabel.Size = new Size(239, 57);
            CustomerPageLabel.TabIndex = 4;
            CustomerPageLabel.Text = "Page: 0";
            CustomerPageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1141, 166);
            panel4.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(CustomersMainTitle, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 37.8571434F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 62.1428566F));
            tableLayoutPanel4.Size = new Size(1141, 166);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // CustomersMainTitle
            // 
            CustomersMainTitle.AutoSize = true;
            CustomersMainTitle.Dock = DockStyle.Fill;
            CustomersMainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersMainTitle.Location = new Point(3, 0);
            CustomersMainTitle.Name = "CustomersMainTitle";
            CustomersMainTitle.Size = new Size(1135, 62);
            CustomersMainTitle.TabIndex = 0;
            CustomersMainTitle.Text = "Картотека";
            CustomersMainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(CustomerSearchText, 1, 1);
            tableLayoutPanel5.Controls.Add(CustomerSearchLabel, 2, 0);
            tableLayoutPanel5.Controls.Add(CustomerSearchTextLabel, 1, 0);
            tableLayoutPanel5.Controls.Add(CustomerSearchTypeLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 2, 1);
            tableLayoutPanel5.Controls.Add(CustomerSearchType, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 65);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1135, 98);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // CustomerSearchText
            // 
            CustomerSearchText.BackColor = Color.FromArgb(251, 234, 235);
            CustomerSearchText.BorderStyle = BorderStyle.FixedSingle;
            CustomerSearchText.Dock = DockStyle.Fill;
            CustomerSearchText.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchText.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerSearchText.Location = new Point(381, 52);
            CustomerSearchText.Name = "CustomerSearchText";
            CustomerSearchText.PlaceholderText = "Текст для пошуку";
            CustomerSearchText.Size = new Size(372, 43);
            CustomerSearchText.TabIndex = 8;
            // 
            // CustomerSearchLabel
            // 
            CustomerSearchLabel.AutoSize = true;
            CustomerSearchLabel.Dock = DockStyle.Fill;
            CustomerSearchLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchLabel.Location = new Point(759, 0);
            CustomerSearchLabel.Name = "CustomerSearchLabel";
            CustomerSearchLabel.Size = new Size(373, 49);
            CustomerSearchLabel.TabIndex = 3;
            CustomerSearchLabel.Text = "Пошук";
            CustomerSearchLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerSearchTextLabel
            // 
            CustomerSearchTextLabel.AutoSize = true;
            CustomerSearchTextLabel.Dock = DockStyle.Fill;
            CustomerSearchTextLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchTextLabel.Location = new Point(381, 0);
            CustomerSearchTextLabel.Name = "CustomerSearchTextLabel";
            CustomerSearchTextLabel.Size = new Size(372, 49);
            CustomerSearchTextLabel.TabIndex = 2;
            CustomerSearchTextLabel.Text = "Текст для пошуку";
            CustomerSearchTextLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerSearchTypeLabel
            // 
            CustomerSearchTypeLabel.AutoSize = true;
            CustomerSearchTypeLabel.Dock = DockStyle.Fill;
            CustomerSearchTypeLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchTypeLabel.Location = new Point(3, 0);
            CustomerSearchTypeLabel.Name = "CustomerSearchTypeLabel";
            CustomerSearchTypeLabel.Size = new Size(372, 49);
            CustomerSearchTypeLabel.TabIndex = 1;
            CustomerSearchTypeLabel.Text = "Тип пошуку";
            CustomerSearchTypeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(CustomerShowAllButton, 0, 0);
            tableLayoutPanel6.Controls.Add(CustomerSearchButton, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(759, 52);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(373, 43);
            tableLayoutPanel6.TabIndex = 9;
            // 
            // CustomerShowAllButton
            // 
            CustomerShowAllButton.Dock = DockStyle.Fill;
            CustomerShowAllButton.FlatAppearance.BorderSize = 4;
            CustomerShowAllButton.FlatStyle = FlatStyle.Flat;
            CustomerShowAllButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerShowAllButton.Location = new Point(189, 3);
            CustomerShowAllButton.Name = "CustomerShowAllButton";
            CustomerShowAllButton.Size = new Size(181, 37);
            CustomerShowAllButton.TabIndex = 7;
            CustomerShowAllButton.Text = "Show All";
            CustomerShowAllButton.UseVisualStyleBackColor = false;
            CustomerShowAllButton.Click += CustomerShowAllButton_Click;
            // 
            // CustomerSearchButton
            // 
            CustomerSearchButton.Dock = DockStyle.Fill;
            CustomerSearchButton.FlatAppearance.BorderSize = 4;
            CustomerSearchButton.FlatStyle = FlatStyle.Flat;
            CustomerSearchButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchButton.Location = new Point(3, 3);
            CustomerSearchButton.Name = "CustomerSearchButton";
            CustomerSearchButton.Size = new Size(180, 37);
            CustomerSearchButton.TabIndex = 6;
            CustomerSearchButton.Text = "Search";
            CustomerSearchButton.UseVisualStyleBackColor = false;
            CustomerSearchButton.Click += CustomerSearchButton_Click;
            // 
            // CustomerSearchType
            // 
            CustomerSearchType.BackColor = Color.FromArgb(251, 234, 235);
            CustomerSearchType.Dock = DockStyle.Fill;
            CustomerSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomerSearchType.Font = new Font("Bookman Old Style", 17F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSearchType.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerSearchType.FormattingEnabled = true;
            CustomerSearchType.Items.AddRange(new object[] { "ID", "Ім`я", "Прізвище", "По-батькові", "Адреса", "Телефон", "ID знижки" });
            CustomerSearchType.Location = new Point(3, 52);
            CustomerSearchType.Name = "CustomerSearchType";
            CustomerSearchType.Size = new Size(372, 41);
            CustomerSearchType.TabIndex = 10;
            // 
            // CustomerControlPanel
            // 
            CustomerControlPanel.BackColor = Color.FromArgb(47, 60, 126);
            CustomerControlPanel.Controls.Add(CustomerControlLayout);
            CustomerControlPanel.Dock = DockStyle.Left;
            CustomerControlPanel.Location = new Point(3, 3);
            CustomerControlPanel.Name = "CustomerControlPanel";
            CustomerControlPanel.Size = new Size(250, 703);
            CustomerControlPanel.TabIndex = 1;
            // 
            // CustomerControlLayout
            // 
            CustomerControlLayout.BackColor = Color.FromArgb(47, 60, 126);
            CustomerControlLayout.ColumnCount = 1;
            CustomerControlLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CustomerControlLayout.Controls.Add(DeleteCustomerButton, 0, 5);
            CustomerControlLayout.Controls.Add(ChangeCustomerButton, 0, 3);
            CustomerControlLayout.Controls.Add(DeleteCusomerLabel, 0, 4);
            CustomerControlLayout.Controls.Add(ChangeCustomerLabel, 0, 2);
            CustomerControlLayout.Controls.Add(AddCustomerLabel, 0, 0);
            CustomerControlLayout.Controls.Add(AddCustomerButton, 0, 1);
            CustomerControlLayout.Dock = DockStyle.Fill;
            CustomerControlLayout.ForeColor = Color.FromArgb(251, 234, 235);
            CustomerControlLayout.Location = new Point(0, 0);
            CustomerControlLayout.Name = "CustomerControlLayout";
            CustomerControlLayout.RowCount = 6;
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            CustomerControlLayout.Size = new Size(250, 703);
            CustomerControlLayout.TabIndex = 0;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Dock = DockStyle.Fill;
            DeleteCustomerButton.FlatAppearance.BorderSize = 3;
            DeleteCustomerButton.FlatStyle = FlatStyle.Flat;
            DeleteCustomerButton.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCustomerButton.Location = new Point(3, 588);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new Size(244, 112);
            DeleteCustomerButton.TabIndex = 6;
            DeleteCustomerButton.Text = "Delete";
            DeleteCustomerButton.UseVisualStyleBackColor = false;
            // 
            // ChangeCustomerButton
            // 
            ChangeCustomerButton.Dock = DockStyle.Fill;
            ChangeCustomerButton.FlatAppearance.BorderSize = 3;
            ChangeCustomerButton.FlatStyle = FlatStyle.Flat;
            ChangeCustomerButton.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeCustomerButton.Location = new Point(3, 354);
            ChangeCustomerButton.Name = "ChangeCustomerButton";
            ChangeCustomerButton.Size = new Size(244, 111);
            ChangeCustomerButton.TabIndex = 5;
            ChangeCustomerButton.Text = "Change";
            ChangeCustomerButton.UseVisualStyleBackColor = false;
            // 
            // DeleteCusomerLabel
            // 
            DeleteCusomerLabel.AutoSize = true;
            DeleteCusomerLabel.Dock = DockStyle.Fill;
            DeleteCusomerLabel.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteCusomerLabel.Location = new Point(3, 468);
            DeleteCusomerLabel.Name = "DeleteCusomerLabel";
            DeleteCusomerLabel.Size = new Size(244, 117);
            DeleteCusomerLabel.TabIndex = 3;
            DeleteCusomerLabel.Text = "Видалити клієнта";
            DeleteCusomerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangeCustomerLabel
            // 
            ChangeCustomerLabel.AutoSize = true;
            ChangeCustomerLabel.Dock = DockStyle.Fill;
            ChangeCustomerLabel.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeCustomerLabel.Location = new Point(3, 234);
            ChangeCustomerLabel.Name = "ChangeCustomerLabel";
            ChangeCustomerLabel.Size = new Size(244, 117);
            ChangeCustomerLabel.TabIndex = 2;
            ChangeCustomerLabel.Text = "Змінити дані клієнта";
            ChangeCustomerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCustomerLabel
            // 
            AddCustomerLabel.AutoSize = true;
            AddCustomerLabel.Dock = DockStyle.Fill;
            AddCustomerLabel.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerLabel.Location = new Point(3, 0);
            AddCustomerLabel.Name = "AddCustomerLabel";
            AddCustomerLabel.Size = new Size(244, 117);
            AddCustomerLabel.TabIndex = 1;
            AddCustomerLabel.Text = "Додати клієнта";
            AddCustomerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Dock = DockStyle.Fill;
            AddCustomerButton.FlatAppearance.BorderSize = 4;
            AddCustomerButton.FlatStyle = FlatStyle.Flat;
            AddCustomerButton.Font = new Font("Bookman Old Style", 20F, FontStyle.Regular, GraphicsUnit.Point);
            AddCustomerButton.Location = new Point(3, 120);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(244, 111);
            AddCustomerButton.TabIndex = 4;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = false;
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
            BooksTab.ResumeLayout(false);
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
            CustomersTab.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomersTable).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            CustomerControlPanel.ResumeLayout(false);
            CustomerControlLayout.ResumeLayout(false);
            CustomerControlLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Tabs;
        private TabPage BooksTab;
        private Panel BooksMainPanel;
        private Panel BooksLowerPart;
        private Panel BooksUpperPart;
        private TableLayoutPanel BooksUpperPartLayout;
        private Label BooksMainTitle;
        private Panel BooksControlPanel;
        private TabPage CustomersTab;
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
        private Panel panel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel2;
        public DataGridView CustomersTable;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CustomersLastPageButton;
        private Button CustomersNextPageButton;
        private Button CustomersPrevPageButton;
        private Button CustomersFirstPageButton;
        public Label CustomerPageLabel;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label CustomersMainTitle;
        private TableLayoutPanel tableLayoutPanel5;
        public TextBox CustomerSearchText;
        private Label CustomerSearchLabel;
        private Label CustomerSearchTextLabel;
        private Label CustomerSearchTypeLabel;
        private TableLayoutPanel tableLayoutPanel6;
        private Button CustomerShowAllButton;
        private Button CustomerSearchButton;
        public ComboBox CustomerSearchType;
        private Panel CustomerControlPanel;
        private TableLayoutPanel CustomerControlLayout;
        private Button DeleteCustomerButton;
        private Button ChangeCustomerButton;
        private Label DeleteCusomerLabel;
        private Label ChangeCustomerLabel;
        private Label AddCustomerLabel;
        private Button AddCustomerButton;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerFullName;
        private DataGridViewTextBoxColumn CustomerAddress;
        private DataGridViewTextBoxColumn CustomerPhone;
        private DataGridViewTextBoxColumn CustomerDiscountId;
    }
}