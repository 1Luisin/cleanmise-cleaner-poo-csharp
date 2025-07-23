using System;
using System.IO;

public class ExcluirArquivosDiretorio
{
    public static void Excluir()
    {
        string caminhoDiretorio = "C:\\Users\f19033\\AppData\\Local\\Temp"; // Substitua pelo caminho real

        if (Directory.Exists(caminhoDiretorio))
        {
            string[] arquivos = Directory.GetFiles(caminhoDiretorio);

            foreach (string arquivo in arquivos)
            {
                try
                {
                    File.Delete(arquivo);
                    Console.WriteLine($"Arquivo {arquivo} excluído com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao excluir o arquivo {arquivo}: {ex.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine($"O diretório {caminhoDiretorio} não existe.");
        }
    }
}