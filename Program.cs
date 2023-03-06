


Console.Write("Digite seu nome: ");
string name = Console.ReadLine(); 
Console.WriteLine("Olá " + (name) + "!");

Console.Write("Digite seu ano de nascimento: ");
int year = int.Parse (Console.ReadLine());
int age = 2023 - year;
Console.WriteLine("Você tem " + (age) + " anos");

if (age >= 18)
{
    Console.WriteLine("Você é maior de idade");
}

else
{
    Console.WriteLine("Você é menor de idade");
}