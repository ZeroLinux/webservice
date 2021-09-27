using System;
namespace webservice.Models
{
    public class Company
    {
        public string IdType { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string SecondLastName { get; set; }

        public string Email { get; set; }

        public Boolean SmsAval { get; set; }

        public Boolean MailAval { get; set; }

        public Boolean Enabled { get; set; }

    }
}
