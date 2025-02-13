

namespace SchoolReg
{
    //public static Form2 instance;
    partial class LandingPage
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
            searchButton = new Button();
            cartButton = new Button();
            header = new Label();
            testLabel = new Label();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(192, 0, 0);
            searchButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(313, 216);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(525, 45);
            searchButton.TabIndex = 0;
            searchButton.Text = "Class Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += button1_Click;
            // 
            // cartButton
            // 
            cartButton.BackColor = Color.FromArgb(192, 0, 0);
            cartButton.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cartButton.ForeColor = Color.White;
            cartButton.Location = new Point(313, 289);
            cartButton.Margin = new Padding(3, 2, 3, 2);
            cartButton.Name = "cartButton";
            cartButton.Size = new Size(525, 45);
            cartButton.TabIndex = 1;
            cartButton.Text = "Cart";
            cartButton.UseVisualStyleBackColor = false;
            cartButton.Click += button2_Click;
            // 
            // header
            // 
            header.BackColor = Color.Brown;
            header.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.ForeColor = Color.White;
            header.Location = new Point(0, -1);
            header.Name = "header";
            header.Size = new Size(1149, 63);
            header.TabIndex = 5;
            header.Text = "Course Registration";
            header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            testLabel.Location = new Point(42, 89);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(71, 30);
            testLabel.TabIndex = 6;
            testLabel.Text = "label1";
            testLabel.Visible = false;
            // 
            // LandingPage
            // 
            AccessibleRole = AccessibleRole.Separator;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 807);
            Controls.Add(testLabel);
            Controls.Add(header);
            Controls.Add(cartButton);
            Controls.Add(searchButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LandingPage";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Button cartButton;
        private Label header;
        private Label testLabel;
    }
}