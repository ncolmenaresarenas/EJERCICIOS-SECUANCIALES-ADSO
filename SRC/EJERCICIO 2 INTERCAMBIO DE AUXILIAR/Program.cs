//PROGRAMA QUE INTERCAMBIA VALORES SOLO CON DOS VARIABLES

//DEFINIR VARIABLES

int a, b;

Console.Write("DIGITE EL VALOR DE A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("DIGITE EL VALOR DE B: ");
b = Convert.ToInt32(Console.ReadLine());

a = a + b;

b = a - b;

a = a - b;


Console.WriteLine($"EL VALOR CAMBIADO DE A ES: {a}");
Console.WriteLine($"EL VALOR CAMBIADO DE B ES: {b}");



