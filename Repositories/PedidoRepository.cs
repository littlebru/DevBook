using ControleEstoque.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleEstoque.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAcessor;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public PedidoRepository(ApplicationContext contexto,
            IHttpContextAccessor contextAcessor, IItemPedidoRepository itemPedidoRepository) : base(contexto)
        {
            this.contextAcessor = contextAcessor;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public void AddItem(string codigo)
        {
            var produto = contexto.Set<Produto>()
                .Where(p => p.Codigo == codigo)
                .SingleOrDefault();

            if(produto == null)
            {
                throw new ArgumentException("Produto não encontrado");
            }

            var pedido = GetPedido();

            var itemPedido = contexto.Set<ItemPedido>()
                .Where(i => i.Produto.Codigo == codigo
                        && i.Pedido.Id == pedido.Id)
                .SingleOrDefault();

            // se o produto não foi encontrado é adicionado ao carrinho
            if(itemPedido == null)
            {
                itemPedido = new ItemPedido(pedido, produto, 1, produto.ValorVenda);
                itemPedidoRepository.Add(itemPedido);
            }
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();   // pedido da Sessão
            var pedido = dbSet
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .Where(p => p.Id == pedidoId)
                .SingleOrDefault();

            if (pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);

                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }

            return pedido;
        }

        // Lendo e gravando o pedido na sessão
        private int? GetPedidoId()
        {
            return contextAcessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAcessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }
    }
}
