using Hockey.Data;
using Util;

namespace Hockey.Data
{   /// <summary>
    /// Testing comments 
    /// </summary>
    public class HockeyPlayer
    {
        // date types & fields
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private string _firstName;
        private string _lastName;
        private int _weightPounds;
        private int _heightInInches;

       
        public string BirthPlace {  
            get { 
                return _birthPlace; 
            } 
            private set 
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birthplace cannot be NULL or Empty!");
                }  
                _birthPlace = value;
            } 
        }
        public DateOnly DateOfBirth { 
            get { 
                return _dateOfBirth; 
            } 
            private set {
                if (Utilities.IsInTheFuture(value)) {
                    throw new ArgumentException("Date of birth cannot be in the future.");
                }
                _dateOfBirth = value;
            } 
        }
        public string FirstName {
            get
            {
                return _firstName;
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be NULL or Empty!");
                }
                _firstName = value;
            }
        }
        public string LastName {
            get
            {
                return _lastName;
            }
            private set
            {
                if (Utilities.IsNullEmptyOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be NULL or Empty!");
                }
                _lastName = value;
            }
        }
        public int WeightPounds {
            get {
                return _weightPounds;
            }
            private set 
            {
                if (!Utilities.IsPositive(value)) {
                    throw new ArgumentException("Weight must be positibe.");
                }
                _weightPounds = value;
            } 
        }
        public int HeightInInches {
            get
            {
                return _heightInInches;
            }
            private set
            {
                if (Utilities.IsZeroOrNegative(value))
                {
                    throw new ArgumentException("Height must be positive");
                }
                _heightInInches = value;
            }
        }
        public Position Position { get; set; }
        public Shot Shot { get; set; }

        // Greedy Constructor
        public HockeyPlayer(string birthPlace, DateOnly dateOfBirth, 
            string firstName, string lastName, int weightPounds, 
            int heightInInches, 
            Position position = Position.LeftWing, // Default value
            Shot shot = Shot.Left)
        {
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;
            WeightPounds = weightPounds;
            HeightInInches = heightInInches;
            Position = position;
            Shot = shot;
        }

        // Overide ToString
        public override string ToString()
        {
            return $"{FirstName},{LastName}....";
        }
    }
}