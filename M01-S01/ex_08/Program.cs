int num1 = 0;
int num2 = 1;
int resultado;

Console.Write(num2+", ");

for (int i = 1; i < 20; i++) {
    
     resultado = num1 + num2;
    
     if (i<=18) {
    
        Console.Write(resultado+", ");
    
     } else { Console.Write(resultado+".");}
    
    num1 = num2;
    num2 = resultado;
}