﻿using merketoaspnet.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;

namespace merketoaspnet.Helpers.Services;

public class UserAdministratorService
{
    private readonly UserManager<UserEntity> _userManager;

    public UserAdministratorService(UserManager<UserEntity> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
       

        var users = new List<User>();
        foreach (var user in await _userManager.Users.ToListAsync())
        {
            var _user = new User
            {
                Id = user.Id,
                Email = user.Email,

            };

            foreach(var role in await _userManager.GetRolesAsync(user))
            {
                _user.NameOfRoles.Add(role);
            }

            users.Add(_user);
        }
        return users;

    }

    public class User
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public List<string> NameOfRoles { get; set; } = new List<string>();
    }
}
