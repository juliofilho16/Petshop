// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Petshop.Entities.EntitiesContext
{
    public partial class Categoria
    {
        public Categoria()
        {
            Produto = new HashSet<Produto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(256)]
        [Unicode(false)]
        public string Nome { get; set; }
        
        [JsonIgnore]
        [InverseProperty("IdCategoriaNavigation")]
        public virtual ICollection<Produto> Produto { get; set; }
    }
}