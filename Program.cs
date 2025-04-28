Console.Clear();

string nomePrimeiroItem = "Câmara de ar";
string nomeSegundoItem = "Capacete";
string nomeTerceiroItem = "Kit de Ferramentas";

decimal precoPrimeiroItem = 29.90m;
decimal precoSegundoItem = 134.90m;
decimal precoTerceiroItem = 189.00m;

decimal percentualImpostoVenda = 0.088m; //8,8%

int qtdItem1, qtdItem2, qtdItem3;

decimal subtotalItemUm, subTotalItemDois, 
        subTotalItemTres, totalClienteUm,
        valorDoImposto, totalComImposto;


const int TAMANHO_LINHA = 36;
const char SEPARADOR = '=';

Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(10)}Oficina Bike Pro{"|".PadLeft(11)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(14)}CATÁLOGO{"|".PadLeft(15)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.WriteLine($"{"| ITEM",-24}{"VALOR",-12}|");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.WriteLine($"| 1. { nomePrimeiroItem,-18} {precoPrimeiroItem,-12:C2}|");
Console.WriteLine($"| 2. { nomeSegundoItem,-18} {precoSegundoItem,-12:C2}|");
Console.WriteLine($"| 3. { nomeTerceiroItem,-18} {precoTerceiroItem,-12:C2}|");

Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"| Imposto sobre a venda: 8,8%",-TAMANHO_LINHA}|");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

Console.Write($"\n\nInforme a quantidade de {nomePrimeiroItem}: ");
qtdItem1 = Convert.ToInt32(Console.ReadLine());

bool primeiroNumeroEhNegativo = qtdItem1 < 0;

// if (primeiroNumeroEhNegativo)
// {
//     Console.WriteLine("Quantidade informada é negativa. Será considerada como zero.");
//     qtdItem1 = 0;
// }
if (primeiroNumeroEhNegativo)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

Console.Write($"Informe a quantidade de {nomeSegundoItem}: ");
qtdItem2 = Convert.ToInt32(Console.ReadLine());
if (qtdItem2 < 0)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

Console.Write($"Informe a quantidade de {nomeTerceiroItem}: ");
qtdItem3 = Convert.ToInt32(Console.ReadLine());
if (qtdItem3 < 0)
{
    Console.WriteLine("Quantidade inválida!");
    return;
}

subtotalItemUm = qtdItem1 * precoPrimeiroItem;
subTotalItemDois = qtdItem2 * precoSegundoItem;
subTotalItemTres = qtdItem3 * precoTerceiroItem;

totalClienteUm = subtotalItemUm + subTotalItemDois + subTotalItemTres;
valorDoImposto = totalClienteUm * percentualImpostoVenda;

totalComImposto = totalClienteUm + valorDoImposto;

Console.WriteLine("\n");
Console.WriteLine($"1. {qtdItem1}x {nomePrimeiroItem} --> {subtotalItemUm:C2}");
Console.WriteLine($"2. {qtdItem2}x {nomeSegundoItem} --> {subTotalItemDois:C2}");
Console.WriteLine($"3. {qtdItem3}x {nomeTerceiroItem} --> {subTotalItemTres:C2}");

Console.WriteLine($"\nImposto (8,8%): {valorDoImposto:C2}");
Console.WriteLine($"\nTotal: {totalComImposto:C2}");
