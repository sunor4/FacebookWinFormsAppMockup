namespace FacebookAppUI
{
    using System;
    using FacebookWrapper.ObjectModel;

    public partial class FormEventerScreen : FormBaseFacebookAppScreen
    {
        public FormEventerScreen()
        {
            InitializeComponent();
        }

        private void buttonShowEvents_Click(object sender, EventArgs e)
        {
            PopulateListBoxOfType(AppManager.LoggedInUser.EventsNotYetReplied, listBoxEventsNotYetReplied);
        }

        private void listBoxEventsNotYetReplied_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEventsNotYetReplied.SelectedItems.Count == 1)
            {
                if (listBoxEventsNotYetReplied.SelectedItem is Event selectedEvent)
                {
                    showEventProperties(true, selectedEvent);
                }
            }
        }

        private void showEventProperties(bool i_Show, Event i_Event)
        {
            buttonAcceptEvent.Enabled = i_Show;
            buttonDeclineEvent.Enabled = i_Show;
            buttonMaybeEvent.Enabled = i_Show;

            textBoxEventDescribtion.Visible = i_Show;
            textBoxEventGoingCount.Visible = i_Show;
            textBoxEventLocation.Visible = i_Show;
            textBoxEventTime.Visible = i_Show;

            labelEventDescribtion.Visible = i_Show;
            labelEventGoingCount.Visible = i_Show;
            labelEventLocatioin.Visible = i_Show;
            labelEventTime.Visible = i_Show;

            if (i_Show)
            {
                textBoxEventTime.Text = i_Event.StartTime.ToString();
                textBoxEventDescribtion.Text = i_Event.Description;
      
                textBoxEventLocation.Text = i_Event.Location;
            }
        }

        private void buttonAcceptEvent_Click(object sender, EventArgs e)
        {
            respondToEvent(Event.eRsvpType.Attending);
        }

        private void buttonMaybeEvent_Click(object sender, EventArgs e)
        {
            respondToEvent(Event.eRsvpType.Maybe);
        }

        private void buttonDeclineEvent_Click(object sender, EventArgs e)
        {
            respondToEvent(Event.eRsvpType.Declined);
        }

        private void respondToEvent(Event.eRsvpType i_RsvpType)
        {
            if (listBoxEventsNotYetReplied.SelectedItems.Count == 1)
            {
                if (listBoxEventsNotYetReplied.SelectedItem is Event selectedEvent)
                {
                    listBoxEventsNotYetReplied.Items.Remove(selectedEvent);
                    showEventProperties(false, selectedEvent);
                    selectedEvent.Respond(i_RsvpType);
                }
            }
        }
    }
}
