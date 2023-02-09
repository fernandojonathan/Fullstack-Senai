List<double> soma = new List<double>();
int op;
double addT = 0.00;

do { 
    Console.Clear();
    Console.WriteLine("                             BNC  ");
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("||          Bem vindo ao Banco Nacional Coqueiros          ||");
    Console.WriteLine("||                                                         ||");
    Console.WriteLine("||          Selecione  uma  opção para continuar           ||");
    Console.Write("||  1 - Adicionar transação");
    Console.WriteLine("    |    2 - Consultar extrato  ||");
    Console.WriteLine("||  3 - Sair                                               ||");
    Console.WriteLine("-------------------------------------------------------------");

      while (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 3) {
        Console.WriteLine("Entrada inválida. Por favor, digite uma opção válida (1, 2 ou 3):");
    }

    if (op == 1) {
        
        Console.Clear();
        Console.WriteLine("                             BNC  ");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("||                 ADICIONAR TRANSAÇÃO                     ||");
        Console.WriteLine("||                                                         ||");
        Console.WriteLine("||                                                         ||");
        Console.WriteLine("||                   Informe o valor                       ||");
        Console.WriteLine("||                                                         ||");
        Console.WriteLine("-------------------------------------------------------------");
        
        /* addT = double.Parse(Console.ReadLine()); */

        while (!double.TryParse(Console.ReadLine(), out addT)) {
            Console.WriteLine("Por favor, digite números ao invés de letras.");
        }   

    soma.Add(addT);

     } else if (op == 2) {

        Console.Clear();
        Console.WriteLine("                        BNC  ");
        Console.WriteLine("----------------------------------------------------------");
        Console.WriteLine("||              CONSULTA DE EXTRATO                  ");
        Console.WriteLine("||                                                         ");
        foreach (double transacao in soma) {
            if (transacao > 0) {
                Console.WriteLine("||                                 Despósito "+ transacao);
            } else {
                 Console.WriteLine("||                                    Saque "+ transacao);
            }
        
                
    }
        Console.WriteLine("||                                                         ");

    double saldo = soma.Sum(); 
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("||                  Valor total em conta: R$ "+ saldo);
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("");
    Console.WriteLine("Pressione enter para retornar");
    Console.ReadLine();

     };

}  while ( op == 1 || op ==2 ) ;



Console.Clear();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("                  Fim de aplicação!");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

