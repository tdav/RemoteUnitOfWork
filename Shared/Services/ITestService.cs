using System.Collections.Generic;
using MagicOnion;
using MessagePack;
using Shared.Models;

namespace Shared.Services
{
    public interface ITestService : IService<ITestService>
    {
        UnaryResult<List<User>> GetUsersAcyncAsync(int id);
        UnaryResult<List<Company>> GetCompaniesAcyncAsync(int id);

        UnaryResult<Company> CompanyInsertAsync(Company cm);
        UnaryResult<Nil> UserInsert(User user);
        UnaryResult<bool> UserUpdate(User user);


        UnaryResult<byte[]> Test(byte[] data, string model_type);


    }
}
