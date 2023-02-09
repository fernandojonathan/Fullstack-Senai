int num = 0;

Console.WriteLine("Informe um número inteiro para a tabuada de 0 à 10:");

while (!int.TryParse(Console.ReadLine(), out num)) {
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro: ");
};

//int num = int.Parse(Console.ReadLine());
Console.WriteLine("---------");

for (int i = 0; i < 11; i++) { 

Console.WriteLine(num + " X " + i + " = " + num*i);

};
Console.WriteLine("---------");