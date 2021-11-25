
namespace YourProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.EmployeeWhereNotButton = new System.Windows.Forms.Button();
            this.EmployeeWhereButton = new System.Windows.Forms.Button();
            this.WhiteSpaceButton = new System.Windows.Forms.Button();
            this.WhiteSpaceExtensionButton = new System.Windows.Forms.Button();
            this.AllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeeWhereNotButton
            // 
            this.EmployeeWhereNotButton.Location = new System.Drawing.Point(12, 12);
            this.EmployeeWhereNotButton.Name = "EmployeeWhereNotButton";
            this.EmployeeWhereNotButton.Size = new System.Drawing.Size(253, 23);
            this.EmployeeWhereNotButton.TabIndex = 1;
            this.EmployeeWhereNotButton.Text = "Employee WhereNot extension";
            this.EmployeeWhereNotButton.UseVisualStyleBackColor = true;
            this.EmployeeWhereNotButton.Click += new System.EventHandler(this.EmployeeWhereNotButton_Click);
            // 
            // EmployeeWhereButton
            // 
            this.EmployeeWhereButton.Location = new System.Drawing.Point(12, 41);
            this.EmployeeWhereButton.Name = "EmployeeWhereButton";
            this.EmployeeWhereButton.Size = new System.Drawing.Size(253, 23);
            this.EmployeeWhereButton.TabIndex = 2;
            this.EmployeeWhereButton.Text = "Employee Where";
            this.EmployeeWhereButton.UseVisualStyleBackColor = true;
            this.EmployeeWhereButton.Click += new System.EventHandler(this.EmployeeWhereButton_Click);
            // 
            // WhiteSpaceButton
            // 
            this.WhiteSpaceButton.Location = new System.Drawing.Point(12, 116);
            this.WhiteSpaceButton.Name = "WhiteSpaceButton";
            this.WhiteSpaceButton.Size = new System.Drawing.Size(253, 23);
            this.WhiteSpaceButton.TabIndex = 3;
            this.WhiteSpaceButton.Text = "String.IsWhitespaceOrNull traditional";
            this.WhiteSpaceButton.UseVisualStyleBackColor = true;
            this.WhiteSpaceButton.Click += new System.EventHandler(this.WhiteSpaceButton_Click);
            // 
            // WhiteSpaceExtensionButton
            // 
            this.WhiteSpaceExtensionButton.Location = new System.Drawing.Point(12, 87);
            this.WhiteSpaceExtensionButton.Name = "WhiteSpaceExtensionButton";
            this.WhiteSpaceExtensionButton.Size = new System.Drawing.Size(253, 23);
            this.WhiteSpaceExtensionButton.TabIndex = 4;
            this.WhiteSpaceExtensionButton.Text = "String.IsWhitespaceOrNull extension";
            this.WhiteSpaceExtensionButton.UseVisualStyleBackColor = true;
            this.WhiteSpaceExtensionButton.Click += new System.EventHandler(this.WhiteSpaceExtensionButton_Click);
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(12, 158);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(253, 23);
            this.AllButton.TabIndex = 5;
            this.AllButton.Text = "All";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 230);
            this.Controls.Add(this.AllButton);
            this.Controls.Add(this.WhiteSpaceExtensionButton);
            this.Controls.Add(this.WhiteSpaceButton);
            this.Controls.Add(this.EmployeeWhereButton);
            this.Controls.Add(this.EmployeeWhereNotButton);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EmployeeWhereNotButton;
        private System.Windows.Forms.Button EmployeeWhereButton;
        private System.Windows.Forms.Button WhiteSpaceButton;
        private System.Windows.Forms.Button WhiteSpaceExtensionButton;
        private System.Windows.Forms.Button AllButton;
    }
}

