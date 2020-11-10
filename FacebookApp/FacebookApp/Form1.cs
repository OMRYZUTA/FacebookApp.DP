using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void loginAndInit()
        {
            if (m_LoginResult == null)
            {
                /// Owner: design.patterns
                ///EAAUm6cZC4eUEBALVbi9bZAb5VFs1ebDkmva0uhzXkgRRlMY8YVVBEjoJRw5e6fdxnbrHezOCBpqybBCglBWxpyaFlqSu98nqSpp3yXhgcDl6YoRH6zSKMIZA3em1D6LidH0mCgXzCjZBXW5HuZBTLVvUDNqDtd6HElosgjevktks5e09iRU0X
                /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
                /// You can then save the result.AccessToken for future auto-connect to this user:
                m_LoginResult = FacebookService.Login("1450160541956417", /// (desig patter's "Design Patterns Course App 2.4" app)

                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "publish_to_groups",
                    "groups_access_member_info",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown"
                    );
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_LoggedInUser = m_LoginResult.LoggedInUser;
                    fetchUserInfo();
                }
                else
                {
                    MessageBox.Show(m_LoginResult.ErrorMessage);
                }

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
