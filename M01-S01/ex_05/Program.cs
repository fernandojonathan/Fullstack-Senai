Console.WriteLine("Informe o lado 1:");
double Lado1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o lado 2:");
double Lado2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o lado 3:");
double Lado3 = double.Parse(Console.ReadLine());
//Console.WriteLine(lado1 +" "+lado2+" "+lado3);
if (Lado1 + Lado2 > Lado3 || Lado3 + Lado2 > Lado1 || Lado3 + Lado1 > Lado2 ) {
  if (Lado1 == Lado2 && Lado2 == Lado3) {
    Console.WriteLine("Temos um Triângulo Equilátero.");
    } else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado3 == Lado1 ) { 
        Console.WriteLine("Temos um Triângulo Isósceles.");
    } else { 
        Console.Write("Temos um Triângulo Escaleno.");
    }
            
} else {
    Console.Write("As medidas não formam um triângulo.");
};