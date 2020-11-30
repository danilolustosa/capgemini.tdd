using System;
using System.Collections.Generic;
using System.Text;
using TDD.Service;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using TDD.Domain;

namespace TDD.Test.Service
{
    public class CustomerServiceTest
    {
        private CustomerService _service = new CustomerService();


        [Fact]
        public void Obter_Customer_ShouldBe200Ok()
        {
            var resultado = _service.Obter();
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);
        }


        [Fact]
        public void Listar_AllCustomer_ShouldBe200Ok()
        {
            var resultado = _service.Listar();
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);

        }

        [Fact]
        public void Inserir_ShoulBe201Created()
        {
            Customer customer = new Customer();
            customer.Name = "João";

            var resultado = _service.Inserir(customer);
            resultado.StatusCode.Should().Be(StatusCodes.Status201Created);
        }

        [Fact]
        public void Inserir_ErrorEmptyName_ShoulBe400BadRequest()
        {
            Customer customer = new Customer();

            var resultado = _service.Inserir(customer);
            resultado.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public void Inserir_IdReturnsNotZero()
        {
            Customer customer = new Customer();
            customer.Name = "João";

            var resultado = _service.Inserir(customer);
            resultado.Id.Should().NotBe(0);
        }
    }
}
