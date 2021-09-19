using System;

namespace questao02 
{

    class Opcoes 
    {
        public static void OpcoesMenuPrincipal(int opcao) 
        {
            switch (opcao)
            {
                case 1: 
                Menu.MenuStrings();
                break;
                case 2:
                NumerosInteiros.ManipularNumerosInteiros();
                Menu.MenuPrincipal();
                break;
                case 3: 
                Console.WriteLine("Tchau! Até mais.");
                Environment.Exit(0);
                break;
                default:
                Console.WriteLine("Opção incorreta, tente novamente: ");
                Menu.MenuPrincipal();
                break;
            }  
        }

        public static void OpcoesStrings(int opcao) 
        {  
            switch (opcao)
            {
                case 1: 
                CaracteresString.QtdCaracteres(LerString());
                Menu.MenuStrings();
                break;
                case 2: 
                InverterString.TrocarCarateres(LerString());
                Menu.MenuStrings();
                break;
                case 3: 
                PalindromoString.VerificarPalindromo(LerString());
                Menu.MenuStrings();
                break;
                case 4: 
                RepeticaoString.VerificarRepeticaoCaractere(LerString());
                Menu.MenuStrings();
                break;
                case 5:
                Menu.MenuPrincipal();
                break;
                default:
                Console.WriteLine("Opção incorreta, tente novamente: ");
                Menu.MenuStrings();
                break;
            }  
        }

        public static string LerString() {
            Console.Write("\nDigite a palavra: ");
            return Console.ReadLine();
        }
    }
}