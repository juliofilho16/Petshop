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
    public partial class Raca
    {
        public Raca()
        {
            Pet = new HashSet<Pet>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("descricao")]
        [StringLength(256)]
        [Unicode(false)]
        public string Descricao { get; set; }

        [JsonIgnore]
        [InverseProperty("IdRacaNavigation")]
        public virtual ICollection<Pet> Pet { get; set; }
    }
}