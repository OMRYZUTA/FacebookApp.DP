using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginResult result = FacebookWrapper.FacebookService.Login("892240561306584", "user_friends");
            Form1 outForm = new Form1();
            //outForm.lablresult.LoggedInUser.FirstName
            //Application.Run(outForm);
           
        }
    }
}
