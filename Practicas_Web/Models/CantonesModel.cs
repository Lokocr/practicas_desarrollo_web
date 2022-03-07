using Microsoft.EntityFrameworkCore;

namespace Practicas_Web.Models
{
    [Keyless]
    public class CantonesModel
    {
        public int canton { get; set; }
        public string nombre { get; set; }
        public int provincia { get; set; }
    }
}
