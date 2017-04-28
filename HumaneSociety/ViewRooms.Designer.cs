namespace HumaneSociety
{
    partial class ViewRooms
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
            this.RoomsDataGrid = new System.Windows.Forms.DataGridView();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllRadio = new System.Windows.Forms.RadioButton();
            this.EmptyRadio = new System.Windows.Forms.RadioButton();
            this.OccupiedRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomsDataGrid
            // 
            this.RoomsDataGrid.AllowUserToAddRows = false;
            this.RoomsDataGrid.AllowUserToDeleteRows = false;
            this.RoomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomsDataGrid.Location = new System.Drawing.Point(13, 33);
            this.RoomsDataGrid.Name = "RoomsDataGrid";
            this.RoomsDataGrid.ReadOnly = true;
            this.RoomsDataGrid.RowTemplate.Height = 24;
            this.RoomsDataGrid.Size = new System.Drawing.Size(560, 418);
            this.RoomsDataGrid.TabIndex = 0;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(656, 385);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(137, 66);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AllRadio);
            this.panel1.Controls.Add(this.EmptyRadio);
            this.panel1.Controls.Add(this.OccupiedRadio);
            this.panel1.Location = new System.Drawing.Point(593, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 2;
            // 
            // AllRadio
            // 
            this.AllRadio.AutoSize = true;
            this.AllRadio.Location = new System.Drawing.Point(15, 81);
            this.AllRadio.Name = "AllRadio";
            this.AllRadio.Size = new System.Drawing.Size(92, 21);
            this.AllRadio.TabIndex = 2;
            this.AllRadio.TabStop = true;
            this.AllRadio.Text = "All Rooms";
            this.AllRadio.UseVisualStyleBackColor = true;
            this.AllRadio.CheckedChanged += new System.EventHandler(this.AllRadio_CheckedChanged);
            // 
            // EmptyRadio
            // 
            this.EmptyRadio.AutoSize = true;
            this.EmptyRadio.Location = new System.Drawing.Point(15, 54);
            this.EmptyRadio.Name = "EmptyRadio";
            this.EmptyRadio.Size = new System.Drawing.Size(116, 21);
            this.EmptyRadio.TabIndex = 1;
            this.EmptyRadio.TabStop = true;
            this.EmptyRadio.Text = "Empty Rooms";
            this.EmptyRadio.UseVisualStyleBackColor = true;
            this.EmptyRadio.CheckedChanged += new System.EventHandler(this.EmptyRadio_CheckedChanged);
            // 
            // OccupiedRadio
            // 
            this.OccupiedRadio.AutoSize = true;
            this.OccupiedRadio.Checked = true;
            this.OccupiedRadio.Location = new System.Drawing.Point(14, 26);
            this.OccupiedRadio.Name = "OccupiedRadio";
            this.OccupiedRadio.Size = new System.Drawing.Size(137, 21);
            this.OccupiedRadio.TabIndex = 0;
            this.OccupiedRadio.TabStop = true;
            this.OccupiedRadio.Text = "Occupied Rooms";
            this.OccupiedRadio.UseVisualStyleBackColor = true;
            this.OccupiedRadio.CheckedChanged += new System.EventHandler(this.OccupiedRadio_CheckedChanged);
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.RoomsDataGrid);
            this.Name = "ViewRooms";
            this.Text = "View Rooms";
            this.Load += new System.EventHandler(this.ViewRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomsDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomsDataGrid;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AllRadio;
        private System.Windows.Forms.RadioButton EmptyRadio;
        private System.Windows.Forms.RadioButton OccupiedRadio;
    }
}