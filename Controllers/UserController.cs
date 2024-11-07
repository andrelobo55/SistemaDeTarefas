using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Create a HTTP GET resquest for fetch all users in a List
        [HttpGet]
        public ActionResult <List<User>> GetAllUsers() {
            return Ok();
        }
    }
}