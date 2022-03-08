using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Practicas_Web.Models
{
    public class CuentaModel
    {
        [Key]
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string correo { get; set; }
        public int provincia { get; set; }
        public int canton { get; set; }
        public int postal { get; set; }
    }
}
