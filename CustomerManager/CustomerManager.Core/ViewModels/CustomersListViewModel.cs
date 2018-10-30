using System;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.Core.PO;
using CustomerManager.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace CustomerManager.Core.ViewModels
{
    public class CustomersListViewModel : MvxViewModel
    {
        private readonly ICustomerService _customerService;

        public CustomersListViewModel(ICustomerService customerService)
        {
            _customerService = customerService;
            CustomerItemClickCommand = new MvxAsyncCommand<CustomerListItemPO>(CustomerItemClickAction);
            AddNewCustomerCommand = new MvxAsyncCommand(AddNewCustomerAction);
        }

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            await UpdateCustomersList();
        }

        private MvxObservableCollection<CustomerListItemPO> _customers;

        public MvxObservableCollection<CustomerListItemPO> Customers
        {
            get { return _customers; }
            set { SetProperty(ref _customers, value); }
        }

        public IMvxCommand CustomerItemClickCommand { get; private set; }

        private Task CustomerItemClickAction(CustomerListItemPO customer)
        {
            return Task.CompletedTask;
        }

        public IMvxCommand AddNewCustomerCommand { get; private set; }

        private Task AddNewCustomerAction()
        {
            return Task.CompletedTask;
        }

        private async Task UpdateCustomersList()
        {
            var customers = await _customerService.GetCustomersListItems();
            Customers = new MvxObservableCollection<CustomerListItemPO>(customers);
        }
    }
}