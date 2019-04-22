namespace RandomPasswordGen2
{
    partial class PasswordGen
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
            this.passwordGenListBox = new System.Windows.Forms.ListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.Management = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.Management.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordGenListBox
            // 
            this.passwordGenListBox.FormattingEnabled = true;
            this.passwordGenListBox.Location = new System.Drawing.Point(9, 10);
            this.passwordGenListBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordGenListBox.Name = "passwordGenListBox";
            this.passwordGenListBox.Size = new System.Drawing.Size(292, 121);
            this.passwordGenListBox.TabIndex = 0;
            this.passwordGenListBox.SelectedIndexChanged += new System.EventHandler(this.passwordGenListBox_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(3, 18);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(221, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(9, 136);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(206, 20);
            this.addTextBox.TabIndex = 3;
            this.addTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Management
            // 
            this.Management.Controls.Add(this.deleteButton);
            this.Management.Controls.Add(this.refreshButton);
            this.Management.Location = new System.Drawing.Point(9, 163);
            this.Management.Name = "Management";
            this.Management.Size = new System.Drawing.Size(287, 47);
            this.Management.TabIndex = 4;
            this.Management.TabStop = false;
            this.Management.Text = "Management";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(84, 18);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 222);
            this.Controls.Add(this.Management);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordGenListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PasswordGen";
            this.Text = "Password Gen";
            this.Management.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox passwordGenListBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.GroupBox Management;
        private System.Windows.Forms.Button deleteButton;
    }
}

