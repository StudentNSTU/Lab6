using System.Collections.Generic;

namespace WindowsFormsApp1.src
{
    internal class tokensList
    {
        public Dictionary<string, TokenType> tokenTypeList = new Dictionary<string, TokenType>
        {
            { "REGEXP", new TokenType("REGEXP", "(^(https|ftp|http):\\/\\/(www.)?\\w+.\\w*)(\\/\\w+)*(.\\w+)*") },
            { "ANY", new TokenType("ANY", ".*") }
        };
    }
}
