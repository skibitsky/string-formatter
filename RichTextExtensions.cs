namespace Skibitsky.Unity.StringFormatter
{
    public static class RichTextExtensions
    {
        public static FormattedStringBuilder Size(this string source, int size, bool skip = false) => new FormattedStringBuilder(source).Size(size, skip);
        public static FormattedStringBuilder Bold(this string source, bool skip = false) => new FormattedStringBuilder(source).Bold(skip);
        public static FormattedStringBuilder Italic(this string source, bool skip = false) => new FormattedStringBuilder(source).Italic(skip);
        public static FormattedStringBuilder Color(this string source, string color, bool skip = false) => new FormattedStringBuilder(source).Color(color, skip);

        public static FormattedStringBuilder Aqua(this string source, bool skip = false) => new FormattedStringBuilder(source).Aqua(skip);
        public static FormattedStringBuilder Black(this string source, bool skip = false) => new FormattedStringBuilder(source).Black(skip);
        public static FormattedStringBuilder Blue(this string source, bool skip = false) => new FormattedStringBuilder(source).Blue(skip);
        public static FormattedStringBuilder Brown(this string source, bool skip = false) => new FormattedStringBuilder(source).Brown(skip);
        public static FormattedStringBuilder Cyan(this string source, bool skip = false) => new FormattedStringBuilder(source).Cyan(skip);
        public static FormattedStringBuilder DarkBlue(this string source, bool skip = false) => new FormattedStringBuilder(source).DarkBlue(skip);
        public static FormattedStringBuilder Fuchsia(this string source, bool skip = false) => new FormattedStringBuilder(source).Fuchsia(skip);
        public static FormattedStringBuilder Green(this string source, bool skip = false) => new FormattedStringBuilder(source).Green(skip);
        public static FormattedStringBuilder Grey(this string source, bool skip = false) => new FormattedStringBuilder(source).Grey(skip);
        public static FormattedStringBuilder LightBlue(this string source, bool skip = false) => new FormattedStringBuilder(source).LightBlue(skip);
        public static FormattedStringBuilder Lime(this string source, bool skip = false) => new FormattedStringBuilder(source).Lime(skip);
        public static FormattedStringBuilder Magenta(this string source, bool skip = false) => new FormattedStringBuilder(source).Magenta(skip);
        public static FormattedStringBuilder Maroon(this string source, bool skip = false) => new FormattedStringBuilder(source).Maroon(skip);
        public static FormattedStringBuilder Navy(this string source, bool skip = false) => new FormattedStringBuilder(source).Navy(skip);
        public static FormattedStringBuilder Olive(this string source, bool skip = false) => new FormattedStringBuilder(source).Olive(skip);
        public static FormattedStringBuilder Orange(this string source, bool skip = false) => new FormattedStringBuilder(source).Orange(skip);
        public static FormattedStringBuilder Purple(this string source, bool skip = false) => new FormattedStringBuilder(source).Purple(skip);
        public static FormattedStringBuilder Red(this string source, bool skip = false) => new FormattedStringBuilder(source).Red(skip);
        public static FormattedStringBuilder Silver(this string source, bool skip = false) => new FormattedStringBuilder(source).Silver(skip);
        public static FormattedStringBuilder Teal(this string source, bool skip = false) => new FormattedStringBuilder(source).Teal(skip);
        public static FormattedStringBuilder White(this string source, bool skip = false) => new FormattedStringBuilder(source).White(skip);
        public static FormattedStringBuilder Yellow(this string source, bool skip = false) => new FormattedStringBuilder(source).Yellow(skip);

        
        public static FormattedStringBuilder Size(this FormattedStringBuilder source, int size, bool skip = false)
        {
            if (skip)
                return source;
            
            source.Append("<size=");
            source.Append(size.ToString());
            source.Append(">");
            
            source.PushToEnd("</size>");
            
            return source;
        }

        public static FormattedStringBuilder Bold(this FormattedStringBuilder source, bool skip = false)
        {
            if (skip)
                return source;
            
            source.Append("<b>");
            source.PushToEnd("</b>");

            return source;
        }
        
        public static FormattedStringBuilder Italic(this FormattedStringBuilder source, bool skip = false)
        {
            if (skip)
                return source;
            
            source.Append("<i>");
            source.PushToEnd("</i>");

            return source;
        }
        
        public static FormattedStringBuilder Color(this FormattedStringBuilder source, string color, bool skip = false)
        {
            if (skip)
                return source;
            
            source.Append("<color=");
            source.Append(color);
            source.Append(">");
            
            source.PushToEnd("</color>");

            return source;
        }

        public static FormattedStringBuilder Aqua(this FormattedStringBuilder source, bool skip = false) => source.Color("aqua", skip);
        public static FormattedStringBuilder Black(this FormattedStringBuilder source, bool skip = false) => source.Color("black", skip);
        public static FormattedStringBuilder Blue(this FormattedStringBuilder source, bool skip = false) => source.Color("blue", skip);
        public static FormattedStringBuilder Brown(this FormattedStringBuilder source, bool skip = false) => source.Color("brown", skip);
        public static FormattedStringBuilder Cyan(this FormattedStringBuilder source, bool skip = false) => source.Color("cyan", skip);
        public static FormattedStringBuilder DarkBlue(this FormattedStringBuilder source, bool skip = false) => source.Color("darkblue", skip);
        public static FormattedStringBuilder Fuchsia(this FormattedStringBuilder source, bool skip = false) => source.Color("fuchsia", skip);
        public static FormattedStringBuilder Green(this FormattedStringBuilder source, bool skip = false) => source.Color("green", skip);
        public static FormattedStringBuilder Grey(this FormattedStringBuilder source, bool skip = false) => source.Color("grey", skip);
        public static FormattedStringBuilder LightBlue(this FormattedStringBuilder source, bool skip = false) => source.Color("lightblue", skip);
        public static FormattedStringBuilder Lime(this FormattedStringBuilder source, bool skip = false) => source.Color("lime", skip);
        public static FormattedStringBuilder Magenta(this FormattedStringBuilder source, bool skip = false) => source.Color("magenta", skip);
        public static FormattedStringBuilder Maroon(this FormattedStringBuilder source, bool skip = false) => source.Color("maroon", skip);
        public static FormattedStringBuilder Navy(this FormattedStringBuilder source, bool skip = false) => source.Color("navy", skip);
        public static FormattedStringBuilder Olive(this FormattedStringBuilder source, bool skip = false) => source.Color("olive", skip);
        public static FormattedStringBuilder Orange(this FormattedStringBuilder source, bool skip = false) => source.Color("orange", skip);
        public static FormattedStringBuilder Purple(this FormattedStringBuilder source, bool skip = false) => source.Color("purple", skip);
        public static FormattedStringBuilder Red(this FormattedStringBuilder source, bool skip = false) => source.Color("red", skip);
        public static FormattedStringBuilder Silver(this FormattedStringBuilder source, bool skip = false) => source.Color("silver", skip);
        public static FormattedStringBuilder Teal(this FormattedStringBuilder source, bool skip = false) => source.Color("teal", skip);
        public static FormattedStringBuilder White(this FormattedStringBuilder source, bool skip = false) => source.Color("white", skip);
        public static FormattedStringBuilder Yellow(this FormattedStringBuilder source, bool skip = false) => source.Color("yellow", skip);
    }
}