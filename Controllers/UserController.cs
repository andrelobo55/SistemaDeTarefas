using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositories.Interfaces;

namespace SistemaDeTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly RepoUserInterface _userRepository;
        public UserController(RepoUserInterface userRepository)
        {
            _userRepository = userRepository;
        }

        // Create a HTTP GET resquest for fetch all users in a List
        [HttpGet]
        public async Task<ActionResult <List<UserModel>>> GetAllUsers() {
            List<UserModel> users = await _userRepository.FetchAllUsers();
            return Ok(users);
        }
    }
}