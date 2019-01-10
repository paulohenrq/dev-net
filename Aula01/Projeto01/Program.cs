using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Controles;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {






            ProdutoControle produtoControle new = produtoControle();
            produtoControle.GravarArquivo(produto);

            Console.WriteLine("\nProduto gravado com sucesso!");

            Console.ReadKey();
        }
    }
}
