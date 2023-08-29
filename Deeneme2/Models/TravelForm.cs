using System;

namespace Deeneme2.Models
{
    public class TravelForm
    {
        public int Id { get; set; }

        public DateTime TravelStartDate { get; set; }
    public DateTime TravelEndDate { get; set; }

        public string Country { get; set; }
        public string TCIdentityNumber { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Price { get; set; }


    }
}