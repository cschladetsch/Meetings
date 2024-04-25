using System.Text.RegularExpressions;

namespace Remarkable {
    public class DurationConverter {
        public static TimeSpan? ParseDuration(string input) {
            if (string.IsNullOrWhiteSpace(input)) {
                return null; // Return null if input is null, empty, or only contains whitespace
            }

            // Regex pattern to match the format (Nm) where N is an integer
            Regex regex = new Regex(@"^\((\d+)m\)$");
            Match match = regex.Match(input);

            if (!match.Success) {
                return null; // Return null if the format does not match
            }

            // Extract the number part and convert to integer
            string numberPart = match.Groups[1].Value;
            if (int.TryParse(numberPart, out int minutes)) {
                // Create and return a TimeSpan object
                return TimeSpan.FromMinutes(minutes);
            }

            return null; // Return null if the number part is not a valid integer
        }
    }
}
