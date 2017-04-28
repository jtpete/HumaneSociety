namespace HumaneSociety
{
    partial class SearchForm
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
            this.SearchResultsTable = new System.Windows.Forms.DataGridView();
            this.TypeCheckBox = new System.Windows.Forms.CheckBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.ColorCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.ShotsCheckBox = new System.Windows.Forms.CheckBox();
            this.AnimalIdLabel = new System.Windows.Forms.Label();
            this.AnimalIdText = new System.Windows.Forms.TextBox();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.RefineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchResultsTable
            // 
            this.SearchResultsTable.AllowUserToAddRows = false;
            this.SearchResultsTable.AllowUserToDeleteRows = false;
            this.SearchResultsTable.AllowUserToOrderColumns = true;
            this.SearchResultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResultsTable.Location = new System.Drawing.Point(21, 56);
            this.SearchResultsTable.Name = "SearchResultsTable";
            this.SearchResultsTable.ReadOnly = true;
            this.SearchResultsTable.RowTemplate.Height = 24;
            this.SearchResultsTable.Size = new System.Drawing.Size(1153, 278);
            this.SearchResultsTable.TabIndex = 0;
            // 
            // TypeCheckBox
            // 
            this.TypeCheckBox.AutoSize = true;
            this.TypeCheckBox.Location = new System.Drawing.Point(65, 408);
            this.TypeCheckBox.Name = "TypeCheckBox";
            this.TypeCheckBox.Size = new System.Drawing.Size(62, 21);
            this.TypeCheckBox.TabIndex = 3;
            this.TypeCheckBox.Text = "Type";
            this.TypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(133, 408);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(262, 22);
            this.TypeBox.TabIndex = 4;
            // 
            // ColorCheckBox
            // 
            this.ColorCheckBox.AutoSize = true;
            this.ColorCheckBox.Location = new System.Drawing.Point(65, 440);
            this.ColorCheckBox.Name = "ColorCheckBox";
            this.ColorCheckBox.Size = new System.Drawing.Size(63, 21);
            this.ColorCheckBox.TabIndex = 7;
            this.ColorCheckBox.Text = "Color";
            this.ColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(133, 440);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(262, 22);
            this.ColorBox.TabIndex = 8;
            // 
            // ShotsCheckBox
            // 
            this.ShotsCheckBox.AutoSize = true;
            this.ShotsCheckBox.Location = new System.Drawing.Point(65, 474);
            this.ShotsCheckBox.Name = "ShotsCheckBox";
            this.ShotsCheckBox.Size = new System.Drawing.Size(66, 21);
            this.ShotsCheckBox.TabIndex = 13;
            this.ShotsCheckBox.Text = "Shots";
            this.ShotsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnimalIdLabel
            // 
            this.AnimalIdLabel.AutoSize = true;
            this.AnimalIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalIdLabel.Location = new System.Drawing.Point(827, 345);
            this.AnimalIdLabel.Name = "AnimalIdLabel";
            this.AnimalIdLabel.Size = new System.Drawing.Size(132, 29);
            this.AnimalIdLabel.TabIndex = 15;
            this.AnimalIdLabel.Text = "Animal ID";
            // 
            // AnimalIdText
            // 
            this.AnimalIdText.Location = new System.Drawing.Point(966, 351);
            this.AnimalIdText.Name = "AnimalIdText";
            this.AnimalIdText.Size = new System.Drawing.Size(208, 22);
            this.AnimalIdText.TabIndex = 16;
            // 
            // ChooseButton
            // 
            this.ChooseButton.Location = new System.Drawing.Point(1022, 381);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(152, 49);
            this.ChooseButton.TabIndex = 17;
            this.ChooseButton.Text = "Choose Animal";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(1022, 440);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(152, 49);
            this.DoneButton.TabIndex = 18;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // RefineButton
            // 
            this.RefineButton.Location = new System.Drawing.Point(65, 345);
            this.RefineButton.Name = "RefineButton";
            this.RefineButton.Size = new System.Drawing.Size(152, 49);
            this.RefineButton.TabIndex = 19;
            this.RefineButton.Text = "Refine Search";
            this.RefineButton.UseVisualStyleBackColor = true;
            this.RefineButton.Click += new System.EventHandler(this.RefineButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 525);
            this.Controls.Add(this.RefineButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.AnimalIdText);
            this.Controls.Add(this.AnimalIdLabel);
            this.Controls.Add(this.ShotsCheckBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.ColorCheckBox);
            this.Controls.Add(this.TypeCheckBox);
            this.Controls.Add(this.SearchResultsTable);
            this.Name = "SearchForm";
            this.Text = "Search Humane Society Animals";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchResultsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchResultsTable;
        private System.Windows.Forms.CheckBox TypeCheckBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.CheckBox ColorCheckBox;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.CheckBox ShotsCheckBox;
        private System.Windows.Forms.Label AnimalIdLabel;
        private System.Windows.Forms.TextBox AnimalIdText;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button RefineButton;
    }
}