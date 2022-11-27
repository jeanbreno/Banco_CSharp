using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco.Util;
using static Banco.Menu;

namespace Banco {
    public static class Crud {

        public static void Incluir(List<Conta> contas) {
            int num;
            string nome;
            double saldo;

            num = EntrarNumeroConta();
            int pos = PesquisarConta(contas, num);
            if (pos != -1) {
                Console.WriteLine("Erro: conta já existe");
                return;
            }
            nome = EntrarNome();
            saldo = EntrarSaldo();
            Conta conta = new Conta(num, nome, saldo);
            contas.Add(conta);
        }

        public static void Alterar(List<Conta> contas) {
            int num, pos, operacao;
            double valor;

            if (ContaVazia(contas)) {
                Console.WriteLine("Erro: contas vazia");
                return;
            }
            num = EntrarNumeroConta();
            pos = PesquisarConta(contas, num);
            if (pos == -1) {
                Console.WriteLine("Erro: conta não existe");
                return;
            }
            operacao = EntrarOperacao();
            valor = EntrarValor();
            RealizarOperacao(contas[pos], operacao, valor);
        }

        public static void RealizarOperacao(Conta conta, int oper, double valor) {

            switch (oper) {
                case 1: conta.Creditar(valor); break;
                case 2: conta.Debitar(valor); break;
            }
        }

        public static void Excluir(List<Conta> contas) {
            int pos, num;

            if (ContaVazia(contas)) {
                Console.WriteLine("Erro: contas vazia");
                return;
            }
            num = EntrarNumeroConta();
            pos = PesquisarConta(contas, num);
            if (pos == -1) {
                Console.WriteLine("Erro: conta não existe");
                return;
            }
            if (!contas[pos].SaldoZero()) {
                Console.WriteLine("Erro: saldo diferente de zero");
                return;
            }
            contas.RemoveAt(pos);
        }

        public static void Consultar(List<Conta> contas) {
            const int FIM = 4;
            int opcao;

            if (ContaVazia(contas)) {
                Console.WriteLine("Erro: contas vazia");
                return;
            }
            opcao = MenuConsultas();
            while (opcao != FIM) {
                switch (opcao) {
                    case 1: ConsultarTodas(contas); break;
                    case 2: ConsultarContasNegativas(contas); break;
                    case 3: ConsultarContasValor(contas); break;
                }
                opcao = MenuConsultas();
            }
        }

        public static void ConsultarTodas(List<Conta> contas) {

            foreach (Conta conta in contas) {
                Console.WriteLine(conta);
            }
        }
        public static void ConsultarContasNegativas(List<Conta> contas) {

            foreach (Conta conta in contas) {
                if (conta.Saldo < 0) {
                    Console.WriteLine(conta);
                }
            }
        }

        public static void ConsultarContasValor(List<Conta> contas) {
            double valor;

            valor = EntrarReal("Entre com um valor: ");
            foreach (Conta conta in contas) {
                if (conta.Saldo > valor) {
                    Console.WriteLine(conta);
                }
            }
        }
    }
}
