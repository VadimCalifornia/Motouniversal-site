using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motofix
{
    [System.ComponentModel.DataObject]
    public class CustomersBLL
    {
        private CustomersDAL DAL = new CustomersDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddNewCustomer(string name, string phone)
        {
            DAL.AddNewCustomer(new Customer { 
                ID = DAL.GetLastID() + 1, 
                Name = name, 
                Phone = phone });
        }

        public List<Customer>? GetAllCustomers()
        {
            return DAL.GetAllCustomers();
        }

        public Customer? GetCustomerByID(int customerID)
        {
            return DAL.GetCustomerByID(customerID);
        }

        public List<Customer>? GetCustomersByName(string name)
        {
            return DAL.GetCustomersByName(name);
        }

        public void UpdateCustomerPassport(int customerID, string newPassport)
        {
            DAL.UpdateCustomerPassport(customerID, newPassport);
        }

        public void DeleteCustomerByID(int customerID)
        {
            DAL.DeleteCustomerByID(customerID);
        }
    }
}
