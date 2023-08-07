using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ListaDeAlunos
{
    internal class CalcProduto
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public double PrecoAquisicao { get; set; }

        public double Lucro { get; set; }

        public double ValorDeVenda { get; set; }


        public CalcProduto()
        {



        }
        public CalcProduto(string codigo, string descricao, double precoaquisicao, double lucro, double valorDeVenda)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.PrecoAquisicao = precoaquisicao;
            this.Lucro = lucro;
            this.ValorDeVenda = valorDeVenda;
        }
    }
}

