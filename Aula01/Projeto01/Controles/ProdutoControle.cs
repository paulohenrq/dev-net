using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using System.IO; //input, output

namespace Projeto01.Controles
{
    class ProdutoControle
    {
        public void GravarArquivo(Produto produto)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\produtos.txt", true);
            sw.WriteLine("Código..........:" + produto.Codigo);
            sw.WriteLine("Nome..........:" + produto.Nome);
            sw.WriteLine("Preço..........:" + produto.Preco);
            sw.WriteLine("Quantidade..........:" + produto.Quantidade);
            sw.WriteLine("----------------------");

            //fecha o arquivo
            sw.Close();
        }
    }
}
