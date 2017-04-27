namespace HumaneSociety
{
    partial class MassAddAnimals
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
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(35, 56);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(560, 22);
            this.FileNameBox.TabIndex = 0;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(520, 84);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(35, 33);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(30, 17);
            this.FileLabel.TabIndex = 2;
            this.FileLabel.Text = "File";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(333, 189);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(125, 42);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(482, 189);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 42);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MassAddAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 255);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileNameBox);
            this.Name = "MassAddAnimals";
            this.Text = "Mass Add Animals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button Cancel;
    }
}