using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }
        public IList<PromocaoProduto> Promocoes { get; set; }
        public IList<Compra> Compras { get; set; }
        // Install-Package Microsoft.EntityFrameworkCore.Tools -Version 1.1.1
        public override string ToString()
        {
            return $"Produto: {this.Id}, {this.Nome}, {this.Categoria}, {this.PrecoUnitario}, {this.Unidade}";// interpolação de strings que nem no JS
        }
    }
}