using System.ComponentModel.DataAnnotations;
namespace Code4F.Components.Data
{
    public class Song
    {
        [Required(ErrorMessage = "El campo \"Nombre\" no puede quedar vacio.")]
        public string Name { get; set; } = "";

        public bool State { get; set; } = true;
    }
}
