using System.Text.RegularExpressions;

public class RemarkItem {
    public string Text { get; set; }
    public int? Time { get; set; }
    public List<RemarkItem> Children { get; set; } = new List<RemarkItem>();
}

public class RemarkParser {
    public List<RemarkItem> Items { get; private set; } = new List<RemarkItem>();

    public RemarkParser(string filename) {
        if (!File.Exists(filename)) {
            throw new FileNotFoundException("Failed to open file", filename);
        }

        using var file = new StreamReader(filename);
        Parse(file);
    }

    private void Parse(StreamReader input) {
        string line;
        while ((line = input.ReadLine()) != null) {
            var item = new RemarkItem {
                Text = ExtractText(line),
                Time = ExtractTime(line)
            };

            Items.Add(item);

            if (item.Time.HasValue && item.Time.Value.Item1 > item.Time.Value.Item2) {
                throw new ArgumentException("Invalid time range");
            }

            while ((line = input.ReadLine()) != null && IsChild(line)) {
                var child = new RemarkItem {
                    Text = ExtractText(line),
                    Time = ExtractTime(line)
                };

                item.Children.Add(child);

                if (child.Time.HasValue && child.Time.Value.Item1 > child.Time.Value.Item2) {
                    throw new ArgumentException("Invalid time range");
                }
            }
        }
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
