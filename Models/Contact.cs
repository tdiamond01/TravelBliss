namespace TravelBliss.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PrimaryEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;
        public int TripCount { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsArchived { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string FullName => $"{FirstName} {LastName}".Trim();
        public string Initials => $"{(FirstName.Length > 0 ? FirstName[0] : "")}{(LastName.Length > 0 ? LastName[0] : "")}".ToUpper();
    }
}
