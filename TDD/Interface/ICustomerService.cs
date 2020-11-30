using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;

namespace TDD.Interface
{
    public interface ICustomerService
    {
        Customer Obter();
        CustomerList Listar();
        Customer Inserir(Customer customer);
    }
}
