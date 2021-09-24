using System;
using Xunit;
using Assignment1;
using static Assignment1.Iterators;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
     
     [Fact]
     public void given_a_stream_of_a_stream_returns_a_stream_of_T ()
     {
     //Given
        var list = new[] {new[] {1,3,5}, new[] {2,4}};
     //When
        var actual = Flatten(list);
        var expected = new[] {1,3,5,2,4};
     //Then
     Assert.Equal(expected, actual);
     }
        
    [Fact]
    public void Given_a_stream_returns_strems_passed_through_filter()
    {
    //Given
        //Predicate<int> even = delegate(int i) {return i % 2 == 0;};
        Predicate<int> p = x => x%2 == 0;
        var list = new[] {1,2,3,4,5};
    //When
        var actual = Filter(list, p);
        var expexted = new[] {2,4};
    //Then
    Assert.Equal(expexted, actual);
    
    }


    }
}
