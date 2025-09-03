using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Funcionario : Pessoa
    {
        protected int codigo;
        protected double salario;
        protected double vale_transporte;
        protected double vale_alimentacao;
        protected double vale_refeicao;

        public void CadastrarCodigo()
        {
            Console.WriteLine("Coloque o codigo do funcionario");
            codigo = int.Parse(Console.ReadLine());
        }
        public void CadastrarSalario()
        {
            Console.WriteLine("Coloque o salario do funcionario");
            salario = double.Parse(Console.ReadLine());
        }
        public void CadastrarVTransporte()
        {
            Console.WriteLine("Coloque o vale transporte do funcionario");
            vale_transporte = double.Parse(Console.ReadLine());
        }
        public void CadastrarVAlimentacao()
        {
            Console.WriteLine("Coloque o vale alimentação do funcionario");
            vale_alimentacao = double.Parse(Console.ReadLine());
        }
        public void CadastrarVRefeicao()
        {
            Console.WriteLine("Coloque o vale refeição do funcionario");
            vale_refeicao = double.Parse(Console.ReadLine());
        }
        public void ExibirCodigo()
        {
            Console.WriteLine("Codigo: " + codigo);
        }
        public void ExibirSalario()
        {
            Console.WriteLine("Salario: " + salario);
        }
        public void ExibirVTransporte()
        {
            Console.WriteLine("VT: " + vale_transporte);
        }
        public void ExibirVAlimentacao()
        {
            Console.WriteLine("VA: " + vale_alimentacao);
        }
        public void ExibirVRefeicao()
        {
            Console.WriteLine("VR: " + vale_refeicao);
        }
    }
}
