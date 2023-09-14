using Hockey.Data;
using Xunit.Sdk;
using FluentAssertions;

namespace Hockey.Test 
{ 
    public class HockeyPlayerTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int a = 1;
            int b = 1;
            int actual;
            // Act
            actual = a + b;
            // Assert
            actual.Should().Be(2);
            
        }
    }
}