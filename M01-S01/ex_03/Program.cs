Console.WriteLine("Informe a 1° nota:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a 2° nota:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe a 3° nota:");
double nota3 = double.Parse(Console.ReadLine());
double media = (nota1+nota2+nota3) / 3;
if (media >= 6 ) {
    Console.WriteLine("Aluno aprovado com média: " + media);
} else if (media >= 5 && media < 6) {
    Console.WriteLine("Aluno em recuperação com média: "+ media);
}
else {
    Console.WriteLine("Aluno reprovado com média: "+ media);
};