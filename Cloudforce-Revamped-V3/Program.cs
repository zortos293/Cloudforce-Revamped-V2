using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;
using Sentry;

namespace Cloudforce_Revamped_V3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://506ce9fe3adf48e59feaa4d5382dfcc3@o1302473.ingest.sentry.io/4504034486714368";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = true;
            }))
            {
                AutoUpdater.ShowRemindLaterButton = true;
                AutoUpdater.RunUpdateAsAdmin = false;
                AutoUpdater.DownloadPath = Environment.SpecialFolder.ApplicationData + "\\Cloudforce\\";
                AutoUpdater.Start("https://raw.githubusercontent.com/zortos293/CloudForce-Revamped/master/cfupdate.xml");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cloudforce\\");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}