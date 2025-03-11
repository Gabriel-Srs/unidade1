using System.Net.Mail;

class Ex9Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 9 - Unidade 1");
        //Declaração de dados
        int hr,mn,sg,sgtotal,shr,smn;

        //Entrada de dados
        Console.WriteLine("Infomer as horas deste momento, separadamente hora - minutos - segundos.");
        hr = int.Parse(Console.ReadLine()!);
        mn = int.Parse(Console.ReadLine()!);
        sg = int.Parse(Console.ReadLine()!);

        //Processamento de dados
        shr = hr*3600;
        smn = mn*60;
        sgtotal = shr + smn + sg;

        //Saída de dados
        Console.WriteLine($"já se passaram {sgtotal} segundos do seu dia.");
        
    }
}