Console.Write("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же САША!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
