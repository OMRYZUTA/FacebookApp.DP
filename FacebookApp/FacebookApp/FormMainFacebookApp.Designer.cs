namespace FacebookApp
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
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.labelCreateAlbumHeader = new System.Windows.Forms.Label();
            this.buttonSelectedFriend = new System.Windows.Forms.Button();
            this.textBoxSelectedFriend = new System.Windows.Forms.TextBox();
            this.listBoxAlbumWithFriend = new System.Windows.Forms.ListBox();
            this.labelSelectedFriend = new System.Windows.Forms.Label();
            this.breakManagerFeature = new System.Windows.Forms.TabPage();
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.userNamePresentation = new System.Windows.Forms.RichTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // appIcon
            // 
            this.appIcon.Image = ((System.Drawing.Image)(resources.GetObject("appIcon.Image")));
            this.appIcon.Location = new System.Drawing.Point(11, 10);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(108, 59);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appIcon.TabIndex = 2;
            this.appIcon.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogin.Location = new System.Drawing.Point(19, 651);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 23);
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
            this.tabControlMain.Location = new System.Drawing.Point(131, 255);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(650, 390);
            this.tabControlMain.TabIndex = 6;
            this.tabControlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlMain_Selected);
            // 
            // tabUserPosts
            // 
            this.tabUserPosts.Controls.Add(this.userPostsList);
            this.tabUserPosts.Location = new System.Drawing.Point(4, 25);
            this.tabUserPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPosts.Name = "tabUserPosts";
            this.tabUserPosts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPosts.Size = new System.Drawing.Size(642, 361);
            this.tabUserPosts.TabIndex = 1;
            this.tabUserPosts.Text = "User Posts";
            this.tabUserPosts.UseVisualStyleBackColor = true;
            // 
            // userPostsList
            // 
            this.userPostsList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPostsList.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPostsList.FormattingEnabled = true;
            this.userPostsList.ItemHeight = 16;
            this.userPostsList.Location = new System.Drawing.Point(4, 7);
            this.userPostsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userPostsList.Name = "userPostsList";
            this.userPostsList.Size = new System.Drawing.Size(639, 340);
            this.userPostsList.TabIndex = 0;
            // 
            // tabAboutUser
            // 
            this.tabAboutUser.Controls.Add(this.tabControl2);
            this.tabAboutUser.Location = new System.Drawing.Point(4, 25);
            this.tabAboutUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAboutUser.Name = "tabAboutUser";
            this.tabAboutUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAboutUser.Size = new System.Drawing.Size(642, 361);
            this.tabAboutUser.TabIndex = 2;
            this.tabAboutUser.Text = "About User";
            this.tabAboutUser.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(5, 5);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(632, 354);
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
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Size = new System.Drawing.Size(624, 325);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "User Overview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // livesInBox
            // 
            this.livesInBox.Location = new System.Drawing.Point(125, 98);
            this.livesInBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.livesInBox.Name = "livesInBox";
            this.livesInBox.Size = new System.Drawing.Size(112, 22);
            this.livesInBox.TabIndex = 5;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(125, 58);
            this.statusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(112, 22);
            this.statusBox.TabIndex = 4;
            // 
            // birthDayBox
            // 
            this.birthDayBox.Location = new System.Drawing.Point(125, 18);
            this.birthDayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(112, 22);
            this.birthDayBox.TabIndex = 3;
            // 
            // livesIn
            // 
            this.livesIn.AutoSize = true;
            this.livesIn.Location = new System.Drawing.Point(22, 98);
            this.livesIn.Name = "livesIn";
            this.livesIn.Size = new System.Drawing.Size(56, 17);
            this.livesIn.TabIndex = 2;
            this.livesIn.Text = "Lives In";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(22, 58);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(56, 17);
            this.gender.TabIndex = 1;
            this.gender.Text = "Gender";
            // 
            // birthDay
            // 
            this.birthDay.AutoSize = true;
            this.birthDay.Location = new System.Drawing.Point(22, 18);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(66, 17);
            this.birthDay.TabIndex = 0;
            this.birthDay.Text = "Birth Day";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.educationPlaces);
            this.tabPage6.Controls.Add(this.educationList);
            this.tabPage6.Controls.Add(this.workPlacesList);
            this.tabPage6.Controls.Add(this.workPlaces);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage6.Size = new System.Drawing.Size(624, 325);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "User Work And Education";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // educationPlaces
            // 
            this.educationPlaces.AutoSize = true;
            this.educationPlaces.Location = new System.Drawing.Point(403, 20);
            this.educationPlaces.Name = "educationPlaces";
            this.educationPlaces.Size = new System.Drawing.Size(117, 17);
            this.educationPlaces.TabIndex = 3;
            this.educationPlaces.Text = "Education Places";
            // 
            // educationList
            // 
            this.educationList.FormattingEnabled = true;
            this.educationList.ItemHeight = 16;
            this.educationList.Location = new System.Drawing.Point(324, 54);
            this.educationList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.educationList.Name = "educationList";
            this.educationList.Size = new System.Drawing.Size(270, 228);
            this.educationList.TabIndex = 2;
            // 
            // workPlacesList
            // 
            this.workPlacesList.FormattingEnabled = true;
            this.workPlacesList.ItemHeight = 16;
            this.workPlacesList.Location = new System.Drawing.Point(25, 54);
            this.workPlacesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workPlacesList.Name = "workPlacesList";
            this.workPlacesList.Size = new System.Drawing.Size(270, 228);
            this.workPlacesList.TabIndex = 1;
            // 
            // workPlaces
            // 
            this.workPlaces.AutoSize = true;
            this.workPlaces.Location = new System.Drawing.Point(115, 20);
            this.workPlaces.Name = "workPlaces";
            this.workPlaces.Size = new System.Drawing.Size(87, 17);
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
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage7.Size = new System.Drawing.Size(624, 325);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "User Statistics";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // numberOfAlbumsBox
            // 
            this.numberOfAlbumsBox.Location = new System.Drawing.Point(153, 102);
            this.numberOfAlbumsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfAlbumsBox.Name = "numberOfAlbumsBox";
            this.numberOfAlbumsBox.Size = new System.Drawing.Size(110, 27);
            this.numberOfAlbumsBox.TabIndex = 5;
            this.numberOfAlbumsBox.Text = "";
            // 
            // numberOfAlbums
            // 
            this.numberOfAlbums.AutoSize = true;
            this.numberOfAlbums.Location = new System.Drawing.Point(11, 102);
            this.numberOfAlbums.Name = "numberOfAlbums";
            this.numberOfAlbums.Size = new System.Drawing.Size(127, 17);
            this.numberOfAlbums.TabIndex = 4;
            this.numberOfAlbums.Text = "Number Of Albums";
            this.numberOfAlbums.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfPostsBox
            // 
            this.numberOfPostsBox.Location = new System.Drawing.Point(153, 56);
            this.numberOfPostsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfPostsBox.Name = "numberOfPostsBox";
            this.numberOfPostsBox.Size = new System.Drawing.Size(110, 27);
            this.numberOfPostsBox.TabIndex = 3;
            this.numberOfPostsBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Posts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numberOfFriendsBox
            // 
            this.numberOfFriendsBox.Location = new System.Drawing.Point(152, 10);
            this.numberOfFriendsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfFriendsBox.Name = "numberOfFriendsBox";
            this.numberOfFriendsBox.Size = new System.Drawing.Size(110, 27);
            this.numberOfFriendsBox.TabIndex = 1;
            this.numberOfFriendsBox.Text = "";
            // 
            // numberOfFriends
            // 
            this.numberOfFriends.AutoSize = true;
            this.numberOfFriends.Location = new System.Drawing.Point(11, 10);
            this.numberOfFriends.Name = "numberOfFriends";
            this.numberOfFriends.Size = new System.Drawing.Size(128, 17);
            this.numberOfFriends.TabIndex = 0;
            this.numberOfFriends.Text = "Number Of Friends";
            // 
            // tabFriendsList
            // 
            this.tabFriendsList.Controls.Add(this.friendsListBox);
            this.tabFriendsList.Location = new System.Drawing.Point(4, 25);
            this.tabFriendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriendsList.Name = "tabFriendsList";
            this.tabFriendsList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFriendsList.Size = new System.Drawing.Size(642, 361);
            this.tabFriendsList.TabIndex = 3;
            this.tabFriendsList.Text = "Friends List";
            this.tabFriendsList.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(-4, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(647, 372);
            this.friendsListBox.TabIndex = 0;
            // 
            // tabUserPhotos
            // 
            this.tabUserPhotos.Controls.Add(this.pictureBoxSelected);
            this.tabUserPhotos.Controls.Add(this.photosListBox);
            this.tabUserPhotos.Location = new System.Drawing.Point(4, 25);
            this.tabUserPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPhotos.Name = "tabUserPhotos";
            this.tabUserPhotos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUserPhotos.Size = new System.Drawing.Size(642, 361);
            this.tabUserPhotos.TabIndex = 0;
            this.tabUserPhotos.Text = "User Photos";
            this.tabUserPhotos.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSelected
            // 
            this.pictureBoxSelected.Location = new System.Drawing.Point(460, 219);
            this.pictureBoxSelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSelected.Name = "pictureBoxSelected";
            this.pictureBoxSelected.Size = new System.Drawing.Size(110, 66);
            this.pictureBoxSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelected.TabIndex = 1;
            this.pictureBoxSelected.TabStop = false;
            // 
            // photosListBox
            // 
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.ItemHeight = 16;
            this.photosListBox.Location = new System.Drawing.Point(0, 0);
            this.photosListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(638, 356);
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
            this.createAlbumFeature.Location = new System.Drawing.Point(4, 25);
            this.createAlbumFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAlbumFeature.Name = "createAlbumFeature";
            this.createAlbumFeature.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAlbumFeature.Size = new System.Drawing.Size(642, 361);
            this.createAlbumFeature.TabIndex = 4;
            this.createAlbumFeature.Text = "Create Album";
            this.createAlbumFeature.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(480, 218);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(156, 138);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 5;
            this.pictureBoxFriend.TabStop = false;
            // 
            // labelCreateAlbumHeader
            // 
            this.labelCreateAlbumHeader.AutoSize = true;
            this.labelCreateAlbumHeader.Location = new System.Drawing.Point(179, 18);
            this.labelCreateAlbumHeader.Name = "labelCreateAlbumHeader";
            this.labelCreateAlbumHeader.Size = new System.Drawing.Size(195, 17);
            this.labelCreateAlbumHeader.TabIndex = 4;
            this.labelCreateAlbumHeader.Text = "Create an album with a friend!";
            // 
            // buttonSelectedFriend
            // 
            this.buttonSelectedFriend.Location = new System.Drawing.Point(303, 59);
            this.buttonSelectedFriend.Name = "buttonSelectedFriend";
            this.buttonSelectedFriend.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectedFriend.TabIndex = 3;
            this.buttonSelectedFriend.Text = "Select";
            this.buttonSelectedFriend.UseVisualStyleBackColor = true;
            this.buttonSelectedFriend.Click += new System.EventHandler(this.buttonSelectedFriend_Click);
            // 
            // textBoxSelectedFriend
            // 
            this.textBoxSelectedFriend.Location = new System.Drawing.Point(179, 60);
            this.textBoxSelectedFriend.Name = "textBoxSelectedFriend";
            this.textBoxSelectedFriend.Size = new System.Drawing.Size(100, 22);
            this.textBoxSelectedFriend.TabIndex = 2;
            // 
            // listBoxAlbumWithFriend
            // 
            this.listBoxAlbumWithFriend.FormattingEnabled = true;
            this.listBoxAlbumWithFriend.ItemHeight = 16;
            this.listBoxAlbumWithFriend.Location = new System.Drawing.Point(6, 115);
            this.listBoxAlbumWithFriend.Name = "listBoxAlbumWithFriend";
            this.listBoxAlbumWithFriend.Size = new System.Drawing.Size(616, 244);
            this.listBoxAlbumWithFriend.TabIndex = 1;
            this.listBoxAlbumWithFriend.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbumWithFriend_SelectedIndexChanged);
            // 
            // labelSelectedFriend
            // 
            this.labelSelectedFriend.AutoSize = true;
            this.labelSelectedFriend.Location = new System.Drawing.Point(64, 65);
            this.labelSelectedFriend.Name = "labelSelectedFriend";
            this.labelSelectedFriend.Size = new System.Drawing.Size(109, 17);
            this.labelSelectedFriend.TabIndex = 0;
            this.labelSelectedFriend.Text = "selected Friend:";
            // 
            // breakManagerFeature
            // 
            this.breakManagerFeature.Location = new System.Drawing.Point(4, 25);
            this.breakManagerFeature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.breakManagerFeature.Name = "breakManagerFeature";
            this.breakManagerFeature.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.breakManagerFeature.Size = new System.Drawing.Size(642, 361);
            this.breakManagerFeature.TabIndex = 5;
            this.breakManagerFeature.Text = "Break Manager";
            this.breakManagerFeature.UseVisualStyleBackColor = true;
            // 
            // coverPhoto
            // 
            this.coverPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coverPhoto.Location = new System.Drawing.Point(131, 10);
            this.coverPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(659, 184);
            this.coverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("profilePicture.InitialImage")));
            this.profilePicture.Location = new System.Drawing.Point(353, 74);
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
            this.userNamePresentation.Location = new System.Drawing.Point(340, 198);
            this.userNamePresentation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userNamePresentation.Name = "userNamePresentation";
            this.userNamePresentation.Size = new System.Drawing.Size(207, 53);
            this.userNamePresentation.TabIndex = 8;
            this.userNamePresentation.Text = "";
            // 
            // FormMainFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 696);
            this.Controls.Add(this.userNamePresentation);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.coverPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TabPage breakManagerFeature;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Label labelCreateAlbumHeader;
        private System.Windows.Forms.Button buttonSelectedFriend;
        private System.Windows.Forms.TextBox textBoxSelectedFriend;
        private System.Windows.Forms.ListBox listBoxAlbumWithFriend;
        private System.Windows.Forms.Label labelSelectedFriend;
    }
}

