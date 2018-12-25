﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emr.Database;
using Emr.Database.Models;
using Emr.Domain.Accounts;
using Emr.Domain.Accounts.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserLoginInfo = Emr.Domain.Accounts.Models.UserLoginInfo;

namespace Emr.Web.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly DatabaseContext _context;
        private readonly SignInManager<Client> _signInManager;

        public AccountController(IAccountService accountService, SignInManager<Client> signInManager, DatabaseContext context)
        {
            _accountService = accountService;
            _signInManager = signInManager;
            _context = context;
        }

        [HttpPost("Reg")]
        public async Task<Guid> Registration(UserRegInfo regInfo)
        {
            return await _accountService.RegistrateUser(regInfo);
        }

        [HttpPost("Login")]
        public async Task Login(UserLoginInfo loginInfo)
        {
            var result = _accountService.Login(loginInfo);
            if (result != null)
            {
                await _signInManager.SignInAsync(result, true);
            }
            else
            throw new Exception("Вы ввели неправильный логин/пароль.");
        }

        [HttpPost("LogOut")]
        [Authorize]
        public async Task Login()
        {
            await _signInManager.SignOutAsync();
        }

        /// <summary>
        /// Временно
        /// </summary>
        /// <returns></returns>
        [HttpGet("admins")]
        public async Task<List<Admin>> GetAdmins()
        {
            return await _context.Admins
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
