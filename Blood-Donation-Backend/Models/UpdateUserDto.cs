namespace Blood_Donation_Backend.Models
{
    public class UpdateUserDto
    {
        public required string Name { get; set; }

        public required string Mobile { get; set; }

        public string? Email { get; set; }

        public required string BloodGroup { get; set; }

        public required string Address { get; set; }
    }
}
