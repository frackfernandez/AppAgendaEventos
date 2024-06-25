namespace UI
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
            PrepararArchivos();
            Application.Run(new FormPrincipal());
        }
        private static void PrepararArchivos()
        {
            var path = Directory.GetCurrentDirectory() + @"\evento.txt";
            var pathCarpeta = Directory.GetCurrentDirectory() + @"\evento";

            if (!File.Exists(path))
            {
                using (File.Create(path))
                {
                    // nada
                }
            }
            if (!File.Exists(pathCarpeta))
            {
                Directory.CreateDirectory(pathCarpeta);
            }

        }
    }
}