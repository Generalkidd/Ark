using System.Diagnostics;

namespace Ark
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (args.Length == 0)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            else
            {
                checkVersion(args[0]);
            }
        }

        private static void checkVersion(string tagpath)
        {
            if(tagpath.Contains("HREK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.HREKPath;
                startInfo.Arguments = "/dontloadlastopenedwindows " + tagpath;
                Process.Start(startInfo);
            }
            else if(tagpath.Contains("H4EK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H4EKPath;
                startInfo.Arguments = "/dontloadlastopenedwindows " + tagpath;
                Process.Start(startInfo);
            }
            else if(tagpath.Contains("H2AMPEK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H2AMPEKPath;
                startInfo.Arguments = "/dontloadlastopenedwindows " + tagpath;
                Process.Start(startInfo);
            }
            else if (tagpath.Contains("H3EK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H3EKPath;
                startInfo.Arguments = tagpath;
                Process.Start(startInfo);
            }
            else if (tagpath.Contains("H3ODSTEK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H3ODSTEKPath;
                startInfo.Arguments = tagpath;
                Process.Start(startInfo);
            }
            else if (tagpath.Contains("H2EK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H2EKPath;
                startInfo.Arguments = tagpath;
                Process.Start(startInfo);
            }
            else if (tagpath.Contains("HCEEK"))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = Properties.Settings.Default.H1EKPath;
                startInfo.Arguments = tagpath;
                Process.Start(startInfo);
            }
        }
    }
}