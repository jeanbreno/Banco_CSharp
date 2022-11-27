using System;
using System.Collections.Generic;
using static Banco.Crud;
using static Banco.Mock;
using static Banco.Arquivo;
using static Banco.Menu;
using static Banco.Util;

namespace Banco {
    public class Program {
        public static void Main(string[] args) {
            int opcao;

            List<Conta> contas = new List<Conta>();

            LerArquivo(contas);
            MockIncluir(contas);

            opcao = MenuPrincipal();

            while ((opcao >= 1) && (opcao <= 5)) { 
                switch (opcao) {
                    case 1: Incluir(contas); break;
                    case 2: Alterar(contas); break;
                    case 3: Excluir(contas); break;
                    case 4: Consultar(contas); break;
                    case 5: EncerrarPrograma();  break;
                }

                opcao = MenuPrincipal();
            }

            //Incluir(contas);
            //Alterar();
            //Excluir();
            //Consultar(contas);

            GravarArquivo(contas);

        }  
    }
}
