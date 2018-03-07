using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD2017.EF;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2017.Models
{
    [Table("tbl_Conhecimento")]
    public class Conhecimento
    {

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Ionic { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Android { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string IOS { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string HTML { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string CSS { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Bootstrap { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Jquery { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string AngularJs { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Java { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string AspNetMVC { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string C_mais_mais { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Cake { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Django { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Majento { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string PHP { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Wordpress { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Phyton { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Ruby { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string MySQLServer { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string MySQL { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Salesforce { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Photoshop { get; set; }

        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string Illustrator { get; set; }
        
        [Required(ErrorMessage = "Campo de uso Obrigatório")]
        public string SEO { get; set; }
        

        [Key, ForeignKey("Programador")]
        public int cod_prog_id { get; set; }        
        public Programador Programador { get; set; }
    }
}