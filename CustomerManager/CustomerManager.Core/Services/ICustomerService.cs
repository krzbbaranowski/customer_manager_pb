using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.Core.PO;

namespace CustomerManager.Core.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerListItemPO>> GetCustomersListItems();
    }
}