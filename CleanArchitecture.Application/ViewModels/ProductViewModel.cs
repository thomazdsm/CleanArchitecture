using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório!")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("Nome do Produto")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatória!")]
        [MinLength(10)]
        [MaxLength(200)]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório!")]
        [Range(1,99999.99)]
        [DisplayName("Preço")]
        public decimal Price { get; set; }
    }
}
