﻿using Traveller.Domain.Models;

namespace Traveller.Domain.Interfaces.Repositories;

public interface IUserRepository : IRepository<User, int>
{
    ValueTask<User?> FindByEmail(string email);
    public IQueryable<AgencyUser> FindAgencyUsers();
    public IEnumerable<Tourist> FindTourists();
}