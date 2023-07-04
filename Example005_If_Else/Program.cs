Console.WriteLine("Представьтесь пожалуйста");
string username = Console.ReadLine();

if(username.ToLower() == "michael")
{
    Console.Write("Ура! Это же ");
    Console.WriteLine(username);
    Console.Write("!");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}