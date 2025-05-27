using OneWealth.Repository.DataModels;

namespace OneWealth.Repository.Interfaces;

public interface IUserRepository : ICoreRepository
{
    public Guid AddUser(User userInfo);
    public void AddUserInformation(UserInformation userInfo);
    public void AddUserFinancialProfile(UserFinancialProfile userFinancialProfile);
}