namespace FacebookAppUI
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;
    using FacebookAppLogic.DesignPatterns;
    using FacebookAppLogic.Managers;
    using System;
    using System.Threading;

    public partial class FormBaseFacebookAppScreen : Form
    {
        private readonly FacebookAppManager r_AppManager =
            ManagersFactory.GetInstance<FacebookAppManager>();


        public FacebookAppManager AppManager
        {
            get { return r_AppManager; }
        }

        public FormBaseFacebookAppScreen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected void PopulateListBoxOfType<T>(IEnumerable<T> i_Items, ListBox i_ListBox)
        {
            new Thread(() =>
            {
                this.Invoke(new Action(() =>
                {
                    i_ListBox.Items.Clear();

                    foreach (T item in i_Items)
                    {
                        i_ListBox.Items.Add(item);
                    }
                }));
            }).Start();
        }
    }
}
