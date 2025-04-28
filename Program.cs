Console.Clear();

string nomePrimeiroItem = "Câmara de ar";
string segundoPrimeiroItem = "Capacete";
string terceiroPrimeiroItem = "Kit de Ferramentas";

decimal precoPrimeiroItem = 29.90m;
decimal precoSegundoItem = 134.90m;
decimal precoTerceiroItem = 189.00m;

double percentualImpostoVenda = 0.088; //8,8%

const int TAMANHO_LINHA = 30;
const char SEPARADOR = '=';

Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(7)}Oficina Bike Pro{"|".PadLeft(8)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");
Console.WriteLine($"{"|".PadRight(11)}CATÁLOGO{"|".PadLeft(12)}");
Console.WriteLine($"{"+".PadRight(TAMANHO_LINHA, SEPARADOR)}+");

