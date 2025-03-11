class Ex1Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 1 - Unidade 1");
        //Declaração das variáveis 
        double nota1,nota2,media;
        int peso1 = 2;
        int peso2 = 3;

        //Entrada de dados
        Console.WriteLine("Vamos calcular a média ponderada das notas do alunos da PUC");
        Console.WriteLine("Me infome a nota da primeira prova.");
        nota1 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Me infome a nota da segunda prova.");
        nota2 = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        media = ((nota1*peso1)+(nota2*peso2))/(peso1+peso2);

        //Saída de dados
        Console.WriteLine($"Sua média é: {media}");

    }
}