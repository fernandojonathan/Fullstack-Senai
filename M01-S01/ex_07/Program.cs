Console.Clear();
Console.WriteLine(" Boletim 2.0");
Console.WriteLine("--------------");
Console.WriteLine("");
Console.WriteLine("Nome do Aluno: ");
string nome = Console.ReadLine();

Console.WriteLine("Digite a quantidade de notas para compor à média: ");
int qtdnotas = 0;
while (!int.TryParse(Console.ReadLine(), out qtdnotas))
{
    Console.WriteLine("Entrada inválida, favor digite um numero inteiro da quantidade de notas!");
};
double[] notas = new double[qtdnotas];
double soma = 0;
double media = 0;
string status;

for (int i = 0; i < qtdnotas; i++)
{
    Console.WriteLine("Digite a " + (i + 1) + "° nota: ");
    
    while (!double.TryParse(Console.ReadLine(), out notas[i])) { 
        Console.WriteLine("Digite uma nota válida!"); 
    };
   
    soma += notas[i];
}

    media = soma/qtdnotas;

if (media >= 6 ) {
    
    status = "Aprovado";

} else if (media >= 5 && media <6 ) {
     status = "Recuperação";

} else {
     status = "Reprovado";
}

Console.Clear();
Console.WriteLine("      Boletim ");
Console.WriteLine("---------------------");
Console.WriteLine("");
Console.WriteLine("Nome do Aluno: "+ nome);

for (int i=0 ; i<qtdnotas ; i++) {
    Console.WriteLine("N"+(i+1)+": "+notas[i]);
}

Console.WriteLine("Média: "+media+" - "+ status);


