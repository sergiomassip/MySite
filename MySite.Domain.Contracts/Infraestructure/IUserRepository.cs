using MySite.Domain.Contracts.Models;

namespace MySite.Domain.Infraestructure.Contracts
{
    public interface IUserRepository
    {
        void Add(User newUser);
        User FetchByLoginName(string loginName);
        void SubmitChanges();
    }
}
