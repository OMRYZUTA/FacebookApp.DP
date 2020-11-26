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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabUserPosts = new System.Windows.Forms.TabPage();
            this.userPostsList = new System.Windows.Forms.ListBox();
            this.tabAboutUser = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.livesInBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.TextBox();
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
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelCreateAlbumHeader = new System.Windows.Forms.Label();
            this.buttonSelectedFriend = new System.Windows.Forms.Button();
            this.textBoxSelectedFriend = new System.Windows.Forms.TextBox();
            this.listBoxAlbumWithFriend = new System.Windows.Forms.ListBox();
            this.labelSelectedFriend = new System.Windows.Forms.Label();
            this.breakManagerFeature = new System.Windows.Forms.TabPage();
            this.timerPresentation = new System.Windows.Forms.Label();
            this.saveBreakManagerSettingsButton = new System.Windows.Forms.Button();
            this.tenMinutesButton = new System.Windows.Forms.RadioButton();
            this.fifteenMinutesButton = new System.Windows.Forms.RadioButton();
            this.oneHourButton = new System.Windows.Forms.RadioButton();
            this.fiveMinutesButton = new System.Windows.Forms.RadioButton();
            this.noBreaksButton = new System.Windows.Forms.RadioButton();
            this.breakManagerLable = new System.Windows.Forms.Label();
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.breakManagerTimer = new System.Windows.Forms.Timer(this.components);
            this.userNamePresentation = new System.Windows.Forms.Label();
            this.saveSettingsNote = new System.Windows.Forms.Label();
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
            this.createAlbumFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.breakManagerFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // appIcon
            // 
            this.appIcon.Image = ((System.Drawing.Image)(resources.GetObject("appIcon.Image")));
            this.appIcon.Location = new System.Drawing.Point(8, 8);
            this.appIcon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(81, 35);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appIcon.TabIndex = 2;
            this.appIcon.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogin.Location = new System.Drawing.Point(8, 48);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 27);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControlMain.Controls.Add(this.tabUserPosts);
            this.tabControlMain.Controls.Add(this.tabAboutUser);
            this.tabControlMain.Controls.Add(this.tabFriendsList);
            this.tabControlMain.Controls.Add(this.tabUserPhotos);
            this.tabControlMain.Controls.Add(this.createAlbumFeature);
            this.tabControlMain.Controls.Add(this.breakManagerFeature);
            this.tabControlMain.Location = new System.Drawing.Point(98, 207);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(487, 317);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabUserPosts
            // 
            this.tabUserPosts.Controls.Add(this.userPostsList);
            this.tabUserPosts.Location = new System.Drawing.Point(4, 22);
            this.tabUserPosts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabUserPosts.Name = "tabUserPosts";
            this.tabUserPosts.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabUserPosts.Size = new System.Drawing.Size(479, 291);
            this.tabUserPosts.TabIndex = 1;
            this.tabUserPosts.Text = "User Posts";
            this.tabUserPosts.UseVisualStyleBackColor = true;
            // 
            // userPostsList
            // 
            this.userPostsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPostsList.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPostsList.FormattingEnabled = true;
            this.userPostsList.ItemHeight = 14;
            this.userPostsList.Location = new System.Drawing.Point(3, 6);
            this.userPostsList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.userPostsList.Name = "userPostsList";
            this.userPostsList.Size = new System.Drawing.Size(480, 270);
            this.userPostsList.TabIndex = 0;
            // 
            // tabAboutUser
            // 
            this.tabAboutUser.Controls.Add(this.tabControl2);
            this.tabAboutUser.Location = new System.Drawing.Point(4, 22);
            this.tabAboutUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAboutUser.Name = "tabAboutUser";
            this.tabAboutUser.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabAboutUser.Size = new System.Drawing.Size(479, 291);
            this.tabAboutUser.TabIndex = 2;
            this.tabAboutUser.Text = "About User";
            this.tabAboutUser.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(474, 287);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.livesInBox);
            this.tabPage5.Controls.Add(this.genderBox);
            this.tabPage5.Controls.Add(this.birthDayBox);
            this.tabPage5.Controls.Add(this.livesIn);
            this.tabPage5.Controls.Add(this.gender);
            this.tabPage5.Controls.Add(this.birthDay);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage5.Size = new System.Drawing.Size(466, 261);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "User Overview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // livesInBox
            // 
            this.livesInBox.Location = new System.Drawing.Point(94, 79);
            this.livesInBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.livesInBox.Name = "livesInBox";
            this.livesInBox.Size = new System.Drawing.Size(85, 20);
            this.livesInBox.TabIndex = 5;
            // 
            // genderBox
            // 
            this.genderBox.Location = new System.Drawing.Point(94, 47);
            this.genderBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(85, 20);
            this.genderBox.TabIndex = 4;
            // 
            // birthDayBox
            // 
            this.birthDayBox.Location = new System.Drawing.Point(94, 14);
            this.birthDayBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(85, 20);
            this.birthDayBox.TabIndex = 3;
            // 
            // livesIn
            // 
            this.livesIn.AutoSize = true;
            this.livesIn.Location = new System.Drawing.Point(17, 79);
            this.livesIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.livesIn.Name = "livesIn";
            this.livesIn.Size = new System.Drawing.Size(44, 13);
            this.livesIn.TabIndex = 2;
            this.livesIn.Text = "Lives In";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(17, 47);
            this.gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(42, 13);
            this.gender.TabIndex = 1;
            this.gender.Text = "Gender";
            // 
            // birthDay
            // 
            this.birthDay.AutoSize = true;
            this.birthDay.Location = new System.Drawing.Point(17, 14);
            this.birthDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(50, 13);
            this.birthDay.TabIndex = 0;
            this.birthDay.Text = "Birth Day";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.educationPlaces);
            this.tabPage6.Controls.Add(this.educationList);
            this.tabPage6.Controls.Add(this.workPlacesList);
            this.tabPage6.Controls.Add(this.workPlaces);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage6.Size = new System.Drawing.Size(466, 261);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "User Work And Education";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // educationPlaces
            // 
            this.educationPlaces.AutoSize = true;
            this.educationPlaces.Location = new System.Drawing.Point(302, 16);
            this.educationPlaces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.educationPlaces.Name = "educationPlaces";
            this.educationPlaces.Size = new System.Drawing.Size(90, 13);
            this.educationPlaces.TabIndex = 3;
            this.educationPlaces.Text = "Education Places";
            // 
            // educationList
            // 
            this.educationList.FormattingEnabled = true;
            this.educationList.Location = new System.Drawing.Point(243, 44);
            this.educationList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.educationList.Name = "educationList";
            this.educationList.Size = new System.Drawing.Size(203, 186);
            this.educationList.TabIndex = 2;
            // 
            // workPlacesList
            // 
            this.workPlacesList.FormattingEnabled = true;
            this.workPlacesList.Location = new System.Drawing.Point(19, 44);
            this.workPlacesList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.workPlacesList.Name = "workPlacesList";
            this.workPlacesList.Size = new System.Drawing.Size(203, 186);
            this.workPlacesList.TabIndex = 1;
            // 
            // workPlaces
            // 
            this.workPlaces.AutoSize = true;
            this.workPlaces.Location = new System.Drawing.Point(86, 16);
            this.workPlaces.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workPlaces.Name = "workPlaces";
            this.workPlaces.Size = new System.Drawing.Size(68, 13);
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
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage7.Size = new System.Drawing.Size(466, 261);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "User Statistics";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // numberOfAlbumsBox
            // 
            this.numberOfAlbumsBox.Location = new System.Drawing.Point(115, 83);
            this.numberOfAlbumsBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numberOfAlbumsBox.Name = "numberOfAlbumsBox";
            this.numberOfAlbumsBox.Size = new System.Drawing.Size(83, 23);
            this.numberOfAlbumsBox.TabIndex = 5;
            this.numberOfAlbumsBox.Text = "";
            // 
            // numberOfAlbums
            // 
            this.numberOfAlbums.AutoSize = true;
            this.numberOfAlbums.Location = new System.Drawing.Point(8, 83);
            this.numberOfAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfAlbums.Name = "numberOfAlbums";
            this.numberOfAlbums.Size = new System.Drawing.Size(95, 13);
            this.numberOfAlbums.TabIndex = 4;
            this.numberOfAlbums.Text = "Number Of Albums";
            this.numberOfAlbums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfPostsBox
            // 
            this.numberOfPostsBox.Location = new System.Drawing.Point(115, 45);
            this.numberOfPostsBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numberOfPostsBox.Name = "numberOfPostsBox";
            this.numberOfPostsBox.Size = new System.Drawing.Size(83, 23);
            this.numberOfPostsBox.TabIndex = 3;
            this.numberOfPostsBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Posts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfFriendsBox
            // 
            this.numberOfFriendsBox.Location = new System.Drawing.Point(114, 8);
            this.numberOfFriendsBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.numberOfFriendsBox.Name = "numberOfFriendsBox";
            this.numberOfFriendsBox.Size = new System.Drawing.Size(83, 23);
            this.numberOfFriendsBox.TabIndex = 1;
            this.numberOfFriendsBox.Text = "";
            // 
            // numberOfFriends
            // 
            this.numberOfFriends.AutoSize = true;
            this.numberOfFriends.Location = new System.Drawing.Point(8, 8);
            this.numberOfFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfFriends.Name = "numberOfFriends";
            this.numberOfFriends.Size = new System.Drawing.Size(95, 13);
            this.numberOfFriends.TabIndex = 0;
            this.numberOfFriends.Text = "Number Of Friends";
            // 
            // tabFriendsList
            // 
            this.tabFriendsList.Controls.Add(this.friendsListBox);
            this.tabFriendsList.Location = new System.Drawing.Point(4, 22);
            this.tabFriendsList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabFriendsList.Name = "tabFriendsList";
            this.tabFriendsList.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabFriendsList.Size = new System.Drawing.Size(479, 291);
            this.tabFriendsList.TabIndex = 3;
            this.tabFriendsList.Text = "Friends List";
            this.tabFriendsList.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(-3, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(486, 303);
            this.friendsListBox.TabIndex = 0;
            // 
            // tabUserPhotos
            // 
            this.tabUserPhotos.Controls.Add(this.pictureBoxSelected);
            this.tabUserPhotos.Controls.Add(this.photosListBox);
            this.tabUserPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabUserPhotos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabUserPhotos.Name = "tabUserPhotos";
            this.tabUserPhotos.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabUserPhotos.Size = new System.Drawing.Size(479, 291);
            this.tabUserPhotos.TabIndex = 0;
            this.tabUserPhotos.Text = "User Photos";
            this.tabUserPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSelected
            // 
            this.pictureBoxSelected.Location = new System.Drawing.Point(345, 178);
            this.pictureBoxSelected.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBoxSelected.Name = "pictureBoxSelected";
            this.pictureBoxSelected.Size = new System.Drawing.Size(132, 116);
            this.pictureBoxSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelected.TabIndex = 1;
            this.pictureBoxSelected.TabStop = false;
            // 
            // photosListBox
            // 
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.Location = new System.Drawing.Point(0, 0);
            this.photosListBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(479, 290);
            this.photosListBox.TabIndex = 0;
            this.photosListBox.SelectedIndexChanged += new System.EventHandler(this.photosListBox_SelectedIndexChanged);
            // 
            // createAlbumFeature
            // 
            this.createAlbumFeature.Controls.Add(this.pictureBoxFriend);
            this.createAlbumFeature.Controls.Add(this.labelCreateAlbumHeader);
            this.createAlbumFeature.Controls.Add(this.buttonSelectedFriend);
            this.createAlbumFeature.Controls.Add(this.textBoxSelectedFriend);
            this.createAlbumFeature.Controls.Add(this.listBoxAlbumWithFriend);
            this.createAlbumFeature.Controls.Add(this.labelSelectedFriend);
            this.createAlbumFeature.Location = new System.Drawing.Point(4, 22);
            this.createAlbumFeature.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createAlbumFeature.Name = "createAlbumFeature";
            this.createAlbumFeature.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createAlbumFeature.Size = new System.Drawing.Size(479, 291);
            this.createAlbumFeature.TabIndex = 4;
            this.createAlbumFeature.Text = "Create Album";
            this.createAlbumFeature.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(360, 177);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(117, 112);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 5;
            this.pictureBoxFriend.TabStop = false;
            // 
            // labelCreateAlbumHeader
            // 
            this.labelCreateAlbumHeader.AutoSize = true;
            this.labelCreateAlbumHeader.Location = new System.Drawing.Point(134, 14);
            this.labelCreateAlbumHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCreateAlbumHeader.Name = "labelCreateAlbumHeader";
            this.labelCreateAlbumHeader.Size = new System.Drawing.Size(147, 13);
            this.labelCreateAlbumHeader.TabIndex = 4;
            this.labelCreateAlbumHeader.Text = "Create an album with a friend!";
            // 
            // buttonSelectedFriend
            // 
            this.buttonSelectedFriend.Location = new System.Drawing.Point(227, 48);
            this.buttonSelectedFriend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSelectedFriend.Name = "buttonSelectedFriend";
            this.buttonSelectedFriend.Size = new System.Drawing.Size(56, 19);
            this.buttonSelectedFriend.TabIndex = 3;
            this.buttonSelectedFriend.Text = "Select";
            this.buttonSelectedFriend.UseVisualStyleBackColor = true;
            this.buttonSelectedFriend.Click += new System.EventHandler(this.buttonSelectedFriend_Click);
            // 
            // textBoxSelectedFriend
            // 
            this.textBoxSelectedFriend.Location = new System.Drawing.Point(134, 49);
            this.textBoxSelectedFriend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxSelectedFriend.Name = "textBoxSelectedFriend";
            this.textBoxSelectedFriend.Size = new System.Drawing.Size(76, 20);
            this.textBoxSelectedFriend.TabIndex = 2;
            // 
            // listBoxAlbumWithFriend
            // 
            this.listBoxAlbumWithFriend.FormattingEnabled = true;
            this.listBoxAlbumWithFriend.Location = new System.Drawing.Point(5, 94);
            this.listBoxAlbumWithFriend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxAlbumWithFriend.Name = "listBoxAlbumWithFriend";
            this.listBoxAlbumWithFriend.Size = new System.Drawing.Size(463, 199);
            this.listBoxAlbumWithFriend.TabIndex = 1;
            this.listBoxAlbumWithFriend.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumWithFriend_SelectedIndexChanged);
            // 
            // labelSelectedFriend
            // 
            this.labelSelectedFriend.AutoSize = true;
            this.labelSelectedFriend.Location = new System.Drawing.Point(48, 53);
            this.labelSelectedFriend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedFriend.Name = "labelSelectedFriend";
            this.labelSelectedFriend.Size = new System.Drawing.Size(82, 13);
            this.labelSelectedFriend.TabIndex = 0;
            this.labelSelectedFriend.Text = "selected Friend:";
            // 
            // breakManagerFeature
            // 
            this.breakManagerFeature.Controls.Add(this.saveSettingsNote);
            this.breakManagerFeature.Controls.Add(this.timerPresentation);
            this.breakManagerFeature.Controls.Add(this.saveBreakManagerSettingsButton);
            this.breakManagerFeature.Controls.Add(this.tenMinutesButton);
            this.breakManagerFeature.Controls.Add(this.fifteenMinutesButton);
            this.breakManagerFeature.Controls.Add(this.oneHourButton);
            this.breakManagerFeature.Controls.Add(this.fiveMinutesButton);
            this.breakManagerFeature.Controls.Add(this.noBreaksButton);
            this.breakManagerFeature.Controls.Add(this.breakManagerLable);
            this.breakManagerFeature.Location = new System.Drawing.Point(4, 22);
            this.breakManagerFeature.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.breakManagerFeature.Name = "breakManagerFeature";
            this.breakManagerFeature.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.breakManagerFeature.Size = new System.Drawing.Size(479, 291);
            this.breakManagerFeature.TabIndex = 5;
            this.breakManagerFeature.Text = "Break Manager";
            this.breakManagerFeature.UseVisualStyleBackColor = true;
            // 
            // timerPresentation
            // 
            this.timerPresentation.AutoSize = true;
            this.timerPresentation.Font = new System.Drawing.Font("Gisha", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerPresentation.Location = new System.Drawing.Point(298, 64);
            this.timerPresentation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerPresentation.Name = "timerPresentation";
            this.timerPresentation.Size = new System.Drawing.Size(70, 25);
            this.timerPresentation.TabIndex = 7;
            this.timerPresentation.Text = "00:00";
            // 
            // saveBreakManagerSettingsButton
            // 
            this.saveBreakManagerSettingsButton.Location = new System.Drawing.Point(411, 268);
            this.saveBreakManagerSettingsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBreakManagerSettingsButton.Name = "saveBreakManagerSettingsButton";
            this.saveBreakManagerSettingsButton.Size = new System.Drawing.Size(63, 20);
            this.saveBreakManagerSettingsButton.TabIndex = 6;
            this.saveBreakManagerSettingsButton.Text = "Save";
            this.saveBreakManagerSettingsButton.UseVisualStyleBackColor = true;
            this.saveBreakManagerSettingsButton.Click += new System.EventHandler(this.saveBreakManagerSettingsButton_Click);
            // 
            // tenMinutesButton
            // 
            this.tenMinutesButton.AutoSize = true;
            this.tenMinutesButton.Location = new System.Drawing.Point(25, 123);
            this.tenMinutesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tenMinutesButton.Name = "tenMinutesButton";
            this.tenMinutesButton.Size = new System.Drawing.Size(106, 17);
            this.tenMinutesButton.TabIndex = 5;
            this.tenMinutesButton.Text = "Every 10 minutes";
            this.tenMinutesButton.UseVisualStyleBackColor = true;
            this.tenMinutesButton.Click += new System.EventHandler(this.tenMinutesButton_Click);
            // 
            // fifteenMinutesButton
            // 
            this.fifteenMinutesButton.AutoSize = true;
            this.fifteenMinutesButton.Checked = true;
            this.fifteenMinutesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifteenMinutesButton.Location = new System.Drawing.Point(25, 156);
            this.fifteenMinutesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fifteenMinutesButton.Name = "fifteenMinutesButton";
            this.fifteenMinutesButton.Size = new System.Drawing.Size(217, 17);
            this.fifteenMinutesButton.TabIndex = 4;
            this.fifteenMinutesButton.TabStop = true;
            this.fifteenMinutesButton.Text = "Every 15 minutes (Recommended)";
            this.fifteenMinutesButton.UseVisualStyleBackColor = true;
            this.fifteenMinutesButton.Click += new System.EventHandler(this.fifteenMinutesButton_Click);
            // 
            // oneHourButton
            // 
            this.oneHourButton.AutoSize = true;
            this.oneHourButton.Location = new System.Drawing.Point(25, 188);
            this.oneHourButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oneHourButton.Name = "oneHourButton";
            this.oneHourButton.Size = new System.Drawing.Size(76, 17);
            this.oneHourButton.TabIndex = 3;
            this.oneHourButton.Text = "Every hour";
            this.oneHourButton.UseVisualStyleBackColor = true;
            this.oneHourButton.Click += new System.EventHandler(this.oneHourButton_Click);
            // 
            // fiveMinutesButton
            // 
            this.fiveMinutesButton.AutoSize = true;
            this.fiveMinutesButton.Location = new System.Drawing.Point(25, 91);
            this.fiveMinutesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fiveMinutesButton.Name = "fiveMinutesButton";
            this.fiveMinutesButton.Size = new System.Drawing.Size(100, 17);
            this.fiveMinutesButton.TabIndex = 2;
            this.fiveMinutesButton.Text = "Every 5 minutes";
            this.fiveMinutesButton.UseVisualStyleBackColor = true;
            this.fiveMinutesButton.Click += new System.EventHandler(this.fiveMinutesButton_Click);
            // 
            // noBreaksButton
            // 
            this.noBreaksButton.AutoSize = true;
            this.noBreaksButton.Location = new System.Drawing.Point(25, 58);
            this.noBreaksButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noBreaksButton.Name = "noBreaksButton";
            this.noBreaksButton.Size = new System.Drawing.Size(74, 17);
            this.noBreaksButton.TabIndex = 1;
            this.noBreaksButton.Text = "No breaks";
            this.noBreaksButton.UseVisualStyleBackColor = true;
            this.noBreaksButton.CheckedChanged += new System.EventHandler(this.noBreaksButton_Click);
            // 
            // breakManagerLable
            // 
            this.breakManagerLable.AutoSize = true;
            this.breakManagerLable.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakManagerLable.Location = new System.Drawing.Point(18, 13);
            this.breakManagerLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.breakManagerLable.Name = "breakManagerLable";
            this.breakManagerLable.Size = new System.Drawing.Size(441, 25);
            this.breakManagerLable.TabIndex = 0;
            this.breakManagerLable.Text = "How often would you like to take a break?";
            // 
            // coverPhoto
            // 
            this.coverPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coverPhoto.Location = new System.Drawing.Point(98, 8);
            this.coverPhoto.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(494, 149);
            this.coverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.InitialImage")));
            this.profilePicture.Location = new System.Drawing.Point(283, 59);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(178, 119);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.profilePicture.TabIndex = 7;
            this.profilePicture.TabStop = false;
            // 
            // breakManagerTimer
            // 
            this.breakManagerTimer.Enabled = true;
            this.breakManagerTimer.Interval = 1000;
            this.breakManagerTimer.Tick += new System.EventHandler(this.breakManagerTimer_Tick);
            // 
            // userNamePresentation
            // 
            this.userNamePresentation.AutoSize = true;
            this.userNamePresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamePresentation.Location = new System.Drawing.Point(267, 172);
            this.userNamePresentation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNamePresentation.Name = "userNamePresentation";
            this.userNamePresentation.Size = new System.Drawing.Size(0, 26);
            this.userNamePresentation.TabIndex = 8;
            // 
            // saveSettingsNote
            // 
            this.saveSettingsNote.AutoSize = true;
            this.saveSettingsNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.saveSettingsNote.Location = new System.Drawing.Point(22, 268);
            this.saveSettingsNote.Name = "saveSettingsNote";
            this.saveSettingsNote.Size = new System.Drawing.Size(316, 15);
            this.saveSettingsNote.TabIndex = 8;
            this.saveSettingsNote.Text = "To change the settings and restart the timer, press \"Save\"";
            // 
            // FormMainFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 565);
            this.Controls.Add(this.userNamePresentation);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.coverPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
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
            this.createAlbumFeature.ResumeLayout(false);
            this.createAlbumFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.breakManagerFeature.ResumeLayout(false);
            this.breakManagerFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Button buttonLogin;
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
        private System.Windows.Forms.TextBox livesInBox;
        private System.Windows.Forms.TextBox genderBox;
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
        private System.Windows.Forms.TabPage breakManagerFeature;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelCreateAlbumHeader;
        private System.Windows.Forms.Button buttonSelectedFriend;
        private System.Windows.Forms.TextBox textBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxAlbumWithFriend;
        private System.Windows.Forms.Label labelSelectedFriend;
        private System.Windows.Forms.Button saveBreakManagerSettingsButton;
        private System.Windows.Forms.RadioButton tenMinutesButton;
        private System.Windows.Forms.RadioButton fifteenMinutesButton;
        private System.Windows.Forms.RadioButton oneHourButton;
        private System.Windows.Forms.RadioButton fiveMinutesButton;
        private System.Windows.Forms.RadioButton noBreaksButton;
        private System.Windows.Forms.Label breakManagerLable;
        private System.Windows.Forms.Timer breakManagerTimer;
        private System.Windows.Forms.Label timerPresentation;
        private System.Windows.Forms.Label userNamePresentation;
        private System.Windows.Forms.Label saveSettingsNote;
    }
}

