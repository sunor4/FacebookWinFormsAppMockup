namespace FacebookAppUI
{
    partial class FormEventerScreen
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
            this.buttonAcceptEvent = new System.Windows.Forms.Button();
            this.buttonDeclineEvent = new System.Windows.Forms.Button();
            this.buttonMaybeEvent = new System.Windows.Forms.Button();
            this.listBoxEventsNotYetReplied = new System.Windows.Forms.ListBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.textBoxEventGoingCount = new System.Windows.Forms.TextBox();
            this.textBoxEventLocation = new System.Windows.Forms.TextBox();
            this.textBoxEventTime = new System.Windows.Forms.TextBox();
            this.textBoxEventDescribtion = new System.Windows.Forms.TextBox();
            this.labelEventGoingCount = new System.Windows.Forms.Label();
            this.labelEventLocatioin = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventDescribtion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcceptEvent
            // 
            this.buttonAcceptEvent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAcceptEvent.Enabled = false;
            this.buttonAcceptEvent.Location = new System.Drawing.Point(299, 71);
            this.buttonAcceptEvent.Name = "buttonAcceptEvent";
            this.buttonAcceptEvent.Size = new System.Drawing.Size(84, 24);
            this.buttonAcceptEvent.TabIndex = 26;
            this.buttonAcceptEvent.Text = "Accept";
            this.buttonAcceptEvent.UseVisualStyleBackColor = false;
            this.buttonAcceptEvent.Click += new System.EventHandler(this.buttonAcceptEvent_Click);
            // 
            // buttonDeclineEvent
            // 
            this.buttonDeclineEvent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeclineEvent.Enabled = false;
            this.buttonDeclineEvent.Location = new System.Drawing.Point(299, 129);
            this.buttonDeclineEvent.Name = "buttonDeclineEvent";
            this.buttonDeclineEvent.Size = new System.Drawing.Size(84, 23);
            this.buttonDeclineEvent.TabIndex = 25;
            this.buttonDeclineEvent.Text = "Decline";
            this.buttonDeclineEvent.UseVisualStyleBackColor = false;
            this.buttonDeclineEvent.Click += new System.EventHandler(this.buttonDeclineEvent_Click);
            // 
            // buttonMaybeEvent
            // 
            this.buttonMaybeEvent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMaybeEvent.Enabled = false;
            this.buttonMaybeEvent.Location = new System.Drawing.Point(299, 101);
            this.buttonMaybeEvent.Name = "buttonMaybeEvent";
            this.buttonMaybeEvent.Size = new System.Drawing.Size(84, 22);
            this.buttonMaybeEvent.TabIndex = 24;
            this.buttonMaybeEvent.Text = "Maybe";
            this.buttonMaybeEvent.UseVisualStyleBackColor = false;
            this.buttonMaybeEvent.Click += new System.EventHandler(this.buttonMaybeEvent_Click);
            // 
            // listBoxEventsNotYetReplied
            // 
            this.listBoxEventsNotYetReplied.FormattingEnabled = true;
            this.listBoxEventsNotYetReplied.Location = new System.Drawing.Point(12, 12);
            this.listBoxEventsNotYetReplied.Name = "listBoxEventsNotYetReplied";
            this.listBoxEventsNotYetReplied.Size = new System.Drawing.Size(260, 212);
            this.listBoxEventsNotYetReplied.TabIndex = 23;
            this.listBoxEventsNotYetReplied.SelectedIndexChanged += new System.EventHandler(this.listBoxEventsNotYetReplied_SelectedIndexChanged);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonShowEvents.Location = new System.Drawing.Point(299, 12);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(84, 43);
            this.buttonShowEvents.TabIndex = 22;
            this.buttonShowEvents.Text = "Show Pending Events";
            this.buttonShowEvents.UseVisualStyleBackColor = false;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // textBoxEventGoingCount
            // 
            this.textBoxEventGoingCount.BackColor = System.Drawing.Color.White;
            this.textBoxEventGoingCount.Location = new System.Drawing.Point(362, 365);
            this.textBoxEventGoingCount.Multiline = true;
            this.textBoxEventGoingCount.Name = "textBoxEventGoingCount";
            this.textBoxEventGoingCount.ReadOnly = true;
            this.textBoxEventGoingCount.Size = new System.Drawing.Size(197, 23);
            this.textBoxEventGoingCount.TabIndex = 39;
            this.textBoxEventGoingCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEventGoingCount.Visible = false;
            // 
            // textBoxEventLocation
            // 
            this.textBoxEventLocation.BackColor = System.Drawing.Color.White;
            this.textBoxEventLocation.Location = new System.Drawing.Point(72, 390);
            this.textBoxEventLocation.Multiline = true;
            this.textBoxEventLocation.Name = "textBoxEventLocation";
            this.textBoxEventLocation.ReadOnly = true;
            this.textBoxEventLocation.Size = new System.Drawing.Size(197, 23);
            this.textBoxEventLocation.TabIndex = 38;
            this.textBoxEventLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEventLocation.Visible = false;
            // 
            // textBoxEventTime
            // 
            this.textBoxEventTime.BackColor = System.Drawing.Color.White;
            this.textBoxEventTime.Location = new System.Drawing.Point(72, 365);
            this.textBoxEventTime.Multiline = true;
            this.textBoxEventTime.Name = "textBoxEventTime";
            this.textBoxEventTime.ReadOnly = true;
            this.textBoxEventTime.Size = new System.Drawing.Size(197, 23);
            this.textBoxEventTime.TabIndex = 37;
            this.textBoxEventTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEventTime.Visible = false;
            // 
            // textBoxEventDescribtion
            // 
            this.textBoxEventDescribtion.BackColor = System.Drawing.Color.White;
            this.textBoxEventDescribtion.Location = new System.Drawing.Point(72, 242);
            this.textBoxEventDescribtion.Multiline = true;
            this.textBoxEventDescribtion.Name = "textBoxEventDescribtion";
            this.textBoxEventDescribtion.ReadOnly = true;
            this.textBoxEventDescribtion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEventDescribtion.Size = new System.Drawing.Size(197, 103);
            this.textBoxEventDescribtion.TabIndex = 36;
            this.textBoxEventDescribtion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEventDescribtion.Visible = false;
            // 
            // labelEventGoingCount
            // 
            this.labelEventGoingCount.AutoSize = true;
            this.labelEventGoingCount.Location = new System.Drawing.Point(321, 368);
            this.labelEventGoingCount.Name = "labelEventGoingCount";
            this.labelEventGoingCount.Size = new System.Drawing.Size(35, 13);
            this.labelEventGoingCount.TabIndex = 35;
            this.labelEventGoingCount.Text = "Going";
            this.labelEventGoingCount.Visible = false;
            // 
            // labelEventLocatioin
            // 
            this.labelEventLocatioin.AutoSize = true;
            this.labelEventLocatioin.Location = new System.Drawing.Point(6, 392);
            this.labelEventLocatioin.Name = "labelEventLocatioin";
            this.labelEventLocatioin.Size = new System.Drawing.Size(39, 13);
            this.labelEventLocatioin.TabIndex = 34;
            this.labelEventLocatioin.Text = "Where";
            this.labelEventLocatioin.Visible = false;
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Location = new System.Drawing.Point(6, 368);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(36, 13);
            this.labelEventTime.TabIndex = 33;
            this.labelEventTime.Text = "When";
            this.labelEventTime.Visible = false;
            // 
            // labelEventDescribtion
            // 
            this.labelEventDescribtion.AutoSize = true;
            this.labelEventDescribtion.Location = new System.Drawing.Point(6, 242);
            this.labelEventDescribtion.Name = "labelEventDescribtion";
            this.labelEventDescribtion.Size = new System.Drawing.Size(60, 13);
            this.labelEventDescribtion.TabIndex = 32;
            this.labelEventDescribtion.Text = "Describtion";
            this.labelEventDescribtion.Visible = false;
            // 
            // FormEventerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(630, 432);
            this.Controls.Add(this.textBoxEventGoingCount);
            this.Controls.Add(this.textBoxEventLocation);
            this.Controls.Add(this.textBoxEventTime);
            this.Controls.Add(this.textBoxEventDescribtion);
            this.Controls.Add(this.labelEventGoingCount);
            this.Controls.Add(this.labelEventLocatioin);
            this.Controls.Add(this.labelEventTime);
            this.Controls.Add(this.labelEventDescribtion);
            this.Controls.Add(this.buttonAcceptEvent);
            this.Controls.Add(this.buttonDeclineEvent);
            this.Controls.Add(this.buttonMaybeEvent);
            this.Controls.Add(this.listBoxEventsNotYetReplied);
            this.Controls.Add(this.buttonShowEvents);
            this.Name = "FormEventerScreen";
            this.Text = "Eventer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptEvent;
        private System.Windows.Forms.Button buttonDeclineEvent;
        private System.Windows.Forms.Button buttonMaybeEvent;
        private System.Windows.Forms.ListBox listBoxEventsNotYetReplied;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.TextBox textBoxEventGoingCount;
        private System.Windows.Forms.TextBox textBoxEventLocation;
        private System.Windows.Forms.TextBox textBoxEventTime;
        private System.Windows.Forms.TextBox textBoxEventDescribtion;
        private System.Windows.Forms.Label labelEventGoingCount;
        private System.Windows.Forms.Label labelEventLocatioin;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventDescribtion;
    }
}