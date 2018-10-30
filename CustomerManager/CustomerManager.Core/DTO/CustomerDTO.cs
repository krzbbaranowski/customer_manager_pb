using System;
namespace CustomerManager.Core.DTO
{
    public class CustomerDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Number { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string FlatNumber { get; set; }

        public string AvatarUrl { get; set; }
    }
}
