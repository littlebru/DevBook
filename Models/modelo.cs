using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ControleEstoque.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Produto : BaseModel
    {
        public Produto()
        {
        }

        public Produto(string codigo, string nome, decimal valorCompra, decimal valorVenda, int quantidade, string dataDeCadastro, string dataDeModificacao, string dataDeInativacao, int status, int controle)
        {
            Codigo = codigo;
            Nome = nome;
            ValorCompra = valorCompra;
            ValorVenda = valorVenda;
            Quantidade = quantidade;
            DataCadastro = dataDeCadastro;
            DataModificacao = dataDeModificacao;
            DataInativacao = dataDeInativacao;
            Status = status;
            Controle = controle;
        }

        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal ValorCompra { get; private set; }
        [Required]
        public decimal ValorVenda { get; private set; }
        [Required]
        public int Quantidade { get; private set; }
        [Required]
        public string DataCadastro { get; private set; }
        [Required]
        public string DataModificacao { get; private set; }
        [Required]
        public string DataInativacao { get; private set; }
        [Required]
        public int Status { get; private set; }
        [Required]
        public int Controle { get; private set; }

    }

    public class Cadastro : BaseModel
    {
        public Cadastro()
        {
        }

        public virtual Pedido Pedido { get; set; }
        [Required]
        public string Nome { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string Telefone { get; set; } = "";
        [Required]
        public string Endereco { get; set; } = "";
        [Required]
        public string Complemento { get; set; } = "";
        [Required]
        public string Bairro { get; set; } = "";
        [Required]
        public string Municipio { get; set; } = "";
        [Required]
        public string UF { get; set; } = "";
        [Required]
        public string CEP { get; set; } = "";
    }

    public class CadastroProduto : BaseModel
    {
        public CadastroProduto()
        {
        }

        [Required]
        public string Nome { get; set; } = "";
        [Required]
        public string Produto { get; set; } = "";
        [Required]
        public string ValorCompra { get; set; } = "";
        [Required]
        public string ValorVenda { get; set; } = "";
        [Required]
        public string Quantidade { get; set; } = "";
    }

    public class ItemPedido : BaseModel
    {   
        [Required]
        public Pedido Pedido { get; private set; }
        [Required]
        public Produto Produto { get; private set; }
        [Required]
        public int Quantidade { get; private set; }
        [Required]
        public decimal PrecoUnitario { get; private set; }

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitario)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }

    public class Pedido : BaseModel
    {
        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        [Required]
        public virtual Cadastro Cadastro { get; private set; }
    }
}


