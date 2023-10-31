using SampleApi.Domain.Entities;

namespace SampleApi.Application.Common.Interfaces.Persistance;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
