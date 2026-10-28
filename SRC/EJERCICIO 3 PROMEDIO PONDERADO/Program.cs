// PROGRAMA PARA CALCULAR LA NOTA DEFINITIVA

double nota1, nota2, nota3, notafinal;

Console.Write("DIGITE LA NOTA 1: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("DIGITE LA NOTA 2: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("DIGITE LA NOTA 3: ");
nota3 = Convert.ToDouble(Console.ReadLine());

notafinal = (nota1 * 0.25) + (nota2 * 0.35) + (nota3 * 0.40);


Console.Write($"LA NOTA DEFINITIVA DEL PROGRAMA DE FORMACION ES: {notafinal:f2}");

