namespace FormHostingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                BackEndConectedService_.BackEServiceClient cl = new BackEndConectedService_.BackEServiceClient();
                cl.GenerateSeedDataAsync().Wait();
                cl.Close();
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2());
        }
    }
}