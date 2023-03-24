using System;

class Program {
    static void Main(string[] args) {
        int n;

        Console.Write("Digite a quantidade de números a serem lidos: ");
        n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];

        for (int i = 0; i < n; i++) {
            Console.Write("Digite o número {0}: ", i+1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Os números digitados foram:");
        for (int i = 0; i < n; i++) {
            Console.Write("{0} ", numeros[i]);
        }

        int maiorDiferenca = MaiorDiferenca(numeros);
        bool estaOrdenado = EstaOrdenado(numeros);

        Console.WriteLine("\nMaior diferença: {0}", maiorDiferenca);
        Console.WriteLine("Está ordenado: {0}", estaOrdenado);
    }

    static int MaiorDiferenca(int[] vetor) {
        int maior = vetor[0];
        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++) {
            if (vetor[i] > maior) {
                maior = vetor[i];
            }
            else if (vetor[i] < menor) {
                menor = vetor[i];
            }
        }

        return maior - menor;
    }

    static bool EstaOrdenado(int[] vetor) {
        for (int i = 0; i < vetor.Length - 1; i++) {
            if (vetor[i] > vetor[i+1]) {
                return false;
            }
        }

        return true;
    }
}