using Hockey.Data;

Console.WriteLine("Welcome to the HockeyPLayer Test App");

// create using default
HockeyPlayer player1 = new HockeyPlayer();
player1.FirstName = "Test";
player1.LastName = "Test2";
// object-initializer
HockeyPlayer player2 = new HockeyPlayer() {
    FirstName = "Mark",
    LastName = "Alejandro"
};

// Greedy constructor
HockeyPlayer player3 = new HockeyPlayer("Parry Sound", new DateOnly(1948, 3, 20), "Bobby", "Orr", 196, 73, Position.Goalie, Shot.Right);

// Output things

Console.WriteLine($"The player's name is {player1.FirstName} {player1.LastName} and they are born on {player1.DateOfBirth}");
Console.WriteLine($"The player's name is {player2.FirstName} {player2.LastName} and they are born on {player2.DateOfBirth}");
Console.WriteLine($"The player's name is {player3.FirstName} {player3.LastName} and they are born on {player3.DateOfBirth}");
