using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD2017.EF;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2017.Models
{
    [Table("TBLDadosBanc")]
    public class DBancario
    {
        [Key, ForeignKey("Programador")]
        public int cod_prog_id { get; set; }

        [Required(ErrorMessage = "Campo Número Agencia de uso Obrigatório")]
        public string nro_agencia { get; set; }

        [Required(ErrorMessage = "Campo Número Conta de uso Obrigatório")]
        public string nro_conta { get; set; }

        [Required(ErrorMessage = "Campo Tipo COnta de uso Obrigatório")]
        public string tp_conta { get; set; }

        [Required(ErrorMessage = "Campo Nome Favorecido de uso Obrigatório")]
        public string nome_Favorecido { get; set; }

        [Required(ErrorMessage = "Campo CPF de uso Obrigatório")]
        public string n_cpf { get; set; }
        public Programador Programador { get; set; }
    }
}