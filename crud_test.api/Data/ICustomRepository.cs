using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_test.api.Models;

namespace crud_test.api.Data
{
    public interface ICustomRepository
    {
        Task<IEnumerable<CustomerViewModel>> GetAllCustomers();
        Task<CustomerViewModel> GetCustomerID(int id);
        Task<bool> PostCustome(CustomerViewModel customer);
        Task<bool> UpdateCustomer(CustomerViewModel customer);
        Task<bool> DeleteCustomer(CustomerViewModel customer);
    }
}
