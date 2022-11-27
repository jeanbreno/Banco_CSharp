using System;
using System.Collections.Generic;
using static Banco.Crud;
using static Banco.Mock;
using static Banco.Arquivo;
using static Banco.Menu;

namespace Banco {
    public class Program {
        public static void Main(string[] args) {
            int opcao, sair;

            List<Conta> contas = new List<Conta>();

            LerArquivo(contas);
            //MockIncluir(contas);

            opcao = Menu();

            while (opcao != sair) {
                switch (opcao) {
                    case 1: Incluir(contas); break;
                    case 2: Alterar(contas); break;
                    case 3: Excluir(contas); break;
                    case 4: Consultar(contas); break;
                }

                opcao = Menu();
            }

            //Incluir(contas);
            //Alterar();
            //Excluir();
            //Consultar(contas);

            GravarArquivo(contas);

        }  
    }
}
