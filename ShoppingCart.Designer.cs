﻿namespace SchoolReg
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
            BackButton = new Button();
            bindingSource1 = new BindingSource(components);
            dropDownTerm = new ComboBox();
            CartDataGridView = new DataGridView();
            NoResultLabel = new Label();
            EnrollButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 86);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 0;
            label1.Text = "Shopping cart";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(192, 0, 0);
            BackButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = Color.White;
            BackButton.Location = new Point(61, 28);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(175, 38);
            BackButton.TabIndex = 5;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // dropDownTerm
            // 
            dropDownTerm.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropDownTerm.ForeColor = SystemColors.ScrollBar;
            dropDownTerm.FormattingEnabled = true;
            dropDownTerm.Items.AddRange(new object[] { "Fall 2025", "Winter 2026" });
            dropDownTerm.Location = new Point(61, 110);
            dropDownTerm.Margin = new Padding(3, 2, 3, 2);
            dropDownTerm.Name = "dropDownTerm";
            dropDownTerm.Size = new Size(809, 33);
            dropDownTerm.TabIndex = 6;
            dropDownTerm.Text = "Choose term";
            // 
            // CartDataGridView
            // 
            CartDataGridView.AllowUserToAddRows = false;
            CartDataGridView.AllowUserToDeleteRows = false;
            CartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartDataGridView.Location = new Point(61, 182);
            CartDataGridView.Margin = new Padding(3, 2, 3, 2);
            CartDataGridView.Name = "CartDataGridView";
            CartDataGridView.RowHeadersWidth = 51;
            CartDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CartDataGridView.Size = new Size(813, 486);
            CartDataGridView.TabIndex = 7;
            // 
            // NoResultLabel
            // 
            NoResultLabel.AutoSize = true;
            NoResultLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoResultLabel.Location = new Point(61, 150);
            NoResultLabel.Name = "NoResultLabel";
            NoResultLabel.Size = new Size(145, 25);
            NoResultLabel.TabIndex = 9;
            NoResultLabel.Text = "No Result Label";
            NoResultLabel.Visible = false;
            // 
            // EnrollButton
            // 
            EnrollButton.BackColor = Color.Gray;
            EnrollButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollButton.ForeColor = Color.White;
            EnrollButton.Location = new Point(61, 681);
            EnrollButton.Margin = new Padding(3, 2, 3, 2);
            EnrollButton.Name = "EnrollButton";
            EnrollButton.Size = new Size(153, 35);
            EnrollButton.TabIndex = 10;
            EnrollButton.Text = "Enroll Into All";
            EnrollButton.UseVisualStyleBackColor = false;
            EnrollButton.Visible = false;
            EnrollButton.Click += EnrollButton_Click;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 732);
            Controls.Add(EnrollButton);
            Controls.Add(NoResultLabel);
            Controls.Add(CartDataGridView);
            Controls.Add(dropDownTerm);
            Controls.Add(BackButton);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ShoppingCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CartDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BackButton;
        private BindingSource bindingSource1;
        private ComboBox dropDownTerm;
        private DataGridView CartDataGridView;
        private Label NoResultLabel;
        private Button EnrollButton;
    }
}