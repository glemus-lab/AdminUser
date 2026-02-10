using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbDataContext _context;
        private IConfiguration _config;

        public UsuarioService(DbDataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<bool> VerificarCredenciales(string username, string password)
        {
            var nombreSp = _config["ProcedimientosAlmacenados:SP_ValidarUsuario"];
            var esValidoParam = new SqlParameter("@pEsValido", SqlDbType.Bit)
            {
                Direction = ParameterDirection.Output
            };

            var userParam = new SqlParameter("@pUserName", username);
            var passwordParam = new SqlParameter("@pPassword", password);

            _ = await _context.Database.ExecuteSqlInterpolatedAsync($"EXEC {nombreSp} {userParam}, {passwordParam}, {esValidoParam} OUTPUT");

            return (bool)esValidoParam.Value;
        }
    }
}
