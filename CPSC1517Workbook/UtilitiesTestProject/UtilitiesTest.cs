using Util;
using FluentAssertions;

namespace UtilitiesTestProject
{
    public class UtilitiesTest
    {
        // DateOnly data generator
        public static IEnumerable<object[]> GenerateIsInTheFutureTestData()
        {
            // present
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now), false
            };

            // past
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now).AddDays(-1), false
            };

            // future
            yield return new object[]
            {
                DateOnly.FromDateTime(DateTime.Now).AddDays(1), true
            };
        }

        [Theory]
        [MemberData(nameof(GenerateIsInTheFutureTestData))] // present
        public void Utilities_IsInTheFuture_ReturnsTrueForFutureFalseOtherwise(DateOnly date, bool expected)
        {
            // Arrange
            bool actual;

            // Act
            actual = Utilities.IsInTheFuture(date);

            // Asset
            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsTrueForEmptyNullOrWhiteSpace(string value)
        {
            // Arrange
            bool actual;

            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace(value);

            // Assert
            actual.Should().BeTrue();
        }



        [Fact]
        public void Utilities_IsNullEmptyOrWhiteSpace_ReturnsFalseForNonEpmpty()
        {
            // Arrange
            bool actual;
            const string GOOD_STRING = "i";
            
            // Act
            actual = Utilities.IsNullEmptyOrWhiteSpace( GOOD_STRING );

            // Assert
            actual.Should().BeFalse();
        }
    }
}