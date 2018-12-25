using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emr.Database.Models;

namespace Emr.Database
{
    public class InitializerDb
    {
        private readonly DatabaseContext _context;

        public InitializerDb(DatabaseContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            CreateRoles();
            CreateAdmin();
        }

        public void CreateRoles()
        {
            if (_context.Roles.Any())
                return;
            var role = new Role
            {
                Name = "admin",
                RoleId = (int)RolesEnum.Admin
            };
            _context.Roles.Add(role);
            role = new Role
            {
                Name = "patient",
                RoleId = (int)RolesEnum.Patient
            };
            _context.Roles.Add(role);
            role = new Role
            {
                Name = "medic",
                RoleId = (int)RolesEnum.Medic
            };
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void CreateAdmin()
        {
            if(_context.Admins.Any())
                return;
            var res = new Admin();
            var client = new Client
            {
                Address = "address",
                Age = "age",
                Gender = "gender",
                Mail = "test@mail.ru",
                Name = "adminName",
                Passport = "11223344",
                Dob = DateTime.Now,
                Patronymic = "adminPatron",
                Number = 1,
                Surname = "adminSurName",
                Pob = "pobAdmin",
                RoleId = (int)RolesEnum.Admin,
                Password = "test"
            };
            res.ClientGuid = client.ClientGuid;
            _context.Clients.Add(client);
            _context.Admins.Add(res);
            _context.SaveChanges();
        }
    }
}
