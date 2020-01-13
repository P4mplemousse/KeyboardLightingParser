using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace KeyboardLightingParser
{
    class Parser
    {
        public List<string> ParseRegex(string line, string regex)
        {
            List<string> output = new List<string>();
            string tempLine = line.ToLower();
            tempLine = tempLine.Replace(" ", string.Empty);

            Regex test = new Regex(regex);
            if (test.IsMatch(tempLine))
            {
                var keys = tempLine.Split(',');
                foreach (var key in keys)
                {
                    if (!output.Contains(key))
                    {
                        output.Add(key);
                    }
                }
            }

            return output;
        }
    }
}
