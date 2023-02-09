Console.WriteLine("Informe seu salário bruto:");
double salario = double.Parse(Console.ReadLine());
if (salario <= 900.00) {
    Console.WriteLine("O valor do imposto devido será de R$ 0,00.");
} else if (salario > 900.00 && salario <=1500.00) {
    Console.WriteLine("O valor do imposto devido será de R$ " + salario / 100 * 5);
} else if (salario > 1500.00 && salario <= 2500.00) {
    Console.WriteLine("O valor do imposto devido será de R$ " + salario / 100 * 10);
} else {
    Console.WriteLine("O valor do imposto devido será de R$ " + salario / 100 * 20);
};