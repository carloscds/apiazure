using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiazure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiazure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Clientes> Get()
        {
            var cli = new List<Clientes>();
            cli.Add(new Clientes() {Id = 1, Nome = "Carlos" });
            cli.Add(new Clientes() {Id = 2, Nome = "Joao" });
            return cli;
        }
    }
}
