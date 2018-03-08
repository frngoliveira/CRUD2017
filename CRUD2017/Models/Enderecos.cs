using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2017.Models
{
    [Table("TBLEndereco")]
    public class Endereco
    {
        [Key, ForeignKey("Programador")]
        public int cod_prog_id { get; set; }

        [Required(ErrorMessage = "Campo CEP de uso Obrigatório")]
        public string cep { get; set; }

        [Required(ErrorMessage = "Campo Endereço de uso Obrigatório")]
        public string logradouro { get; set; }

        [Required(ErrorMessage = "Campo Número Residêncial de uso Obrigatório")]
        public string nro_residencia { get; set; }

        [Required(ErrorMessage = "Campo Baiiro de uso Obrigatório")]
        public string bairro { get; set; }

        [Required(ErrorMessage = "Campo Cidade de uso Obrigatório")]
        public string cidade { get; set; }

        [Required(ErrorMessage = "Campo Estado de uso Obrigatório")]
        public string estado { get; set; }
        public Programador Programador { get; set; }

    }
}