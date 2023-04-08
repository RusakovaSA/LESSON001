// Выполнение условий ИСТИНА и ЛОЖЬ - if or else

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "славяна")
{
    Console.WriteLine("Ура, это же СЛАВЯНА!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}