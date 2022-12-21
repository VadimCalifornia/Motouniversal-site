using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motofix
{
    public class CustomersDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddNewCustomer(Customer customer)
        {
            db.Customers.Add(customer);
        }

        public int GetLastID()
        {
            int? id = db.Customers.Max(s => s.ID);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Customer>? GetAllCustomers()
        {
            List<Customer>? customers = db.Customers.ToList();
            return customers;
        }

        public Customer? GetCustomerByID(int customerID)
        {
            Customer? customer = (from s in db.Customers where s.ID == customerID select s).FirstOrDefault(); 
            return customer; 
        }

        public List<Customer>? GetCustomersByName(string name)
        {
            List<Customer>? customers = (from s in db.Customers where s.Name.Contains(name) select s).ToList();
            return customers;
        }

        public void UpdateCustomerPassport(int customerID, string newPassport)
        {
            Customer? customer = (from s in db.Customers where s.ID == customerID select s).FirstOrDefault();
            if (customer != null)
            {
                customer.Passport = newPassport;
                db.SaveChanges();
            }
        }

        public void DeleteCustomerByID(int customerID)
        {
            Customer? customer = (from s in db.Customers where s.ID == customerID select s).FirstOrDefault();
            if (customer != null)
            {
                db.Customers.Remove(customer);
            }
        }
    }
}
