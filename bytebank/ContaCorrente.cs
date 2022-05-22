using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        //propriedade autoimplementada
        public Cliente Titular{get;set;}
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }
        private int _numero_Agencia;

        public int Numero_Agencia { 
            get
            {
                return _numero_Agencia;
            }
            set
            {
                if(_numero_Agencia <= 0)
                {
                    return;
                }
                else
                {
                    _numero_Agencia = value;
                }
            }
        }

        public string Nome_Agencia { get; set; }
        public double saldo;

       public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            } else if(valor <  0)
            {
                return false;
            } else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            } else if (valor < 0)
            {
                return false;
            } else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo - valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + Titular);
            Console.WriteLine("Conta: " + Conta);
            Console.WriteLine("Número da agência: " + Numero_Agencia);
            Console.WriteLine("Nome da Agência: " + Nome_Agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public double Saldo
        {
            get {
                return saldo;
            }
            set { 
                if(value < 0)
                {
                    Saldo = value;
                }
            }
        }   

        public double GetSaldo()
        {
            return saldo;
        }

        public ContaCorrente(int numero_Agencia, string conta)
        {
            Numero_Agencia = numero_Agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }
    }
}