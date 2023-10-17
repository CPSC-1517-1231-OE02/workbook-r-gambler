using FluentAssertions;
using Hockey.Data;

namespace Hockey.Test
{
    public class HockeyPlayerTest
    {
        // constants for a test player
        const string FirstName = "Connor";
        const string LastName = "Brown";
        const string BirthPlace = "Toronto, ON, CAN";
        const int HeightInInches = 72;
        const int WeightInPounds = 188;
        const int JerseyNumber = 28;
        const Position PlayerPosition = Position.Defense;
        const Shot PlayerShot = Shot.Left;
        static readonly DateOnly DateOfBirth = new DateOnly(1994, 01, 14);
        const string ToStringValue = $"{FirstName} {LastName}";
        readonly int Age = (DateOnly.FromDateTime(DateTime.Now).DayNumber - DateOfBirth.DayNumber)/365;

        public HockeyPlayer CreateTestHockeyPlayer() 
        {
            return new HockeyPlayer(BirthPlace, DateOfBirth,
            FirstName, LastName, WeightInPounds,
            HeightInInches);
        }

        [Fact]
        public void HockeyPLayer_ToString_ReturnCorrectValue() 
        { 
            HockeyPlayer player = CreateTestHockeyPlayer();
            string actual;

            actual = player.ToString();

            actual.Should().Be(ToStringValue);
        }
    }
}