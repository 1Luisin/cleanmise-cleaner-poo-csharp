using System;
using System.IO;
using System.Reflection.Metadata;
class Program
{
    enum ObjetosMenu { Começar = 1, Info = 2, Sair = 3 }

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao menu do CleanMise");
            Console.WriteLine("Digite o NÚMERO do que deseja fazer:");
            Console.WriteLine("1 - Começar");
            Console.WriteLine("2 - Info");
            Console.WriteLine("3 - Sair");

            int userInput;

            bool inputValido = int.TryParse(Console.ReadLine(), out userInput);

            if (!inputValido || !Enum.IsDefined(typeof(ObjetosMenu), userInput))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.ReadKey();
                continue;
            }

            ObjetosMenu escolha = (ObjetosMenu)userInput;

            switch (escolha)
            {
                case ObjetosMenu.Começar:
                    ExcluirArquivosDiretorio ObjetoExcluir = new ExcluirArquivosDiretorio();
                    Console.WriteLine(ObjetoExcluir.Excluir());
                    break;
               
                case ObjetosMenu.Info:
                    InfoMenu mensagem = new InfoMenu();
                        Console.Clear();
                        Console.WriteLine(mensagem.info1);
                        Console.WriteLine(mensagem.info2);
                    break;
               
                case ObjetosMenu.Sair:
                    continuar = false;
                    Console.WriteLine("Pressione mais uma vez para sair. . .");
                    break;
            }

            Console.ReadKey();
        }
    }
}