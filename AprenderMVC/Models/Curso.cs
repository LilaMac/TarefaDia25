using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AprenderMVC.Models
{
    [Table("Curso")]
    public class Curso
    {

        [Key]
        public int Id { get; set; }
        public int IdArea { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;
        public int Cargahoraria { get; set; }
        public float Valor { get; set; }

        [ForeignKey("IdArea")]
        public Area Area { get; set; }

    }
}
