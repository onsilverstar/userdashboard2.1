﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using userdashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace userdashboard.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext _dbContext)
        {
            dbContext = _dbContext;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Login");
        }
        [HttpGet]
        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        [Route("edit{id}")]
        public IActionResult Edit(string id)
        {
            HttpContext.Session.SetObjectAsJson("UserViewed", id);
            User model=dbContext.Users.FirstOrDefault(r=>r.Id==HttpContext.Session.GetObjectFromJson<String>("UserViewed"));
            User newuser=new User {UserName=model.UserName, Description=model.Description, Email=model.Email,EmailConfirmed=model.EmailConfirmed, Password=model.Password, FirstName=model.FirstName, LastName=model.LastName};
            var roles=dbContext.Roles.ToList();
            ViewBag.roles=roles;
            return View("EditUser", model);
        }
        [HttpGet]
        [Route("/delete{id}")]
        [Authorize(Roles="Level3")]
        public IActionResult ProcessDelete(string id)
        {
            var ToDelete=dbContext.Users.FirstOrDefault(v=>v.Id==id);
            dbContext.Users.Remove(ToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("AllUsers");
        }
        
        [HttpPost]
        [Route("/processmessage")]
        public IActionResult ProcessMessage(Post NewPost)
        {
            Message NewMessage=new Message();
            NewMessage.content=NewPost.message.content;
            NewMessage.CreatedAt=DateTime.Now;
            NewMessage.user=dbContext.Users.FirstOrDefault(b=>b.Id==HttpContext.Session.GetObjectFromJson<String>("UserViewed"));
            NewMessage.Author=HttpContext.Session.GetObjectFromJson<String>("Username");
            string CurrentUserId=dbContext.Users.FirstOrDefault(y=>y.UserName==NewMessage.Author).Id;
            dbContext.messages.Add(NewMessage);
            dbContext.SaveChanges();
            return RedirectToAction("ViewUser", CurrentUserId);
        }
         public IActionResult ProcessComment(Post NewPost)
        {
            Comment NewComment=new Comment();
            NewComment.content=NewPost.comment.content;
            Message CurrentMessage=dbContext.messages.FirstOrDefault(l=>l.MessageId==NewPost.MessageId);
            NewComment.user=dbContext.Users.FirstOrDefault(b=>b.Id==HttpContext.Session.GetObjectFromJson<String>("UserViewed"));
            NewComment.message=CurrentMessage;
            NewComment.CreatedAt=DateTime.Now;
            NewComment.Author=HttpContext.Session.GetObjectFromJson<String>("Username");
            string CurrentUserId=dbContext.Users.FirstOrDefault(y=>y.UserName==NewComment.Author).Id;
            dbContext.comments.Add(NewComment);
            dbContext.SaveChanges();
            return RedirectToAction("ViewUser",CurrentUserId);
        }
        [HttpGet]
        [Route("/{id}/ViewUser")]
        [Authorize(Roles="Level1")]
        public IActionResult ViewUser(string id)
        {
            User CurrentUser=dbContext.Users.FirstOrDefault(m=>m.Id==id);
            var messages=dbContext.messages;
            var comments=dbContext.comments;
            var MessagesWithComments=dbContext.messages.Include(t=>t.user).Include(s=>s.comment).Where(q=>q.user.Id==id).OrderByDescending(r=>r.CreatedAt).Take(5).ToList();
            HttpContext.Session.SetObjectAsJson("UserViewed", id);
            ViewBag.Messages=MessagesWithComments;
            User author=dbContext.Users.FirstOrDefault(o=>o.UserName==HttpContext.Session.GetObjectFromJson<String>("Username"));
            User Current=new User();
            foreach(Message message in MessagesWithComments)
            {
                message.duration=(DateTime.Now-message.CreatedAt);
                foreach(var comment in message.comment)
                {
                    comment.duration=(DateTime.Now-comment.CreatedAt);
                }
    
            }
            Current.FirstName=author.FirstName;
            Current.LastName=author.LastName;
            Current.Email=author.Email;
            Current.Description=author.Description;
            Current.UserName=author.UserName;
            ViewBag.Current=Current;
            ViewBag.CurrentUser=CurrentUser;
            return View("Wall");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
