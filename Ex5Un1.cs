class Ex5Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 5 - Unidade 1");
        //Declaração de variáveis
        double pi = Math.PI;
        double r,c,a,v;

        //Entrada de dados
        Console.WriteLine("Infome um valor de R=raio de uma efera, vamos calcular comprimento,área e volume");
        r = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        c = (2*pi)*r;
        a = pi*Math.Pow(r,2);
        v = (4.0/3.0)*pi*Math.Pow(r,3);

        //Saída de dados
        Console.WriteLine($"O comprimento da esfera é: {c}. \nA área da esfera é: {a}. \nO volume da esfera é: {v}.");
    }
}