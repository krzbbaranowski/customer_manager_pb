using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CustomerManager.Core.DTO;
using CustomerManager.Core.PO;

namespace CustomerManager.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<IEnumerable<CustomerListItemPO>> GetCustomersListItems()
        {
            var customersDTO = GetCustomersMock();
            var customersPO = _mapper.Map<List<CustomerListItemPO>>(customersDTO);
         
            return await Task.FromResult(customersPO);
        }

        private List<CustomerDTO> GetCustomersMock()
        {
            var customers = new List<CustomerDTO>();

            customers.Add(new CustomerDTO()
            {
                Id = "1",
                City = "Poznań",
                FlatNumber = "13",
                Name = "Krzysztof",
                Number = "111111111",
                PostalCode = "50-240",
                StreetName = "ul. Niska 4",
                Surname = "Baranowski"
            });

            customers.Add(new CustomerDTO()
            {
                Id = "2",
                City = "Warszawa",
                FlatNumber = "10",
                Name = "Tomasz",
                Number = "222222",
                PostalCode = "22-151",
                StreetName = "ul. Fiołkowa 34",
                Surname = "Kowalski"
            });

            customers.Add(new CustomerDTO()
            {
                Id = "3",
                City = "Szczecin",
                FlatNumber = "1",
                Name = "Józek",
                Number = "123456789",
                PostalCode = "21-301",
                StreetName = "ul. Kolorowa 50",
                Surname = "Nowakowski"
            });

            for (int i = 0; i < customers.Count; i++)
            {
                customers[i].AvatarUrl = GetRandomAvatarUrl(customers[i].Id);
            }

            return customers;
        }

        private string GetRandomAvatarUrl(string id)
        {
            var random = new Random();

            var idValue = string.IsNullOrEmpty(id) ? 1 : Convert.ToInt32(id);
            var index = random.Next(0, 80) + idValue;

            return $"https://randomuser.me/api/portraits/men/{index}.jpg";
        }
    }
}