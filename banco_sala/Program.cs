﻿using M1S3_SistemaBanco;

List<Cliente> clientes = new List<Cliente>();
string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
  Console.WriteLine("1 - Criar Conta ");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  Console.WriteLine("5 - Exibir Clientes");
  opcao = Console.ReadLine();

  if(opcao == "1"){
    CriarConta();
  }
  if (opcao == "5"){
    ExibirClientes();
  }

  Console.WriteLine("Tecle Enter para continuar");
  Console.ReadLine();
} while(opcao != "4");


void ExibirClientes(){
   Console.WriteLine("Número da conta        | Nome         | CPF    ");
  for(int i =0; i < clientes.Count; i++){
    Console.WriteLine(clientes[i].ResumoCliente());
  }
}

void CriarConta(){
    Cliente cliente = new Cliente();
    Console.WriteLine("Data de Nascimento do cliente:");
    cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
    if(!cliente.EhMaior()){
      Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
      return ;
    }
    Console.WriteLine("A idade do cliente é " + cliente.Idade);
    Console.WriteLine("Nome do cliente:");
    cliente.Nome = Console.ReadLine();
    Console.WriteLine("CPF do cliente:");
    cliente.CPF = Console.ReadLine();
    Console.WriteLine("Endereco do cliente:");
    cliente.Endereco = Console.ReadLine();
    Console.WriteLine("Telefone do cliente:");
    cliente.Telefone = Console.ReadLine();
    Console.WriteLine("Email do cliente:");
    cliente.Email = Console.ReadLine();
    Console.WriteLine("Numero Da Conta");
    cliente.NumeroConta = int.Parse(Console.ReadLine());
    clientes.Add(cliente);
}