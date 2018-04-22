using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double valor;

            
            Conta c = new Conta();

            Console.WriteLine("Bem vindo ao banco Gabriel's");
            Console.WriteLine("Gostaria de fazer um cadatro? Sim - 1 ou Não - 2");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Usuario user = new Usuario();
                    Console.WriteLine("Qual é o seu nome?");
                    user.setNome(Console.ReadLine());
                    Console.WriteLine("Qual a sua idade?");
                    user.setIdade(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Quanto gostaria de depositar inicialmente?");
                    c.setSaldo(double.Parse(Console.ReadLine()));

                    do
                    {
                        Console.WriteLine("-----Gabriel's Bank-----");
                        Console.WriteLine("1 - Depósito");
                        Console.WriteLine("2 - Saque");
                        Console.WriteLine("3 - Verificar saldo");
                        Console.WriteLine("4 - Sobre voce");
                        Console.WriteLine("0 - Sair");
                        Console.WriteLine("O que gostaria de fazer hoje?");
                        op = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (op)
                        {
                            case 1:
                                Console.WriteLine("Quanto deseja depositar?");
                                valor = double.Parse(Console.ReadLine());
                                do
                                {
                                    if (c.getVerificarI() == true)
                                    {
                                        c.deposito(valor);
                                        Console.WriteLine("Valor depositado com sucesso!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {

                                        Console.WriteLine("O valor deve ser maior que 0");
                                        Console.ReadKey();
                                        Console.WriteLine();
                                        Console.WriteLine("Quanto deseja depositar?");
                                        valor = double.Parse(Console.ReadLine());
                                        Console.WriteLine();
                                    }
                                } while (valor == 0);


                                break;
                            case 2:
                                Console.WriteLine("Quanto deseja sacar?");
                                valor = double.Parse(Console.ReadLine());
                                do
                                {
                                    if (c.getVerificarI() == true)
                                    {
                                        c.saque(valor);
                                        Console.WriteLine("Saque feito com sucesso!");
                                        Console.WriteLine();
                                    }
                                    else
                                    {

                                        Console.WriteLine("O valor deve ser maior que 0 e menor que o saldo atual");
                                        Console.ReadKey();
                                        Console.WriteLine();
                                        Console.WriteLine("Quanto deseja sacar?");
                                        valor = double.Parse(Console.ReadLine());
                                        do
                                        {
                                            if (c.getVerificarI() == true)
                                            {
                                                c.saque(valor);
                                                Console.WriteLine("Saque feito com sucesso!");
                                                Console.WriteLine();
                                            }
                                            else
                                            {

                                                Console.WriteLine("O valor deve ser maior que 0 e menor que o saldo atual");
                                                Console.ReadKey();
                                            }
                                        } while (valor != 0);

                                        Console.WriteLine();
                                        
                                    }
                                } while (valor == 0);

                                break;
                            case 3:
                                Console.WriteLine("Seu saldo atual é de:");
                                Console.Write(c.getSaldo());
                                Console.WriteLine();
                                break;
                            case 4:
                                Console.Write("Nome:");
                                Console.WriteLine(user.getNome());
                                Console.Write("Idade:");
                                Console.WriteLine(user.getIdade());
                                Console.Write("Saldo:");
                                Console.WriteLine(c.getSaldo());
                                Console.WriteLine();
                                
                                break;
                            case 0:
                                Console.WriteLine("Obrigado pela preferencia!");
                                Environment.Exit(1);
                                break;
                        }
                        
                    } while (op != 0);

                    break;
                case 2:
                    Console.WriteLine("Até mais!!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            

            
        }
    }
}
