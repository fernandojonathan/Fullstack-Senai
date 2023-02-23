using Ex_01_new;
var op = 0;

List<Carros> listaCarros = new List<Carros>();
/* List<Carros> novoCarro = new List<Carros>();
List<Tickets> novoTicket = new List<Tickets>(); */



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
            Carros novoCarro = CadCarros();
            listaCarros.Add(novoCarro);

            

/*          
        
] var placa = Console.ReadLine();
            bool placaCadastrada = listaCarros.Any(c => c.Placa == placa); */
        
                    
        
            } else if (op == 2) {
                
                CadTicket();
                
            }
            
            
            else if (op == 7) {
                
                ExibirCarros();
                Console.ReadLine();
            }

        
            } while (op !=5);




//Apenas Métodos Abaixo
//Método de cadastro de objetos na classe Carros
Carros CadCarros(){
    Carros carro = new Carros();
    Console.WriteLine("Placa:");
    carro.Placa=Console.ReadLine();
    Console.WriteLine("Marca:");
    carro.Marca=Console.ReadLine();
    Console.WriteLine("Modelo:");
    carro.Modelo=Console.ReadLine();
    Console.WriteLine("Cor:");
    carro.Cor=Console.ReadLine();

    return carro;

}

Tickets CadTicket(){
    Tickets ticket = new Tickets();
    Console.WriteLine("Placa");
    var placa = Console.ReadLine();

    if (placa ) {

        Console.WriteLine($"Entrada: {DateTime.Now}");
        ticket.Entrada=DateTime.Now;
        Console.ReadLine();  
        ticket.Ativo=true;
                

    } else {

        Console.WriteLine("placa não cadastrada");
    }
    return ticket;
} 

Tickets CadTicket(){
    Tickets ticket = new Tickets();
    Console.WriteLine("Placa");
    var placa = Console.ReadLine();

    if (placa ) {

        Console.WriteLine($"Saída: {DateTime.Now}");
        ticket.Saida=DateTime.Now;
        Console.ReadLine();
        ticket.Ativo=false;
        
                

    } else {
        Console.WriteLine("placa não cadastrada");
    }
    return ticket;
}
//Método para exibir carros de acordo com o cadastro da lista
void ExibirCarros (){

    Console.Clear();
    Console.WriteLine($"Total cadastrado(s): {listaCarros.Count}");
    
    for (int i = 0; i <listaCarros.Count ; i++){
               
        Console.WriteLine($"{i+1}. {listaCarros[i].Placa} | {listaCarros[i].Marca} | {listaCarros[i].Modelo} | {listaCarros[i].Cor}");
        
        }
}