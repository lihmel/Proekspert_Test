using System.IO;
using System.Text.RegularExpressions;

namespace Proekspert_Test
{
    public class FileReader
    {
        private const string IgnorePunctuationPattern = @"[^\w\d\s]";

        public string GetInputFromFile(string filePath)
        {
            string fileContents = File.ReadAllText(filePath);
            fileContents = Regex.Replace(fileContents, IgnorePunctuationPattern, "");
            return fileContents;
        }
    }
}
