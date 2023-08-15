using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBookingSystem
{
    internal class Kunde
    {
        public int KundeId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Vacation> Vacations { get; set; }

        public Kunde(int kundeId, string name, string password, List<Vacation> vacations)
        {
            KundeId = kundeId;
            Password = password;
            Name = name;
            Vacations = vacations;
        }
    }
}
