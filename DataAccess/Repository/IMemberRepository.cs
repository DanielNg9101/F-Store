using BusinessObject;

namespace DataAccess.Repository;
public interface IMemberRepository
{
    Task<MemberObject> GetUser(int id);
    Task<MemberObject> GetUser(string email);
}
