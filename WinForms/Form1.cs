using Remarkable;
using System.Reflection;

namespace WinFormsApp1 {
    public partial class Form1 : Form {
        RemarkParser _parsed;
        int _itemIndex = 0;

        public Form1(string fileName) {
            InitializeComponent();
            LoadAdgenda(fileName);
        }

        private void LoadAdgenda(string fileName) {
            Console.WriteLine($"Reading {fileName}");
            _parsed = new RemarkParser(fileName);
            Text = "Meeting - " + _parsed.Title;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            Console.WriteLine("text changed");
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }
    }
}
