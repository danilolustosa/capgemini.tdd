using System;
using System.Collections.Generic;
using System.Text;
using TDD.Service;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using TDD.Domain;
using AutoFixture;
using TDD.Interface;
using NSubstitute;

namespace TDD.Test.Service
{
    public class CustomerServiceTest
    {
        private CustomerService _service;
        private Customer _customer;
        private Fixture _fixture = new Fixture();
        private ICustomerRepository _repository;
        private List<Customer> _lista;


        public CustomerServiceTest()
        {
            _customer = _fixture.Create<Customer>();
            _lista = _fixture.Create<List<Customer>>();
            _repository = Substitute.For<ICustomerRepository>();
            _service = new CustomerService(_repository);
        }


        [Fact]
        public void Obter_Customer_ShouldBe200Ok()
        {
            _repository.Obter().Returns(_customer);
            _customer.StatusCode = StatusCodes.Status200OK;

            var resultado = _service.Obter();
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);
        }


        [Fact]
        public void Listar_AllCustomer_ShouldBe200Ok()
        {
            _repository.Listar().Returns(_lista);

            var resultado = _service.Listar();
            resultado.StatusCode.Should().Be(StatusCodes.Status200OK);
        }

        [Fact]
        public void Inserir_ShoulBe201Created()
        {
            _repository.Inserir(_customer).Returns(_customer);

            var resultado = _service.Inserir(_customer);
            resultado.StatusCode.Should().Be(StatusCodes.Status201Created);
        }

        [Fact]
        public void Inserir_ErrorEmptyName_ShoulBe400BadRequest()
        {
            _repository.Inserir(_customer).Returns(_customer);
            _customer.Name = "";

            var resultado = _service.Inserir(_customer);
            resultado.StatusCode.Should().Be(StatusCodes.Status400BadRequest);
        }

        [Fact]
        public void Inserir_IdReturnsNotZero()
        {
            _repository.Inserir(_customer).Returns(_customer);

            var resultado = _service.Inserir(_customer);
            resultado.Id.Should().NotBe(0);
        }
    }
}
