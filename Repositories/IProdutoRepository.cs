using ControleEstoque.Models;
using System.Collections.Generic;

namespace controleEstoque.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);

        IList<Produto> GetProdutos();
    }
}