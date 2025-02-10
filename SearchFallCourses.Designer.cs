namespace SchoolReg
{
    partial class SearchFallCourses
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
            searchInput = new TextBox();
            label1 = new Label();
            button1 = new Button();
            FallCourses = new DataGridView();
            searchButton = new Button();
            button3 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)FallCourses).BeginInit();
            SuspendLayout();
            // 
            // searchInput
            // 
            searchInput.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchInput.ForeColor = Color.DarkGray;
            searchInput.Location = new Point(70, 146);
            searchInput.Name = "searchInput";
            searchInput.Size = new Size(929, 38);
            searchInput.TabIndex = 0;
            searchInput.TextChanged += searchInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 115);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 1;
            label1.Text = "Search for 2025 Fall classes";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 38);
            button1.Name = "button1";
            button1.Size = new Size(200, 50);
            button1.TabIndex = 2;
            button1.Text = "Change Term";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FallCourses
            // 
            FallCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FallCourses.Location = new Point(70, 267);
            FallCourses.Name = "FallCourses";
            FallCourses.RowHeadersWidth = 51;
            FallCourses.Size = new Size(929, 374);
            FallCourses.TabIndex = 3;
            FallCourses.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 0, 0);
            searchButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1033, 146);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(192, 38);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1278, 362);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 209);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // SearchFallCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 621);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(searchButton);
            Controls.Add(FallCourses);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(searchInput);
            Name = "SearchFallCourses";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)FallCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchInput;
        private Label label1;
        private Button button1;
        private DataGridView FallCourses;
        private Button searchButton;
        private Button button3;
        private Label label2;
    }
}