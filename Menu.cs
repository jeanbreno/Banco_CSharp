using System;
using static Banco.Util;

namespace Banco {
    public class Menu {

        public static int MenuPrincipal() {
            int opcao;
            bool opcaoOk = false;

            do {
                Console.WriteLine("[1]-Incluir");
                Console.WriteLine("[2]-Alterar");
                Console.WriteLine("[3]-Excluir");
                Console.WriteLine("[4]-Consultar");
                Console.WriteLine("[5]-Sair");
                opcao = EntrarInteiro("Entre com uma opção: ");
                if ((opcao >= 1) && (opcao <= 5)) {
                    opcaoOk = true;
                } else {
                    Console.WriteLine("Erro: opção inválida");
                }
            } while (!opcaoOk);
            return opcao;
        }

        public static int MenuConsultas() {
            int opcao;
            bool opcaoOk = false;

            do {
                Console.WriteLine("[1]-Consultar Todas");
                Console.WriteLine("[2]-Consultar Contas Negativas");
                Console.WriteLine("[3]-Consultar Contas Acima do Valor");
                Console.WriteLine("[4]-Sair");
                opcao = EntrarInteiro("Entre com uma opção: ");
                if ((opcao >= 1) && (opcao <= 4)) {
                    opcaoOk = true;
                } else {
                    Console.WriteLine("Erro: opção inválida");
                }
            } while (!opcaoOk);
            return opcao;
        }
    }
}
