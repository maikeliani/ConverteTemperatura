// See https://aka.ms/new-console-template for more information
double c, f;
Console.WriteLine( " Informe a temperatura");
c =double.Parse(Console.ReadLine());

f = ((c * 9 / 5) + 32);
Console.WriteLine(  " A temperatura em graus celsius é : " + c + "" +
    " e a temperatura em graus farenheit é: " + f);