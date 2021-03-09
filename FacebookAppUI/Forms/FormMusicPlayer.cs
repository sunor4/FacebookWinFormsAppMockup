namespace FacebookAppUI
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Windows.Media;

    public partial class FormMusicPlayer : FormBaseFacebookAppScreen
    {
        private static string[] s_MediaExtensions = {
             
            ".WAV", ".MID", ".MIDI", ".WMA", ".MP3", ".OGG", ".RMA", 
        };

        private readonly MediaPlayer r_MediaPlayer;

        public FormMusicPlayer()
        {
            InitializeComponent();
            r_MediaPlayer = new MediaPlayer();
        }

        private void buttonBrowseMusic_Click(object sender, EventArgs e)
        {
           browseMusicFile();
        }

        private void browseMusicFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(fileDialog.FileName))
            {
                if (isMediaFile(fileDialog.FileName))
                {
                    textBoxNowPlaying.Text = fileDialog.SafeFileName;
                    r_MediaPlayer.Open(new Uri(fileDialog.FileName));
                }
                else
                {
                    const string errorMessage = "Not a valid media file";
                    MessageBox.Show(errorMessage);
                }
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            r_MediaPlayer.Volume = trackBarVolume.Value / 100f;
        }

        private bool isMediaFile(string i_Path)
        {
            return -1 != Array.IndexOf(s_MediaExtensions, Path.GetExtension(i_Path).ToUpperInvariant());
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            pauseMusic();
        }

        private void pauseMusic()
        {
            r_MediaPlayer.Pause();
        }
       

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            playMusic();
        }

        private void playMusic()
        {
            r_MediaPlayer.Play();
        }

        private void buttonPlayVideo_Click(object sender, EventArgs e)
        {
            processLink();
        }

        private void processLink()
        {
            if (validateURL())
            {
                labelError.Visible = false;
                string htmlString = "<html><head>" +
                                    "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>" +
                                    "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen></iframe>" +
                                    "</body></html>";

                // Seperate the actual video "code" from the url the user provided in the textBoxLink (comes after the '/watch?v=':
                string youtubeToken = textBoxLink.Text.Split('=')[1];
                playVideo(htmlString, youtubeToken);
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void playVideo(string i_HtmlString, string i_YoutubeToken)
        {
            this.webBrowserYoutube.DocumentText = string.Format(i_HtmlString, i_YoutubeToken);
        }

        private bool validateURL()
        {
            bool result = false;
            Regex urlValidator = new Regex("^[https://]*[www\\.]*youtube\\.com/watch\\?v=.{11}");
            string urlToCheck = textBoxLink.Text.ToLower();
            if (urlValidator.IsMatch(urlToCheck))
            {
                result = true;
            }

            return result;
        }
    }
}
