namespace Multilevel
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

            //check if database exist in location
            /*string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileInfo[] fileinfo = directoryInfo.GetFiles("*.accdb");
            if(fileinfo.Length == 0)
            {

            }*/

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}