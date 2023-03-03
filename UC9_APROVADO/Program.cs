//CRIANDO AS VARIÁVEIS
double[,] matriz = new double[4, 7];
string resposta, trabalho;
int aulas, faltas, trabalhonota;
double prova1, prova2, prova3, notatotal, faltastotal;

//DANDO VALOR AS VARIÁVEIS
resposta = "S";
trabalhonota = 0;
aulas = 0;
faltas = 0;
prova1 = 0;
prova2 = 0;
prova3 = 0;
notatotal = 0;
faltastotal = 0;


//ESCRITAS
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("--------------------- APROVADO VER. 1.0 ---------------------");
Console.WriteLine("-------------------------------------------------------------");

//FAZENDO AS PERGUNTAS
for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 6; coluna++)
    {
        if (coluna == 0)
        {
            Console.WriteLine("Qual o nome do aluno " + linha + "?");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());
        }
        if (coluna == 1)
        {
            Console.WriteLine("Quantas faltas o " + matriz[linha, 0] + " tem?");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());
        }
        if (coluna == 2)
        {
            Console.WriteLine("O " + matriz[linha, 0] + " fez o trabalho?  \n1 para SIM / 2 para NÃO");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());

            if (matriz[linha, 2] == 1)
            {
                trabalhonota = 1;
            }
        }
        if (coluna == 3)
        {
            Console.WriteLine("Qual a nota do " + matriz[linha, 0] + " na 1º prova?");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());
        }
        if (coluna == 4)
        {
            Console.WriteLine("Qual a nota do " + matriz[linha, 0] + " na 2º prova?");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());
        }
        if (coluna == 5)
        {
            Console.WriteLine("Qual a nota do " + matriz[linha, 0] + " na 3º prova?");
            matriz[linha, coluna] = double.Parse(Console.ReadLine());
        }
        //CONTAS
        prova1 = (matriz[linha, 3] * 30) / 100;
        prova2 = (matriz[linha, 4] * 25) / 100;
        prova3 = (matriz[linha, 5] * 35) / 100;
        matriz[linha, 6] = prova1 + prova2 + prova3 + trabalhonota;
    }
}

Console.WriteLine("Quantas aulas foi dada no total?");
aulas = int.Parse(Console.ReadLine());

faltastotal = (faltas * 100) / aulas;

//DANDO A RESPOSTA SE O ALUNO FOI REPROVADO OU APROVADO
if (faltastotal > 25 && notatotal > 6)
{
    
}
