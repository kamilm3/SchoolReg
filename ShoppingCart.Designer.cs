namespace SchoolReg
{
    partial class ShoppingCart
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button3 = new Button();
            bindingSource1 = new BindingSource(components);
            dropDownTerm = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 115);
            label1.Name = "label1";
            label1.Size = new Size(140, 28);
            label1.TabIndex = 0;
            label1.Text = "Shopping cart";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(70, 38);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 5;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dropDownTerm
            // 
            dropDownTerm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropDownTerm.ForeColor = SystemColors.ScrollBar;
            dropDownTerm.FormattingEnabled = true;
            dropDownTerm.Items.AddRange(new object[] { "Fall 2025", "Winter 2026" });
            dropDownTerm.Location = new Point(70, 146);
            dropDownTerm.Name = "dropDownTerm";
            dropDownTerm.Size = new Size(924, 39);
            dropDownTerm.TabIndex = 6;
            dropDownTerm.Text = "Choose term";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(70, 215);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(929, 676);
            dataGridView1.TabIndex = 7;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 581);
            Controls.Add(dataGridView1);
            Controls.Add(dropDownTerm);
            Controls.Add(button3);
            Controls.Add(label1);
            Name = "ShoppingCart";
            Text = "Form6";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private BindingSource bindingSource1;
        private ComboBox dropDownTerm;
        private DataGridView dataGridView1;
    }
}