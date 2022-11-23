using System;
using System.Collections.Generic;
using System.IO;

namespace Banco {
    public class Arquivo {

        const string ARQ = "contas.txt";
        const string DIR = @"C:\Users\009671631\Desktop\arquivos\";

        public static void LerArquivo (List<Conta> contas) {

            string caminho = Path.Combine(DIR, ARQ);

            if (!File.Exists(caminho)) {
                Console.WriteLine("Erro: arquivo não existe");
                return;
            }

            try {
                string linha;

                using (var arquivo = new StreamReader(caminho)) {
                    while ((linha = arquivo.ReadLine()) != null) {

                        string[] campos = linha.Split(';');

                        Conta conta = new Conta(int.Parse(campos[0]),campos[1], double.Parse(campos[2]));

                        contas.Add(conta);
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }

        public static void GravarArquivo(List<Conta> contas) {

            string caminho = Path.Combine(DIR, ARQ);

            try {
                using (var arquivo = new StreamWriter(caminho)) {
                    foreach (Conta conta in contas) {
                        arquivo.WriteLine(conta.Id + ";" + conta.Nome + ";" + conta.Saldo);
                    }
                }
                Console.WriteLine("Contas gravadas");
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
