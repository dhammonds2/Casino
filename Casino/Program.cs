namespace Casino
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
            GlobalStuff.gGameScreen = new GameScreen();
            GlobalStuff.gRoulette = new Roulette();
            Application.Run(new StartScreen());
        }
    }
}