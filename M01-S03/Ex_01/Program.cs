using Ex_01;
//instâncias das Classes, criadas com variáveis que permitirão a execução dos métodos
Carros carro = new Carros();
List<Carros> listaCarros = new List<Carros>();
List<Tickets> listaTicket = new List<Tickets>();   
int op=0;


//Resolver:
// Números inteiros, string, 
//cadastro duplicado de carro e tickets
// na exibição dos carros cadastrados colocar se está com tickete ativo

do {

    Console.Clear();
    Console.WriteLine(".................... Pare Aqui ....................");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1 - Veículos: Cadastro  |  Consulta de veículos");
    Console.WriteLine("2 - Tickets:  Emissão   |  Baixa  |  Consulta de tickets");
    Console.WriteLine("3 - Histórico");
    Console.WriteLine("4 - Sair");
    
    while(!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 4) {
        Console.WriteLine("Escolha uma opção válida");
    
    } 

    if (op ==1 ) { 

        Console.Clear();
        Console.WriteLine(".................... Pare Aqui ....................");
        Console.WriteLine("............... Cadastro de veículo ...............");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("1 - Cadastar veículo  |  2 - Consultar cadastrados ");
        var opA = Console.ReadLine();

            if (opA == "1"){

            Carros novoCarro = new Carros();
            novoCarro.CadCarro();
            listaCarros.Add(novoCarro);
            Console.WriteLine("Veículo cadastrado com sucesso!");
            Console.ReadLine();
        
            } else {

                Console.Clear();
                Console.WriteLine(".................... Pare Aqui ....................");
                Console.WriteLine("............... Veículos Cadastrados ..............");
                Console.WriteLine();
                Console.WriteLine();

                for (int i=0; i < listaCarros.Count; i++) {
                    
                    Console.WriteLine($"{i+1}. {listaCarros[i].Placa}, {listaCarros[i].Modelo}, {listaCarros[i].Marca}, {listaCarros[i].Cor}, status do ticker: ");
                
                }
                
                Console.WriteLine();
                Console.WriteLine("Pressione enter para sair...");
                Console.ReadLine();
                                     
            }



    }    else if (op == 2 ) { 

            Console.Clear();
            Console.WriteLine("................ Emissão de tícket ................");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1 - Emitir entrada        |       2 - Emitir saída");
            
            var opB = Console.ReadLine();

            if (opB == "1") {

                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("..................... Entrada ..................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");
                 Console.WriteLine("Informe a placa do veículo:");
                 
                 //Verificar se a placa é existente nos objetos da lista
                 var placa = Console.ReadLine();
                 bool placaCadastrada = listaCarros.Any(c => c.Placa == placa);
                 
                 if (placaCadastrada) {

                                 
                    var novoticket = new Tickets();
                    novoticket.CadEntrada();
                    listaTicket = new List<Tickets>();
                    listaTicket.Add(novoticket);
                    
                  /*     Carros novoCarro = new Carros();
                      novoCarro.CadCarro();
                      listaCarros.Add(novoCarro); */
                                     
                 } else {
                    
                    Console.WriteLine("Primeiro efetue o cadastro do veículo...");
                    Console.ReadLine();

                 }
                 

                } else {

                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine("................ Emissão de tícket ................");
                 Console.WriteLine("..................... Saída ..................... ");
                 Console.WriteLine("");
                 Console.WriteLine("");
                 Console.WriteLine("Informe a placa do veículo:");
                 
                 //Verificar se a placa é existente nos objetos da lista
                 var placa = Console.ReadLine();
                 bool placaCadastrada = listaCarros.Any(c => c.Placa == placa);
                 
                 if (placaCadastrada) {
                                    
                    var novoticket = new Tickets();
                    novoticket.CadSaida();
                           
                 } else {
                    
                    Console.WriteLine("Veículo sem ticket ativo(AJUSTAR DEFININDO BUSCA ATRAVÉS DO TICKET)...");
                    Console.ReadLine();

                 }
                 }

                
            } else if (op ==3 ) {

                 Console.Clear();
                 Console.WriteLine(".................... Pare Aqui ....................");
                 Console.WriteLine(".................... Histórico ....................");
                 Console.WriteLine("");
                 Console.WriteLine("");
                 Console.WriteLine("Informe a placa do veículo:");
                 
                 //Verificar se a placa é existente nos objetos da lista
                 var placa = Console.ReadLine();
                 bool placaCadastrada = listaCarros.Any(c => c.Placa == placa);
                 
                 if (placaCadastrada && listaTicket.Count > 0) {
                                    
                    for (int i=0; i<listaTicket.Count; i++) {
                        
                        Console.WriteLine($"Placa: {placa} | Entrada: {listaTicket[i]}");
                                               
                    } Console.ReadLine();

                    } else {
                    
                    Console.WriteLine("Veículo não cadastrado ou sem histórico...");
                                        
                    }
          }
        
    } while(op != 4 ); 

    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("     Fim da aplicação!");
    Console.WriteLine();
    Console.WriteLine();



