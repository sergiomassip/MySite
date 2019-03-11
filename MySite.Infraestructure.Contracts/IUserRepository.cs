using MySite.Domain.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Infraestructure.Contracts
{
    public interface IUserRepository
    {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }
}
