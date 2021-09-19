using System;

namespace questao02
{
    class NumerosInteiros
    {
        public static void ManipularNumerosInteiros() 
        {
            int numero, divisores, contador, qtdPares, qtdImpares, soma, maior, menor;
            int[] numeros = new int[10];

            Console.WriteLine("\nO programa será finalizado quando for digitado 10 números ou qualquer número primo.");
            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            divisores = 0;
            contador = 0;
            qtdPares = 0;
            qtdImpares = 0;
            soma = 0;
            menor = 0;
            maior = 0;
            
            for(int i = 1; i <= numero; i++) {
                if(numero % i == 0) {
                    divisores++;
                }
            }

            while(divisores > 2 && contador < 9) {
                numeros[contador] = numero;
                
                Console.Write("Digite um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());

                divisores = 0;
                for(int i = 1; i <= numero; i++) {
                    if(numero % i == 0) {
                        divisores++;
                    }
                }

                contador++;   
            }

            numeros[contador] = numero;
            
            Console.Write($"\nMatriz dos números digitados: ");
            for(int i = 0; i <= contador; i++) {
                Console.Write($"{numeros[i]} | ");
                soma += numeros[i];

                if(numeros[i] % 2 == 0) {
                    qtdPares++;
                
                } else {
                    qtdImpares++;
                }
            
                menor = numeros[0];
                if (numeros[i] < menor) {
                    menor = numeros[i];
                }
                else if (numeros[i] > maior) {
                    maior = numeros[i];
                }
            }  

            Random random = new Random();
            int[] matrizUni = new int[3];

            Console.Write("\nMatriz aleatória de 3 números entre o menor e maior valor digitado: ");
            for(int i = 0; i < 3; i++) {
                matrizUni[i] = random.Next(menor, maior);
                Console.Write($"{matrizUni[i]} | ");
            }
            
            if(contador >= 2) {
                int[] interseccao = new int[contador + 1];
                int repetidos = 0;
                bool isRepetidos = false;
            
                Console.Write("\nIntersecção das matrizes: ");
                for(int i = 0; i < matrizUni.Length; i++)
                {
                    for(int j = 0; j < numeros.Length; j++)
                    {
                        if(matrizUni[i] == numeros[j])
                        {
                            for(int k = 0; k < repetidos; k++) {
                                if(matrizUni[i] == interseccao[k]) {
                                    isRepetidos = true;
                                }
                            }
                            if(!isRepetidos) {
                                interseccao[repetidos] = matrizUni[i]; 
                                Console.Write($"{interseccao[repetidos]} | ");
                                repetidos++;
                            }
                        }     
                    }     
                }
            }

            Console.Write($"\nQuantidade de números ímpares digitados: {qtdImpares}.");
            Console.Write($"\nQuantidade de números pares digitados: {qtdPares}.");
            Console.WriteLine($"\nSoma dos números digitados: {soma}.");
            Console.WriteLine($"Menor número digitado: {menor}.");
            Console.WriteLine($"Maior número digitado: {maior}.");
        }
    }
}
