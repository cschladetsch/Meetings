namespace WinFormsApp1 {
    internal static class Program {
        [STAThread]
        static void Main(string[] args) {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(args[1]));
        }
    }
}