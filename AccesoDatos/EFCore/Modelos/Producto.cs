using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccesoDatos.EFCore.Modelos
{
    public partial class Producto
    {
        public int Id { get; set; }

        [DisplayName("Nombre del Producto")]
        [Required(ErrorMessage ="El nombre del producto es obligatorio")]
        [StringLength(100)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Debe ser solo letras")]
        //  [Range(0,8)]
        //  [DataType(DataType.Password)]
       // [EmailAddress(ErrorMessage = "El formato del email no es valido")]
        public string? Nombre { get; set; }

        [DisplayName("Tipo del Producto")]
        [Required(ErrorMessage = "El tipo del producto es obligatorio")]
        public string? Tipo { get; set; }

        [DisplayName("El precio")]
        [Required(ErrorMessage = "El precio es obligatorio")]
        public decimal? Precio { get; set; }
    }
}
