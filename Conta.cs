namespace Banco {
    public class Conta {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(int id, string nome, double saldo) { 
            Id = id;
            Nome = nome;  
            Saldo = saldo;
        }

        public bool SaldoZero() {
            return (Saldo == 0);
        }

        public void Creditar(double valor) {
            Saldo += valor;
        }

        public void Debitar(double valor) {
            Saldo -= valor;
        }

        public override string ToString() {
            return Id + " " + Nome + " " + Saldo;
        }
    }
}
