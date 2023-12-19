namespace DBS_Course_Work_3kurs.AdditionalForms.BookForms
{
    partial class ChangeBook
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
            ChangeBookMainPanel = new Panel();
            MainDataPanel = new Panel();
            DataLayout = new TableLayoutPanel();
            BookGenre = new TextBox();
            BookAuthor = new TextBox();
            BookGenreLabel = new Label();
            BookAuthorLabel = new Label();
            BookTitleLabel = new Label();
            LableRowLayout = new TableLayoutPanel();
            BookValueLabel = new Label();
            BookQuantityLabel = new Label();
            ButtonRowLayout = new TableLayoutPanel();
            BookValue = new TextBox();
            BookQuantity = new TextBox();
            BookTitle = new TextBox();
            RightSideBar = new Panel();
            LeftSideBar = new Panel();
            TitlePanel = new Panel();
            MainTitle = new Label();
            ButtonsPanel = new Panel();
            ButtonsLayout = new TableLayoutPanel();
            CancelButton = new Button();
            ChangeButton = new Button();
            ChangeBookMainPanel.SuspendLayout();
            MainDataPanel.SuspendLayout();
            DataLayout.SuspendLayout();
            LableRowLayout.SuspendLayout();
            ButtonRowLayout.SuspendLayout();
            TitlePanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            ButtonsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ChangeBookMainPanel
            // 
            ChangeBookMainPanel.Controls.Add(MainDataPanel);
            ChangeBookMainPanel.Controls.Add(RightSideBar);
            ChangeBookMainPanel.Controls.Add(LeftSideBar);
            ChangeBookMainPanel.Controls.Add(TitlePanel);
            ChangeBookMainPanel.Controls.Add(ButtonsPanel);
            ChangeBookMainPanel.Dock = DockStyle.Fill;
            ChangeBookMainPanel.Location = new Point(0, 0);
            ChangeBookMainPanel.Name = "ChangeBookMainPanel";
            ChangeBookMainPanel.Size = new Size(1025, 596);
            ChangeBookMainPanel.TabIndex = 1;
            // 
            // MainDataPanel
            // 
            MainDataPanel.Controls.Add(DataLayout);
            MainDataPanel.Dock = DockStyle.Fill;
            MainDataPanel.Location = new Point(50, 69);
            MainDataPanel.Name = "MainDataPanel";
            MainDataPanel.Size = new Size(925, 452);
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
            DataLayout.Size = new Size(925, 452);
            DataLayout.TabIndex = 0;
            // 
            // BookGenre
            // 
            BookGenre.BackColor = Color.FromArgb(251, 234, 235);
            BookGenre.BorderStyle = BorderStyle.FixedSingle;
            BookGenre.Dock = DockStyle.Fill;
            BookGenre.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookGenre.ForeColor = Color.FromArgb(47, 60, 126);
            BookGenre.Location = new Point(3, 283);
            BookGenre.Name = "BookGenre";
            BookGenre.PlaceholderText = "Жанр книги";
            BookGenre.Size = new Size(919, 43);
            BookGenre.TabIndex = 9;
            // 
            // BookAuthor
            // 
            BookAuthor.BackColor = Color.FromArgb(251, 234, 235);
            BookAuthor.BorderStyle = BorderStyle.FixedSingle;
            BookAuthor.Dock = DockStyle.Fill;
            BookAuthor.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookAuthor.ForeColor = Color.FromArgb(47, 60, 126);
            BookAuthor.Location = new Point(3, 171);
            BookAuthor.Name = "BookAuthor";
            BookAuthor.PlaceholderText = "Автор книги";
            BookAuthor.Size = new Size(919, 43);
            BookAuthor.TabIndex = 8;
            // 
            // BookGenreLabel
            // 
            BookGenreLabel.Dock = DockStyle.Fill;
            BookGenreLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookGenreLabel.Location = new Point(3, 224);
            BookGenreLabel.Name = "BookGenreLabel";
            BookGenreLabel.Size = new Size(919, 56);
            BookGenreLabel.TabIndex = 4;
            BookGenreLabel.Text = "Жанр книги";
            BookGenreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookAuthorLabel
            // 
            BookAuthorLabel.Dock = DockStyle.Fill;
            BookAuthorLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookAuthorLabel.Location = new Point(3, 112);
            BookAuthorLabel.Name = "BookAuthorLabel";
            BookAuthorLabel.Size = new Size(919, 56);
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
            BookTitleLabel.Size = new Size(919, 56);
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
            LableRowLayout.Location = new Point(3, 339);
            LableRowLayout.Name = "LableRowLayout";
            LableRowLayout.RowCount = 1;
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.Size = new Size(919, 50);
            LableRowLayout.TabIndex = 5;
            // 
            // BookValueLabel
            // 
            BookValueLabel.Dock = DockStyle.Fill;
            BookValueLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            BookValueLabel.Location = new Point(462, 0);
            BookValueLabel.Name = "BookValueLabel";
            BookValueLabel.Size = new Size(454, 50);
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
            BookQuantityLabel.Size = new Size(453, 50);
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
            ButtonRowLayout.Location = new Point(3, 395);
            ButtonRowLayout.Name = "ButtonRowLayout";
            ButtonRowLayout.RowCount = 1;
            ButtonRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ButtonRowLayout.Size = new Size(919, 54);
            ButtonRowLayout.TabIndex = 6;
            // 
            // BookValue
            // 
            BookValue.BackColor = Color.FromArgb(251, 234, 235);
            BookValue.BorderStyle = BorderStyle.FixedSingle;
            BookValue.Dock = DockStyle.Fill;
            BookValue.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookValue.ForeColor = Color.FromArgb(47, 60, 126);
            BookValue.Location = new Point(462, 3);
            BookValue.Name = "BookValue";
            BookValue.PlaceholderText = "Заставна вартість";
            BookValue.Size = new Size(454, 43);
            BookValue.TabIndex = 11;
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
            BookQuantity.Size = new Size(453, 43);
            BookQuantity.TabIndex = 10;
            // 
            // BookTitle
            // 
            BookTitle.BackColor = Color.FromArgb(251, 234, 235);
            BookTitle.BorderStyle = BorderStyle.FixedSingle;
            BookTitle.Dock = DockStyle.Fill;
            BookTitle.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitle.ForeColor = Color.FromArgb(47, 60, 126);
            BookTitle.Location = new Point(3, 59);
            BookTitle.Name = "BookTitle";
            BookTitle.PlaceholderText = "Назва книги";
            BookTitle.Size = new Size(919, 43);
            BookTitle.TabIndex = 7;
            // 
            // RightSideBar
            // 
            RightSideBar.Dock = DockStyle.Right;
            RightSideBar.Location = new Point(975, 69);
            RightSideBar.Name = "RightSideBar";
            RightSideBar.Size = new Size(50, 452);
            RightSideBar.TabIndex = 3;
            // 
            // LeftSideBar
            // 
            LeftSideBar.Dock = DockStyle.Left;
            LeftSideBar.Location = new Point(0, 69);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(50, 452);
            LeftSideBar.TabIndex = 2;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(MainTitle);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1025, 69);
            TitlePanel.TabIndex = 1;
            // 
            // MainTitle
            // 
            MainTitle.Dock = DockStyle.Fill;
            MainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MainTitle.Location = new Point(0, 0);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(1025, 69);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "Змінити книгу";
            MainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(ButtonsLayout);
            ButtonsPanel.Dock = DockStyle.Bottom;
            ButtonsPanel.Location = new Point(0, 521);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(1025, 75);
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
            ButtonsLayout.Controls.Add(ChangeButton, 1, 0);
            ButtonsLayout.Dock = DockStyle.Fill;
            ButtonsLayout.Location = new Point(0, 0);
            ButtonsLayout.Name = "ButtonsLayout";
            ButtonsLayout.RowCount = 1;
            ButtonsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsLayout.Size = new Size(1025, 75);
            ButtonsLayout.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderSize = 4;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(540, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(224, 69);
            CancelButton.TabIndex = 6;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // ChangeButton
            // 
            ChangeButton.Dock = DockStyle.Fill;
            ChangeButton.FlatAppearance.BorderSize = 4;
            ChangeButton.FlatStyle = FlatStyle.Flat;
            ChangeButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeButton.Location = new Point(259, 3);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(224, 69);
            ChangeButton.TabIndex = 5;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ChangeBook
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 234, 235);
            ClientSize = new Size(1025, 596);
            Controls.Add(ChangeBookMainPanel);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(47, 60, 126);
            Name = "ChangeBook";
            Text = "ChangeBook";
            ChangeBookMainPanel.ResumeLayout(false);
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

        private Panel ChangeBookMainPanel;
        private Panel MainDataPanel;
        private TableLayoutPanel DataLayout;
        private TextBox BookGenre;
        private TextBox BookAuthor;
        private Label BookGenreLabel;
        private Label BookAuthorLabel;
        private Label BookTitleLabel;
        private TableLayoutPanel LableRowLayout;
        private Label BookValueLabel;
        private Label BookQuantityLabel;
        private TableLayoutPanel ButtonRowLayout;
        private TextBox BookValue;
        private TextBox BookQuantity;
        private TextBox BookTitle;
        private Panel RightSideBar;
        private Panel LeftSideBar;
        private Panel TitlePanel;
        private Label MainTitle;
        private Panel ButtonsPanel;
        private TableLayoutPanel ButtonsLayout;
        private Button CancelButton;
        private Button ChangeButton;
    }
}