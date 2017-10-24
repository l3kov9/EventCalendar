namespace EventManager
{
    partial class EventManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagerForm));
            this.eventsBox = new System.Windows.Forms.ListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmDeleteButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.createConfirmButton = new System.Windows.Forms.Button();
            this.nameExceptionLabel = new System.Windows.Forms.Label();
            this.locationExceptionLabel = new System.Windows.Forms.Label();
            this.updateConfirmButton = new System.Windows.Forms.Button();
            this.dateExceptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventsBox
            // 
            this.eventsBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.eventsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.eventsBox.FormattingEnabled = true;
            this.eventsBox.HorizontalScrollbar = true;
            this.eventsBox.Location = new System.Drawing.Point(35, 254);
            this.eventsBox.Name = "eventsBox";
            this.eventsBox.ScrollAlwaysVisible = true;
            this.eventsBox.Size = new System.Drawing.Size(475, 147);
            this.eventsBox.TabIndex = 0;
            this.eventsBox.SelectedIndexChanged += new System.EventHandler(this.eventsBox_SelectedIndexChanged);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.createButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.createButton.Location = new System.Drawing.Point(35, 27);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(194, 41);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create Event";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.updateButton.ForeColor = System.Drawing.Color.Green;
            this.updateButton.Location = new System.Drawing.Point(35, 139);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(194, 41);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update Event";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.deleteButton.ForeColor = System.Drawing.Color.Green;
            this.deleteButton.Location = new System.Drawing.Point(35, 196);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(194, 41);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Event";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select an Event from the box";
            // 
            // confirmDeleteButton
            // 
            this.confirmDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.confirmDeleteButton.ForeColor = System.Drawing.Color.Red;
            this.confirmDeleteButton.Location = new System.Drawing.Point(35, 203);
            this.confirmDeleteButton.Name = "confirmDeleteButton";
            this.confirmDeleteButton.Size = new System.Drawing.Size(118, 34);
            this.confirmDeleteButton.TabIndex = 5;
            this.confirmDeleteButton.Text = "Delete";
            this.confirmDeleteButton.UseVisualStyleBackColor = true;
            this.confirmDeleteButton.Click += new System.EventHandler(this.confirmDeleteButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.mainMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mainMenuButton.Location = new System.Drawing.Point(35, 27);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(100, 34);
            this.mainMenuButton.TabIndex = 6;
            this.mainMenuButton.Text = "Main Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameLabel.Location = new System.Drawing.Point(290, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(290, 91);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(48, 13);
            this.locationLabel.TabIndex = 8;
            this.locationLabel.Text = "Location";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(290, 129);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 9;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(290, 167);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 10;
            this.endDateLabel.Text = "End Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(366, 123);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(133, 20);
            this.startDatePicker.TabIndex = 11;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.endDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.endDatePicker.Location = new System.Drawing.Point(366, 160);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(133, 20);
            this.endDatePicker.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(366, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(133, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(366, 84);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(133, 20);
            this.locationTextBox.TabIndex = 14;
            // 
            // createConfirmButton
            // 
            this.createConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.createConfirmButton.ForeColor = System.Drawing.Color.Blue;
            this.createConfirmButton.Location = new System.Drawing.Point(402, 203);
            this.createConfirmButton.Name = "createConfirmButton";
            this.createConfirmButton.Size = new System.Drawing.Size(91, 34);
            this.createConfirmButton.TabIndex = 15;
            this.createConfirmButton.Text = "Create";
            this.createConfirmButton.UseVisualStyleBackColor = true;
            this.createConfirmButton.Click += new System.EventHandler(this.createConfirmButton_Click);
            // 
            // nameExceptionLabel
            // 
            this.nameExceptionLabel.AutoSize = true;
            this.nameExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.nameExceptionLabel.Location = new System.Drawing.Point(292, 27);
            this.nameExceptionLabel.Name = "nameExceptionLabel";
            this.nameExceptionLabel.Size = new System.Drawing.Size(207, 13);
            this.nameExceptionLabel.TabIndex = 16;
            this.nameExceptionLabel.Text = "Name must be between 3 and 20 symbols!";
            // 
            // locationExceptionLabel
            // 
            this.locationExceptionLabel.AutoSize = true;
            this.locationExceptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.locationExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.locationExceptionLabel.Location = new System.Drawing.Point(279, 68);
            this.locationExceptionLabel.Name = "locationExceptionLabel";
            this.locationExceptionLabel.Size = new System.Drawing.Size(220, 13);
            this.locationExceptionLabel.TabIndex = 17;
            this.locationExceptionLabel.Text = "Location must be between 3 and 20 symbols!";
            // 
            // updateConfirmButton
            // 
            this.updateConfirmButton.BackColor = System.Drawing.Color.Silver;
            this.updateConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.updateConfirmButton.ForeColor = System.Drawing.Color.Green;
            this.updateConfirmButton.Location = new System.Drawing.Point(398, 203);
            this.updateConfirmButton.Name = "updateConfirmButton";
            this.updateConfirmButton.Size = new System.Drawing.Size(95, 34);
            this.updateConfirmButton.TabIndex = 18;
            this.updateConfirmButton.Text = "Update";
            this.updateConfirmButton.UseVisualStyleBackColor = false;
            this.updateConfirmButton.Click += new System.EventHandler(this.updateConfirmButton_Click);
            // 
            // dateExceptionLabel
            // 
            this.dateExceptionLabel.AutoSize = true;
            this.dateExceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.dateExceptionLabel.Location = new System.Drawing.Point(323, 107);
            this.dateExceptionLabel.Name = "dateExceptionLabel";
            this.dateExceptionLabel.Size = new System.Drawing.Size(176, 13);
            this.dateExceptionLabel.TabIndex = 19;
            this.dateExceptionLabel.Text = "Start Date must be before End Date";
            // 
            // EventManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 451);
            this.Controls.Add(this.dateExceptionLabel);
            this.Controls.Add(this.updateConfirmButton);
            this.Controls.Add(this.locationExceptionLabel);
            this.Controls.Add(this.nameExceptionLabel);
            this.Controls.Add(this.createConfirmButton);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.confirmDeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.eventsBox);
            this.Name = "EventManagerForm";
            this.Text = "Event Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox eventsBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmDeleteButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Button createConfirmButton;
        private System.Windows.Forms.Label nameExceptionLabel;
        private System.Windows.Forms.Label locationExceptionLabel;
        private System.Windows.Forms.Button updateConfirmButton;
        private System.Windows.Forms.Label dateExceptionLabel;
    }
}

