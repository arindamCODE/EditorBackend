using System;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class UserDetailsService : IUserDetailsService
    {
        private UserDetailsContext _context;
        public UserDetailsService(UserDetailsContext context)
        {
            _context = context;
        }
        public async Task<List<UserDetails>> Get()
        {
            return await _context.UserDetails.ToListAsync();
        }
        public async Task<List<UserDetails>> GetByID(int id)
        {
            UserDetails objectScore = await _context.UserDetails.FirstOrDefaultAsync(pi => pi.UserId == id);

            List<UserDetails> product = new List<UserDetails>();
            try
            {
                product.Add(objectScore);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public async Task Post(UserDetails item)
        {
            try
            {
                _context.UserDetails.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task Update(int id, UserDetails item)
        {
            try
            {
                var result = _context.UserDetails.FirstOrDefault(t => t.UserId == id);
                result.FirstName = item.FirstName;
                result.LastName = item.LastName;
                result.Email = item.Email;
                result.PasswordHash = item.PasswordHash;
                result.PasswordSalt = item.PasswordSalt;
                result.
                result.IsDelete = item.IsDelete;
                _context.QuillTable.Update(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public async Task Delete(int id)
        {
            try
            {
                var result = _context.QuillTable.FirstOrDefault(t => t.ID == id);
                _context.QuillTable.Remove(result);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}