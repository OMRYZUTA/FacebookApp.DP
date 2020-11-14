﻿using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainFacebookApp());
        }
    }
}
