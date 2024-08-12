namespace GDDownloader
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            MessageBox.Show("Change Display res in settings if ui bad and if that dosen't work email me gddownloaderd@gmail.com if ok press continue");
            Application.Run(new Form1());
        }
    }
}