﻿using SampleApi.Application.Common.Interfaces.Persistance;
using SampleApi.Domain.Entities;

namespace SampleApi.Infrastructure.Persistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public void Add(User user)
    {
        _users.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _users.SingleOrDefault(u => u.Email == email);
    }
}
