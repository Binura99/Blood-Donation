using DocumentFormat.OpenXml.Office2010.Excel;

namespace Blood_Donation_Backend.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Mobile { get; set; }

        public string? Email { get; set; }

        public required string BloodGroup { get; set; }

        public required string Address { get; set; }


    }
}
