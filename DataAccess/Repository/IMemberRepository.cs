using BusinessObject;

namespace DataAccess.Repository;
public interface IMemberRepository
{
    Task<MemberObject> FindByIdAsync(int id);
    Task<MemberObject> FindByIdAsync(string email);
    Task CreateAsync(MemberObject member);
}
