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
            this.SpaceNeedGroup = new System.Windows.Forms.GroupBox();
            this.XLSpaceRadio = new System.Windows.Forms.RadioButton();
            this.LargeSpaceRadio = new System.Windows.Forms.RadioButton();
            this.MedSpaceRadio = new System.Windows.Forms.RadioButton();
            this.SmallSpaceRadio = new System.Windows.Forms.RadioButton();
            this.DishSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.XLDishRadio = new System.Windows.Forms.RadioButton();
            this.LargeDishRadio = new System.Windows.Forms.RadioButton();
            this.MediumDishRadio = new System.Windows.Forms.RadioButton();
            this.SmallDishRadio = new System.Windows.Forms.RadioButton();
            this.ShotsPicker = new System.Windows.Forms.DateTimePicker();
            this.DishesPerWeekText = new System.Windows.Forms.TextBox();
            this.DishPerWeekLabel = new System.Windows.Forms.Label();
            this.FoodLabel = new System.Windows.Forms.Label();
            this.FoodTextBox = new System.Windows.Forms.TextBox();
            this.ShotsCheckBox = new System.Windows.Forms.CheckBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.Health = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ActivityLevelBox = new System.Windows.Forms.GroupBox();
            this.NeedyRadio = new System.Windows.Forms.RadioButton();
            this.HighRadio = new System.Windows.Forms.RadioButton();
            this.LowActivityRadio = new System.Windows.Forms.RadioButton();
            this.MediumRadio = new System.Windows.Forms.RadioButton();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.InLabel = new System.Windows.Forms.Label();
            this.LbLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.OtherDetailsLabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AdoptionPriceText = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SpaceNeedGroup.SuspendLayout();
            this.DishSizeGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ActivityLevelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalTypeText
            // 
            this.AnimalTypeText.Location = new System.Drawing.Point(27, 107);
            this.AnimalTypeText.Name = "AnimalTypeText";
            this.AnimalTypeText.Size = new System.Drawing.Size(254, 22);
            this.AnimalTypeText.TabIndex = 1;
            this.AnimalTypeText.Tag = "";
            // 
            // AnimalTypeLabel
            // 
            this.AnimalTypeLabel.AutoSize = true;
            this.AnimalTypeLabel.Location = new System.Drawing.Point(24, 87);
            this.AnimalTypeLabel.Name = "AnimalTypeLabel";
            this.AnimalTypeLabel.Size = new System.Drawing.Size(40, 17);
            this.AnimalTypeLabel.TabIndex = 20;
            this.AnimalTypeLabel.Text = "Type";
            // 
            // AnimalNameText
            // 
            this.AnimalNameText.Location = new System.Drawing.Point(27, 50);
            this.AnimalNameText.Name = "AnimalNameText";
            this.AnimalNameText.Size = new System.Drawing.Size(254, 22);
            this.AnimalNameText.TabIndex = 0;
            this.AnimalNameText.Tag = "";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(24, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Name";
            // 
            // ArrivalLabel
            // 
            this.ArrivalLabel.AutoSize = true;
            this.ArrivalLabel.Location = new System.Drawing.Point(301, 87);
            this.ArrivalLabel.Name = "ArrivalLabel";
            this.ArrivalLabel.Size = new System.Drawing.Size(82, 17);
            this.ArrivalLabel.TabIndex = 18;
            this.ArrivalLabel.Text = "Arrival Date";
            // 
            // ArrivalDatePicker
            // 
            this.ArrivalDatePicker.Enabled = false;
            this.ArrivalDatePicker.Location = new System.Drawing.Point(302, 107);
            this.ArrivalDatePicker.Name = "ArrivalDatePicker";
            this.ArrivalDatePicker.Size = new System.Drawing.Size(245, 22);
            this.ArrivalDatePicker.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpaceNeedGroup);
            this.panel1.Controls.Add(this.DishSizeGroupBox);
            this.panel1.Controls.Add(this.ShotsPicker);
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
            this.panel1.TabIndex = 4;
            // 
            // SpaceNeedGroup
            // 
            this.SpaceNeedGroup.Controls.Add(this.XLSpaceRadio);
            this.SpaceNeedGroup.Controls.Add(this.LargeSpaceRadio);
            this.SpaceNeedGroup.Controls.Add(this.MedSpaceRadio);
            this.SpaceNeedGroup.Controls.Add(this.SmallSpaceRadio);
            this.SpaceNeedGroup.Location = new System.Drawing.Point(6, 201);
            this.SpaceNeedGroup.Name = "SpaceNeedGroup";
            this.SpaceNeedGroup.Size = new System.Drawing.Size(277, 134);
            this.SpaceNeedGroup.TabIndex = 8;
            this.SpaceNeedGroup.TabStop = false;
            this.SpaceNeedGroup.Text = "Space Needed";
            // 
            // XLSpaceRadio
            // 
            this.XLSpaceRadio.AutoSize = true;
            this.XLSpaceRadio.Location = new System.Drawing.Point(7, 106);
            this.XLSpaceRadio.Name = "XLSpaceRadio";
            this.XLSpaceRadio.Size = new System.Drawing.Size(160, 21);
            this.XLSpaceRadio.TabIndex = 3;
            this.XLSpaceRadio.TabStop = true;
            this.XLSpaceRadio.Text = "X-Large (Oper Area)";
            this.XLSpaceRadio.UseVisualStyleBackColor = true;
            // 
            // LargeSpaceRadio
            // 
            this.LargeSpaceRadio.AutoSize = true;
            this.LargeSpaceRadio.Location = new System.Drawing.Point(7, 78);
            this.LargeSpaceRadio.Name = "LargeSpaceRadio";
            this.LargeSpaceRadio.Size = new System.Drawing.Size(179, 21);
            this.LargeSpaceRadio.TabIndex = 2;
            this.LargeSpaceRadio.TabStop = true;
            this.LargeSpaceRadio.Text = "Large (Home and Yard)";
            this.LargeSpaceRadio.UseVisualStyleBackColor = true;
            // 
            // MedSpaceRadio
            // 
            this.MedSpaceRadio.AutoSize = true;
            this.MedSpaceRadio.Location = new System.Drawing.Point(7, 50);
            this.MedSpaceRadio.Name = "MedSpaceRadio";
            this.MedSpaceRadio.Size = new System.Drawing.Size(144, 21);
            this.MedSpaceRadio.TabIndex = 1;
            this.MedSpaceRadio.TabStop = true;
            this.MedSpaceRadio.Text = "Medium (In Home)";
            this.MedSpaceRadio.UseVisualStyleBackColor = true;
            // 
            // SmallSpaceRadio
            // 
            this.SmallSpaceRadio.AutoSize = true;
            this.SmallSpaceRadio.Checked = true;
            this.SmallSpaceRadio.Location = new System.Drawing.Point(7, 22);
            this.SmallSpaceRadio.Name = "SmallSpaceRadio";
            this.SmallSpaceRadio.Size = new System.Drawing.Size(166, 21);
            this.SmallSpaceRadio.TabIndex = 0;
            this.SmallSpaceRadio.TabStop = true;
            this.SmallSpaceRadio.Text = "Small (In Home Cage)";
            this.SmallSpaceRadio.UseVisualStyleBackColor = true;
            // 
            // DishSizeGroupBox
            // 
            this.DishSizeGroupBox.Controls.Add(this.XLDishRadio);
            this.DishSizeGroupBox.Controls.Add(this.LargeDishRadio);
            this.DishSizeGroupBox.Controls.Add(this.MediumDishRadio);
            this.DishSizeGroupBox.Controls.Add(this.SmallDishRadio);
            this.DishSizeGroupBox.Location = new System.Drawing.Point(12, 112);
            this.DishSizeGroupBox.Name = "DishSizeGroupBox";
            this.DishSizeGroupBox.Size = new System.Drawing.Size(259, 41);
            this.DishSizeGroupBox.TabIndex = 6;
            this.DishSizeGroupBox.TabStop = false;
            this.DishSizeGroupBox.Text = "Dish Size";
            // 
            // XLDishRadio
            // 
            this.XLDishRadio.AutoSize = true;
            this.XLDishRadio.Location = new System.Drawing.Point(193, 20);
            this.XLDishRadio.Name = "XLDishRadio";
            this.XLDishRadio.Size = new System.Drawing.Size(60, 21);
            this.XLDishRadio.TabIndex = 3;
            this.XLDishRadio.TabStop = true;
            this.XLDishRadio.Text = "24oz";
            this.XLDishRadio.UseVisualStyleBackColor = true;
            // 
            // LargeDishRadio
            // 
            this.LargeDishRadio.AutoSize = true;
            this.LargeDishRadio.Location = new System.Drawing.Point(127, 21);
            this.LargeDishRadio.Name = "LargeDishRadio";
            this.LargeDishRadio.Size = new System.Drawing.Size(60, 21);
            this.LargeDishRadio.TabIndex = 2;
            this.LargeDishRadio.TabStop = true;
            this.LargeDishRadio.Text = "16oz";
            this.LargeDishRadio.UseVisualStyleBackColor = true;
            // 
            // MediumDishRadio
            // 
            this.MediumDishRadio.AutoSize = true;
            this.MediumDishRadio.Location = new System.Drawing.Point(69, 21);
            this.MediumDishRadio.Name = "MediumDishRadio";
            this.MediumDishRadio.Size = new System.Drawing.Size(52, 21);
            this.MediumDishRadio.TabIndex = 1;
            this.MediumDishRadio.TabStop = true;
            this.MediumDishRadio.Text = "8oz";
            this.MediumDishRadio.UseVisualStyleBackColor = true;
            // 
            // SmallDishRadio
            // 
            this.SmallDishRadio.AutoSize = true;
            this.SmallDishRadio.Checked = true;
            this.SmallDishRadio.Location = new System.Drawing.Point(10, 21);
            this.SmallDishRadio.Name = "SmallDishRadio";
            this.SmallDishRadio.Size = new System.Drawing.Size(52, 21);
            this.SmallDishRadio.TabIndex = 0;
            this.SmallDishRadio.TabStop = true;
            this.SmallDishRadio.Text = "2oz";
            this.SmallDishRadio.UseVisualStyleBackColor = true;
            // 
            // ShotsPicker
            // 
            this.ShotsPicker.Location = new System.Drawing.Point(22, 52);
            this.ShotsPicker.Name = "ShotsPicker";
            this.ShotsPicker.Size = new System.Drawing.Size(259, 22);
            this.ShotsPicker.TabIndex = 9;
            this.ShotsPicker.Visible = false;
            // 
            // DishesPerWeekText
            // 
            this.DishesPerWeekText.Location = new System.Drawing.Point(133, 159);
            this.DishesPerWeekText.Name = "DishesPerWeekText";
            this.DishesPerWeekText.Size = new System.Drawing.Size(52, 22);
            this.DishesPerWeekText.TabIndex = 7;
            // 
            // DishPerWeekLabel
            // 
            this.DishPerWeekLabel.AutoSize = true;
            this.DishPerWeekLabel.Location = new System.Drawing.Point(10, 164);
            this.DishPerWeekLabel.Name = "DishPerWeekLabel";
            this.DishPerWeekLabel.Size = new System.Drawing.Size(117, 17);
            this.DishPerWeekLabel.TabIndex = 9;
            this.DishPerWeekLabel.Text = "Dishes Per Week";
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Location = new System.Drawing.Point(19, 84);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(40, 17);
            this.FoodLabel.TabIndex = 9;
            this.FoodLabel.Text = "Food";
            // 
            // FoodTextBox
            // 
            this.FoodTextBox.Location = new System.Drawing.Point(79, 84);
            this.FoodTextBox.Name = "FoodTextBox";
            this.FoodTextBox.Size = new System.Drawing.Size(202, 22);
            this.FoodTextBox.TabIndex = 5;
            // 
            // ShotsCheckBox
            // 
            this.ShotsCheckBox.AutoSize = true;
            this.ShotsCheckBox.Location = new System.Drawing.Point(205, 12);
            this.ShotsCheckBox.Name = "ShotsCheckBox";
            this.ShotsCheckBox.Size = new System.Drawing.Size(66, 21);
            this.ShotsCheckBox.TabIndex = 4;
            this.ShotsCheckBox.Text = "Shots";
            this.ShotsCheckBox.UseVisualStyleBackColor = true;
            this.ShotsCheckBox.CheckedChanged += new System.EventHandler(this.ShotsCheckBox_CheckedChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(9, 12);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 17);
            this.AgeLabel.TabIndex = 8;
            this.AgeLabel.Text = "Age";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(48, 12);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 22);
            this.AgeTextBox.TabIndex = 3;
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.Location = new System.Drawing.Point(23, 154);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(140, 24);
            this.Health.TabIndex = 12;
            this.Health.Text = "Health Details";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ActivityLevelBox);
            this.panel2.Controls.Add(this.ErrorLabel);
            this.panel2.Controls.Add(this.InLabel);
            this.panel2.Controls.Add(this.LbLabel);
            this.panel2.Controls.Add(this.HeightTextBox);
            this.panel2.Controls.Add(this.HeightLabel);
            this.panel2.Controls.Add(this.WeightTextBox);
            this.panel2.Controls.Add(this.WeightLabel);
            this.panel2.Controls.Add(this.ColorLabel);
            this.panel2.Controls.Add(this.ColorTextBox);
            this.panel2.Location = new System.Drawing.Point(321, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 338);
            this.panel2.TabIndex = 5;
            // 
            // ActivityLevelBox
            // 
            this.ActivityLevelBox.Controls.Add(this.NeedyRadio);
            this.ActivityLevelBox.Controls.Add(this.HighRadio);
            this.ActivityLevelBox.Controls.Add(this.LowActivityRadio);
            this.ActivityLevelBox.Controls.Add(this.MediumRadio);
            this.ActivityLevelBox.Location = new System.Drawing.Point(14, 114);
            this.ActivityLevelBox.Name = "ActivityLevelBox";
            this.ActivityLevelBox.Size = new System.Drawing.Size(224, 135);
            this.ActivityLevelBox.TabIndex = 7;
            this.ActivityLevelBox.TabStop = false;
            this.ActivityLevelBox.Text = "Activity Level";
            // 
            // NeedyRadio
            // 
            this.NeedyRadio.AutoSize = true;
            this.NeedyRadio.Location = new System.Drawing.Point(6, 100);
            this.NeedyRadio.Name = "NeedyRadio";
            this.NeedyRadio.Size = new System.Drawing.Size(178, 21);
            this.NeedyRadio.TabIndex = 4;
            this.NeedyRadio.TabStop = true;
            this.NeedyRadio.Text = "Needy (Much Attention)";
            this.NeedyRadio.UseVisualStyleBackColor = true;
            // 
            // HighRadio
            // 
            this.HighRadio.AutoSize = true;
            this.HighRadio.Location = new System.Drawing.Point(6, 73);
            this.HighRadio.Name = "HighRadio";
            this.HighRadio.Size = new System.Drawing.Size(173, 21);
            this.HighRadio.TabIndex = 3;
            this.HighRadio.TabStop = true;
            this.HighRadio.Text = "High (Daily Interaction)";
            this.HighRadio.UseVisualStyleBackColor = true;
            // 
            // LowActivityRadio
            // 
            this.LowActivityRadio.AutoSize = true;
            this.LowActivityRadio.Checked = true;
            this.LowActivityRadio.Location = new System.Drawing.Point(6, 21);
            this.LowActivityRadio.Name = "LowActivityRadio";
            this.LowActivityRadio.Size = new System.Drawing.Size(191, 21);
            this.LowActivityRadio.TabIndex = 0;
            this.LowActivityRadio.TabStop = true;
            this.LowActivityRadio.Text = "Low (Very Little Attention)";
            this.LowActivityRadio.UseVisualStyleBackColor = true;
            // 
            // MediumRadio
            // 
            this.MediumRadio.AutoSize = true;
            this.MediumRadio.Location = new System.Drawing.Point(6, 46);
            this.MediumRadio.Name = "MediumRadio";
            this.MediumRadio.Size = new System.Drawing.Size(198, 21);
            this.MediumRadio.TabIndex = 1;
            this.MediumRadio.TabStop = true;
            this.MediumRadio.Text = "Medium (Some Interaction)";
            this.MediumRadio.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(16, 288);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(73, 17);
            this.ErrorLabel.TabIndex = 16;
            this.ErrorLabel.Text = "error label";
            this.ErrorLabel.Visible = false;
            // 
            // InLabel
            // 
            this.InLabel.AutoSize = true;
            this.InLabel.Location = new System.Drawing.Point(77, 80);
            this.InLabel.Name = "InLabel";
            this.InLabel.Size = new System.Drawing.Size(23, 17);
            this.InLabel.TabIndex = 15;
            this.InLabel.Text = "in.";
            // 
            // LbLabel
            // 
            this.LbLabel.AutoSize = true;
            this.LbLabel.Location = new System.Drawing.Point(174, 82);
            this.LbLabel.Name = "LbLabel";
            this.LbLabel.Size = new System.Drawing.Size(30, 17);
            this.LbLabel.TabIndex = 14;
            this.LbLabel.Text = "lbs.";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(14, 77);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(52, 22);
            this.HeightTextBox.TabIndex = 5;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(17, 57);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightLabel.TabIndex = 12;
            this.HeightLabel.Text = "Height";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(116, 77);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(52, 22);
            this.WeightTextBox.TabIndex = 6;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(113, 57);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(52, 17);
            this.WeightLabel.TabIndex = 9;
            this.WeightLabel.Text = "Weight";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(11, 12);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(41, 17);
            this.ColorLabel.TabIndex = 9;
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
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(242, 525);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(99, 37);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(350, 525);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 37);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AdoptionPriceText
            // 
            this.AdoptionPriceText.Location = new System.Drawing.Point(302, 50);
            this.AdoptionPriceText.Name = "AdoptionPriceText";
            this.AdoptionPriceText.Size = new System.Drawing.Size(245, 22);
            this.AdoptionPriceText.TabIndex = 3;
            this.AdoptionPriceText.Tag = "";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(301, 30);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(100, 17);
            this.PriceLabel.TabIndex = 11;
            this.PriceLabel.Text = "Adoption Price";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(457, 525);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(99, 37);
            this.DoneButton.TabIndex = 8;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 587);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AdoptionPriceText);
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
            this.SpaceNeedGroup.ResumeLayout(false);
            this.SpaceNeedGroup.PerformLayout();
            this.DishSizeGroupBox.ResumeLayout(false);
            this.DishSizeGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ActivityLevelBox.ResumeLayout(false);
            this.ActivityLevelBox.PerformLayout();
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
        private System.Windows.Forms.TextBox DishesPerWeekText;
        private System.Windows.Forms.Label DishPerWeekLabel;
        private System.Windows.Forms.Label FoodLabel;
        private System.Windows.Forms.TextBox FoodTextBox;
        private System.Windows.Forms.CheckBox ShotsCheckBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.DateTimePicker ShotsPicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InLabel;
        private System.Windows.Forms.Label LbLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label OtherDetailsLabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox AdoptionPriceText;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.GroupBox SpaceNeedGroup;
        private System.Windows.Forms.RadioButton XLSpaceRadio;
        private System.Windows.Forms.RadioButton LargeSpaceRadio;
        private System.Windows.Forms.RadioButton MedSpaceRadio;
        private System.Windows.Forms.RadioButton SmallSpaceRadio;
        private System.Windows.Forms.GroupBox DishSizeGroupBox;
        private System.Windows.Forms.RadioButton XLDishRadio;
        private System.Windows.Forms.RadioButton LargeDishRadio;
        private System.Windows.Forms.RadioButton MediumDishRadio;
        private System.Windows.Forms.RadioButton SmallDishRadio;
        private System.Windows.Forms.GroupBox ActivityLevelBox;
        private System.Windows.Forms.RadioButton NeedyRadio;
        private System.Windows.Forms.RadioButton HighRadio;
        private System.Windows.Forms.RadioButton LowActivityRadio;
        private System.Windows.Forms.RadioButton MediumRadio;
        private System.Windows.Forms.Button DoneButton;
    }
}