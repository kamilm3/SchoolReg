using System.ComponentModel;
using Microsoft.Data.SqlClient;

namespace SchoolReg
{
    public partial class Verification : Form
    {
        private Label label2;
        private Label header;
        private SqlCommand sqlCommand1;
        private System.Windows.Forms.Button nextButton;


        private System.Windows.Forms.TextBox studentIDInput;
        private System.Windows.Forms.TextBox emailAddressInput;
        private Label label1;

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Verification));
            emailAddressInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            studentIDInput = new TextBox();
            header = new Label();
            sqlCommand1 = new SqlCommand();
            nextButton = new Button();
            PopulateButton = new Button();
            SuspendLayout();
            // 
            // emailAddressInput
            // 
            resources.ApplyResources(emailAddressInput, "emailAddressInput");
            emailAddressInput.Name = "emailAddressInput";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // studentIDInput
            // 
            resources.ApplyResources(studentIDInput, "studentIDInput");
            studentIDInput.Name = "studentIDInput";
            studentIDInput.TextChanged += textBox1_TextChanged;
            // 
            // header
            // 
            resources.ApplyResources(header, "header");
            header.BackColor = Color.Brown;
            header.ForeColor = Color.White;
            header.Name = "header";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // nextButton
            // 
            resources.ApplyResources(nextButton, "nextButton");
            nextButton.BackColor = Color.FromArgb(192, 0, 0);
            nextButton.ForeColor = Color.White;
            nextButton.Name = "nextButton";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // PopulateButton
            // 
            resources.ApplyResources(PopulateButton, "PopulateButton");
            PopulateButton.Name = "PopulateButton";
            PopulateButton.UseVisualStyleBackColor = true;
            PopulateButton.Click += button1_Click;
            // 
            // Verification
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(PopulateButton);
            Controls.Add(emailAddressInput);
            Controls.Add(label2);
            Controls.Add(nextButton);
            Controls.Add(header);
            Controls.Add(studentIDInput);
            Controls.Add(label1);
            Name = "Verification";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button PopulateButton;
    }
}
