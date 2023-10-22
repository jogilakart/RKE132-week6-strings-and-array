//string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

//Random rnd = new Random();

//int randomIndex = rnd.Next(0, snacks.Length);

//Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");


//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//for (int i = colors.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine($"{colors.Length - i}. {colors[i]}");
//}

//string[] colors = { "red", "green", "blue", "pink", "yellow" };

//for (int i = colors.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(colors[i]);
//}

//string hello = "Hello, world!".ToLower();
//int counter = 0;

//for(int i = 0; i < hello.Length; i++)
//{
//    if (hello[i] == 'l')
//    {
//        counter++;
//    }
//}
//Console.WriteLine($"There are {counter} l's in the string \"{hello}\"");

string[] colors = { "red", "green", "blue", "pink", "yellow" };

Random rnd = new Random();
String randomColor = colors[rnd.Next(0, colors.Length)];
Console.WriteLine($"You should wear {randomColor} today.");