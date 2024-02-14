namespace Utilities
{
    public static class StringUtilities
    {
        public static int WordsCount(string str)
        {
            return str.Split(" ").Length;
        }

        public static string ToSpinalCase(string str)
        {
            var words = str.ToLower().Split(' ');
            return string.Join("-", words);
        }
        public static string ToPascalCase(string str)
        {
            var words = str.Split(" ");
            var result = new List<string>();
            foreach (var word in words) {
                var newWord = char.ToUpper(word[0]) + word[1..].ToLower();
                result.Append(newWord);
            }
            return string.Join("", result);
        }
    }
}