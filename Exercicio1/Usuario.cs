using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Usuario
    {
        string nome;
        int idade;

        public Usuario()
        {

        }

        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
