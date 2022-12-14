// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Petshop.Entities.EntitiesContext
{
    public partial class Servico
    {
        public Servico()
        {
            Pagamento = new HashSet<Pagamento>();
            ServicoProduto = new HashSet<ServicoProduto>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("idFuncionario")]
        public int IdFuncionario { get; set; }
        [Column("idPet")]
        public int IdPet { get; set; }
        [Column("dataEntrada", TypeName = "datetime")]
        public DateTime DataEntrada { get; set; }
        [Column("dataSaida", TypeName = "datetime")]
        public DateTime? DataSaida { get; set; }
        [Required]
        [Column("descricao")]
        [StringLength(256)]
        [Unicode(false)]
        public string Descricao { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("Servico")]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey("IdFuncionario")]
        [InverseProperty("Servico")]
        public virtual Funcionario IdFuncionarioNavigation { get; set; }
        [ForeignKey("IdPet")]
        [InverseProperty("Servico")]
        public virtual Pet IdPetNavigation { get; set; }
        [InverseProperty("IdServicoNavigation")]
        public virtual ICollection<Pagamento> Pagamento { get; set; }
        [InverseProperty("IdServicoNavigation")]
        public virtual ICollection<ServicoProduto> ServicoProduto { get; set; }
    }
}