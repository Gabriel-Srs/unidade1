class Ex6Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 6 - Unidade 1");
        //Declaração de variáveis
        int angulo1,angulo2,angulo3;

        //Entrada de dados
        Console.WriteLine("Informe a medida de um ângulo do triângulo.");
        angulo1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe outra medida de um ângulo do triângulo.");
        angulo2 = int.Parse(Console.ReadLine()!);

        //Processamento de dados
        angulo3 = 180 - (angulo1 + angulo2);

        //Saída de dados
        Console.WriteLine($"O terceiro ângulo mede: {angulo3}.");

    }
}