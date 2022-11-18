using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petshop.Borders.Dtos.Repositories.Categoria;
using Petshop.Borders.Dtos.Repositories.Produto;

namespace Petshop.Borders.Dtos.Repositories.Produto
{
    public class ReadProdutoDto
    {
        public ReadProdutoDto()
        {
            Categoria = new ReadCategoriaDto();
        }

        [Key]
        public int Id { get; set; }
        public ReadCategoriaDto Categoria { get; set; }
        [Required]
        [StringLength(256)]
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
    public static class ReadProdutoDtoConversions
    {
        public static ReadProdutoDto toReadProdutoDto(this Entities.EntitiesContext.Produto Produto)
        {
            ReadProdutoDto ProdutoDto = new ReadProdutoDto();
            ProdutoDto.Id = Produto.Id;

            ProdutoDto.Id = Produto.Id;
            ProdutoDto.Nome = Produto.Nome;
            ProdutoDto.Preco = Produto.Preco;
            ProdutoDto.Categoria.Id = Produto.IdCategoriaNavigation.Id;
            ProdutoDto.Categoria.Nome = Produto.IdCategoriaNavigation.Nome;

            return ProdutoDto;
        }
    }
}
