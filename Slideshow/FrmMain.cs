using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{

    public partial class FrmMain : Form
    {
        const int                           TIMER_INTERVAL = 10000;
        int                                 imageIndex;
        Boolean                             isPlay;
        Boolean                             isSoundOn;
        String                              pathFolder;
        List<Image>                         imageList;
        private WMPLib.WindowsMediaPlayer   wplayer;
        Boolean                             firstTimePlay;

        public void init()
        {
            firstTimePlay   = true;
            imageIndex      = 0;
            isPlay          = false;
            isSoundOn       = false;
            pathFolder      = "";
            imageList       = new List<Image>();
            wplayer         = new WMPLib.WindowsMediaPlayer();
            wplayer.URL     = Application.StartupPath + @"\Resources\SunflowerPaddySunCover-SergeyYarovoy-4976513.mp3";

            wplayer.controls.stop();
        }


        public FrmMain()
        {
            InitializeComponent();

            init();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Btn_Folder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                pathFolder = folderBrowserDialog1.SelectedPath;
                String [] imageLinks = Directory.GetFiles(pathFolder, "*.jpg");

                foreach(String link in imageLinks)
                {
                    FileStream fileStream = new FileStream(link, FileMode.Open, FileAccess.Read);
                    imageList.Add(Image.FromStream(fileStream));
                }

                showImages();
            }
        }

        private void Btn_PlayPause_Click(object sender, EventArgs e)
        {
            if (imageList.Count == 0)
                    return;
            
            if (isPlay == false)
            {
                btn_PlayPause.LabelText = "Pause";
                btn_PlayPause.Image = global::SlideShow.Properties.Resources.icons8_pause_button_100;

                if (firstTimePlay)
                {
                    turnSoundOn(true);
                    firstTimePlay = false;
                    imageIndex++;
                }
                else
                    Timer1_Tick(null, null);

                timer1.Start();
                isPlay = true;   
            }
            else
            {
                timer1.Stop();
                isPlay = false;

                btn_PlayPause.LabelText = "Play";
                btn_PlayPause.Image = global::SlideShow.Properties.Resources.icons8_circled_play_100;
            }
        }

        void showImages()
        {
            bunifuTransition_LargeImages.HideSync(pictureBox_Large);

            pictureBox_Large.Image = imageList[imageIndex];
            pictureBox_Anh1.Image = (imageList[Math.Abs(imageIndex - 2 + imageList.Count) % imageList.Count]);
            pictureBox_Anh2.Image = (imageList[Math.Abs(imageIndex - 1 + imageList.Count) % imageList.Count]);
            pictureBox_Anh3.Image = (imageList[imageIndex]);
            pictureBox_Anh4.Image = (imageList[(imageIndex + 1) % imageList.Count]);
            pictureBox_Anh5.Image = (imageList[(imageIndex + 2) % imageList.Count]);

            bunifuTransition_LargeImages.ShowSync(pictureBox_Large);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            showImages();
            imageIndex = imageIndex == imageList.Count-1 ? 0 : imageIndex+1;
        }

        private void Btn_Previous_Click(object sender, EventArgs e)
        {
            if (--imageIndex == -1)
                imageIndex = imageList.Count;
            showImages();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (++imageIndex == imageList.Count)
                imageIndex = 0;
            showImages();
        }
        
        private void Btn_Sound_Click(object sender, EventArgs e)
        {
            turnSoundOn(!isSoundOn);
        }

        void turnSoundOn(Boolean choice)
        {
            if (choice == true)
            {
                wplayer.controls.play();
                isSoundOn = true;

                btn_Sound.LabelText = "Mute";
                btn_Sound.Image = global::SlideShow.Properties.Resources.icons8_mute_100;
            }
            else
            {
                wplayer.controls.pause();
                isSoundOn = false;

                btn_Sound.LabelText = "Turn on";
                btn_Sound.Image = global::SlideShow.Properties.Resources.icons8_sound_100;
            }
        }
    }
}
