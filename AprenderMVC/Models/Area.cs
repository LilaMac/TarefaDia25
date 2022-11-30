using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AprenderMVC.Models
{
    [Table("Area")]
    public class Area
    {

        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Descricao { get; set; } = null!;

    }
}
