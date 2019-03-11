using System.ComponentModel.DataAnnotations;


namespace MySite.Domain.Contracts.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int Phone { get; set; }
        public string EmailSubject { get; set; }
        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }

    }
}
