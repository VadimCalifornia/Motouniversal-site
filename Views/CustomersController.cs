using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using records;

namespace motofix
{
    [ApiController]
    [Route("customers")]
    [ApiExplorerSettings(GroupName = "customers")]
    public class CustomersController : ControllerBase
    {

        CustomersBLL BLL = new CustomersBLL();

        [HttpPut]
        [Route("add_new")]
        public void AddCustomer(string name, string phone)
        {
            BLL.AddNewCustomer(name, phone);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Customer>? GetAllCustomers()
        {
            return BLL.GetAllCustomers();
        }

        [HttpGet]
        [Route("get_by_id")]
        public Customer? GetCustomerByID(int customerID)
        {
            return BLL.GetCustomerByID(customerID);
        }

        [HttpGet]
        [Route("get_by_name")]
        public List<Customer>? GetCustomersByName(string name)
        {
            return BLL.GetCustomersByName(name);
        }

        [HttpGet]
        [Route("get_by_phone")]
        public List<Customer>? GetCustomersByPhone(string phone)
        {
            return BLL.GetCustomersByName(phone);
        }

        [HttpPatch]
        [Route("update_passport")]
        public void UpdateCustomerPassport(int customerID, string newPassport)
        {
            BLL.UpdateCustomerPassport(customerID, newPassport);
        }

        [HttpDelete]
        [Route("delete_by_id")]
        public void DeleteCustomerByID(int customerID)
        {
            BLL.DeleteCustomerByID(customerID);
        }

    }
}
