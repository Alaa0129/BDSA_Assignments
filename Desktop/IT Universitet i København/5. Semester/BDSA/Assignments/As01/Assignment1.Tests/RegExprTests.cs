using Xunit;
using Assignment1;
using static Assignment1.RegExpr;


namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Given_a_stream_of_lines_returns_the_sentence_in_splitted_words()
        {
        //Given
        var input = new[] {"Hej med dig", "Hvor er du"};
        
        //When
        var actual = SplitLine(input);
        var expected = new[] {"Hej", "med", "dig", "Hvor", "er", "du"};
        //Then
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_a_stream_of_resolution_returns_stream_of_tuples()
        {
        //Given
        var input = new[]{"1920x1080, 1024x768, 800x600, 640x480, 320x200, 320x240, 800x600, 1280x960"};

        //When
        var actual = Resolution(input);
        var expected = new[] {(1920,1080),(1024,768),(800,600),(640,480),(320,200),(320,240), (800,600),(1280,960)}; 
        
        //Then
        Assert.Equal(expected,actual);
        }

        [Fact]
        public void Test_InnerText_Returns_Only_Text_Between_Tags_Case_2()
        {
        //Given
        var input_html = "<div>" +
        @"<p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p>" + 
        "</div>";
        var input_tag = "p";

        //When
        var actual = InnerText(input_html, input_tag);
        var expexted = new[] {"The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to."};

        //Then
        Assert.Equal(expexted, actual);
        }

        [Fact]
        public void Test_InnerText_Returns_Only_Text_Between_Tags_Case_1()
        {
        //Given
        var input_html = "<div>" +
        @"<p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href='/wiki/Theoretical_computer_science' title='Theoretical computer science'>theoretical computer science</a> and <a href='/wiki/Formal_language' title='Formal language'>formal language</a> theory, a sequence of <a href='/wiki/Character_(computing)' title='Character (computing)'>characters</a> that define a <i>search <a href='/wiki/Pattern_matching' title='Pattern matching'>pattern</a></i>. Usually this pattern is then used by <a href='/wiki/String_searching_algorithm' title='String searching algorithm'>string searching algorithms</a> for 'find' or 'find and replace' operations on <a href='/wiki/String_(computer_science)' title='String (computer science)'>strings</a>.</p>" + 
        "</div>";
        var input_tag = "a";

        //When
        var actual = InnerText(input_html, input_tag);
        var expected = new[] {"theoretical computer science", "formal language", "characters", "pattern", "string searching algorithms", "strings"};

        //Then
        Assert.Equal(expected, actual);
        }
    }
}
