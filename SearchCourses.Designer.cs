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
            button1 = new Button();
            TitleLabel = new Label();
            searchInput = new TextBox();
            CoursesTable = new DataGridView();
            searchButton = new Button();
            noResultMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)CoursesTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(61, 28);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(175, 38);
            button1.TabIndex = 3;
            button1.Text = "Change Term";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            CoursesTable.RowHeadersWidth = 51;
            CoursesTable.Size = new Size(678, 238);
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
            // noResultMessage
            // 
            noResultMessage.AutoSize = true;
            noResultMessage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noResultMessage.Location = new Point(61, 157);
            noResultMessage.Name = "noResultMessage";
            noResultMessage.Size = new Size(166, 25);
            noResultMessage.TabIndex = 8;
            noResultMessage.Text = "no result message";
            noResultMessage.Visible = false;
            // 
            // SearchCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 477);
            Controls.Add(noResultMessage);
            Controls.Add(searchButton);
            Controls.Add(CoursesTable);
            Controls.Add(TitleLabel);
            Controls.Add(searchInput);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SearchCourses";
            ((System.ComponentModel.ISupportInitialize)CoursesTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label TitleLabel;
        private TextBox searchInput;
        private DataGridView CoursesTable;
        private Button searchButton;
        private Label noResultMessage;
    }
}