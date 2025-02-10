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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            FallCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FallCourses).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(70, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(929, 38);
            textBox1.TabIndex = 0;
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
            button1.BackColor = Color.FromArgb(192, 0, 0);
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
            FallCourses.Location = new Point(70, 215);
            FallCourses.Name = "FallCourses";
            FallCourses.RowHeadersWidth = 51;
            FallCourses.Size = new Size(929, 374);
            FallCourses.TabIndex = 3;
            // 
            // SearchFallCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 593);
            Controls.Add(FallCourses);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "SearchFallCourses";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)FallCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private DataGridView FallCourses;
    }
}