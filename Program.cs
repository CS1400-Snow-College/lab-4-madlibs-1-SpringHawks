//Annette Hawks
//Due 6/25/2025
//lab-4-madlibs-1-SpringHawks
// 
//Mad Libs: Vacation 

string welcome = "Welcome to a short game of madlibs.\n" +
                 "I will ask you for a series of words and put them into a story for you.\n" +
                 "They could be a noun, adjective, or verb.\n" +
                 "Type your word and press enter.\n" +
                 "Verb: actions or state of being. ie: run or jump.\n" +
                 "Adjective: a word that describes a noun. ie blue, tall, short, nice.\n" +
                 "Noun: person, place, or thing. ie: Paul, New York, ball.\n";

Console.WriteLine(welcome);

Console.Write("Please give me an adjective: ");
string adj1 = Console.ReadLine();

Console.Write("Please give me an adjective: ");
string adj2 = Console.ReadLine();

Console.Write("Please give me a noun: ");
string noun1 = Console.ReadLine();

Console.Write("Please give me a noun: ");
string noun2 = Console.ReadLine();

Console.Write("Please give me a plural noun: ");
string noun3 = Console.ReadLine();

Console.Write("Please give me a game: ");
string game = Console.ReadLine();

Console.Write("Please give me a plural noun: ");
string noun4 = Console.ReadLine();

Console.Write("Please give me a verb ending in \"ing\": ");
string verb1 = Console.ReadLine();

Console.Write("Please give me a verb ending in \"ing\": ");
string verb2 = Console.ReadLine();

Console.Write("Please give me a plural noun: ");
string noun5 = Console.ReadLine();

Console.Write("Please give me a verb ending in \"ing\": ");
string verb3 = Console.ReadLine();

Console.Write("Please give me a noun: ");
string noun6 = Console.ReadLine();

Console.Write("Please give me a plant: ");
string plant = Console.ReadLine();

Console.Write("Please give me a part of the body: ");
string bodyPart = Console.ReadLine();

Console.Write("Please give me a place: ");
string place = Console.ReadLine();

Console.Write("Please give me a verb ending in \"ing\": ");
string verb4 = Console.ReadLine();

Console.Write("Please give me an adjective: ");
string adj3 = Console.ReadLine();

Console.Write("Please give me a number: ");
string number = Console.ReadLine();

Console.Write("Please give me a plural noun: ");
string noun7 = Console.ReadLine();

string originalStory = "A vacation is when you take a trip to some (adj1) place with your " +
                       "(adj2) family. Usually, you go to some place that is near a/an (noun1) or up on a/an (noun2). " +
                       "A good vacation place is one where you can ride (noun3) or play (game) or go hunting for (noun4). " +
                       "I like to spend my time (verb1) or (verb2). " +
                       "When parents go on a vacation, they spend their time eating three (noun5) a day, and fathers play golf, " +
                       "and mothers sit around (verb3). Last summer, my little brother fell in a/an (noun6) and got poison " +
                       "(plant) all over his (bodyPart). My family is going to go to (place) and I will practice (verb4). " +
                       "Parents need vacations more than kids because parents are always very (adj3) and because they have to work " +
                       "(number) hours every day all year making enough (noun7) to pay for the vacation.";

string[] storyWords = originalStory.Split(' ');
foreach (string word in storyWords)
{
    Console.WriteLine(word);
}

// Print the Story #5
Console.WriteLine($"\nA vacation is when you take a trip to some {adj1} place with your {adj2} family. " +
                  $"Usually, you go to some place that is near a/an {noun1} or up on a/an {noun2}. " +
                  $"A good vacation place is one where you can ride {noun3} or play {game} or go hunting for {noun4}. " +
                  $"I like to spend my time {verb1} or {verb2}. " +
                  $"When parents go on a vacation, they spend their time eating three {noun5} a day, and fathers play golf, " +
                  $"and mothers sit around {verb3}. Last summer, my little brother fell in a/an {noun6} and got poison {plant} all over his {bodyPart}. " +
                  $"My family is going to go to {place} and I will practice {verb4}. " +
                  $"Parents need vacations more than kids because parents are always very {adj3} and because they have to work {number} hours every day " +
                  $"all year making enough {noun7} to pay for the vacation.");
