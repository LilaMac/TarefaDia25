using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AprenderMVC.Models
{
    [Table("Turma")]
    public partial class Turma
    {
        [Key]
        public int Id { get; set; }
        public int IdCurso { get; set; }
        public int IdPessoa { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }

        [ForeignKey("IdPessoa")]
        public Pessoa Pessoa { get; set; }
        [ForeignKey("IdCurso")]
        public Curso Curso { get; set; }

        
    }
}
