using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD2017.EF;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2017.Models
{
    [Table("tbl_programadores")]
    public class Programador
    {
        
        [Key]        
        public int cod_prog_id { get; set; }

        [Required(ErrorMessage ="Campo 'Nome' de uso Obrigatório")]
        [Display(Name ="Programador")]
        public string nome_prog { get; set; }

        [Required(ErrorMessage = "Campo 'Skype' de uso Obrigatório")]
        public string skype_prog { get; set; }

        [Required(ErrorMessage = "Campo 'Celular' de uso Obrigatório")]
        public string celular { get; set; }

        [Required(ErrorMessage = "Campo 'Linkedin' de uso Obrigatório")]
        public string linkedin { get; set; }       

        [Required(ErrorMessage = "Campo 'Portifolio' de uso Obrigatório")]
        public string portifolio { get; set; }

        [Required(ErrorMessage = "Campo 'Horas Desiponivel' de uso Obrigatório")]
        public string disp_horas { get; set; }

        [Required(ErrorMessage = "Campo 'Melhor Hora' de uso Obrigatório")]
        public string melhor_hora { get; set; }

        [Required(ErrorMessage = "Campo 'Pretensão' de uso Obrigatório")]
        [RegularExpression(@"^\d+(.\d{1,2})?$")]
        public Decimal pretensao_hora { get; set; }      
                
        public Conhecimento Conhecimento { get; set; }     
        public DBancario DBancario { get; set; }
        public Endereco Endereco { get; set; }
         

    }
}