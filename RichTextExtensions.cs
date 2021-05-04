namespace Skibitsky.Unity.StringFormatter
{
    public static class RichTextExtensions
    {
        public static FormattedStringBuilder Size(this string source, int size) => new FormattedStringBuilder(source).Size(size);
        public static FormattedStringBuilder Bold(this string source) => new FormattedStringBuilder(source).Bold();
        public static FormattedStringBuilder Italic(this string source) => new FormattedStringBuilder(source).Italic();
        public static FormattedStringBuilder Color(this string source, string color) => new FormattedStringBuilder(source).Color(color);

        public static FormattedStringBuilder Aqua(this string source) => new FormattedStringBuilder(source).Aqua();
        public static FormattedStringBuilder Black(this string source) => new FormattedStringBuilder(source).Black();
        public static FormattedStringBuilder Blue(this string source) => new FormattedStringBuilder(source).Blue();
        public static FormattedStringBuilder Brown(this string source) => new FormattedStringBuilder(source).Brown();
        public static FormattedStringBuilder Cyan(this string source) => new FormattedStringBuilder(source).Cyan();
        public static FormattedStringBuilder DarkBlue(this string source) => new FormattedStringBuilder(source).DarkBlue();
        public static FormattedStringBuilder Fuchsia(this string source) => new FormattedStringBuilder(source).Fuchsia();
        public static FormattedStringBuilder Green(this string source) => new FormattedStringBuilder(source).Green();
        public static FormattedStringBuilder Grey(this string source) => new FormattedStringBuilder(source).Grey();
        public static FormattedStringBuilder LightBlue(this string source) => new FormattedStringBuilder(source).LightBlue();
        public static FormattedStringBuilder Lime(this string source) => new FormattedStringBuilder(source).Lime();
        public static FormattedStringBuilder Magenta(this string source) => new FormattedStringBuilder(source).Magenta();
        public static FormattedStringBuilder Maroon(this string source) => new FormattedStringBuilder(source).Maroon();
        public static FormattedStringBuilder Navy(this string source) => new FormattedStringBuilder(source).Navy();
        public static FormattedStringBuilder Olive(this string source) => new FormattedStringBuilder(source).Olive();
        public static FormattedStringBuilder Orange(this string source) => new FormattedStringBuilder(source).Orange();
        public static FormattedStringBuilder Purple(this string source) => new FormattedStringBuilder(source).Purple();
        public static FormattedStringBuilder Red(this string source) => new FormattedStringBuilder(source).Red();
        public static FormattedStringBuilder Silver(this string source) => new FormattedStringBuilder(source).Silver();
        public static FormattedStringBuilder Teal(this string source) => new FormattedStringBuilder(source).Teal();
        public static FormattedStringBuilder White(this string source) => new FormattedStringBuilder(source).White();
        public static FormattedStringBuilder Yellow(this string source) => new FormattedStringBuilder(source).Yellow();

        
        public static FormattedStringBuilder Size(this FormattedStringBuilder source, int size)
        {
            source.Append("<size=");
            source.Append(size.ToString());
            source.Append(">");
            
            source.PushToEnd("</size>");
            
            return source;
        }

        public static FormattedStringBuilder Bold(this FormattedStringBuilder source)
        {
            source.Append("<b>");
            source.PushToEnd("</b>");

            return source;
        }
        
        public static FormattedStringBuilder Italic(this FormattedStringBuilder source)
        {
            source.Append("<i>");
            source.PushToEnd("</i>");

            return source;
        }
        
        public static FormattedStringBuilder Color(this FormattedStringBuilder source, string color)
        {
            source.Append("<color=");
            source.Append(color);
            source.Append(">");
            
            source.PushToEnd("</color>");

            return source;
        }

        public static FormattedStringBuilder Aqua(this FormattedStringBuilder source) => source.Color("aqua");
        public static FormattedStringBuilder Black(this FormattedStringBuilder source) => source.Color("black");
        public static FormattedStringBuilder Blue(this FormattedStringBuilder source) => source.Color("blue");
        public static FormattedStringBuilder Brown(this FormattedStringBuilder source) => source.Color("brown");
        public static FormattedStringBuilder Cyan(this FormattedStringBuilder source) => source.Color("cyan");
        public static FormattedStringBuilder DarkBlue(this FormattedStringBuilder source) => source.Color("darkblue");
        public static FormattedStringBuilder Fuchsia(this FormattedStringBuilder source) => source.Color("fuchsia");
        public static FormattedStringBuilder Green(this FormattedStringBuilder source) => source.Color("green");
        public static FormattedStringBuilder Grey(this FormattedStringBuilder source) => source.Color("grey");
        public static FormattedStringBuilder LightBlue(this FormattedStringBuilder source) => source.Color("lightblue");
        public static FormattedStringBuilder Lime(this FormattedStringBuilder source) => source.Color("lime");
        public static FormattedStringBuilder Magenta(this FormattedStringBuilder source) => source.Color("magenta");
        public static FormattedStringBuilder Maroon(this FormattedStringBuilder source) => source.Color("maroon");
        public static FormattedStringBuilder Navy(this FormattedStringBuilder source) => source.Color("navy");
        public static FormattedStringBuilder Olive(this FormattedStringBuilder source) => source.Color("olive");
        public static FormattedStringBuilder Orange(this FormattedStringBuilder source) => source.Color("orange");
        public static FormattedStringBuilder Purple(this FormattedStringBuilder source) => source.Color("purple");
        public static FormattedStringBuilder Red(this FormattedStringBuilder source) => source.Color("red");
        public static FormattedStringBuilder Silver(this FormattedStringBuilder source) => source.Color("silver");
        public static FormattedStringBuilder Teal(this FormattedStringBuilder source) => source.Color("teal");
        public static FormattedStringBuilder White(this FormattedStringBuilder source) => source.Color("white");
        public static FormattedStringBuilder Yellow(this FormattedStringBuilder source) => source.Color("yellow");
    }
}