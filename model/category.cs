using System.ComponentModel.DataAnnotations;

namespace simpleapi.model{

    public class Category{
        [Key]
        public int id { get; set; }

        [Required (ErrorMessage="Este campo é obrigatório" )]
        [MaxLength(60,ErrorMessage="Este campo deve conter entre 3 e 60 caracateres")]
        [MinLength(3,ErrorMessage="Este campo deve conter entre 3 e 60 caracteres")]
        public string title { get; set; }
    }
}