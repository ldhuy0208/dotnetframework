using System;

namespace SlideShow
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition_ShowThumbnails = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sound = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Folder = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Next = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Previous = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_PlayPause = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel_Background = new System.Windows.Forms.Panel();
            this.panel_LeftDock = new System.Windows.Forms.Panel();
            this.pictureBox_Anh1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Anh2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Anh3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Anh4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Anh5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Large = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition_LargeImages = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bunifuTransition_HideThumbnails = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Background.SuspendLayout();
            this.panel_LeftDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Large)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1690, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_Exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_Exit, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_Exit, BunifuAnimatorNS.DecorationType.None);
            this.btn_Exit.Image = global::SlideShow.Properties.Resources.icons8_xbox_x_100;
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(1609, 20);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(61, 57);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Georgia", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slideshow";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition_ShowThumbnails
            // 
            this.bunifuTransition_ShowThumbnails.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition_ShowThumbnails.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition_ShowThumbnails.DefaultAnimation = animation1;
            this.bunifuTransition_ShowThumbnails.MaxAnimationTime = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.panel2.Controls.Add(this.btn_Sound);
            this.panel2.Controls.Add(this.btn_Folder);
            this.panel2.Controls.Add(this.btn_Next);
            this.panel2.Controls.Add(this.btn_Previous);
            this.panel2.Controls.Add(this.btn_PlayPause);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 864);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1690, 136);
            this.panel2.TabIndex = 3;
            // 
            // btn_Sound
            // 
            this.btn_Sound.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sound.color = System.Drawing.Color.Transparent;
            this.btn_Sound.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.btn_Sound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_Sound, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_Sound, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_Sound, BunifuAnimatorNS.DecorationType.None);
            this.btn_Sound.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sound.ForeColor = System.Drawing.Color.White;
            this.btn_Sound.Image = global::SlideShow.Properties.Resources.icons8_sound_100;
            this.btn_Sound.ImagePosition = 14;
            this.btn_Sound.ImageZoom = 50;
            this.btn_Sound.LabelPosition = 45;
            this.btn_Sound.LabelText = "Turn on";
            this.btn_Sound.Location = new System.Drawing.Point(1552, 1);
            this.btn_Sound.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Sound.Name = "btn_Sound";
            this.btn_Sound.Size = new System.Drawing.Size(139, 136);
            this.btn_Sound.TabIndex = 6;
            this.btn_Sound.Click += new System.EventHandler(this.Btn_Sound_Click);
            // 
            // btn_Folder
            // 
            this.btn_Folder.BackColor = System.Drawing.Color.Transparent;
            this.btn_Folder.color = System.Drawing.Color.Transparent;
            this.btn_Folder.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.btn_Folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_Folder, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_Folder, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_Folder, BunifuAnimatorNS.DecorationType.None);
            this.btn_Folder.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Folder.ForeColor = System.Drawing.Color.White;
            this.btn_Folder.Image = global::SlideShow.Properties.Resources.icons8_folder_100;
            this.btn_Folder.ImagePosition = 14;
            this.btn_Folder.ImageZoom = 50;
            this.btn_Folder.LabelPosition = 45;
            this.btn_Folder.LabelText = "Folder";
            this.btn_Folder.Location = new System.Drawing.Point(0, 0);
            this.btn_Folder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Folder.Name = "btn_Folder";
            this.btn_Folder.Size = new System.Drawing.Size(139, 136);
            this.btn_Folder.TabIndex = 5;
            this.btn_Folder.Click += new System.EventHandler(this.Btn_Folder_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.btn_Next.color = System.Drawing.Color.Transparent;
            this.btn_Next.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_Next, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_Next, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_Next, BunifuAnimatorNS.DecorationType.None);
            this.btn_Next.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Image = global::SlideShow.Properties.Resources.icons8_end_100__1_;
            this.btn_Next.ImagePosition = 14;
            this.btn_Next.ImageZoom = 50;
            this.btn_Next.LabelPosition = 45;
            this.btn_Next.LabelText = "Next";
            this.btn_Next.Location = new System.Drawing.Point(925, 1);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(139, 136);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.Transparent;
            this.btn_Previous.color = System.Drawing.Color.Transparent;
            this.btn_Previous.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.btn_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_Previous, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_Previous, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_Previous, BunifuAnimatorNS.DecorationType.None);
            this.btn_Previous.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.ForeColor = System.Drawing.Color.White;
            this.btn_Previous.Image = global::SlideShow.Properties.Resources.icons8_skip_to_start_100;
            this.btn_Previous.ImagePosition = 14;
            this.btn_Previous.ImageZoom = 50;
            this.btn_Previous.LabelPosition = 45;
            this.btn_Previous.LabelText = "Previous";
            this.btn_Previous.Location = new System.Drawing.Point(627, 0);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(139, 136);
            this.btn_Previous.TabIndex = 3;
            this.btn_Previous.Click += new System.EventHandler(this.Btn_Previous_Click);
            // 
            // btn_PlayPause
            // 
            this.btn_PlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btn_PlayPause.color = System.Drawing.Color.Transparent;
            this.btn_PlayPause.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(165)))), ((int)(((byte)(240)))));
            this.btn_PlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition_LargeImages.SetDecoration(this.btn_PlayPause, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.btn_PlayPause, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.btn_PlayPause, BunifuAnimatorNS.DecorationType.None);
            this.btn_PlayPause.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayPause.ForeColor = System.Drawing.Color.White;
            this.btn_PlayPause.Image = global::SlideShow.Properties.Resources.icons8_circled_play_100;
            this.btn_PlayPause.ImagePosition = 14;
            this.btn_PlayPause.ImageZoom = 50;
            this.btn_PlayPause.LabelPosition = 45;
            this.btn_PlayPause.LabelText = "Play";
            this.btn_PlayPause.Location = new System.Drawing.Point(776, 1);
            this.btn_PlayPause.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_PlayPause.Name = "btn_PlayPause";
            this.btn_PlayPause.Size = new System.Drawing.Size(139, 136);
            this.btn_PlayPause.TabIndex = 2;
            this.btn_PlayPause.Click += new System.EventHandler(this.Btn_PlayPause_Click);
            // 
            // panel_Background
            // 
            this.panel_Background.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Background.Controls.Add(this.panel_LeftDock);
            this.panel_Background.Controls.Add(this.panel1);
            this.panel_Background.Controls.Add(this.pictureBox_Large);
            this.panel_Background.Controls.Add(this.panel2);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.panel_Background, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.panel_Background, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.panel_Background, BunifuAnimatorNS.DecorationType.None);
            this.panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Size = new System.Drawing.Size(1692, 1002);
            this.panel_Background.TabIndex = 4;
            // 
            // panel_LeftDock
            // 
            this.panel_LeftDock.BackColor = System.Drawing.Color.Transparent;
            this.panel_LeftDock.Controls.Add(this.pictureBox_Anh1);
            this.panel_LeftDock.Controls.Add(this.pictureBox_Anh2);
            this.panel_LeftDock.Controls.Add(this.pictureBox_Anh3);
            this.panel_LeftDock.Controls.Add(this.pictureBox_Anh4);
            this.panel_LeftDock.Controls.Add(this.pictureBox_Anh5);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.panel_LeftDock, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.panel_LeftDock, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this.panel_LeftDock, BunifuAnimatorNS.DecorationType.None);
            this.panel_LeftDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_LeftDock.Location = new System.Drawing.Point(0, 100);
            this.panel_LeftDock.Name = "panel_LeftDock";
            this.panel_LeftDock.Size = new System.Drawing.Size(275, 764);
            this.panel_LeftDock.TabIndex = 9;
            // 
            // pictureBox_Anh1
            // 
            this.pictureBox_Anh1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Anh1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Anh1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Anh1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Anh1.Location = new System.Drawing.Point(21, 23);
            this.pictureBox_Anh1.Name = "pictureBox_Anh1";
            this.pictureBox_Anh1.Size = new System.Drawing.Size(240, 132);
            this.pictureBox_Anh1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Anh1.TabIndex = 4;
            this.pictureBox_Anh1.TabStop = false;
            // 
            // pictureBox_Anh2
            // 
            this.pictureBox_Anh2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Anh2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Anh2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Anh2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Anh2.Location = new System.Drawing.Point(21, 170);
            this.pictureBox_Anh2.Name = "pictureBox_Anh2";
            this.pictureBox_Anh2.Size = new System.Drawing.Size(240, 132);
            this.pictureBox_Anh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Anh2.TabIndex = 5;
            this.pictureBox_Anh2.TabStop = false;
            // 
            // pictureBox_Anh3
            // 
            this.pictureBox_Anh3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Anh3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Anh3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Anh3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Anh3.Location = new System.Drawing.Point(21, 317);
            this.pictureBox_Anh3.Name = "pictureBox_Anh3";
            this.pictureBox_Anh3.Size = new System.Drawing.Size(240, 132);
            this.pictureBox_Anh3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Anh3.TabIndex = 6;
            this.pictureBox_Anh3.TabStop = false;
            // 
            // pictureBox_Anh4
            // 
            this.pictureBox_Anh4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Anh4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Anh4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Anh4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Anh4.Location = new System.Drawing.Point(21, 464);
            this.pictureBox_Anh4.Name = "pictureBox_Anh4";
            this.pictureBox_Anh4.Size = new System.Drawing.Size(240, 132);
            this.pictureBox_Anh4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Anh4.TabIndex = 7;
            this.pictureBox_Anh4.TabStop = false;
            // 
            // pictureBox_Anh5
            // 
            this.pictureBox_Anh5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Anh5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Anh5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Anh5, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Anh5.Location = new System.Drawing.Point(21, 611);
            this.pictureBox_Anh5.Name = "pictureBox_Anh5";
            this.pictureBox_Anh5.Size = new System.Drawing.Size(240, 132);
            this.pictureBox_Anh5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Anh5.TabIndex = 8;
            this.pictureBox_Anh5.TabStop = false;
            // 
            // pictureBox_Large
            // 
            this.pictureBox_Large.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition_HideThumbnails.SetDecoration(this.pictureBox_Large, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_LargeImages.SetDecoration(this.pictureBox_Large, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this.pictureBox_Large, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox_Large.Location = new System.Drawing.Point(281, 123);
            this.pictureBox_Large.Name = "pictureBox_Large";
            this.pictureBox_Large.Size = new System.Drawing.Size(1389, 721);
            this.pictureBox_Large.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Large.TabIndex = 1;
            this.pictureBox_Large.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bunifuTransition_LargeImages
            // 
            this.bunifuTransition_LargeImages.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition_LargeImages.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition_LargeImages.DefaultAnimation = animation2;
            // 
            // bunifuTransition_HideThumbnails
            // 
            this.bunifuTransition_HideThumbnails.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition_HideThumbnails.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition_HideThumbnails.DefaultAnimation = animation3;
            this.bunifuTransition_HideThumbnails.MaxAnimationTime = 1000;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 1002);
            this.Controls.Add(this.panel_Background);
            this.bunifuTransition_LargeImages.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_ShowThumbnails.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition_HideThumbnails.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_Background.ResumeLayout(false);
            this.panel_LeftDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Anh5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Large)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition_ShowThumbnails;
        private System.Windows.Forms.PictureBox pictureBox_Large;
        private Bunifu.Framework.UI.BunifuTileButton btn_PlayPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btn_Next;
        private Bunifu.Framework.UI.BunifuTileButton btn_Previous;
        private Bunifu.Framework.UI.BunifuTileButton btn_Folder;
        private Bunifu.Framework.UI.BunifuTileButton btn_Sound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Background;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition_LargeImages;
        private System.Windows.Forms.PictureBox pictureBox_Anh5;
        private System.Windows.Forms.PictureBox pictureBox_Anh4;
        private System.Windows.Forms.PictureBox pictureBox_Anh3;
        private System.Windows.Forms.PictureBox pictureBox_Anh2;
        private System.Windows.Forms.PictureBox pictureBox_Anh1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition_HideThumbnails;
        private System.Windows.Forms.Panel panel_LeftDock;
    }
}