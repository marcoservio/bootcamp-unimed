using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Curso_MVC.Models
{
public class Categoria
{
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatorio")]
        public string Descricao { get; set; }

        public Categoria()
        {
            Id = 0;
            Descricao = string.Empty;
        }
    }
}
