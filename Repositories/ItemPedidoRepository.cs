using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public interface IItemPedidoRepository
    {
        void Add(ItemPedido itemPedido);
    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
         public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void Add(ItemPedido itemPedido)
        {
           contexto.Set<ItemPedido>()
                    .Add(itemPedido);


                contexto.SaveChanges();
           
        }
    }
}
