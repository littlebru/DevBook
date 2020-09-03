using ControleEstoque.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
            // reorna uma lista apartir do dbset
            return dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {

                if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    // adicionando informacoes em memoria
                    dbSet.Add(new Produto(
                        livro.Codigo,
                        livro.Nome,
                        livro.ValorCompra,
                        livro.ValorVenda,
                        livro.Quantidade,
                        livro.DataCadastro,
                        livro.DataModificacao,
                        livro.DataInativacao,
                        livro.Status,
                        livro.Controle
                        ));
                }

                contexto.SaveChanges();
            }
        }

    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public int Quantidade { get; set; }
        public string DataCadastro { get; set; }
        public string DataModificacao { get; set; }
        public string DataInativacao { get; set; }
        public int Status { get; set; }
        public int Controle { get; set; }
    }
}
