
namespace Data
{
    public interface IUsuarioService
    {
        Task<bool> VerificarCredenciales(string username, string password);
    }
}
