namespace WinFormsApp1 {
    public partial class Form1 : Form {
        private string commentsFile;

        public Form1(string fileName) {
            InitializeComponent();
            LoadAdgenda(fileName);
        }

        private void LoadAdgenda(string FileName) {
            Console.WriteLine("Reading {Filename}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            Console.WriteLine("text changed");
        }

        private void Form1_Load(object sender, EventArgs e) {
            titleBox.Text = "foo";
        }
    }
}
