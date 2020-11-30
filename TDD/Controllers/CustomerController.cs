using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDD.Domain;
using TDD.Interface;
using TDD.Service;

namespace TDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }


        [HttpGet]
        public Customer Get()
        {
            return _service.Obter();
        }

        [HttpGet("all")]
        public CustomerList GetAll()
        {
            return _service.Listar();
        }
    }
}
