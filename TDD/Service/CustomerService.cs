using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;
using TDD.Interface;

namespace TDD.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }


        public Customer Obter()
        {
            return _repository.Obter();
        }

        public CustomerList Listar()
        {
            return new CustomerList() { Lista = _repository.Listar(), StatusCode = StatusCodes.Status200OK };
        }


        public Customer Inserir(Customer customer)
        {
            if (customer.Name == "" || customer.Name == null)
                return new Customer() { StatusCode = StatusCodes.Status400BadRequest };

            var result = _repository.Inserir(customer);
            result.StatusCode = StatusCodes.Status201Created;

            return result;
        }
    }
}
