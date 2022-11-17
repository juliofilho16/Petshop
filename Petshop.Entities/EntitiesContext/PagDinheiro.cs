﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Petshop.Entities.EntitiesContext
{
    public partial class PagDinheiro
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idPagamento")]
        public int IdPagamento { get; set; }
        [Column("dataPagamento", TypeName = "datetime")]
        public DateTime DataPagamento { get; set; }
        [Column("dataVencimento", TypeName = "datetime")]
        public DateTime DataVencimento { get; set; }
        [Column("desconto", TypeName = "decimal(18, 2)")]
        public decimal Desconto { get; set; }
    }
}