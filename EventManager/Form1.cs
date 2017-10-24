namespace EventManager
{
    using EventManager.Context;
    using EventManager.Models;
    using System;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    public partial class EventManagerForm : Form
    {
        public EventManagerForm()
        {
            InitializeComponent();
            UpdateEventBox(eventsBox);
        }

        private void UpdateEventBox(ListBox eventsBox)
        {
            eventsBox
                .Items
                .Clear();

            using (var db = new EventManagerDbContext())
            {
                var events = db
                    .Events
                    .ToList();

                foreach (var @event in events)
                {
                    eventsBox
                        .Items
                        .Add($"{@event.Id}; Name: {@event.Name}; Location: {@event.Location}; Period: {@event.StartDate:dd/M/yyyy};{@event.EndDate:dd/M/yyyy}");
                }
            }
            createButton.Show();
            updateButton.Show();
            deleteButton.Show();

            confirmDeleteButton.Hide();
            mainMenuButton.Hide();
            label1.Hide();
            nameLabel.Hide();
            nameTextBox.Hide();
            locationLabel.Hide();
            locationTextBox.Hide();
            startDateLabel.Hide();
            startDatePicker.Hide();
            endDateLabel.Hide();
            endDatePicker.Hide();
            createConfirmButton.Hide();
            nameExceptionLabel.Hide();
            locationExceptionLabel.Hide();
            updateConfirmButton.Hide();
            dateExceptionLabel.Hide();
        }

        private void eventsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainMenuButton.Visible == true && createConfirmButton.Visible == false 
                && updateConfirmButton.Visible == false && nameLabel.Visible==false)
            {
                confirmDeleteButton.Show();
            }

            if(mainMenuButton.Visible=true && deleteButton.Visible==false 
                && createConfirmButton.Visible == false && nameLabel.Visible == true)
            {
                updateConfirmButton.Show();
            }

            if (updateConfirmButton.Visible == true)
            {
                var eventInfo = eventsBox
                    .SelectedItem
                    .ToString()
                    .Split(';')
                    .ToArray();

                var eventName = eventInfo[1].Split(':')[1].Trim();
                var eventLocation = eventInfo[2].Split(':')[1].Trim();
                var startDate = DateTime.Parse(eventInfo[3].Split()[2].Trim());
                var endDate = DateTime.Parse(eventInfo[4].Trim());

                nameTextBox.Text = eventName;
                locationTextBox.Text = eventLocation;
                startDatePicker.Value = startDate;
                endDatePicker.Value = endDate;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Show();
            createButton.Hide();
            updateButton.Hide();
            deleteButton.Hide();
            confirmDeleteButton.Show();

            if (eventsBox.SelectedItem == null)
            {
                confirmDeleteButton.Hide();
            }
            mainMenuButton.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateEventBox(eventsBox);
        }

        private void confirmDeleteButton_Click(object sender, EventArgs e)
        {
            var selectedItem = eventsBox
                            .SelectedItem
                            .ToString();

            var id = int.Parse(selectedItem
                .Split(';')
                .ToArray()[0]);

            using (var db = new EventManagerDbContext())
            {
                var eventToRemove = db
                    .Events
                    .Where(ev => ev.Id == id)
                    .FirstOrDefault();

                db
                    .Events
                    .Remove(eventToRemove);

                db.SaveChanges();
            }

            UpdateEventBox(eventsBox);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            nameLabel.Show();
            nameTextBox.Show();
            nameTextBox.Text = string.Empty;
            locationLabel.Show();
            locationTextBox.Show();
            locationTextBox.Text = string.Empty;
            startDateLabel.Show();
            startDatePicker.Show();
            endDateLabel.Show();
            endDatePicker.Show();
            mainMenuButton.Show();
            updateButton.Hide();
            deleteButton.Hide();
            createButton.Hide();
            createConfirmButton.Show();
        }

        private void createConfirmButton_Click(object sender, EventArgs e)
        {
            var eventName = nameTextBox.Text;
            var eventLocation = locationTextBox.Text;

            if (eventName.Length < 3 || eventName.Length > 20 || eventName == null)
            {
                nameExceptionLabel.Show();
            }
            else if (eventLocation.Length < 3 || eventLocation.Length > 20)
            {
                locationExceptionLabel.Show();
            }
            else if (startDatePicker.Value>endDatePicker.Value)
            {
                dateExceptionLabel.Show();
            }
            else
            {
                var @event = new Event
                {
                    Name = eventName,
                    Location = eventLocation,
                    StartDate = DateTime.Parse(startDatePicker.Text),
                    EndDate = DateTime.Parse(endDatePicker.Text)
                };

                using (var db = new EventManagerDbContext())
                {
                    db
                        .Events
                        .Add(@event);

                    db.SaveChanges();
                }

                UpdateEventBox(eventsBox);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            label1.Show();
            createButton.Hide();
            updateButton.Hide();
            deleteButton.Hide();


            nameLabel.Show();
            nameTextBox.Show();
            nameTextBox.Text = string.Empty;
            locationLabel.Show();
            locationTextBox.Show();
            locationTextBox.Text = string.Empty;
            startDateLabel.Show();
            startDatePicker.Show();
            endDateLabel.Show();
            endDatePicker.Show();
            mainMenuButton.Show();
        }

        private void updateConfirmButton_Click(object sender, EventArgs e)
        {
            var selectedItem = eventsBox
                            .SelectedItem
                            .ToString();

            var id = int.Parse(selectedItem
                .Split(';')
                .ToArray()[0]);
            if (nameTextBox.Text.Length < 3 || nameTextBox.Text.Length > 20 || nameTextBox.Text == null)
            {
                nameExceptionLabel.Show();
            }
            else if (locationTextBox.Text.Length < 3 || locationTextBox.Text.Length > 20)
            {
                locationExceptionLabel.Show();
            }
            else if (startDatePicker.Value > endDatePicker.Value)
            {
                dateExceptionLabel.Show();
            }
            else
            {
                using (var db = new EventManagerDbContext())
                {
                    db
                        .Events
                        .Where(ev => ev.Id == id)
                        .FirstOrDefault()
                        .Name = nameTextBox.Text;

                    db
                        .Events
                        .Where(ev => ev.Id == id)
                        .FirstOrDefault()
                        .Location = locationTextBox.Text;

                    db
                        .Events
                        .Where(ev => ev.Id == id)
                        .FirstOrDefault()
                        .StartDate = DateTime.Parse(startDatePicker.Text);

                    db
                        .Events
                        .Where(ev => ev.Id == id)
                        .FirstOrDefault()
                        .EndDate = DateTime.Parse(startDatePicker.Text);

                    db.SaveChanges();

                    UpdateEventBox(eventsBox);
                }
            }
        }
    }
}
