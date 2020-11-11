namespace FacebookApp
{
    partial class Form1
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
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.userNamePresentation = new System.Windows.Forms.RichTextBox();
            this.userPostsList = new System.Windows.Forms.ListBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.numberOfFriends = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.numberOfPhotos = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.workPlaces = new System.Windows.Forms.Label();
            this.workPlacesList = new System.Windows.Forms.ListBox();
            this.educationList = new System.Windows.Forms.ListBox();
            this.educationPlaces = new System.Windows.Forms.Label();
            this.birthDay = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.livesIn = new System.Windows.Forms.Label();
            this.birthDayBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.livesInBox = new System.Windows.Forms.TextBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.photosListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // appIcon
            // 
            this.appIcon.Location = new System.Drawing.Point(12, 13);
            this.appIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(112, 62);
            this.appIcon.TabIndex = 2;
            this.appIcon.TabStop = false;
            this.appIcon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonLogin
            // 
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
            this.button1.Location = new System.Drawing.Point(804, 814);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(147, 319);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 488);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.photosListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "userPhotos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userPostsList);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "userPosts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(723, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "aboutUser";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.friendsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(723, 455);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "friendsList";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // coverPhoto
            // 
            this.coverPhoto.Location = new System.Drawing.Point(147, 12);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(741, 230);
            this.coverPhoto.TabIndex = 1;
            this.coverPhoto.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(397, 93);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(200, 149);
            this.profilePicture.TabIndex = 7;
            this.profilePicture.TabStop = false;
            // 
            // userNamePresentation
            // 
            this.userNamePresentation.Location = new System.Drawing.Point(382, 248);
            this.userNamePresentation.Name = "userNamePresentation";
            this.userNamePresentation.Size = new System.Drawing.Size(232, 65);
            this.userNamePresentation.TabIndex = 8;
            this.userNamePresentation.Text = "";
            // 
            // userPostsList
            // 
            this.userPostsList.FormattingEnabled = true;
            this.userPostsList.ItemHeight = 20;
            this.userPostsList.Location = new System.Drawing.Point(4, 9);
            this.userPostsList.Name = "userPostsList";
            this.userPostsList.Size = new System.Drawing.Size(718, 444);
            this.userPostsList.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(711, 443);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.livesInBox);
            this.tabPage5.Controls.Add(this.statusBox);
            this.tabPage5.Controls.Add(this.birthDayBox);
            this.tabPage5.Controls.Add(this.livesIn);
            this.tabPage5.Controls.Add(this.status);
            this.tabPage5.Controls.Add(this.birthDay);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(703, 410);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "userOverview";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.educationPlaces);
            this.tabPage6.Controls.Add(this.educationList);
            this.tabPage6.Controls.Add(this.workPlacesList);
            this.tabPage6.Controls.Add(this.workPlaces);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(703, 410);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "userWorkAndEducation";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.richTextBox3);
            this.tabPage7.Controls.Add(this.numberOfPhotos);
            this.tabPage7.Controls.Add(this.richTextBox2);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.richTextBox1);
            this.tabPage7.Controls.Add(this.numberOfFriends);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(703, 410);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "userStatistics";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // numberOfFriends
            // 
            this.numberOfFriends.AutoSize = true;
            this.numberOfFriends.Location = new System.Drawing.Point(12, 12);
            this.numberOfFriends.Name = "numberOfFriends";
            this.numberOfFriends.Size = new System.Drawing.Size(133, 20);
            this.numberOfFriends.TabIndex = 0;
            this.numberOfFriends.Text = "numberOfFriends";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(171, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(123, 33);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "numberOfPosts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(172, 70);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(123, 33);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // numberOfPhotos
            // 
            this.numberOfPhotos.AutoSize = true;
            this.numberOfPhotos.Location = new System.Drawing.Point(12, 128);
            this.numberOfPhotos.Name = "numberOfPhotos";
            this.numberOfPhotos.Size = new System.Drawing.Size(130, 20);
            this.numberOfPhotos.TabIndex = 4;
            this.numberOfPhotos.Text = "numberOfPhotos";
            this.numberOfPhotos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(172, 128);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(123, 33);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // workPlaces
            // 
            this.workPlaces.AutoSize = true;
            this.workPlaces.Location = new System.Drawing.Point(129, 25);
            this.workPlaces.Name = "workPlaces";
            this.workPlaces.Size = new System.Drawing.Size(89, 20);
            this.workPlaces.TabIndex = 0;
            this.workPlaces.Text = "workPlaces";
            // 
            // workPlacesList
            // 
            this.workPlacesList.FormattingEnabled = true;
            this.workPlacesList.ItemHeight = 20;
            this.workPlacesList.Location = new System.Drawing.Point(28, 68);
            this.workPlacesList.Name = "workPlacesList";
            this.workPlacesList.Size = new System.Drawing.Size(303, 284);
            this.workPlacesList.TabIndex = 1;
            // 
            // educationList
            // 
            this.educationList.FormattingEnabled = true;
            this.educationList.ItemHeight = 20;
            this.educationList.Location = new System.Drawing.Point(365, 68);
            this.educationList.Name = "educationList";
            this.educationList.Size = new System.Drawing.Size(303, 284);
            this.educationList.TabIndex = 2;
            // 
            // educationPlaces
            // 
            this.educationPlaces.AutoSize = true;
            this.educationPlaces.Location = new System.Drawing.Point(453, 25);
            this.educationPlaces.Name = "educationPlaces";
            this.educationPlaces.Size = new System.Drawing.Size(126, 20);
            this.educationPlaces.TabIndex = 3;
            this.educationPlaces.Text = "educationPlaces";
            // 
            // birthDay
            // 
            this.birthDay.AutoSize = true;
            this.birthDay.Location = new System.Drawing.Point(25, 22);
            this.birthDay.Name = "birthDay";
            this.birthDay.Size = new System.Drawing.Size(68, 20);
            this.birthDay.TabIndex = 0;
            this.birthDay.Text = "birthDay";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(25, 72);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 20);
            this.status.TabIndex = 1;
            this.status.Text = "status";
            // 
            // livesIn
            // 
            this.livesIn.AutoSize = true;
            this.livesIn.Location = new System.Drawing.Point(25, 122);
            this.livesIn.Name = "livesIn";
            this.livesIn.Size = new System.Drawing.Size(53, 20);
            this.livesIn.TabIndex = 2;
            this.livesIn.Text = "livesIn";
            // 
            // birthDayBox
            // 
            this.birthDayBox.Location = new System.Drawing.Point(141, 22);
            this.birthDayBox.Name = "birthDayBox";
            this.birthDayBox.Size = new System.Drawing.Size(125, 26);
            this.birthDayBox.TabIndex = 3;
            // 
            // statusBox
            // 
            this.statusBox.Location = new System.Drawing.Point(141, 72);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(125, 26);
            this.statusBox.TabIndex = 4;
            // 
            // livesInBox
            // 
            this.livesInBox.Location = new System.Drawing.Point(141, 122);
            this.livesInBox.Name = "livesInBox";
            this.livesInBox.Size = new System.Drawing.Size(125, 26);
            this.livesInBox.TabIndex = 5;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(-4, 0);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(727, 464);
            this.friendsListBox.TabIndex = 0;
            // 
            // photosListBox
            // 
            this.photosListBox.FormattingEnabled = true;
            this.photosListBox.ItemHeight = 20;
            this.photosListBox.Location = new System.Drawing.Point(0, 0);
            this.photosListBox.Name = "photosListBox";
            this.photosListBox.Size = new System.Drawing.Size(717, 444);
            this.photosListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 870);
            this.Controls.Add(this.userNamePresentation);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.appIcon);
            this.Controls.Add(this.coverPhoto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox userPostsList;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label numberOfPhotos;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label numberOfFriends;
        private System.Windows.Forms.PictureBox coverPhoto;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.RichTextBox userNamePresentation;
        private System.Windows.Forms.TextBox livesInBox;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.TextBox birthDayBox;
        private System.Windows.Forms.Label livesIn;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label birthDay;
        private System.Windows.Forms.Label educationPlaces;
        private System.Windows.Forms.ListBox educationList;
        private System.Windows.Forms.ListBox workPlacesList;
        private System.Windows.Forms.Label workPlaces;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.ListBox photosListBox;
    }
}

