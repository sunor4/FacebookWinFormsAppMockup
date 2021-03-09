namespace FacebookAppUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using FacebookWrapper.ObjectModel;

    public partial class FormAlbumsScreen : FormBaseFacebookAppScreen
    {
        private readonly List<PictureBox> r_CurrentAlbumPictureBoxes = new List<PictureBox>();

        public FormAlbumsScreen()
        {
            InitializeComponent();
            initLocalCollections();
        }

        private void initLocalCollections()
        {
            initCurrentAlbumPictureBoxes();
        }

        private void initCurrentAlbumPictureBoxes()
        {
            const string albumPictureBoxName = "pictureBoxCurrentAlbum";
            Regex albumPictureBoxPattern = new Regex("^" + albumPictureBoxName + "\\d$");
            IEnumerable<PictureBox> pictureBoxList = this.Controls.OfType<PictureBox>();
            foreach (PictureBox albumPictureBox in pictureBoxList)
            {
                if (albumPictureBoxPattern.IsMatch(albumPictureBox.Name))
                {
                    r_CurrentAlbumPictureBoxes.Add(albumPictureBox);
                }
            }
        }

        private void buttonShowAlbums_Click(object sender, EventArgs e)
        {
            listBoxAlbums.DisplayMember = "Name";
            PopulateListBoxOfType(AppManager.LoggedInUser.Albums, listBoxAlbums);

            if (AppManager.LoggedInUser.Albums.Count == 0)
            {
                const string errorMessage = "No Albums to retrieve!";
                MessageBox.Show(errorMessage);
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1 &&
                listBoxAlbums.SelectedItem is Album selectedAlbum)
            {
                for (int i = 0; i < selectedAlbum.Photos.Count && i < r_CurrentAlbumPictureBoxes.Count; i++)
                {
                    Photo currentPhoto = selectedAlbum.Photos[i];
                    if (currentPhoto.PictureNormalURL != null)
                    {
                        // Show first 9 pictures
                        r_CurrentAlbumPictureBoxes[i].LoadAsync(currentPhoto.PictureNormalURL);
                        r_CurrentAlbumPictureBoxes[i].Visible = true;
                    }
                }

                Console.WriteLine(selectedAlbum.Photos.Count);

                if (selectedAlbum.Photos.Count < r_CurrentAlbumPictureBoxes.Count)
                {
                    for (int i = selectedAlbum.Photos.Count; i < r_CurrentAlbumPictureBoxes.Count; i++)
                    {
                        r_CurrentAlbumPictureBoxes[i].Visible = false;
                    }
                }
            }
        }
    }
}
