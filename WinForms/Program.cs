namespace Remarkable {
    internal static class Program {
        [STAThread]
        static void Main(string[] args) {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1(args[1]));
            Application.Run(new WinFormsApp1.Form1("config.json"));
        }
    }
}