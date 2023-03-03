//CRIANDO AS VARIÁVEIS
string nome, trabalho;
int aulas, faltas, repeticao, trabalhonota;
double prova1, prova2, prova3, notatotal, faltastotal;

//DANDO VALOR AS VARIÁVEIS
nome = "";
trabalho = "S";
repeticao = 0;
trabalhonota = 0;
aulas = 0;
faltas = 0;
prova1 = 0;
prova2 = 0;
prova3 = 0;
notatotal = 0;
faltastotal = 0;

while (repeticao < 5)
{
    //ESCRITAS
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("--------------------- APROVADO VER. 1.0 ---------------------");
    Console.WriteLine("-------------------------------------------------------------");

    //FAZENDO AS PERGUNTAS
    Console.WriteLine("\n\nQual o nome do aluno?");
    nome = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Quantas faltas o " + nome + " tem?");
    faltas = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("O " + nome + " fez o trabalho?  S/N");
    trabalho = Console.ReadLine();

    Console.Clear();
    Console.WriteLine("Qual a nota do " + nome + " na 1º prova?");
    prova1 = double.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Qual a nota do " + nome + " na 2º prova?");
    prova2 = double.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Qual a nota do " + nome + " na 3º prova?");
    prova3 = double.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Quantas aulas foi dada no total?");
    aulas = int.Parse(Console.ReadLine());

    //ACERTO
    if (trabalho == "S" || trabalho == "s")
    {
        trabalhonota = 1;
    }

    //CONTAS
    prova1 = (prova1 * 30) / 100;
    prova2 = (prova2 * 25) / 100;
    prova3 = (prova3 * 35) / 100;
    notatotal = prova1 + prova2 + prova3 + trabalhonota;

    faltastotal = (faltas * 100) / aulas;
    faltastotal = 100 - faltastotal;

    //LIMPANDO
    Console.Clear();

    //DANDO A RESPOSTA SE O ALUNO FOI REPROVADO OU APROVADO
    if (faltastotal > 25 && notatotal >= 6)
    {
        Console.WriteLine(nome + " foi APROVADO com: \n" + faltastotal + "% de FALTAS e " + notatotal + " de NOTA.");
    }
    if (faltastotal > 25 && notatotal < 6)
    {
        Console.WriteLine(nome + " foi REPROVADO POR NOTA com: \n" + faltastotal + "% de FALTAS e " + notatotal + " de NOTA.");
    }
    if (faltastotal < 25 && notatotal >= 6)
    {
        Console.WriteLine(nome + " foi REPROVADO POR FALTA com: \n" + faltastotal + "% de FALTAS e " + notatotal + " de NOTA.");
    }
    if (faltastotal < 25 && notatotal < 6)
    {
        Console.WriteLine(nome + " foi REPROVADO POR NOTA EFALTA com: \n" + faltastotal + "% de FALTAS e " + notatotal + " de NOTA.");
    }

    Console.WriteLine("\n\nCLIQUE ENTER PARA CONTINUAR");
    Console.ReadLine();

    //AUMENTANDO A REPETIÇÃO
    repeticao++;
}




