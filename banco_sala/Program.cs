Console.Clear();
using banco_sala;

Cliente CriarConta() {
    Cliente cliente = new Cliente();
    Console.WriteLine("Nome do Cliente: ");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF: ");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereço: ");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Data de nascimento: ");
    cliente.DateTime = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Telefone: ");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Número da conta: ");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    return cliente;


}
string op;


do {
Console.WriteLine("Banco é Noix");
Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Criar conta");
Console.WriteLine("2 - Adicionar Transação");
Console.WriteLine("3 - Consultar Extrato");
Console.WriteLine("4 - Sair");
op = Console.ReadLine();

 if(op =="1"){
    Cliente novoCliente  =  CriarConta();
    
 }
} while (op != "3");

