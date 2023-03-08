Console.Write("Digite um número: ");
int entrada = Convert.ToInt32(Console.ReadLine());
int valor1 = 0;
int valor2 = 1;
int soma = 0;

while(valor2 <= entrada)
{
    soma = valor1;
    valor1 = valor2;
    valor2 = valor1 + soma;

    if(valor2 == entrada)
    {
        Console.WriteLine($"Atual número da sequência: {valor2}");
        Console.WriteLine($"O número {entrada} pertence à sequência.");
        break;

    }

    Console.WriteLine($"Atual número da sequência: {valor2}");

}

if (valor2 != entrada ) {
    
    Console.WriteLine($"O número {entrada} não pertence à sequência.");

}
