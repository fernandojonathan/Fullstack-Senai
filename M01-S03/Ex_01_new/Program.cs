using Ex_01_new;
var op = 0;

List<Carros> listaCarros = new List<Carros>();



//Linhas abaixos criadas para facilitar tesdtes DEVEM SER EXCLUIDAS PARA ENTREGAR A ATIVIDADE
listaCarros.Add(new Carros("aaa-1111","Classic","Chevrolet","Cinza"));
listaCarros.Add(new Carros("bbb-2222","Palio","Fiat","Branco"));
listaCarros.Add(new Carros("ccc-3333","Gol","Volksvagem","Azul"));
listaCarros.Add(new Carros("ddd-4444","Hilux","Toyta","Roxo"));

do {

    Console.Clear();
    Console.WriteLine(".................... Pare Aqui ....................");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar histórico");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("7 - Exibir Carros"); //APAGAR APÓS CONCLUSÃO


    //APOS TESTES Ajeitar dexando até opção 5, 
    while(!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 8) {
        Console.WriteLine("Escolha uma opção válida");
    
    } 

    if (op == 1) { 
        
            Console.Clear();
            //ao chamar o método (ação) Cadastro de carros, devo inserir novo carro à Classe
            CadCarros();

            } else if (op == 2) {
                
                EntradaTicket();
                
            } else if (op == 3) {
                
                SaidaTicket();
               /*  CalcTempo();
                CalcValor(); */
                
            } else if (op == 4) {
                
              ExibirHistorico();

            }
                        
            else if (op == 7) {
                
                ExibirCarros();
                Console.ReadLine();
            }
        
            } while (op !=5);


//Apenas Métodos Abaixo

//Método de cadastro de objetos na classe Carros

Carros CadCarros(){

Carros novoCarro = new Carros();

Console.WriteLine("Placa: ");
novoCarro.Placa = Console.ReadLine();

//class variavelRecebeBool lista     condicao    classe "c"arros.Placa == objeto declarado.atributo
Carros  placaconsulta = listaCarros.FirstOrDefault(c => c.Placa == novoCarro.Placa);
    
    if (placaconsulta == null ) {

        Console.WriteLine("Modelo: ");
        novoCarro.Modelo = Console.ReadLine();

        Console.WriteLine("Marca: ");
        novoCarro.Marca = Console.ReadLine(); 

        Console.WriteLine("Cor: ");
        novoCarro.Cor = Console.ReadLine();

        //Adiciona o objeto novo carro à lista de carros
        listaCarros.Add(novoCarro);

        //Cria uma lista dentro do objeto, nela irão os registros de entrada, saída e Ativo 
        List<Tickets> listaTickets = new List<Tickets>();

        //Retorna o objeto
        return novoCarro;

    } else {

        Console.WriteLine("Veículo já cadastrado"); 
        Console.ReadLine();

        }

//Caso a placa já cadastrada, retornará nullo, desta forma não criará um novo objeto.
return null;


}


void EntradaTicket(){

    Carros novoCarro = new Carros();
        Console.WriteLine("....................................................");
    Console.WriteLine("Placa: ");
    novoCarro.Placa = Console.ReadLine();

    //class variavelRecebeBool lista     condicao    classe "c"arros.Placa == objeto declarado.atributo
    Carros placaconsulta = listaCarros.FirstOrDefault(c => c.Placa == novoCarro.Placa);

    if (placaconsulta != null) {
                
        Tickets tickets = new Tickets(DateTime.Now,true);
        placaconsulta.Extrato.Add(tickets);
        
        Console.WriteLine($"Entrada registrada: {DateTime.Now}");
        Console.WriteLine($"Status do ticket: {tickets.Ativo}");
        Console.ReadLine();
          
    } else {
        
        Console.WriteLine("Carro não cadastrado!");
        Console.ReadLine();

}
}

// Marca a saída do carro
void SaidaTicket(){
    
      Console.WriteLine("....................................................");
    Console.WriteLine("Placa: ");
    string placa = Console.ReadLine();

    Carros carro = listaCarros.FirstOrDefault(c => c.Placa == placa);

    if (carro == null) {
        Console.WriteLine("Carro não cadastrado!");
        Console.ReadLine();
        return;
    }

    Tickets ultimoTicket = carro.Extrato.LastOrDefault();

    if (!ultimoTicket.Ativo) {
        Console.WriteLine("Esse carro já saiu!");
        Console.ReadLine();
        return;
    }

    Tickets tickets = new Tickets(false,DateTime.Now);
    carro.Extrato.Add(tickets);
    
    // Calcula o tempo de permanência e o valor a pagar
    TimeSpan tempoentrada = DateTime.Now - ultimoTicket.Entrada;
    TimeSpan temposaida = DateTime.Now - ultimoTicket.Saida;
    TimeSpan tempo = temposaida - tempoentrada;
    

    Console.WriteLine($"Saída registrada: {DateTime.Now}");
    Console.WriteLine($"Tempo de permanência: {tempo}");
    Console.WriteLine($"Valor a pagar: {tempo * 0.09}");
    Console.ReadLine();
}

void ExibirCarros (){

    Carros carro = new Carros();
    Console.Clear();
    Console.WriteLine($"Cadastrado(s): {listaCarros.Count}");

    for (int i = 0; i < listaCarros.Count ; i++){
        Console.WriteLine($"{i+1}. {listaCarros[i].Placa}, {listaCarros[i].Marca}, {listaCarros[i].Modelo}, {listaCarros[i].Cor}");
        
    
    }
}

void ExibirHistorico() {
    Console.WriteLine("Digite a placa do carro para exibir o histórico:");
    string placa = Console.ReadLine();

    var carro = listaCarros.LastOrDefault(c => c.Placa == placa);

    if (carro == null) {
        Console.WriteLine("Carro não encontrado.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine($"Placa: {carro.Placa}");
    Console.WriteLine("Histórico:");
    foreach (var ticket in carro.Extrato) {
        Console.WriteLine($"   Entrada: {ticket.Entrada}, Saída: {ticket.Saida}, Ativo: {ticket.Ativo}");
    }
    Console.ReadLine();
}

