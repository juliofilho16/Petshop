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
    public partial class Estado
    {
        public Estado()
        {
            Cidade = new HashSet<Cidade>();
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
        [InverseProperty("IdEstadoNavigation")]
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}