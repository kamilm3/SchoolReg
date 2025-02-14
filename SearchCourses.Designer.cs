namespace SchoolReg
{
    partial class SearchCourses
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
            ChangeTermButton = new Button();
            TitleLabel = new Label();
            searchInput = new TextBox();
            CoursesTable = new DataGridView();
            searchButton = new Button();
            NoResultLabel = new Label();
            addCartButton = new Button();
            ViewCartButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)CoursesTable).BeginInit();
            SuspendLayout();
            // 
            // ChangeTermButton
            // 
            ChangeTermButton.BackColor = Color.Black;
            ChangeTermButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeTermButton.ForeColor = Color.White;
            ChangeTermButton.Location = new Point(61, 28);
            ChangeTermButton.Margin = new Padding(3, 2, 3, 2);
            ChangeTermButton.Name = "ChangeTermButton";
            ChangeTermButton.Size = new Size(175, 38);
            ChangeTermButton.TabIndex = 3;
            ChangeTermButton.Text = "Change Term";
            ChangeTermButton.UseVisualStyleBackColor = false;
            ChangeTermButton.Click += ChangeTermButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(61, 86);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(265, 21);
            TitleLabel.TabIndex = 5;
            TitleLabel.Text = "Search for %year% %term% classes";
            // 
            // searchInput
            // 
            searchInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchInput.ForeColor = Color.Black;
            searchInput.Location = new Point(61, 110);
            searchInput.Margin = new Padding(3, 2, 3, 2);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(678, 32);
            searchInput.TabIndex = 4;
            // 
            // CoursesTable
            // 
            CoursesTable.AllowUserToAddRows = false;
            CoursesTable.AllowUserToDeleteRows = false;
            CoursesTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CoursesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            CoursesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CoursesTable.Location = new Point(61, 200);
            CoursesTable.Margin = new Padding(3, 2, 3, 2);
            CoursesTable.Name = "CoursesTable";
            CoursesTable.ReadOnly = true;
            CoursesTable.RowHeadersWidth = 51;
            CoursesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CoursesTable.Size = new Size(678, 270);
            CoursesTable.TabIndex = 6;
            CoursesTable.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 0, 0);
            searchButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(758, 107);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 35);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // NoResultLabel
            // 
            NoResultLabel.AutoSize = true;
            NoResultLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoResultLabel.Location = new Point(61, 157);
            NoResultLabel.Name = "NoResultLabel";
            NoResultLabel.Size = new Size(133, 25);
            NoResultLabel.TabIndex = 8;
            NoResultLabel.Text = "no result label";
            NoResultLabel.Visible = false;
            // 
            // addCartButton
            // 
            addCartButton.BackColor = Color.Gray;
            addCartButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCartButton.ForeColor = Color.White;
            addCartButton.Location = new Point(61, 474);
            addCartButton.Margin = new Padding(3, 2, 3, 2);
            addCartButton.Name = "addCartButton";
            addCartButton.Size = new Size(147, 35);
            addCartButton.TabIndex = 9;
            addCartButton.Text = "Add to Cart";
            addCartButton.UseVisualStyleBackColor = false;
            addCartButton.Visible = false;
            addCartButton.Click += addCartButton_Click;
            // 
            // ViewCartButton
            // 
            ViewCartButton.BackColor = Color.Gray;
            ViewCartButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewCartButton.ForeColor = Color.White;
            ViewCartButton.Location = new Point(592, 474);
            ViewCartButton.Margin = new Padding(3, 2, 3, 2);
            ViewCartButton.Name = "ViewCartButton";
            ViewCartButton.Size = new Size(147, 35);
            ViewCartButton.TabIndex = 10;
            ViewCartButton.Text = "View Cart";
            ViewCartButton.UseVisualStyleBackColor = false;
            ViewCartButton.Visible = false;
            ViewCartButton.Click += ViewCartButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(704, 28);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 11;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // SearchCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 807);
            Controls.Add(button1);
            Controls.Add(ViewCartButton);
            Controls.Add(addCartButton);
            Controls.Add(NoResultLabel);
            Controls.Add(searchButton);
            Controls.Add(CoursesTable);
            Controls.Add(TitleLabel);
            Controls.Add(searchInput);
            Controls.Add(ChangeTermButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchCourses";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)CoursesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChangeTermButton;
        private Label TitleLabel;
        private TextBox searchInput;
        private DataGridView CoursesTable;
        private Button searchButton;
        private Label NoResultLabel;
        private Button addCartButton;
        private Button ViewCartButton;
        private Button button1;
    }
}