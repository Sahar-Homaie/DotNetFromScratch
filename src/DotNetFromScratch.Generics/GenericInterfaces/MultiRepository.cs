

using DotNetFromScratch.Generics.Models;

namespace DotNetFromScratch.Generics.GenericInterfaces
{
    public class MultiRepository: IRepository<Product, Guid>, IRepository<Customer, int>
    {
        private List<Product> _products = new();
        private List<Customer> _customers = new();
        void IRepository<Product, Guid>.Add(Product prod)
        {
            _products.Add(prod);
        }

        void IRepository<Customer, int>.Add(Customer customer)
        {
            _customers.Add(customer);
        }

        bool IRepository<Product, Guid>.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Customer, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Product? IRepository<Product, Guid>.Find(Guid id)
        {
            throw new NotImplementedException();
        }

        Customer? IRepository<Customer, int>.Find(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository<Product, Guid>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> IRepository<Customer, int>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
