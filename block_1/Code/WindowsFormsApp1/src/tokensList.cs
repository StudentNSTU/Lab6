using System.Collections.Generic;

namespace WindowsFormsApp1.src
{
    internal class tokensList
    {
        public Dictionary<string, TokenType> tokenTypeList = new Dictionary<string, TokenType>
        {
            { "REGEXP", new TokenType("REGEXP", "\\d{5}(-\\d{4})?") },
            { "ANY", new TokenType("ANY", ".*") }
        };
    }
}
