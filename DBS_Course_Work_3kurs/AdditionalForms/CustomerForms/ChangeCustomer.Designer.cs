namespace DBS_Course_Work_3kurs.AdditionalForms.CustomerForms
{
    partial class ChangeCustomer
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
            ChangeCustomerMainPanel = new Panel();
            MainDataPanel = new Panel();
            DataLayout = new TableLayoutPanel();
            TextBoxRowLayout = new TableLayoutPanel();
            CustomerDiscountId = new TextBox();
            CustomerDiscountLayout = new TableLayoutPanel();
            SeeFullDiscount = new Button();
            CustomerDiscountDesc = new Label();
            LableRowLayout = new TableLayoutPanel();
            CustomerDiscountLabel = new Label();
            CustomerDiscountIdLabel = new Label();
            CustomerPhone = new TextBox();
            CustomerAddress = new TextBox();
            CustomerPhoneLabel = new Label();
            CustomerAddressLabel = new Label();
            FullNameLabelsLayout = new TableLayoutPanel();
            CustomerPaternalNameLabel = new Label();
            CustomerSurnameLabel = new Label();
            CustomerNameLabel = new Label();
            FullNameLayout = new TableLayoutPanel();
            CustomerPaternalName = new TextBox();
            CustomerSurname = new TextBox();
            CustomerName = new TextBox();
            RightSideBar = new Panel();
            LeftSideBar = new Panel();
            TitlePanel = new Panel();
            MainTitle = new Label();
            ButtonsPanel = new Panel();
            ButtonsLayout = new TableLayoutPanel();
            CancelButton = new Button();
            ChangeButton = new Button();
            ChangeCustomerMainPanel.SuspendLayout();
            MainDataPanel.SuspendLayout();
            DataLayout.SuspendLayout();
            TextBoxRowLayout.SuspendLayout();
            CustomerDiscountLayout.SuspendLayout();
            LableRowLayout.SuspendLayout();
            FullNameLabelsLayout.SuspendLayout();
            FullNameLayout.SuspendLayout();
            TitlePanel.SuspendLayout();
            ButtonsPanel.SuspendLayout();
            ButtonsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ChangeCustomerMainPanel
            // 
            ChangeCustomerMainPanel.Controls.Add(MainDataPanel);
            ChangeCustomerMainPanel.Controls.Add(RightSideBar);
            ChangeCustomerMainPanel.Controls.Add(LeftSideBar);
            ChangeCustomerMainPanel.Controls.Add(TitlePanel);
            ChangeCustomerMainPanel.Controls.Add(ButtonsPanel);
            ChangeCustomerMainPanel.Dock = DockStyle.Fill;
            ChangeCustomerMainPanel.Location = new Point(0, 0);
            ChangeCustomerMainPanel.Name = "ChangeCustomerMainPanel";
            ChangeCustomerMainPanel.Size = new Size(1028, 620);
            ChangeCustomerMainPanel.TabIndex = 2;
            // 
            // MainDataPanel
            // 
            MainDataPanel.Controls.Add(DataLayout);
            MainDataPanel.Dock = DockStyle.Fill;
            MainDataPanel.Location = new Point(50, 69);
            MainDataPanel.Name = "MainDataPanel";
            MainDataPanel.Size = new Size(928, 476);
            MainDataPanel.TabIndex = 4;
            // 
            // DataLayout
            // 
            DataLayout.ColumnCount = 1;
            DataLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DataLayout.Controls.Add(TextBoxRowLayout, 0, 7);
            DataLayout.Controls.Add(LableRowLayout, 0, 6);
            DataLayout.Controls.Add(CustomerPhone, 0, 5);
            DataLayout.Controls.Add(CustomerAddress, 0, 3);
            DataLayout.Controls.Add(CustomerPhoneLabel, 0, 4);
            DataLayout.Controls.Add(CustomerAddressLabel, 0, 2);
            DataLayout.Controls.Add(FullNameLabelsLayout, 0, 0);
            DataLayout.Controls.Add(FullNameLayout, 0, 1);
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
            DataLayout.Size = new Size(928, 476);
            DataLayout.TabIndex = 0;
            // 
            // TextBoxRowLayout
            // 
            TextBoxRowLayout.ColumnCount = 2;
            TextBoxRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7807026F));
            TextBoxRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.2193F));
            TextBoxRowLayout.Controls.Add(CustomerDiscountId, 0, 0);
            TextBoxRowLayout.Controls.Add(CustomerDiscountLayout, 1, 0);
            TextBoxRowLayout.Dock = DockStyle.Fill;
            TextBoxRowLayout.Location = new Point(3, 416);
            TextBoxRowLayout.Name = "TextBoxRowLayout";
            TextBoxRowLayout.RowCount = 1;
            TextBoxRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextBoxRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextBoxRowLayout.Size = new Size(922, 57);
            TextBoxRowLayout.TabIndex = 13;
            // 
            // CustomerDiscountId
            // 
            CustomerDiscountId.BackColor = Color.FromArgb(251, 234, 235);
            CustomerDiscountId.BorderStyle = BorderStyle.FixedSingle;
            CustomerDiscountId.Dock = DockStyle.Fill;
            CustomerDiscountId.Font = new Font("Bookman Old Style", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDiscountId.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerDiscountId.Location = new Point(3, 3);
            CustomerDiscountId.Name = "CustomerDiscountId";
            CustomerDiscountId.PlaceholderText = "ID";
            CustomerDiscountId.Size = new Size(222, 51);
            CustomerDiscountId.TabIndex = 10;
            CustomerDiscountId.TextChanged += CustomerDiscountId_TextChanged;
            // 
            // CustomerDiscountLayout
            // 
            CustomerDiscountLayout.ColumnCount = 2;
            CustomerDiscountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.9117661F));
            CustomerDiscountLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.0882359F));
            CustomerDiscountLayout.Controls.Add(SeeFullDiscount, 0, 0);
            CustomerDiscountLayout.Controls.Add(CustomerDiscountDesc, 0, 0);
            CustomerDiscountLayout.Dock = DockStyle.Fill;
            CustomerDiscountLayout.Location = new Point(231, 3);
            CustomerDiscountLayout.Name = "CustomerDiscountLayout";
            CustomerDiscountLayout.RowCount = 1;
            CustomerDiscountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomerDiscountLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            CustomerDiscountLayout.Size = new Size(688, 51);
            CustomerDiscountLayout.TabIndex = 11;
            // 
            // SeeFullDiscount
            // 
            SeeFullDiscount.Dock = DockStyle.Fill;
            SeeFullDiscount.FlatAppearance.BorderSize = 4;
            SeeFullDiscount.FlatStyle = FlatStyle.Flat;
            SeeFullDiscount.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SeeFullDiscount.Location = new Point(566, 3);
            SeeFullDiscount.Name = "SeeFullDiscount";
            SeeFullDiscount.Size = new Size(119, 45);
            SeeFullDiscount.TabIndex = 7;
            SeeFullDiscount.Text = "See Full";
            SeeFullDiscount.UseVisualStyleBackColor = false;
            SeeFullDiscount.Click += SeeFullDiscount_Click;
            // 
            // CustomerDiscountDesc
            // 
            CustomerDiscountDesc.BorderStyle = BorderStyle.FixedSingle;
            CustomerDiscountDesc.Dock = DockStyle.Fill;
            CustomerDiscountDesc.Font = new Font("Bookman Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDiscountDesc.Location = new Point(3, 0);
            CustomerDiscountDesc.Name = "CustomerDiscountDesc";
            CustomerDiscountDesc.Size = new Size(557, 51);
            CustomerDiscountDesc.TabIndex = 6;
            CustomerDiscountDesc.Text = "Опис знижки";
            CustomerDiscountDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LableRowLayout
            // 
            LableRowLayout.ColumnCount = 2;
            LableRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5614033F));
            LableRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.4386F));
            LableRowLayout.Controls.Add(CustomerDiscountLabel, 0, 0);
            LableRowLayout.Controls.Add(CustomerDiscountIdLabel, 0, 0);
            LableRowLayout.Dock = DockStyle.Fill;
            LableRowLayout.Location = new Point(3, 357);
            LableRowLayout.Name = "LableRowLayout";
            LableRowLayout.RowCount = 1;
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LableRowLayout.Size = new Size(922, 53);
            LableRowLayout.TabIndex = 12;
            // 
            // CustomerDiscountLabel
            // 
            CustomerDiscountLabel.Dock = DockStyle.Fill;
            CustomerDiscountLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDiscountLabel.Location = new Point(229, 0);
            CustomerDiscountLabel.Name = "CustomerDiscountLabel";
            CustomerDiscountLabel.Size = new Size(690, 53);
            CustomerDiscountLabel.TabIndex = 5;
            CustomerDiscountLabel.Text = "Опис знижки";
            CustomerDiscountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerDiscountIdLabel
            // 
            CustomerDiscountIdLabel.Dock = DockStyle.Fill;
            CustomerDiscountIdLabel.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDiscountIdLabel.Location = new Point(3, 0);
            CustomerDiscountIdLabel.Name = "CustomerDiscountIdLabel";
            CustomerDiscountIdLabel.Size = new Size(220, 53);
            CustomerDiscountIdLabel.TabIndex = 4;
            CustomerDiscountIdLabel.Text = "ID Знижки";
            CustomerDiscountIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerPhone
            // 
            CustomerPhone.BackColor = Color.FromArgb(251, 234, 235);
            CustomerPhone.BorderStyle = BorderStyle.FixedSingle;
            CustomerPhone.Dock = DockStyle.Fill;
            CustomerPhone.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhone.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerPhone.Location = new Point(3, 298);
            CustomerPhone.Name = "CustomerPhone";
            CustomerPhone.PlaceholderText = "Телефон";
            CustomerPhone.Size = new Size(922, 43);
            CustomerPhone.TabIndex = 9;
            // 
            // CustomerAddress
            // 
            CustomerAddress.BackColor = Color.FromArgb(251, 234, 235);
            CustomerAddress.BorderStyle = BorderStyle.FixedSingle;
            CustomerAddress.Dock = DockStyle.Fill;
            CustomerAddress.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerAddress.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerAddress.Location = new Point(3, 180);
            CustomerAddress.Name = "CustomerAddress";
            CustomerAddress.PlaceholderText = "Адреса";
            CustomerAddress.Size = new Size(922, 43);
            CustomerAddress.TabIndex = 8;
            // 
            // CustomerPhoneLabel
            // 
            CustomerPhoneLabel.Dock = DockStyle.Fill;
            CustomerPhoneLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPhoneLabel.Location = new Point(3, 236);
            CustomerPhoneLabel.Name = "CustomerPhoneLabel";
            CustomerPhoneLabel.Size = new Size(922, 59);
            CustomerPhoneLabel.TabIndex = 4;
            CustomerPhoneLabel.Text = "Телефон";
            CustomerPhoneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerAddressLabel
            // 
            CustomerAddressLabel.Dock = DockStyle.Fill;
            CustomerAddressLabel.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerAddressLabel.Location = new Point(3, 118);
            CustomerAddressLabel.Name = "CustomerAddressLabel";
            CustomerAddressLabel.Size = new Size(922, 59);
            CustomerAddressLabel.TabIndex = 3;
            CustomerAddressLabel.Text = "Адреса";
            CustomerAddressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLabelsLayout
            // 
            FullNameLabelsLayout.ColumnCount = 3;
            FullNameLabelsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLabelsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLabelsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLabelsLayout.Controls.Add(CustomerPaternalNameLabel, 2, 0);
            FullNameLabelsLayout.Controls.Add(CustomerSurnameLabel, 1, 0);
            FullNameLabelsLayout.Controls.Add(CustomerNameLabel, 0, 0);
            FullNameLabelsLayout.Dock = DockStyle.Fill;
            FullNameLabelsLayout.Location = new Point(3, 3);
            FullNameLabelsLayout.Name = "FullNameLabelsLayout";
            FullNameLabelsLayout.RowCount = 1;
            FullNameLabelsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FullNameLabelsLayout.Size = new Size(922, 53);
            FullNameLabelsLayout.TabIndex = 10;
            // 
            // CustomerPaternalNameLabel
            // 
            CustomerPaternalNameLabel.Dock = DockStyle.Fill;
            CustomerPaternalNameLabel.Font = new Font("Bookman Old Style", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPaternalNameLabel.Location = new Point(617, 0);
            CustomerPaternalNameLabel.Name = "CustomerPaternalNameLabel";
            CustomerPaternalNameLabel.Size = new Size(302, 53);
            CustomerPaternalNameLabel.TabIndex = 4;
            CustomerPaternalNameLabel.Text = "По-батькові";
            CustomerPaternalNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerSurnameLabel
            // 
            CustomerSurnameLabel.Dock = DockStyle.Fill;
            CustomerSurnameLabel.Font = new Font("Bookman Old Style", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSurnameLabel.Location = new Point(310, 0);
            CustomerSurnameLabel.Name = "CustomerSurnameLabel";
            CustomerSurnameLabel.Size = new Size(301, 53);
            CustomerSurnameLabel.TabIndex = 3;
            CustomerSurnameLabel.Text = "Прізвище";
            CustomerSurnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.Dock = DockStyle.Fill;
            CustomerNameLabel.Font = new Font("Bookman Old Style", 22F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerNameLabel.Location = new Point(3, 0);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(301, 53);
            CustomerNameLabel.TabIndex = 2;
            CustomerNameLabel.Text = "Ім`я";
            CustomerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLayout
            // 
            FullNameLayout.ColumnCount = 3;
            FullNameLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            FullNameLayout.Controls.Add(CustomerPaternalName, 2, 0);
            FullNameLayout.Controls.Add(CustomerSurname, 1, 0);
            FullNameLayout.Controls.Add(CustomerName, 0, 0);
            FullNameLayout.Dock = DockStyle.Fill;
            FullNameLayout.Location = new Point(3, 62);
            FullNameLayout.Name = "FullNameLayout";
            FullNameLayout.RowCount = 1;
            FullNameLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FullNameLayout.Size = new Size(922, 53);
            FullNameLayout.TabIndex = 11;
            // 
            // CustomerPaternalName
            // 
            CustomerPaternalName.BackColor = Color.FromArgb(251, 234, 235);
            CustomerPaternalName.BorderStyle = BorderStyle.FixedSingle;
            CustomerPaternalName.Dock = DockStyle.Fill;
            CustomerPaternalName.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerPaternalName.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerPaternalName.Location = new Point(617, 3);
            CustomerPaternalName.Name = "CustomerPaternalName";
            CustomerPaternalName.PlaceholderText = "По-батькові";
            CustomerPaternalName.Size = new Size(302, 43);
            CustomerPaternalName.TabIndex = 9;
            // 
            // CustomerSurname
            // 
            CustomerSurname.BackColor = Color.FromArgb(251, 234, 235);
            CustomerSurname.BorderStyle = BorderStyle.FixedSingle;
            CustomerSurname.Dock = DockStyle.Fill;
            CustomerSurname.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerSurname.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerSurname.Location = new Point(310, 3);
            CustomerSurname.Name = "CustomerSurname";
            CustomerSurname.PlaceholderText = "Прізвище";
            CustomerSurname.Size = new Size(301, 43);
            CustomerSurname.TabIndex = 8;
            // 
            // CustomerName
            // 
            CustomerName.BackColor = Color.FromArgb(251, 234, 235);
            CustomerName.BorderStyle = BorderStyle.FixedSingle;
            CustomerName.Dock = DockStyle.Fill;
            CustomerName.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerName.ForeColor = Color.FromArgb(47, 60, 126);
            CustomerName.Location = new Point(3, 3);
            CustomerName.Name = "CustomerName";
            CustomerName.PlaceholderText = "Ім`я";
            CustomerName.Size = new Size(301, 43);
            CustomerName.TabIndex = 7;
            // 
            // RightSideBar
            // 
            RightSideBar.Dock = DockStyle.Right;
            RightSideBar.Location = new Point(978, 69);
            RightSideBar.Name = "RightSideBar";
            RightSideBar.Size = new Size(50, 476);
            RightSideBar.TabIndex = 3;
            // 
            // LeftSideBar
            // 
            LeftSideBar.Dock = DockStyle.Left;
            LeftSideBar.Location = new Point(0, 69);
            LeftSideBar.Name = "LeftSideBar";
            LeftSideBar.Size = new Size(50, 476);
            LeftSideBar.TabIndex = 2;
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(MainTitle);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1028, 69);
            TitlePanel.TabIndex = 1;
            // 
            // MainTitle
            // 
            MainTitle.Dock = DockStyle.Fill;
            MainTitle.Font = new Font("Bookman Old Style", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MainTitle.Location = new Point(0, 0);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(1028, 69);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "Змінити дані клієнта";
            MainTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.Controls.Add(ButtonsLayout);
            ButtonsPanel.Dock = DockStyle.Bottom;
            ButtonsPanel.Location = new Point(0, 545);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(1028, 75);
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
            ButtonsLayout.Size = new Size(1028, 75);
            ButtonsLayout.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderSize = 4;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(542, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(225, 69);
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
            ChangeButton.Location = new Point(260, 3);
            ChangeButton.Name = "ChangeButton";
            ChangeButton.Size = new Size(225, 69);
            ChangeButton.TabIndex = 5;
            ChangeButton.Text = "Change";
            ChangeButton.UseVisualStyleBackColor = false;
            ChangeButton.Click += ChangeButton_Click;
            // 
            // ChangeCustomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(251, 234, 235);
            ClientSize = new Size(1028, 620);
            Controls.Add(ChangeCustomerMainPanel);
            Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(47, 60, 126);
            Margin = new Padding(5, 3, 5, 3);
            Name = "ChangeCustomer";
            Text = "ChangeCustomer";
            ChangeCustomerMainPanel.ResumeLayout(false);
            MainDataPanel.ResumeLayout(false);
            DataLayout.ResumeLayout(false);
            DataLayout.PerformLayout();
            TextBoxRowLayout.ResumeLayout(false);
            TextBoxRowLayout.PerformLayout();
            CustomerDiscountLayout.ResumeLayout(false);
            LableRowLayout.ResumeLayout(false);
            FullNameLabelsLayout.ResumeLayout(false);
            FullNameLayout.ResumeLayout(false);
            FullNameLayout.PerformLayout();
            TitlePanel.ResumeLayout(false);
            ButtonsPanel.ResumeLayout(false);
            ButtonsLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel ChangeCustomerMainPanel;
        private Panel MainDataPanel;
        private TableLayoutPanel DataLayout;
        private TableLayoutPanel TextBoxRowLayout;
        private TextBox CustomerDiscountId;
        private TableLayoutPanel CustomerDiscountLayout;
        private Button SeeFullDiscount;
        private Label CustomerDiscountDesc;
        private TableLayoutPanel LableRowLayout;
        private Label CustomerDiscountLabel;
        private Label CustomerDiscountIdLabel;
        private TextBox CustomerPhone;
        private TextBox CustomerAddress;
        private Label CustomerPhoneLabel;
        private Label CustomerAddressLabel;
        private TableLayoutPanel FullNameLabelsLayout;
        private Label CustomerPaternalNameLabel;
        private Label CustomerSurnameLabel;
        private Label CustomerNameLabel;
        private TableLayoutPanel FullNameLayout;
        private TextBox CustomerPaternalName;
        private TextBox CustomerSurname;
        private TextBox CustomerName;
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