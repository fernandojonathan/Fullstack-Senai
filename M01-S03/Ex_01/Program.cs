using Ex_01;
//instâncias das Classes, criadas com variáveis que permitirão a execução dos métodos
Tickets ticket = new Tickets();
Carros carro = new Carros();
List<Carros> listaCarros = new List<Carros>();
int op=0;

do {
    Console.Clear();
    Console.WriteLine(".................... Pare Aqui ....................");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1 - Cadastro/Consulta de veículo");
    Console.WriteLine("2 - Emissão de ticket");
    Console.WriteLine("3 - Sair");
    
    while(!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 3) {
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
                    Console.WriteLine($"{i+1}. {listaCarros[i].Placa}, {listaCarros[i].Modelo}, {listaCarros[i].Marca}, {listaCarros[i].Cor}");
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

                ticket.CadEntrada();

            } else {
                ticket.CadSaida();
                ticket.CalcValor();
                Console.ReadLine();


                
            }

        

    }






    }  while(op != 3 ); 
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("     Fim da aplicação!");
    Console.WriteLine();
    Console.WriteLine();



