using System;

namespace questao02
{
    class Menu
    {
        public static void MenuPrincipal() {
            Console.WriteLine("\n1 - Manipular Strings.");
            Console.WriteLine("2 - Manipular Números");
            Console.WriteLine("3 - Sair do programa");
            Console.Write("Escolha uma opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            Opcoes.OpcoesMenuPrincipal(opcao);
        }   

        public static void MenuStrings() {
            Console.WriteLine("\n1 - Verificar quantidade de caracteres.");
            Console.WriteLine("2 - Inverter String.");
            Console.WriteLine("3 - Verificar se é um palíndromo.");
            Console.WriteLine("4 - Retirar caracteres repetidos.");
            Console.WriteLine("5 - Voltar ao Menu Principal.");
            Console.Write("Escolha uma opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            Opcoes.OpcoesStrings(opcao);
        } 
    }
}
