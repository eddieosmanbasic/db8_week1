Console.WriteLine("Welcome to the Room Detail Generator!");
Console.WriteLine("Enter length:");
decimal length = decimal.Parse(Console.ReadLine());
Console.WriteLine("Enter width:");
decimal width = decimal.Parse(Console.ReadLine());
decimal area = length * width;
decimal perimeter = length + length + width + width;
Console.WriteLine($"The area is {area} sqft.");
Console.WriteLine($"The perimeter is {perimeter} ");
Console.WriteLine("Would you like to calculate the volume of your room? Please enter yes or no.");
string volAnswer = Console.ReadLine();
if (volAnswer == "yes")
{
    Console.WriteLine("Please enter the height of the room.");
    decimal height = decimal.Parse(Console.ReadLine());
    decimal vol = length * width * height;
    Console.WriteLine($"The volume of the room is {vol} feet cubed");

}
else if (volAnswer == "no")
{

}
if (area <= 250)
{
    string roomSize = "small-sized";
    Console.WriteLine($"This room is a {roomSize} room");
}
else if (area > 250 && area < 650)
{
    string roomSize = "medium-sized";
    Console.WriteLine($"This room is a {roomSize} room");
}
else if (area > 650)
{
    string roomSize = "large-sized";
    Console.WriteLine($"This room is a {roomSize} room");
}
Console.WriteLine("Thanks for using the Room Detail Generator!");