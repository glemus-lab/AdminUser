using System.ComponentModel.DataAnnotations;

namespace LoginUsuarioWebApp.Models
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "El username es requerido")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "El password es requerido")]
        public string Password { get; set; } = string.Empty;
    }
}
