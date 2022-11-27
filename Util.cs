using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class Util {

        public static double EntrarReal(string msg) {
            double num = 0;
            bool flag = false;

            do {
                try {
                    Console.WriteLine(msg);
                    //num = int.Parse(Console.ReadLine());
                    num = Convert.ToDouble(Console.ReadLine());
                } catch (FormatException) {
                    Console.WriteLine("Erro: Número inválido!");
                }

            } while (!flag);

            return num;
        }

        public static int EntrarInteiro(string msg) {
            int num = 0;
            bool flag = false;

            do {
                try {
                    Console.WriteLine(msg);
                    //num = int.Parse(Console.ReadLine());
                    num = Convert.ToInt32(Console.ReadLine());
                } catch (FormatException) {
                    Console.WriteLine("Erro: Número inválido!");
                }

            } while (flag);

            return num;
        }

        public static int EntrarNumeroConta() {
            int num;
            bool flag = false;

            do {
                num = EntrarInteiro("Número da Conta: ");
                if (num > 0) {
                    flag = true;    
                } else {
                    Console.WriteLine("Erro: Número de conta inválido!");
                }

            } while (!flag);

            return num;
        }

        public static double EntrarSaldo() {
            double saldo;
            bool flag = false;

            do {
                saldo = EntrarReal("Saldo: ");

                if (saldo >= 0) {
                    flag = true;
                } else {
                    Console.WriteLine("Erro: Saldo inválido!");
                }

            } while (!flag);

            return saldo;
        }

        public static string EntrarNome() {
            string nome;
            bool flag = false;

            do {
                Console.WriteLine("Nome completo: ");
                nome = Console.ReadLine();

                string[] nomes = nome.Split(' ');

                if (nomes.Length >= 2) {
                    flag = true;
                } else {
                    Console.WriteLine("Nome inválido!");
                }
            } while (!flag);

            return nome;
        }

        public static int PesquisarConta(List<Conta> contas, int num) {
            int flag = -1;

            for (int i=0; i< contas.Count; i++) {

                if (contas[i].Id == num) {
                    flag = i;
                    break;
                }
            }

            return flag;
        }
    }
}
