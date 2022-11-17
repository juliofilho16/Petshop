﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Petshop.Entities.EntitiesContext
{
    public partial class ServicoProduto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idServico")]
        public int IdServico { get; set; }
        [Column("idProduto")]
        public int IdProduto { get; set; }

        [ForeignKey("IdProduto")]
        [InverseProperty("ServicoProduto")]
        public virtual Produto IdProdutoNavigation { get; set; }
        [ForeignKey("IdServico")]
        [InverseProperty("ServicoProduto")]
        [JsonIgnore]
        public virtual Servico IdServicoNavigation { get; set; }
    }
}