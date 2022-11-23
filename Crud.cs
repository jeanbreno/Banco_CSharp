using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco.Util;


namespace Banco {
    public static class Crud {

        public static void Incluir(List<Conta> contas) {

            int num;
            string nome;
            double saldo;

            num = EntrarNumeroConta();

            bool contaExiste = PesquisarConta(contas, num);

            if (contaExiste) {
                Console.WriteLine("ERRO: Conta já existe!");
                return;
            }

            nome = EntrarNome();

            saldo = EntrarSaldo();

            Conta conta = new Conta(num, nome, saldo);
            contas.Add(conta);
        }

        public static void Alterar() {

        }

        public static void Excluir() {

        }

        public static void Consultar(List<Conta> contas) {
            foreach (Conta conta in contas) { 
                Console.WriteLine(conta);
            }

        }

    }
}
