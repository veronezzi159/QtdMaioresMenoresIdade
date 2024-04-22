int idade = 0, count = 0, qtdmaiores = 0, qtdmenores = 0;


do
{
    Console.WriteLine($"Escreva a idade da pessoa {count + 1}");
    idade = int.Parse( Console.ReadLine() );

    if ( idade < 0 || idade > 117 )
    {
        Console.WriteLine("idade menor de zero ou acima de 117 impossivel");
    }
    else
    {
        if (idade > 17)
        {
            qtdmaiores++;            
        } else
        {
            qtdmenores++;
        }
        count++;
    }

} while (count <10);

Console.WriteLine($"O numero de pessoas maiores de idade é: {qtdmaiores}");
Console.WriteLine($"O numero de pessoas menores de idade é: {qtdmenores}");