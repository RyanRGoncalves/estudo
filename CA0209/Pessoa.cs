using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Pessoa
    {
        protected string cpf;
        protected string nome;
        protected string endereco;
        protected string email;

        public void cadastrar()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu Endereço");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            Console.WriteLine("Digite seu cpf");
            cpf = Console.ReadLine();
        }

        Console.WriteLine("teste");
        public void consultar()
        {
            Console.WriteLine("Olá {0}", nome);
            Console.WriteLine("cpf:{0}\n email:{1}\n Endereço:{2}\n", cpf, email, endereco);
        }

    }

}
