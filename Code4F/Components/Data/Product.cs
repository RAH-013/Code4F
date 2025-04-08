using System.ComponentModel.DataAnnotations;
namespace Code4F.Components.Data
{
    public class Product
    {
        [Required(ErrorMessage = "El campo \"Inventario\" es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El campo \"Inventario\" debe ser un entero positivo mayor a 0.")]
        public int Inv { get; set; } = 0;
        [Required(ErrorMessage = "El campo \"Nombre\" no puede quedar vacio.")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "El campo \"Departamento\" no puede quedar sin seleccionar.")]
        public string Dep { get; set; } = string.Empty;
    }
}
