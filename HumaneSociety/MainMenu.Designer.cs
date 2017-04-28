namespace HumaneSociety
{
    partial class WelcomeMenu
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
            this.AddButton = new System.Windows.Forms.Button();
            this.AdoptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MassAddButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ViewRoomsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(52, 83);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(401, 65);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Animal";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AdoptButton
            // 
            this.AdoptButton.Location = new System.Drawing.Point(52, 163);
            this.AdoptButton.Name = "AdoptButton";
            this.AdoptButton.Size = new System.Drawing.Size(401, 65);
            this.AdoptButton.TabIndex = 1;
            this.AdoptButton.Text = "Adopt Animal";
            this.AdoptButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME";
            // 
            // MassAddButton
            // 
            this.MassAddButton.Location = new System.Drawing.Point(52, 406);
            this.MassAddButton.Name = "MassAddButton";
            this.MassAddButton.Size = new System.Drawing.Size(401, 65);
            this.MassAddButton.TabIndex = 5;
            this.MassAddButton.Text = "Mass Add Animals";
            this.MassAddButton.UseVisualStyleBackColor = true;
            this.MassAddButton.Click += new System.EventHandler(this.MassAddButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(52, 244);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(401, 65);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search Animals";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ViewRoomsButton
            // 
            this.ViewRoomsButton.Location = new System.Drawing.Point(52, 324);
            this.ViewRoomsButton.Name = "ViewRoomsButton";
            this.ViewRoomsButton.Size = new System.Drawing.Size(401, 65);
            this.ViewRoomsButton.TabIndex = 6;
            this.ViewRoomsButton.Text = "View Rooms";
            this.ViewRoomsButton.UseVisualStyleBackColor = true;
            this.ViewRoomsButton.Click += new System.EventHandler(this.ViewRoomsButton_Click);
            // 
            // WelcomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 508);
            this.Controls.Add(this.ViewRoomsButton);
            this.Controls.Add(this.MassAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AdoptButton);
            this.Controls.Add(this.AddButton);
            this.Name = "WelcomeMenu";
            this.Text = "Humane Society";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button AdoptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MassAddButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ViewRoomsButton;
    }
}

