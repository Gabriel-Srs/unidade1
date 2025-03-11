class Ex4Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 4 - Unidade 1");
        //Declaração de Variáveis
        double salarioMinimo,salarioFunc;
        int quantSalario;

        //Entrada de dados
        Console.WriteLine("Informe qual o valor do salário do mínimo atual:");
        salarioMinimo = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Informe qual o valor do salário do funcionário:");
        salarioFunc = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        quantSalario = (int)(salarioFunc / salarioMinimo);

        //Saída de dados
        Console.WriteLine($"A quantidade de salários mínimos que o funcionário ganha é: {quantSalario}.");
    }
}