using System;
using userdashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
//using System.Data.Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
namespace userdashboard.Models
{
public class MyContext : IdentityDbContext<User>
    {
        public MyContext(DbContextOptions<MyContext> options): base(options)
        {
            
        }
        public Microsoft.EntityFrameworkCore.DbSet<User> customers {get; set;}
        public Microsoft.EntityFrameworkCore.DbSet<Message> messages {get; set;}
        public Microsoft.EntityFrameworkCore.DbSet<Comment> comments {get; set;}       
    }
    
}