class Ex3Un1
{
    public static void Executar()
    {
        Console.WriteLine("Exercício 3 - Unidade 1");
        //Declaração de variáveis
        double bMaior, bMenor, al, area;

        //Entrada de dados
        Console.WriteLine("Vamosa calcular a área de um trapézio. \nInfome a base maior:");
        bMaior = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Agora me infome a base menor:");
        bMenor = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Agora me infome a Altura:");
        al = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        area = ((bMaior + bMenor) * al) / 2;

        //Saída de dados
        Console.WriteLine($"A área do trapézio é {area}cm².");

    }
}