using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class Mock {
        public static void MockIncluir(List<Conta> contas) {

            contas.Add(new Conta(1, "Joao Paulo", 100));
            contas.Add(new Conta(2, "Demétrio Raposo", 200));
            contas.Add(new Conta(3, "Joarez da Silva", 300));
            contas.Add(new Conta(4, "Tariff Abudad", 400));
        }
    }
}
