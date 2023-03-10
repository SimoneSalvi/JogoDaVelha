// Declaração de variáveis
char[,] tabuleiro = new char[3, 3];
int rodada = 0;
char simbolo = 'O';
bool vitoria = false;
bool velha = false;
bool jogadaValida = false;
// Programa
InicializarTabuleiro(tabuleiro);
do
{
    simbolo = TrocaSimbolo(simbolo);
    do
    {
        Console.Clear();
        ImprimirTabuleiro(tabuleiro);
        Console.WriteLine("Simbolo atual [{0}]:", simbolo);
        string posicao = Console.ReadLine();
        if (int.Parse(posicao) > 9 || int.Parse(posicao) < 0)
        {
            Console.WriteLine("Posição inexistente");
            continue;
        }
        char posicaoChar = char.Parse(posicao);
        jogadaValida = EscolherPosicao(posicaoChar, simbolo, tabuleiro);
    } while (!jogadaValida);
    rodada++;
    if (rodada >= 5)
    {
        vitoria = VerificarVitoria(tabuleiro);
    }
    if (rodada == 9 && !vitoria)
    {
        velha = true;
        Console.WriteLine("Deu velha!");
        break;
    }
} while (!vitoria);
if (!velha)
{
    Console.WriteLine("Vitória do jogador com simbolo [{0}]", simbolo);
}
Console.WriteLine("Fim de jogo");
// Inicializar
void InicializarTabuleiro(char[,] tabuleiro)
{
    int contador = 0;
    for (int i = 0; i < tabuleiro.GetLength(0); i++)
    {
        for (int j = 0; j < tabuleiro.GetLength(1); j++)
        {
            tabuleiro[i, j] = char.Parse($"{contador + 1}");
            contador++;
        }
    }
}
// Imprimindo tabuleiro
void ImprimirTabuleiro(char[,] tabuleiro)
{
    for (int i = 0; i < tabuleiro.GetLength(0); i++)
    {
        for (int j = 0; j < tabuleiro.GetLength(1); j++)
        {
            Console.Write(" " + tabuleiro[i, j]);
        }
        Console.WriteLine();
    }
}
// TrocaSimbolo
char TrocaSimbolo(char simbolo)
{
    if (simbolo == 'O')
    {
        return 'X';
    }
    return 'O';
}
// Escolher posição
bool EscolherPosicao(char posicao, char simbolo, char[,] tabuleiro)
{
    for (int i = 0; i < tabuleiro.GetLength(0); i++)
    {
        for (int j = 0; j < tabuleiro.GetLength(1); j++)
        {
            if (tabuleiro[i, j] == posicao)
            {
                tabuleiro[i, j] = simbolo;
                return true;
            }
        }
    }
    return false;
}
// Verificação de vitória
bool VerificarVitoria(char[,] tabuleiro)
{
    // Verificação de linhas
    for (int i = 0; i < tabuleiro.GetLength(0); i++)
    {
        if ((tabuleiro[i, 0] == tabuleiro[i, 1]) && (tabuleiro[i, 0] == tabuleiro[i, 2]))
        {
            return true;
        }
    }
    // Verificação de colunas
    for (int j = 0; j < tabuleiro.GetLength(1); j++)
    {
        if ((tabuleiro[0, j] == tabuleiro[1, j]) && (tabuleiro[1, j] == tabuleiro[2, j]))
        {
            return true;
        }
    }
    // Verificação de diagonal principal
    if ((tabuleiro[0, 0] == tabuleiro[1, 1]) && (tabuleiro[1, 1] == tabuleiro[2, 2]))
    {
        return true;
    }
    // Verificação de diagonal secundária
    if ((tabuleiro[0, 2] == tabuleiro[1, 1]) && (tabuleiro[1, 1] == tabuleiro[2, 0]))
    {
        return true;
    }
    return false;
}