using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public interface ICadastroProdutoRepository
    {

    }

    public class CadastroProdutoRepository : BaseRepository<Cadastro>, ICadastroProdutoRepository
    {
        public CadastroProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
