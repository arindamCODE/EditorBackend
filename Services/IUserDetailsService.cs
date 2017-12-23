using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public interface IUserDetailsService
    {
        Task<List<UserDetails>> Get();
        Task<List<UserDetails>> GetByID(int id);
        Task Post(UserDetails item);
        Task Update(int id, UserDetails item);
        Task Delete(int id);
    }
}