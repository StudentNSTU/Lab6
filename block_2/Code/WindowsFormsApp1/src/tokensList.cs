using System.Collections.Generic;

namespace WindowsFormsApp1.src
{
    internal class tokensList
    {
        public Dictionary<string, TokenType> tokenTypeList = new Dictionary<string, TokenType>
        {
            { "REGEXP", new TokenType("REGEXP", "^[0-9A-Fa-f]+$") },
            { "ANY", new TokenType("ANY", ".*") }
        };
    }
}
