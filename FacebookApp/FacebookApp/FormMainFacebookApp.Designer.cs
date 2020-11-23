﻿namespace FacebookApp
{
    partial class FormMainFacebookApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainFacebookApp));
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabUserPosts = new System.Windows.Forms.TabPage();
            this.userPostsList = new System.Windows.Forms.ListBox();
            this.tabAboutUser = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.livesInBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.birthDayBox = new System.Windows.Forms.TextBox();
            this.livesIn = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.birthDay = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.educationPlaces = new System.Windows.Forms.Label();
            this.educationList = new System.Windows.Forms.ListBox();
            this.workPlacesList = new System.Windows.Forms.ListBox();
            this.workPlaces = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.numberOfAlbumsBox = new System.Windows.Forms.RichTextBox();
            this.numberOfAlbums = new System.Windows.Forms.Label();
            this.numberOfPostsBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfFriendsBox = new System.Windows.Forms.RichTextBox();
            this.numberOfFriends = new System.Windows.Forms.Label();
            this.tabFriendsList = new System.Windows.Forms.TabPage();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.tabUserPhotos = new System.Windows.Forms.TabPage();
            this.pictureBoxSelected = new System.Windows.Forms.PictureBox();
            this.photosListBox = new System.Windows.Forms.ListBox();
            this.createAlbumFeature = new System.Windows.Forms.TabPage();
            this.breakManagerTab = new System.Windows.Forms.TabPage();
            this.breakManagerTopic = new System.Windows.Forms.Label();
            this.saveBreakManagerSettingsButton = new System.Windows.Forms.Button();
            this.oneHourCheckBox = new System.Windows.Forms.CheckBox();
            this.fifteenMinutesCheckBox = new System.Windows.Forms.CheckBox();
            this.tenMinutesCheckBox = new System.Windows.Forms.CheckBox();
            this.fiveMinutesCheckBox = new System.Windows.Forms.CheckBox();
            this.noBreaksCheckBox = new System.Windows.Forms.CheckBox();
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.userNamePresentation = new System.Windows.Forms.RichTextBox();
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabUserPosts.SuspendLayout();
            this.tabAboutUser.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabFriendsList.SuspendLayout();
            this.tabUserPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).BeginInit();
            this.breakManagerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // appIcon
            // 
            this.appIcon.Image = ((System.Drawing.Image)(resources.GetObject("appIcon.Image")));
            this.appIcon.Location = new System.Drawing.Point(12, 12);
            this.appIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(122, 74);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appIcon.TabIndex = 2;
            this.appIcon.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogin.Location = new System.Drawing.Point(21, 814);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 29);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(804, 814);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControlMain.Controls.Add(this.tabUserPosts);
            this.tabControlMain.Controls.Add(this.tabAboutUser);
            this.tabControlMain.Controls.Add(this.tabFriendsList);
            this.tabControlMain.Controls.Add(this.tabUserPhotos);
            this.tabControlMain.Controls.Add(this.createAlbumFeature);
            this.tabControlMain.Controls.Add(this.breakManagerTab);
            this.tabControlMain.Location = new System.Drawing.Point(147, 319);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(731, 488);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabUserPosts
            // 
            this.tabUserPosts.Controls.Add(this.userPostsList);
            this.tabUserPosts.Location = new System.Drawing.Point(4, 29);
            this.tabUserPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPosts.Name = "tabUserPosts";
            this.tabUserPosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPosts.Size = new System.Drawing.Size(723, 455);
            this.tabUserPosts.TabIndex = 1;
            this.tabUserPosts.Text = "User Posts";
            this.tabUserPosts.UseVisualStyleBackColor = true;
            // 
            // userPostsList
            // 
            this.userPostsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPostsList.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPostsList.FormattingEnabled = true;
            this.userPostsList.ItemHeight = 21;
            this.userPostsList.Location = new System.Drawing.Point(4, 9);
            this.userPostsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPostsList.Name = "userPostsList";
            this.userPostsList.Size = new System.Drawing.Size(718, 424);
            this.userPostsList.TabIndex = 0;
            // 
            // tabAboutUser
            // 
            this.tabAboutUser.Controls.Add(this.tabControl2);
            this.tabAboutUser.Location = new System.Drawing.Point(4, 29);
            this.tabAboutUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAboutUser.Name = "tabAboutUser";
            this.tabAboutUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAboutUser.Size = new System.Drawing.Size(723, 455);
            this.tabAboutUser.TabIndex = 2;
            this.tabAboutUser.Text = "About User";
            this.tabAboutUser.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(711, 442);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.livesInBox);
            this.tabPage5.Controls.Add(this.statusBox);
            this.tabPage5.Controls.Add(this.birthDayBox);
            this.tabPage5.Controls.Add(this.livesIn);
            this.tabPage5.Controls.Add(this.gender);
            this.tabPage5.Controls.Add(this.birthDay);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(703, 409);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "User Overview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // livesInBox
            // 
            this.livesInBox.Location = new System.Drawing.Point(141, 122);
            this.livesInBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.livesInBox.Name = "livesInBox";
            this.livesInBox.Size = new System.Drawing.Size(126, 26);
            this.livesInBox.TabIndex = 5;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(141, 72);
            this.statusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(126, 26);
            this.statusBox.TabIndex = 4;
            // 
            // birthDayBox
            // 
            this.birthDayBox.Location = new System.Drawing.Point(141, 22);
            this.birthDayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(126, 26);
            this.birthDayBox.TabIndex = 3;
            // 
            // livesIn
            // 
            this.livesIn.AutoSize = true;
            this.livesIn.Location = new System.Drawing.Point(25, 122);
            this.livesIn.Name = "livesIn";
            this.livesIn.Size = new System.Drawing.Size(63, 20);
            this.livesIn.TabIndex = 2;
            this.livesIn.Text = "Lives In";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(25, 72);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(63, 20);
            this.gender.TabIndex = 1;
            this.gender.Text = "Gender";
            // 
            // birthDay
            // 
            this.birthDay.AutoSize = true;
            this.birthDay.Location = new System.Drawing.Point(25, 22);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(74, 20);
            this.birthDay.TabIndex = 0;
            this.birthDay.Text = "Birth Day";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.educationPlaces);
            this.tabPage6.Controls.Add(this.educationList);
            this.tabPage6.Controls.Add(this.workPlacesList);
            this.tabPage6.Controls.Add(this.workPlaces);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(703, 409);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "User Work And Education";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // educationPlaces
            // 
            this.educationPlaces.AutoSize = true;
            this.educationPlaces.Location = new System.Drawing.Point(453, 25);
            this.educationPlaces.Name = "educationPlaces";
            this.educationPlaces.Size = new System.Drawing.Size(132, 20);
            this.educationPlaces.TabIndex = 3;
            this.educationPlaces.Text = "Education Places";
            // 
            // educationList
            // 
            this.educationList.FormattingEnabled = true;
            this.educationList.ItemHeight = 20;
            this.educationList.Location = new System.Drawing.Point(364, 68);
            this.educationList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.educationList.Name = "educationList";
            this.educationList.Size = new System.Drawing.Size(303, 284);
            this.educationList.TabIndex = 2;
            // 
            // workPlacesList
            // 
            this.workPlacesList.FormattingEnabled = true;
            this.workPlacesList.ItemHeight = 20;
            this.workPlacesList.Location = new System.Drawing.Point(28, 68);
            this.workPlacesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workPlacesList.Name = "workPlacesList";
            this.workPlacesList.Size = new System.Drawing.Size(303, 284);
            this.workPlacesList.TabIndex = 1;
            // 
            // workPlaces
            // 
            this.workPlaces.AutoSize = true;
            this.workPlaces.Location = new System.Drawing.Point(129, 25);
            this.workPlaces.Name = "workPlaces";
            this.workPlaces.Size = new System.Drawing.Size(97, 20);
            this.workPlaces.TabIndex = 0;
            this.workPlaces.Text = "Work Places";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.numberOfAlbumsBox);
            this.tabPage7.Controls.Add(this.numberOfAlbums);
            this.tabPage7.Controls.Add(this.numberOfPostsBox);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.numberOfFriendsBox);
            this.tabPage7.Controls.Add(this.numberOfFriends);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Size = new System.Drawing.Size(703, 409);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "User Statistics";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // numberOfAlbumsBox
            // 
            this.numberOfAlbumsBox.Location = new System.Drawing.Point(172, 128);
            this.numberOfAlbumsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfAlbumsBox.Name = "numberOfAlbumsBox";
            this.numberOfAlbumsBox.Size = new System.Drawing.Size(123, 33);
            this.numberOfAlbumsBox.TabIndex = 5;
            this.numberOfAlbumsBox.Text = "";
            // 
            // numberOfAlbums
            // 
            this.numberOfAlbums.AutoSize = true;
            this.numberOfAlbums.Location = new System.Drawing.Point(12, 128);
            this.numberOfAlbums.Name = "numberOfAlbums";
            this.numberOfAlbums.Size = new System.Drawing.Size(143, 20);
            this.numberOfAlbums.TabIndex = 4;
            this.numberOfAlbums.Text = "Number Of Albums";
            this.numberOfAlbums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfPostsBox
            // 
            this.numberOfPostsBox.Location = new System.Drawing.Point(172, 70);
            this.numberOfPostsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfPostsBox.Name = "numberOfPostsBox";
            this.numberOfPostsBox.Size = new System.Drawing.Size(123, 33);
            this.numberOfPostsBox.TabIndex = 3;
            this.numberOfPostsBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Posts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfFriendsBox
            // 
            this.numberOfFriendsBox.Location = new System.Drawing.Point(171, 12);
            this.numberOfFriendsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfFriendsBox.Name = "numberOfFriendsBox";
            this.numberOfFriendsBox.Size = new System.Drawing.Size(123, 33);
            this.numberOfFriendsBox.TabIndex = 1;
            this.numberOfFriendsBox.Text = "";
            // 
            // numberOfFriends
            // 
            this.numberOfFriends.AutoSize = true;
            this.numberOfFriends.Location = new System.Drawing.Point(12, 12);
            this.numberOfFriends.Name = "numberOfFriends";
            this.numberOfFriends.Size = new System.Drawing.Size(143, 20);
            this.numberOfFriends.TabIndex = 0;
            this.numberOfFriends.Text = "Number Of Friends";
            // 
            // tabFriendsList
            // 
            this.tabFriendsList.Controls.Add(this.friendsListBox);
            this.tabFriendsList.Location = new System.Drawing.Point(4, 29);
            this.tabFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriendsList.Name = "tabFriendsList";
            this.tabFriendsList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriendsList.Size = new System.Drawing.Size(723, 455);
            this.tabFriendsList.TabIndex = 3;
            this.tabFriendsList.Text = "Friends List";
            this.tabFriendsList.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(-4, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(727, 464);
            this.friendsListBox.TabIndex = 0;
            // 
            // tabUserPhotos
            // 
            this.tabUserPhotos.Controls.Add(this.pictureBoxSelected);
            this.tabUserPhotos.Controls.Add(this.photosListBox);
            this.tabUserPhotos.Location = new System.Drawing.Point(4, 29);
            this.tabUserPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPhotos.Name = "tabUserPhotos";
            this.tabUserPhotos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPhotos.Size = new System.Drawing.Size(723, 455);
            this.tabUserPhotos.TabIndex = 0;
            this.tabUserPhotos.Text = "User Photos";
            this.tabUserPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSelected
            // 
            this.pictureBoxSelected.Location = new System.Drawing.Point(518, 274);
            this.pictureBoxSelected.Name = "pictureBoxSelected";
            this.pictureBoxSelected.Size = new System.Drawing.Size(124, 82);
            this.pictureBoxSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelected.TabIndex = 1;
            this.pictureBoxSelected.TabStop = false;
            // 
            // photosListBox
            // 
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.ItemHeight = 20;
            this.photosListBox.Location = new System.Drawing.Point(0, 0);
            this.photosListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(717, 444);
            this.photosListBox.TabIndex = 0;
            this.photosListBox.SelectedIndexChanged += new System.EventHandler(this.photosListBox_SelectedIndexChanged);
            // 
            // createAlbumFeature
            // 
            this.createAlbumFeature.Location = new System.Drawing.Point(4, 29);
            this.createAlbumFeature.Name = "createAlbumFeature";
            this.createAlbumFeature.Padding = new System.Windows.Forms.Padding(3);
            this.createAlbumFeature.Size = new System.Drawing.Size(723, 455);
            this.createAlbumFeature.TabIndex = 4;
            this.createAlbumFeature.Text = "Create Album";
            this.createAlbumFeature.UseVisualStyleBackColor = true;
            // 
            // breakManagerTab
            // 
            this.breakManagerTab.Controls.Add(this.breakManagerTopic);
            this.breakManagerTab.Controls.Add(this.saveBreakManagerSettingsButton);
            this.breakManagerTab.Controls.Add(this.oneHourCheckBox);
            this.breakManagerTab.Controls.Add(this.fifteenMinutesCheckBox);
            this.breakManagerTab.Controls.Add(this.tenMinutesCheckBox);
            this.breakManagerTab.Controls.Add(this.fiveMinutesCheckBox);
            this.breakManagerTab.Controls.Add(this.noBreaksCheckBox);
            this.breakManagerTab.Location = new System.Drawing.Point(4, 29);
            this.breakManagerTab.Name = "breakManagerTab";
            this.breakManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.breakManagerTab.Size = new System.Drawing.Size(723, 455);
            this.breakManagerTab.TabIndex = 5;
            this.breakManagerTab.Text = "Break Manager";
            this.breakManagerTab.UseVisualStyleBackColor = true;
            // 
            // breakManagerTopic
            // 
            this.breakManagerTopic.AutoSize = true;
            this.breakManagerTopic.Font = new System.Drawing.Font("MingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakManagerTopic.Location = new System.Drawing.Point(27, 21);
            this.breakManagerTopic.Name = "breakManagerTopic";
            this.breakManagerTopic.Size = new System.Drawing.Size(642, 28);
            this.breakManagerTopic.TabIndex = 6;
            this.breakManagerTopic.Text = "How often whould you like to have a break?";
            // 
            // saveBreakManagerSettingsButton
            // 
            this.saveBreakManagerSettingsButton.Location = new System.Drawing.Point(618, 408);
            this.saveBreakManagerSettingsButton.Name = "saveBreakManagerSettingsButton";
            this.saveBreakManagerSettingsButton.Size = new System.Drawing.Size(92, 37);
            this.saveBreakManagerSettingsButton.TabIndex = 5;
            this.saveBreakManagerSettingsButton.Text = "Save";
            this.saveBreakManagerSettingsButton.UseVisualStyleBackColor = true;
            this.saveBreakManagerSettingsButton.Click += new System.EventHandler(this.saveBreakManagerSettingsButton_Click);
            // 
            // oneHourCheckBox
            // 
            this.oneHourCheckBox.AutoSize = true;
            this.oneHourCheckBox.Location = new System.Drawing.Point(27, 260);
            this.oneHourCheckBox.Name = "oneHourCheckBox";
            this.oneHourCheckBox.Size = new System.Drawing.Size(110, 24);
            this.oneHourCheckBox.TabIndex = 4;
            this.oneHourCheckBox.Text = "Every hour";
            this.oneHourCheckBox.UseVisualStyleBackColor = true;
            // 
            // fifteenMinutesCheckBox
            // 
            this.fifteenMinutesCheckBox.AutoSize = true;
            this.fifteenMinutesCheckBox.Checked = true;
            this.fifteenMinutesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fifteenMinutesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifteenMinutesCheckBox.Location = new System.Drawing.Point(27, 220);
            this.fifteenMinutesCheckBox.Name = "fifteenMinutesCheckBox";
            this.fifteenMinutesCheckBox.Size = new System.Drawing.Size(309, 24);
            this.fifteenMinutesCheckBox.TabIndex = 3;
            this.fifteenMinutesCheckBox.Text = "Every 15 minutes (Recommended)";
            this.fifteenMinutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // tenMinutesCheckBox
            // 
            this.tenMinutesCheckBox.AutoSize = true;
            this.tenMinutesCheckBox.Location = new System.Drawing.Point(27, 180);
            this.tenMinutesCheckBox.Name = "tenMinutesCheckBox";
            this.tenMinutesCheckBox.Size = new System.Drawing.Size(156, 24);
            this.tenMinutesCheckBox.TabIndex = 2;
            this.tenMinutesCheckBox.Text = "Every 10 minutes";
            this.tenMinutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // fiveMinutesCheckBox
            // 
            this.fiveMinutesCheckBox.AutoSize = true;
            this.fiveMinutesCheckBox.Location = new System.Drawing.Point(27, 140);
            this.fiveMinutesCheckBox.Name = "fiveMinutesCheckBox";
            this.fiveMinutesCheckBox.Size = new System.Drawing.Size(147, 24);
            this.fiveMinutesCheckBox.TabIndex = 1;
            this.fiveMinutesCheckBox.Text = "Every 5 minutes";
            this.fiveMinutesCheckBox.UseVisualStyleBackColor = true;
            // 
            // noBreaksCheckBox
            // 
            this.noBreaksCheckBox.AutoSize = true;
            this.noBreaksCheckBox.Location = new System.Drawing.Point(27, 100);
            this.noBreaksCheckBox.Name = "noBreaksCheckBox";
            this.noBreaksCheckBox.Size = new System.Drawing.Size(118, 24);
            this.noBreaksCheckBox.TabIndex = 0;
            this.noBreaksCheckBox.Text = "No Breakes";
            this.noBreaksCheckBox.UseVisualStyleBackColor = true;
            this.noBreaksCheckBox.CheckedChanged += new System.EventHandler(this.noBreaksCheckBox_CheckedChanged);
            // 
            // coverPhoto
            // 
            this.coverPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coverPhoto.Location = new System.Drawing.Point(147, 12);
            this.coverPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(741, 230);
            this.coverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.InitialImage")));
            this.profilePicture.Location = new System.Drawing.Point(397, 92);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(178, 119);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profilePicture.TabIndex = 7;
            this.profilePicture.TabStop = false;
            // 
            // userNamePresentation
            // 
            this.userNamePresentation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNamePresentation.Location = new System.Drawing.Point(382, 248);
            this.userNamePresentation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNamePresentation.Name = "userNamePresentation";
            this.userNamePresentation.Size = new System.Drawing.Size(232, 65);
            this.userNamePresentation.TabIndex = 8;
            this.userNamePresentation.Text = "";
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 900000;
            // 
            // FormMainFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 870);
            this.Controls.Add(this.userNamePresentation);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.coverPhoto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainFacebookApp";
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabUserPosts.ResumeLayout(false);
            this.tabAboutUser.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabFriendsList.ResumeLayout(false);
            this.tabUserPhotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).EndInit();
            this.breakManagerTab.ResumeLayout(false);
            this.breakManagerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabUserPosts;
        private System.Windows.Forms.TabPage tabAboutUser;
        private System.Windows.Forms.TabPage tabFriendsList;
        private System.Windows.Forms.TabPage tabUserPhotos;
        private System.Windows.Forms.ListBox userPostsList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox numberOfAlbumsBox;
        private System.Windows.Forms.Label numberOfAlbums;
        private System.Windows.Forms.RichTextBox numberOfPostsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox numberOfFriendsBox;
        private System.Windows.Forms.Label numberOfFriends;
        private System.Windows.Forms.PictureBox coverPhoto;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.RichTextBox userNamePresentation;
        private System.Windows.Forms.TextBox livesInBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox birthDayBox;
        private System.Windows.Forms.Label livesIn;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label birthDay;
        private System.Windows.Forms.Label educationPlaces;
        private System.Windows.Forms.ListBox educationList;
        private System.Windows.Forms.ListBox workPlacesList;
        private System.Windows.Forms.Label workPlaces;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox photosListBox;
        private System.Windows.Forms.PictureBox pictureBoxSelected;
        private System.Windows.Forms.TabPage createAlbumFeature;
        private System.Windows.Forms.TabPage breakManagerTab;
        private System.Windows.Forms.Label breakManagerTopic;
        private System.Windows.Forms.Button saveBreakManagerSettingsButton;
        private System.Windows.Forms.CheckBox oneHourCheckBox;
        private System.Windows.Forms.CheckBox fifteenMinutesCheckBox;
        private System.Windows.Forms.CheckBox tenMinutesCheckBox;
        private System.Windows.Forms.CheckBox fiveMinutesCheckBox;
        private System.Windows.Forms.CheckBox noBreaksCheckBox;
        private System.Windows.Forms.Timer breakTimer;
    }
}

