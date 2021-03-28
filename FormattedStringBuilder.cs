using System.Collections.Generic;
using System.Text;

namespace Skibitsky.Unity.StringFormatter
{
    public class FormattedStringBuilder
    {
        private readonly StringBuilder _openingTagsBuilder;
        private readonly Stack<string> _closingTagsStack;

        private string String { get; }
        
        public FormattedStringBuilder() : this(string.Empty)
        {
        }

        public FormattedStringBuilder(string value)
        {
            String = value;

            _openingTagsBuilder = new StringBuilder();
            _closingTagsStack = new Stack<string>();
        }

        public void Append(string value)
        {
            _openingTagsBuilder.Append(value);
        }
        
        public void PushToEnd(string value)
        {
            _closingTagsStack.Push(value);
        }

        public string Apply(string value)
        {
            var builder = new StringBuilder(_openingTagsBuilder.ToString());
            
            builder.Append(value);
            
            foreach (var s in _closingTagsStack)
                builder.Append(s);

            return builder.ToString();
        }

        public override string ToString() => Apply(String);

        public static implicit operator string(FormattedStringBuilder fsb) => fsb.ToString();
        public static implicit operator FormattedStringBuilder(string str) => new FormattedStringBuilder(str);
    }
}