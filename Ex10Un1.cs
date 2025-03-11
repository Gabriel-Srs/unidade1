using System.Data.SqlTypes;

class Ex10Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 9 - Unidade 1");
        //Declaração de variáveis
        int spassados,hr,mn,s,rests,restmn;

        //Entrada de dados
        Console.WriteLine("Infome quantos segundos já se passaram do seu dia, e te falo as horas.");
        spassados = int.Parse(Console.ReadLine()!);

        //Processamento de dados
        hr = spassados / 3600;
        rests = spassados % 3600;
        mn = rests / 60;
        restmn = rests % 60;
        s = restmn;

        //Saída de dados
        Console.WriteLine($"Agora é {hr}:{mn}:{s}.");

    }
}