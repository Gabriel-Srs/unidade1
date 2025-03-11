class Ex2Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 2 - Unidade 1");
        //Declaração da variável 
        double preco,novoPreco;
        double desconto10 = 0.9;

        //Entrada de dados
        Console.WriteLine("Infome o valor do produto.");
        preco = double.Parse(Console.ReadLine()!);

        //Processamento de dados
        novoPreco = preco*desconto10;
        
        //Saída de dados
        Console.WriteLine("Este valor sofreu um desconto de 10%.");
        Console.WriteLine("Seu valor final é: {0:C}",novoPreco);
    }
}