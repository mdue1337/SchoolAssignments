using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBookingSystem
{
    internal class Vacation
    {
        public int VacationId { get; set; }
        public string Destination { get; set; }
        public double price { get; set; }
        public int stock { get; set; }

        public Vacation(int vacationId, string destination, double price, int stock)
        {
            VacationId = vacationId;
            Destination = destination;
            this.price = price;
            this.stock = stock;
        }
    }
}
