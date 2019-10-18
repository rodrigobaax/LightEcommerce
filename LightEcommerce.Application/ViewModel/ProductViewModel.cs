using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LightEcommerce.Application.ViewModel
{
    public class ProductViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Price is Required")]       
        public int Price { get; set; }

        [Required(ErrorMessage = "The Value is Required")]
        public int Value { get; set; }
    }
}
