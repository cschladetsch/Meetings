using System.Text.RegularExpressions;

namespace Remarkable {
    public class RemarkItem {
        public string Text { get; set; }
        public int? Time { get; set; }
        public List<RemarkItem> Children { get; set; } = new List<RemarkItem>();
    }

    public class RemarkParser {
        public string Title { get; private set; }

        public List<RemarkItem> Items { get; private set; } = new List<RemarkItem>();

        public RemarkParser(string filename) {
            if (!File.Exists(filename)) {
                throw new FileNotFoundException("Failed to open file", filename);
            }

            using var file = new StreamReader(filename);
            if (!Parse(file)) {
                throw new Exception("Couldn't parse " + filename);
            }

        }

        private bool Parse(StreamReader input) {
            if (input == null ) {
                throw new Exception("Nothing to read");
            }

            if ((Title = input.ReadLine()) == null) {
                throw new Exception("Meeetings notes has no title");
            }

            string line;
            while ((line = input.ReadLine()) != null) {
                var item = new RemarkItem {
                    Text = ExtractText(line),
                    Time = ExtractTime(line)
                };

                Items.Add(item);

                while ((line = input.ReadLine()) != null && IsChild(line)) {
                    var child = new RemarkItem {
                        Text = ExtractText(line),
                        Time = ExtractTime(line)
                    };

                    item.Children.Add(child);
                }
            }

            return true;
        }

        private string ExtractText(string line) {
            var match = Regex.Match(line, @"^([^\s]+)");
            return match.Success ? match.Value : string.Empty;
        }

        private int? ExtractTime(string line) {
            var match = Regex.Match(line, @"\((\d+))");
            if (match.Success) {
                return (int.Parse(match.Groups[1].Value));
            }
            return null;
        }

        private bool IsChild(string line) {
            return line.TrimStart().StartsWith(" ");
        }
    }
}
