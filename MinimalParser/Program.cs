
using Antlr4.Runtime;

namespace antchat
{
    class Program
    {
        static void Main(string[] args)
        {
            LexerTest();

            ParserTest();
        }

        static void LexerTest()
        {
            string input = "john says: hello @michael this will not work";

            AntlrInputStream inputStream = new AntlrInputStream(input);
            antchatLexer lex = new antchatLexer(inputStream);

            List<IToken> itl = (List<IToken>)lex.GetAllTokens();
            foreach (var item in itl)
            {
                Console.Write(item.ToString() + " -> ");
                string tokenname = lex.Vocabulary.GetDisplayName(item.Type);

                // string tokenname = lex.Vocabulary.GetLiteralName(item.Type);
                // if (tokenname == null) tokenname = lex.Vocabulary.GetSymbolicName(item.Type);
                Console.WriteLine(tokenname);
            }
        }

        static void ParserTest()
        {
            string input = "john says: hello @michael this will not work\n";

            AntlrInputStream inputStream = new AntlrInputStream(input);
            antchatLexer lex = new antchatLexer(inputStream);

            CommonTokenStream commonTokenStream = new CommonTokenStream(lex);

            antchatParser parser = new antchatParser(commonTokenStream);
            antchatParser.ChatContext ctx = parser.chat();

            Console.WriteLine(ctx.ToStringTree());
        }
    }
}
