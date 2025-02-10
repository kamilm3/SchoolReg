namespace SchoolReg
{
    partial class SearchWinterCourses
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
            label1 = new Label();
            searchInput = new TextBox();
            WinterCourses = new DataGridView();
            searchButton = new Button();
            noResultMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)WinterCourses).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 38);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 3;
            button1.Text = "Change Term";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 115);
            label1.Name = "label1";
            label1.Size = new Size(289, 28);
            label1.TabIndex = 5;
            label1.Text = "Search for 2026 Winter classes";
            // 
            // searchInput
            // 
            searchInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchInput.ForeColor = Color.DarkGray;
            searchInput.Location = new Point(70, 146);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(929, 38);
            searchInput.TabIndex = 4;
            // 
            // WinterCourses
            // 
            WinterCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WinterCourses.Location = new Point(70, 267);
            WinterCourses.Name = "WinterCourses";
            WinterCourses.RowHeadersWidth = 51;
            WinterCourses.Size = new Size(929, 676);
            WinterCourses.TabIndex = 6;
            WinterCourses.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 0, 0);
            searchButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1033, 146);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(192, 38);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // noResultMessage
            // 
            noResultMessage.AutoSize = true;
            noResultMessage.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noResultMessage.Location = new Point(70, 209);
            noResultMessage.Name = "noResultMessage";
            noResultMessage.Size = new Size(77, 31);
            noResultMessage.TabIndex = 8;
            noResultMessage.Text = "label2";
            noResultMessage.Visible = false;
            // 
            // SearchWinterCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(noResultMessage);
            Controls.Add(searchButton);
            Controls.Add(WinterCourses);
            Controls.Add(label1);
            Controls.Add(searchInput);
            Controls.Add(button1);
            Name = "SearchWinterCourses";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)WinterCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox searchInput;
        private DataGridView WinterCourses;
        private Button searchButton;
        private Label noResultMessage;
    }
}