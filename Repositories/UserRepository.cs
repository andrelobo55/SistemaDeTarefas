using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositories.Interfaces;

namespace SistemaDeTarefas.Repositories
{
    public class UserRepository : RepoUserInterface
    {
        private readonly TaskSystemDbContext _dbContext;
        public UserRepository (TaskSystemDbContext taskSystemDbContext){
            _dbContext = taskSystemDbContext;
        }
        public async Task<UserModel> FetchById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<UserModel>> FetchAllUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<UserModel> AddUser(UserModel user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<UserModel> UpdateUser(UserModel user, int id)
        {
            UserModel userById = await FetchById(id);

            if (userById == null) {
                throw new Exception($"User with {id} not found on database.");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Update(userById);
            await _dbContext.SaveChangesAsync();

            return userById;
        }
        public async Task<bool> DeleteUser(int id)
        {
            UserModel userById = await FetchById(id);
            
            if (userById == null) {
                throw new Exception($"User with {id} not found on database.");
            }

            _dbContext.Remove(userById);
            await _dbContext.SaveChangesAsync();
            
            return true;
        }
    }
}