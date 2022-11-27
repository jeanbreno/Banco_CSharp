using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {

    public class Util {

        public static int EntrarInteiro(string msg) {
            int num = 0;
            bool numOk = false;

            do {
                try {
                    Console.Write(msg);
                    num = int.Parse(Console.ReadLine());
                    numOk = true;
                } catch (FormatException) {
                    Console.WriteLine("Erro: número inválido");
                }
            } while (!numOk);
            return num;
        }

        public static int EntrarNumeroConta() {
            int num;
            bool contaOk = false;

            do {
                num = EntrarInteiro("Entre com o número da conta: ");
                if (num > 0) {
                    contaOk = true;
                } else {
                    Console.WriteLine("Erro: número de conta inválido");
                }
            } while (!contaOk);
            return num;
        }

        public static double EntrarReal(string msg) {
            double num = 0;
            bool numOk = false;

            do {
                try {
                    Console.Write(msg);
                    num = double.Parse(Console.ReadLine());
                    numOk = true;
                } catch (FormatException) {
                    Console.WriteLine("Erro: número inválido");
                }
            } while (!numOk);
            return num;
        }

        public static double EntrarSaldo() {
            double saldo;
            bool saldoOk = false;

            do {
                saldo = EntrarReal("Entre com o saldo: ");
                if (saldo >= 0) {
                    saldoOk = true;
                } else {
                    Console.WriteLine("Erro: saldo inválido");
                }
            } while (!saldoOk);
            return saldo;
        }

        public static string EntrarNome() {
            string nome;
            bool nomeOk = false;

            do {
                Console.Write("Entre com o nome: ");
                nome = Console.ReadLine();
                string[] nomes = nome.Split(' ');
                if (nomes.Length >= 2) {
                    nomeOk = true;
                } else {
                    Console.WriteLine("Erro: nome inválido");
                }
            } while (!nomeOk);
            return nome;
        }

        public static int PesquisarConta(List<Conta> contas, int num) {
            int achou = -1;

            for (int i = 0; i < contas.Count; i++) {
                if (contas[i].Id == num) {
                    achou = i;
                    break;
                }
            }
            return achou;
        }

        public static bool ContaVazia(List<Conta> contas) {
            return (contas.Count == 0);
        }

        public static int EntrarOperacao() {
            int oper;
            bool operOk = false;

            do {
                oper = EntrarInteiro("Entre com a operação [1]-Crédito ou [2]-Débito: ");
                if ((oper == 1) || (oper == 2)) {
                    operOk = true;
                } else {
                    Console.WriteLine("Erro: operãção inválida");
                }
            } while (!operOk);
            return oper;
        }

        public static double EntrarValor() {
            double valor;
            bool valorOk = false;

            do {
                valor = EntrarReal("Entre com um valor maior que zero: ");
                if (valor > 0) {
                    valorOk = true;
                } else {
                    Console.WriteLine("Erro: valor inválido");
                }
            } while (!valorOk);
            return valor;
        }
    }
}
