// Вид 1.

// void Method()
// {
//     Console.WriteLine("Автор ...");
// }
// Method();


// Вид 2.

// void Method1(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method1("Текаст сообщения");


// void Method11 (string msg, int count)
// {
// int i = 0;
// while (i < count)
// {
//     Console.WriteLine(msg);
//     i++;
// }
// }
// Method11 ("Текст", 4);
// Method11 (count: 4, msg: "новый текст");


// Вид 3.

// int Method2()
// {
//     return DateTime.Now.Year;
// }
// int year = Method2();
// Console.WriteLine(year);


// Вид 3.

string Method3(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method3(10,"куку");
Console.WriteLine(res);
