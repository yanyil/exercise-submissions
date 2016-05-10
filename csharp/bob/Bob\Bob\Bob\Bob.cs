using System.Collections.Generic;
using System.Linq;

namespace Exercism.Bob
{
    public static class Bob
    {
        public static string Hey(string message)
        {
            return Interpreter.Decipher(message);
        }
    }

    public abstract class Conversation
    {
        public Conversation(string response)
        {
            _response = response;
        }

        readonly string _response;

        public string Response { get { return _response; } }

        public abstract bool IsMatch(string message);
    }

    public class DefaultConversation : Conversation
    {
        public DefaultConversation(string response)
            : base(response) { }

        public override bool IsMatch(string message)
        {
            return true;
        }
    }

    public class YellingConversation : Conversation
    {
        public YellingConversation(string response)
            : base(response) { }

        static char _exceptionPunctuation = '!';

        public override bool IsMatch(string message)
        {
            var cleansed = _CleanseMessage(message);
            if (!cleansed.Any()) { return false; }
            return _CleanseMessage(message)
                .All(c => char.IsUpper(c) || c == _exceptionPunctuation);
        }

        IEnumerable<char> _CleanseMessage(string message)
        {
            return message
                .ToCharArray()
                .Where(_IsNotPunctuationAndWhitespace);
        }

        static bool _IsNotPunctuationAndWhitespace(char c)
        {
            if(c == _exceptionPunctuation) { return true; }
            return !char.IsPunctuation(c) && !char.IsWhiteSpace(c) && !char.IsNumber(c) && !char.IsSymbol(c);
        }
    }

    public class QuestionConversation : Conversation
    {
        public QuestionConversation(string response)
            : base(response) { }

        public override bool IsMatch(string message)
        {
            return message.Trim().EndsWith("?");
        }
    }

    public class EmptyConversation : Conversation
    {
        public EmptyConversation(string response)
            : base(response ){ }

        public override bool IsMatch(string message)
        {
            return string.IsNullOrWhiteSpace(message.Trim());
        }
    }


    public static class Interpreter
    {
        static IEnumerable<Conversation> _conversations = new Conversation[]
        {
            new EmptyConversation("Fine. Be that way!"),
            new YellingConversation("Whoa, chill out!"),
            new QuestionConversation("Sure."),
            new DefaultConversation("Whatever."),
        };

        public static string Decipher(string message)
        {
            return _conversations
                .FirstOrDefault(conv => conv.IsMatch(message))
                .Response;
        }
    }
}