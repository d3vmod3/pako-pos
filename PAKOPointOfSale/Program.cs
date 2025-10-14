namespace PAKOPointOfSale
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        public static string ConnString = "Server=DESKTOP-VPUL2MD;Database=db_pos;Trusted_Connection=True;TrustServerCertificate=True;";
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}