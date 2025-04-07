using System.ComponentModel.DataAnnotations;
namespace Code4F.Components.Data
{
    public class ToDoTask
    {
        [Required(ErrorMessage = "El campo \"Nombre\" no puede quedar vacio.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "El campo \"Descripción\" no puede quedar vacio.")]
        public string? Description { get; set; }
    }
}
