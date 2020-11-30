using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;
using TDD.Service;

namespace TDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public Customer Get()
        {
            return new CustomerService().Obter();
        }

        [HttpGet("all")]
        public CustomerList GetAll()
        {
            return new CustomerService().Listar();
        }
    }
}
