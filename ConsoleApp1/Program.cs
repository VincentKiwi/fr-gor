using System;
int points = 0;
Console.WriteLine("welcome to the quiz ");
Console.WriteLine("remember to use small letters");



Console.WriteLine("1 is stockholm the main city in Sweden    a for yes   b for no");
string answer1 = Console.ReadLine();
if (answer1 == "a")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}






Console.WriteLine("2 in swedish does (hejdå) mean hello    a for yes   b for no");
string answer2 = Console.ReadLine();
if (answer2 == "b")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}





Console.WriteLine("3 does 12+23+44=79    a for yes   b for no");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}




Console.WriteLine("4 is the time 08 00    a for yes   b for no");
string answer4 = Console.ReadLine();
if (answer4 == "b")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}




Console.WriteLine("5 does 10-23+12=89    a for yes   b for no");
string answer5 = Console.ReadLine();
if (answer5 == "b")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}



Console.WriteLine("6 what is the second letter in the alphabet ");
Console.WriteLine("a = L      b = B ");
string answer6 = Console.ReadLine();
if (answer6 == "a")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}






Console.WriteLine("7 last one   what does hej mean");
Console.WriteLine("a = hi b = bye ");
string answer7 = Console.ReadLine();
if (answer7 == "a")
{
  points++;
  Console.WriteLine("good");
}
else
{
  Console.WriteLine("wrong");
}


Console.WriteLine($"you got {points} points ");
Console.WriteLine($"0-0 bad 1-2 ok 3-5 good 6-7 super");
Console.WriteLine($"press any key to exit");
Console.ReadKey();
