Console.Write("Введите имя пользователя: ");
var username = Console.ReadLine();

if(username.ToLower() == "андрей")
{
    Console.WriteLine("Ура, это же Андрей!");
}
else
{
    Console.Write("Привет, " + username);
    Console.Write(username);
    Console.Out.Flush();

}