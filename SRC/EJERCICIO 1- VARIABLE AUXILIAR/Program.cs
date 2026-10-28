//PROGRAMA PARA EL INTERCAMBIO DE VARIABLE AUXILIAR

int a, b, intercambio;

Console.Write("DIGITE EL VALOR DE a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("DIGITE EL VALOR DE b: ");
b = Convert.ToInt32(Console.ReadLine());

intercambio = a;

a = b;

b = intercambio;

Console.WriteLine($"El VALOR DE a INTERCAMBIADO ES: {a}");
Console.WriteLine($"El VALOR DE b INTERCAMBIADO ES: {b}");
