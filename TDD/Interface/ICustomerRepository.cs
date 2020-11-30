using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;

namespace TDD.Interface
{
    public interface ICustomerRepository
    {
        Customer Obter();
        List<Customer> Listar();
        Customer Inserir(Customer customer);
    }
}
