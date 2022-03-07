using Microsoft.EntityFrameworkCore;

namespace Practicas_Web.Models
{
    [Keyless]
    public class CuentaModel
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int provincia { get; set; }
        public int canton { get; set; }
        public int postal { get; set; }
    }
}
