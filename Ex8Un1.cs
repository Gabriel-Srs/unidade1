class Ex8Un1
{
    public static void Executar(){
        Console.WriteLine("Exercício 8 - Unidade 1");
        //Declaração de variáveis 
        int salario, n200, n100, n50, n20, n10, n5, n2, n1, r200, r100, r50, r20, r10, r5, r2;

        //Entrada de dados
        Console.WriteLine("Infome o salário que vamos dizer quantas notas deve ser sacadas.");
        salario = int.Parse(Console.ReadLine()!);

        //Processamento de dados
        n200 = salario / 200;  
        r200 = salario % 200;
        n100 = r200 / 100;
        r100 = r200 % 100;
        n50 = r100 / 50;
        r50 = r100 % 50;
        n20 = r50 / 20;
        r20 = r50 % 20;
        n10 = r20 / 10;
        r10 = r20 % 10;
        n5 = r10 / 5;
        r5 = r10 % 5;
        n2 = r5 / 2;
        r2 = r5 % 2;
        n1 = r2 / 1;



        //Saída de Dados
        Console.WriteLine($"Você precisa sacar essa quantidade de cada nota para pegar seu salário: \nNota 200: {n200} \nNota 100: {n100} \nNota 50: {n50} \nNota 20: {n20} \nNota 10: {n10} \nNota 5: {n5} \nNota 2: {n2} \nNota 1: {n1}");
    }
}