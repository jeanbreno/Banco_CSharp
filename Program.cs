using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banco.Crud;
using static Banco.Mock;

namespace Banco {
    public class Program {
        public static void Main(string[] args) {
            List<Conta> contas = new List<Conta>();

            MockIncluir(contas);
            Incluir(contas);
            //Alterar();
            //Excluir();
            Consultar(contas);

        }

        
    }
}
