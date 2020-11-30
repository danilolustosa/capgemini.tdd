using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;

namespace TDD.Service
{
    public class CustomerService
    {
        public Customer Obter()
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "João";
            customer.StatusCode = StatusCodes.Status200OK;

            return customer;
        }

        public CustomerList Listar()
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

            return new CustomerList() { Lista = lista, StatusCode = StatusCodes.Status200OK };
        }


        public Customer Inserir(Customer customer)
        {
            if (customer.Name == "" || customer.Name == null)
                return new Customer() { StatusCode = StatusCodes.Status400BadRequest };


            //chamar a Repository



            return new Customer() { Id = 10,  StatusCode = StatusCodes.Status201Created };
        }
    }
}
