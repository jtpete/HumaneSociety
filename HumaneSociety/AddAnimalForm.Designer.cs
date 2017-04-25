namespace HumaneSociety
{
    partial class AddAnimalForm
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
            this.AnimalTypeText = new System.Windows.Forms.TextBox();
            this.AnimalTypeLabel = new System.Windows.Forms.Label();
            this.AnimalNameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ArrivalLabel = new System.Windows.Forms.Label();
            this.ArrivalDatePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Health = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ShotsCheckBox = new System.Windows.Forms.CheckBox();
            this.FoodTextBox = new System.Windows.Forms.TextBox();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.DishPerWeekLabel = new System.Windows.Forms.Label();
            this.DishesPerWeekText = new System.Windows.Forms.TextBox();
            this.DishSizeLabel = new System.Windows.Forms.Label();
            this.DishSizeComboBox = new System.Windows.Forms.ComboBox();
            this.SpaceNeedsComboBox = new System.Windows.Forms.ComboBox();
            this.SpaceNeedLabel = new System.Windows.Forms.Label();
            this.ShotsPicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.OtherDetailsLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.LbLabel = new System.Windows.Forms.Label();
            this.InLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalTypeText
            // 
            this.AnimalTypeText.Location = new System.Drawing.Point(75, 107);
            this.AnimalTypeText.Name = "AnimalTypeText";
            this.AnimalTypeText.Size = new System.Drawing.Size(206, 22);
            this.AnimalTypeText.TabIndex = 0;
            this.AnimalTypeText.Tag = "";
            // 
            // AnimalTypeLabel
            // 
            this.AnimalTypeLabel.AutoSize = true;
            this.AnimalTypeLabel.Location = new System.Drawing.Point(24, 107);
            this.AnimalTypeLabel.Name = "AnimalTypeLabel";
            this.AnimalTypeLabel.Size = new System.Drawing.Size(40, 17);
            this.AnimalTypeLabel.TabIndex = 1;
            this.AnimalTypeLabel.Text = "Type";
            // 
            // AnimalNameText
            // 
            this.AnimalNameText.Location = new System.Drawing.Point(75, 63);
            this.AnimalNameText.Name = "AnimalNameText";
            this.AnimalNameText.Size = new System.Drawing.Size(206, 22);
            this.AnimalNameText.TabIndex = 2;
            this.AnimalNameText.Tag = "";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // ArrivalLabel
            // 
            this.ArrivalLabel.AutoSize = true;
            this.ArrivalLabel.Location = new System.Drawing.Point(301, 87);
            this.ArrivalLabel.Name = "ArrivalLabel";
            this.ArrivalLabel.Size = new System.Drawing.Size(82, 17);
            this.ArrivalLabel.TabIndex = 5;
            this.ArrivalLabel.Text = "Arrival Date";
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.Location = new System.Drawing.Point(302, 107);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.Size = new System.Drawing.Size(245, 22);
            this.ArrivalDatePicker.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShotsPicker);
            this.panel1.Controls.Add(this.SpaceNeedLabel);
            this.panel1.Controls.Add(this.SpaceNeedsComboBox);
            this.panel1.Controls.Add(this.DishSizeComboBox);
            this.panel1.Controls.Add(this.DishSizeLabel);
            this.panel1.Controls.Add(this.DishesPerWeekText);
            this.panel1.Controls.Add(this.DishPerWeekLabel);
            this.panel1.Controls.Add(this.FoodLabel);
            this.panel1.Controls.Add(this.FoodTextBox);
            this.panel1.Controls.Add(this.ShotsCheckBox);
            this.panel1.Controls.Add(this.AgeLabel);
            this.panel1.Controls.Add(this.AgeTextBox);
            this.panel1.Location = new System.Drawing.Point(27, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 338);
            this.panel1.TabIndex = 7;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(12, 32);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.AgeTextBox.TabIndex = 0;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.Location = new System.Drawing.Point(23, 154);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(140, 24);
            this.Health.TabIndex = 8;
            this.Health.Text = "Health Details";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(9, 5);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age";
            // 
            // ShotsCheckBox
            // 
            this.ShotsCheckBox.AutoSize = true;
            this.ShotsCheckBox.Location = new System.Drawing.Point(12, 81);
            this.ShotsCheckBox.Name = "ShotsCheckBox";
            this.ShotsCheckBox.Size = new System.Drawing.Size(66, 21);
            this.ShotsCheckBox.TabIndex = 3;
            this.ShotsCheckBox.Text = "Shots";
            this.ShotsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FoodTextBox
            // 
            this.FoodTextBox.Location = new System.Drawing.Point(69, 144);
            this.FoodTextBox.Name = "FoodTextBox";
            this.FoodTextBox.Size = new System.Drawing.Size(202, 22);
            this.FoodTextBox.TabIndex = 4;
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Location = new System.Drawing.Point(9, 144);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(40, 17);
            this.FoodLabel.TabIndex = 5;
            this.FoodLabel.Text = "Food";
            // 
            // DishPerWeekLabel
            // 
            this.DishPerWeekLabel.AutoSize = true;
            this.DishPerWeekLabel.Location = new System.Drawing.Point(9, 222);
            this.DishPerWeekLabel.Name = "DishPerWeekLabel";
            this.DishPerWeekLabel.Size = new System.Drawing.Size(117, 17);
            this.DishPerWeekLabel.TabIndex = 7;
            this.DishPerWeekLabel.Text = "Dishes Per Week";
            // 
            // DishesPerWeekText
            // 
            this.DishesPerWeekText.Location = new System.Drawing.Point(132, 222);
            this.DishesPerWeekText.Name = "DishesPerWeekText";
            this.DishesPerWeekText.Size = new System.Drawing.Size(52, 22);
            this.DishesPerWeekText.TabIndex = 8;
            // 
            // DishSizeLabel
            // 
            this.DishSizeLabel.AutoSize = true;
            this.DishSizeLabel.Location = new System.Drawing.Point(9, 185);
            this.DishSizeLabel.Name = "DishSizeLabel";
            this.DishSizeLabel.Size = new System.Drawing.Size(67, 17);
            this.DishSizeLabel.TabIndex = 9;
            this.DishSizeLabel.Text = "Dish Size";
            // 
            // DishSizeComboBox
            // 
            this.DishSizeComboBox.FormattingEnabled = true;
            this.DishSizeComboBox.Items.AddRange(new object[] {
            "Small (2 oz.)",
            "Medium (8 oz.)",
            "Large (16 oz.)",
            "X-Large (24 oz.)"});
            this.DishSizeComboBox.Location = new System.Drawing.Point(82, 185);
            this.DishSizeComboBox.Name = "DishSizeComboBox";
            this.DishSizeComboBox.Size = new System.Drawing.Size(189, 24);
            this.DishSizeComboBox.TabIndex = 9;
            // 
            // SpaceNeedsComboBox
            // 
            this.SpaceNeedsComboBox.FormattingEnabled = true;
            this.SpaceNeedsComboBox.Items.AddRange(new object[] {
            "Small (In Home Cage)",
            "Medium (In Home)",
            "Large (Home, Yard)",
            "X-Large (Home, Yard, Open Space)"});
            this.SpaceNeedsComboBox.Location = new System.Drawing.Point(12, 282);
            this.SpaceNeedsComboBox.Name = "SpaceNeedsComboBox";
            this.SpaceNeedsComboBox.Size = new System.Drawing.Size(259, 24);
            this.SpaceNeedsComboBox.TabIndex = 10;
            // 
            // SpaceNeedLabel
            // 
            this.SpaceNeedLabel.AutoSize = true;
            this.SpaceNeedLabel.Location = new System.Drawing.Point(9, 262);
            this.SpaceNeedLabel.Name = "SpaceNeedLabel";
            this.SpaceNeedLabel.Size = new System.Drawing.Size(102, 17);
            this.SpaceNeedLabel.TabIndex = 11;
            this.SpaceNeedLabel.Text = "Space Needed";
            // 
            // ShotsPicker
            // 
            this.ShotsPicker.Location = new System.Drawing.Point(12, 108);
            this.ShotsPicker.Name = "ShotsPicker";
            this.ShotsPicker.Size = new System.Drawing.Size(259, 22);
            this.ShotsPicker.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InLabel);
            this.panel2.Controls.Add(this.LbLabel);
            this.panel2.Controls.Add(this.HeightTextBox);
            this.panel2.Controls.Add(this.HeightLabel);
            this.panel2.Controls.Add(this.ActivityComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.WeightTextBox);
            this.panel2.Controls.Add(this.WeightLabel);
            this.panel2.Controls.Add(this.ColorLabel);
            this.panel2.Controls.Add(this.ColorTextBox);
            this.panel2.Location = new System.Drawing.Point(321, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 338);
            this.panel2.TabIndex = 12;
            // 
            // ActivityComboBox
            // 
            this.ActivityComboBox.FormattingEnabled = true;
            this.ActivityComboBox.Items.AddRange(new object[] {
            "Low (Very Little Attention)",
            "Medium (Some Daily Interaction)",
            "High (Multiple Times Of Daily Interaction )",
            "Needy (A Lot Of Attention Needed)"});
            this.ActivityComboBox.Location = new System.Drawing.Point(14, 78);
            this.ActivityComboBox.Name = "ActivityComboBox";
            this.ActivityComboBox.Size = new System.Drawing.Size(212, 24);
            this.ActivityComboBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Activity Level";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(143, 128);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(52, 22);
            this.WeightTextBox.TabIndex = 8;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(140, 108);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(52, 17);
            this.WeightLabel.TabIndex = 7;
            this.WeightLabel.Text = "Weight";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(11, 12);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(41, 17);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(16, 32);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(210, 22);
            this.ColorTextBox.TabIndex = 4;
            // 
            // OtherDetailsLabel
            // 
            this.OtherDetailsLabel.AutoSize = true;
            this.OtherDetailsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherDetailsLabel.Location = new System.Drawing.Point(317, 154);
            this.OtherDetailsLabel.Name = "OtherDetailsLabel";
            this.OtherDetailsLabel.Size = new System.Drawing.Size(134, 24);
            this.OtherDetailsLabel.TabIndex = 13;
            this.OtherDetailsLabel.Text = "Other Details";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(13, 108);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Height";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(14, 128);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(52, 22);
            this.HeightTextBox.TabIndex = 13;
            // 
            // LbLabel
            // 
            this.LbLabel.AutoSize = true;
            this.LbLabel.Location = new System.Drawing.Point(201, 133);
            this.LbLabel.Name = "LbLabel";
            this.LbLabel.Size = new System.Drawing.Size(30, 17);
            this.LbLabel.TabIndex = 14;
            this.LbLabel.Text = "lbs.";
            // 
            // InLabel
            // 
            this.InLabel.AutoSize = true;
            this.InLabel.Location = new System.Drawing.Point(72, 131);
            this.InLabel.Name = "InLabel";
            this.InLabel.Size = new System.Drawing.Size(23, 17);
            this.InLabel.TabIndex = 15;
            this.InLabel.Text = "in.";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(335, 523);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 37);
            this.Submit.TabIndex = 14;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(448, 523);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 37);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 587);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.OtherDetailsLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ArrivalDatePicker);
            this.Controls.Add(this.ArrivalLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AnimalNameText);
            this.Controls.Add(this.AnimalTypeLabel);
            this.Controls.Add(this.AnimalTypeText);
            this.Name = "AddAnimalForm";
            this.Text = "Add Animal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AnimalTypeText;
        private System.Windows.Forms.Label AnimalTypeLabel;
        private System.Windows.Forms.TextBox AnimalNameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ArrivalLabel;
        private System.Windows.Forms.DateTimePicker ArrivalDatePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox DishSizeComboBox;
        private System.Windows.Forms.Label DishSizeLabel;
        private System.Windows.Forms.TextBox DishesPerWeekText;
        private System.Windows.Forms.Label DishPerWeekLabel;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.TextBox FoodTextBox;
        private System.Windows.Forms.CheckBox ShotsCheckBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label SpaceNeedLabel;
        private System.Windows.Forms.ComboBox SpaceNeedsComboBox;
        private System.Windows.Forms.DateTimePicker ShotsPicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InLabel;
        private System.Windows.Forms.Label LbLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ComboBox ActivityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label OtherDetailsLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button ClearButton;
    }
}