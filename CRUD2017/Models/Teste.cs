using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD2017.EF;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2017.Models
{

    [Table("Teste")]
    public class Teste
    {
        [Key]
        public int cod_teste { get; set; }
        public string nome_teste { get; set; }
    }
}