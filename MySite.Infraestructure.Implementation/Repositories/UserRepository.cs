using System;
using MySite.Domain.Contracts.Models;
using MySite.Domain.Infraestructure.Contracts;

namespace MySite.Infraestructure.Implementation.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Add(User newUser)
        {
            throw new NotImplementedException();
        }

        public User FetchByLoginName(string loginName)
        {
            return new User() { LoginName = loginName };
            //throw new NotImplementedException();
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }
}
