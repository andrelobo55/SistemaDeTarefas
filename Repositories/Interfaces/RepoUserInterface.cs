using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Repositories.Interfaces
{
    public interface RepoUserInterface
    {
        Task <List<UserModel>> FetchAllUsers();
        Task <UserModel> FetchById(int id);
        Task <UserModel> AddUser(UserModel user);
        Task <UserModel> UpdateUser(UserModel user, int id);
        Task <bool> DeleteUser(int id);
    }
}