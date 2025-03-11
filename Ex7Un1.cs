class Ex7Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 7 - Unidade 1");
        //Declaração de variáveis
        double a, b, c, deltaResposta, x, x1, x2;
        
        //Entrada de dados
        Console.WriteLine("Me dê valores para a, b, c.");
        a = double.Parse(Console.ReadLine()!);
        b = double.Parse(Console.ReadLine()!);
        c = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        deltaResposta = Math.Pow(b,2) - 4 * a * c;
        x = -b + Math.Sqrt(deltaResposta);
        x1 = x / (2 * a);

        x = -b - Math.Sqrt(deltaResposta);
        x2 = x / (2 * a);

        //Saída de dados
        Console.WriteLine($"As raízes são X1:{x1} e X2:{x2}");
    }
}