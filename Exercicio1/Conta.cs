using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Conta
    {
        double saldo;
        bool verificarI;
        
        List<Usuario> cadastro = new List<Usuario>();

        public Conta()
        {

        }

        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public bool getVerificarI()
        {
            return verificarI;
        }

        public void setVerificarI(bool verificarI)
        {
            this.verificarI = verificarI;
        }

        public void verificar(double valor)
        {
            if (valor != 0 || saldo > valor)
            {
                verificarI = true;
            }
            else
            {
                verificarI = false;
            }
        }

        public void cadastrarUser(Usuario u)
        {
            cadastro.Add(u);
        }

        public void deposito(double valor)
        {
            saldo = saldo + valor;
        }

        public void saque(double valor)
        {
            saldo = saldo - valor;
        }

        
    }
}
