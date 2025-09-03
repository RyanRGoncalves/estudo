using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Cliente : Pessoa
    {
        protected int codigo;

        public void CadastrarCodigo()
        {
            Console.WriteLine("Coloque o codigo");
            codigo = int.Parse(Console.ReadLine());
        }
        
        public void ExibirCodigo()
        {
            Console.WriteLine("Codigo: " + codigo);
        }
    }
}
