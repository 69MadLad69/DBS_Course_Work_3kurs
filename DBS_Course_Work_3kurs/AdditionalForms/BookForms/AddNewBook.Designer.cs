namespace DBS_Course_Work_3kurs.AdditionalForms.BookForms
{
    partial class AddNewBook
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
            AddBookMainPanel = new Panel();
            MainDataPanel = new Panel();
            DataLayout = new TableLayoutPanel();
            BookGenreLabel = new Label();
            BookAuthorLabel = new Label();
            BookTitleLabel = new Label();
            LableRowLayout = new TableLayoutPanel();
            BookValueLabel = new Label();
            BookQuantityLabel = new Label();
            ButtonRowLayout = new TableLayoutPanel();
            BookTitle = new TextBox();
            RightSideBar = new Panel();
            LeftSideBar = new Panel();
            TitlePanel = new Panel();
            MainTitle = new Label();
            ButtonsPanel = new Panel();
            ButtonsLayout = new TableLayoutPanel();
            CancelButton = new Button();
            AddButton = new Button();
            BookAuthor = new TextBox();
            BookGenre = new TextBox();
            BookQuantity = new TextBox();
            BookValue = new TextBox();
            AddBookMainPanel.SuspendLayout();
            MainDataPanel.SuspendLayout();
            DataLayout.SuspendLayout();
            LableRowLayout.SuspendLayout();
            ButtonRowLayout.SuspendLayout();
            TitlePanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            ButtonsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // AddBookMainPanel
            // 
            AddBookMainPanel.Controls.Add(MainDataPanel);
            AddBookMainPanel.Controls.Add(RightSideBar);
            AddBookMainPanel.Controls.Add(LeftSideBar);
            AddBookMainPanel.Controls.Add(TitlePanel);
            AddBookMainPanel.Controls.Add(ButtonsPanel);
            AddBookMainPanel.Dock = DockStyle.Fill;
            AddBookMainPanel.Location = new Point(0, 0);
            AddBookMainPanel.Name = "AddBookMainPanel";
            AddBookMainPanel.Size = new Size(1056, 581);
            AddBookMainPanel.TabIndex = 0;
            // 
            // MainDataPanel
            // 
            MainDataPanel.Controls.Add(DataLayout);
            MainDataPanel.Dock = DockStyle.Fill;
            MainDataPanel.Location = new Point(50, 69);
            MainDataPanel.Name = "MainDataPanel";
            MainDataPanel.Size = new Size(956, 437);
            MainDataPanel.TabIndex = 4;
            // 
            // DataLayout
            // 
            DataLayout.ColumnCount = 1;
            DataLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DataLayout.Controls.Add(BookGenre, 0, 5);
            DataLayout.Controls.Add(BookAuthor, 0, 3);
            DataLayout.Controls.Add(BookGenreLabel, 0, 4);
            DataLayout.Controls.Add(BookAuthorLabel, 0, 2);
            DataLayout.Controls.Add(BookTitleLabel, 0, 0);
            DataLayout.Controls.Add(LableRowLayout, 0, 6);
            DataLayout.Controls.Add(ButtonRowLayout, 0, 7);
            DataLayout.Controls.Add(BookTitle, 0, 1);
            DataLayout.Dock = DockStyle.Fill;
            DataLayout.Location = new Point(0, 0);
            DataLayout.Name = "DataLayout";
            DataLayout.RowCount = 8;
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            DataLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DataLayout.Size = new Size(956, 437);
            DataLayout.TabIndex = 0;
            // 
            // BookGenreLabel
            // 
            BookGenreLabel.Dock = DockStyle.Fill;
            BookGenreLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookGenreLabel.Location = new Point(3, 216);
            BookGenreLabel.Name = "BookGenreLabel";
            BookGenreLabel.Size = new Size(950, 54);
            BookGenreLabel.TabIndex = 4;
            BookGenreLabel.Text = "Жанр книги";
            BookGenreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookAuthorLabel
            // 
            BookAuthorLabel.Dock = DockStyle.Fill;
            BookAuthorLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookAuthorLabel.Location = new Point(3, 108);
            BookAuthorLabel.Name = "BookAuthorLabel";
            BookAuthorLabel.Size = new Size(950, 54);
            BookAuthorLabel.TabIndex = 3;
            BookAuthorLabel.Text = "Автор книги";
            BookAuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.Dock = DockStyle.Fill;
            BookTitleLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitleLabel.Location = new Point(3, 0);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(950, 54);
            BookTitleLabel.TabIndex = 2;
            BookTitleLabel.Text = "Назва книги";
            BookTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LableRowLayout
            // 
            LableRowLayout.ColumnCount = 2;
            LableRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LableRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LableRowLayout.Controls.Add(BookValueLabel, 0, 0);
            LableRowLayout.Controls.Add(BookQuantityLabel, 0, 0);
            LableRowLayout.Dock = DockStyle.Fill;
            LableRowLayout.Location = new Point(3, 327);
            LableRowLayout.Name = "LableRowLayout";
            LableRowLayout.RowCount = 1;
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.Size = new Size(950, 48);
            LableRowLayout.TabIndex = 5;
            // 
            // BookValueLabel
            // 
            BookValueLabel.Dock = DockStyle.Fill;
            BookValueLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookValueLabel.Location = new Point(478, 0);
            BookValueLabel.Name = "BookValueLabel";
            BookValueLabel.Size = new Size(469, 48);
            BookValueLabel.TabIndex = 5;
            BookValueLabel.Text = "Заставна вартість";
            BookValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookQuantityLabel
            // 
            BookQuantityLabel.Dock = DockStyle.Fill;
            BookQuantityLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookQuantityLabel.Location = new Point(3, 0);
            BookQuantityLabel.Name = "BookQuantityLabel";
            BookQuantityLabel.Size = new Size(469, 48);
            BookQuantityLabel.TabIndex = 4;
            BookQuantityLabel.Text = "Кількість екземплярів";
            BookQuantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonRowLayout
            // 
            ButtonRowLayout.ColumnCount = 2;
            ButtonRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonRowLayout.Controls.Add(BookValue, 0, 0);
            ButtonRowLayout.Controls.Add(BookQuantity, 0, 0);
            ButtonRowLayout.Dock = DockStyle.Fill;
            ButtonRowLayout.Location = new Point(3, 381);
            ButtonRowLayout.Name = "ButtonRowLayout";
            ButtonRowLayout.RowCount = 1;
            ButtonRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonRowLayout.Size = new Size(950, 53);
            ButtonRowLayout.TabIndex = 6;
            // 
            // BookTitle
            // 
            BookTitle.BackColor = Color.FromArgb(251, 234, 235);
            BookTitle.BorderStyle = BorderStyle.FixedSingle;
            BookTitle.Dock = DockStyle.Fill;
            BookTitle.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitle.ForeColor = Color.FromArgb(47, 60, 126);
            BookTitle.Location = new Point(3, 57);
            BookTitle.Name = "BookTitle";
            BookTitle.PlaceholderText = "Назва книги";
            BookTitle.Size = new Size(950, 43);
            BookTitle.TabIndex = 7;
            // 
            // RightSideBar
            // 
            RightSideBar.Dock = DockStyle.Right;
            RightSideBar.Location = new Point(1006, 69);
            RightSideBar.Name = "RightSideBar";
            RightSideBar.Size = new Size(50, 437);
            RightSideBar.TabIndex = 3;
            // 
            // LeftSideBar
            // 
            LeftSideBar.Dock = DockStyle.Left;
            LeftSideBar.Location = new Point(0, 69);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(50, 437);
            LeftSideBar.TabIndex = 2;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(MainTitle);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1056, 69);
            TitlePanel.TabIndex = 1;
            // 
            // MainTitle
            // 
            MainTitle.Dock = DockStyle.Fill;
            MainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MainTitle.Location = new Point(0, 0);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(1056, 69);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "Додати книгу";
            MainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(ButtonsLayout);
            ButtonsPanel.Dock = DockStyle.Bottom;
            ButtonsPanel.Location = new Point(0, 506);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(1056, 75);
            ButtonsPanel.TabIndex = 0;
            // 
            // ButtonsLayout
            // 
            ButtonsLayout.ColumnCount = 5;
            ButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            ButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            ButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            ButtonsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ButtonsLayout.Controls.Add(CancelButton, 3, 0);
            ButtonsLayout.Controls.Add(AddButton, 1, 0);
            ButtonsLayout.Dock = DockStyle.Fill;
            ButtonsLayout.Location = new Point(0, 0);
            ButtonsLayout.Name = "ButtonsLayout";
            ButtonsLayout.RowCount = 1;
            ButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsLayout.Size = new Size(1056, 75);
            ButtonsLayout.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderSize = 4;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(556, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(231, 69);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.FlatAppearance.BorderSize = 4;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(267, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(231, 69);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // BookAuthor
            // 
            BookAuthor.BackColor = Color.FromArgb(251, 234, 235);
            BookAuthor.BorderStyle = BorderStyle.FixedSingle;
            BookAuthor.Dock = DockStyle.Fill;
            BookAuthor.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookAuthor.ForeColor = Color.FromArgb(47, 60, 126);
            BookAuthor.Location = new Point(3, 165);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.PlaceholderText = "Автор книги";
            BookAuthor.Size = new Size(950, 43);
            BookAuthor.TabIndex = 8;
            // 
            // BookGenre
            // 
            BookGenre.BackColor = Color.FromArgb(251, 234, 235);
            BookGenre.BorderStyle = BorderStyle.FixedSingle;
            BookGenre.Dock = DockStyle.Fill;
            BookGenre.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookGenre.ForeColor = Color.FromArgb(47, 60, 126);
            BookGenre.Location = new Point(3, 273);
            BookGenre.Name = "BookGenre";
            BookGenre.PlaceholderText = "Жанр книги";
            BookGenre.Size = new Size(950, 43);
            BookGenre.TabIndex = 9;
            // 
            // BookQuantity
            // 
            BookQuantity.BackColor = Color.FromArgb(251, 234, 235);
            BookQuantity.BorderStyle = BorderStyle.FixedSingle;
            BookQuantity.Dock = DockStyle.Fill;
            BookQuantity.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookQuantity.ForeColor = Color.FromArgb(47, 60, 126);
            BookQuantity.Location = new Point(3, 3);
            BookQuantity.Name = "BookQuantity";
            BookQuantity.PlaceholderText = "Кількість екземплярів";
            BookQuantity.Size = new Size(469, 43);
            BookQuantity.TabIndex = 10;
            // 
            // BookValue
            // 
            BookValue.BackColor = Color.FromArgb(251, 234, 235);
            BookValue.BorderStyle = BorderStyle.FixedSingle;
            BookValue.Dock = DockStyle.Fill;
            BookValue.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookValue.ForeColor = Color.FromArgb(47, 60, 126);
            BookValue.Location = new Point(478, 3);
            BookValue.Name = "BookValue";
            BookValue.PlaceholderText = "Заставна вартість";
            BookValue.Size = new Size(469, 43);
            BookValue.TabIndex = 11;
            // 
            // AddNewBook
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 234, 235);
            ClientSize = new Size(1056, 581);
            Controls.Add(AddBookMainPanel);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(47, 60, 126);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AddNewBook";
            Text = "AddNewBook";
            AddBookMainPanel.ResumeLayout(false);
            MainDataPanel.ResumeLayout(false);
            DataLayout.ResumeLayout(false);
            DataLayout.PerformLayout();
            LableRowLayout.ResumeLayout(false);
            ButtonRowLayout.ResumeLayout(false);
            ButtonRowLayout.PerformLayout();
            TitlePanel.ResumeLayout(false);
            ButtonsPanel.ResumeLayout(false);
            ButtonsLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel AddBookMainPanel;
        private Panel ButtonsPanel;
        private TableLayoutPanel ButtonsLayout;
        private Panel TitlePanel;
        private Button CancelButton;
        private Button AddButton;
        private Panel RightSideBar;
        private Panel LeftSideBar;
        private Label MainTitle;
        private Panel MainDataPanel;
        private TableLayoutPanel DataLayout;
        private Label BookAuthorLabel;
        private Label BookTitleLabel;
        private Label BookGenreLabel;
        private TableLayoutPanel LableRowLayout;
        private Label BookValueLabel;
        private Label BookQuantityLabel;
        private TableLayoutPanel ButtonRowLayout;
        private TextBox BookTitle;
        private TextBox BookGenre;
        private TextBox BookAuthor;
        private TextBox BookValue;
        private TextBox BookQuantity;
    }
}