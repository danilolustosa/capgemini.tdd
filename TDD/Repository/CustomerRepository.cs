using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;
using TDD.Interface;

namespace TDD.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Obter()
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "João";
            customer.StatusCode = StatusCodes.Status200OK;

            return customer;
        }

        public List<Customer> Listar()
        {
            List<Customer> lista = new List<Customer>();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "João";
            lista.Add(customer);

            customer = new Customer();
            customer.Id = 2;
            customer.Name = "Maria";
            lista.Add(customer);

            return lista;
        }


        public Customer Inserir(Customer customer)
        {
            return new Customer() { Id = 10 };
        }
    }
}
