using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AprenderMVC.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public int IdTipo { get; set; }
        [StringLength(14)]
        [Unicode(false)]
        public string CPF { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Tel { get; set; } = null!; 
        [StringLength(50)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [ForeignKey("IdTipo")]
        public Tipo Tipo { get; set; }
        
    }
}
