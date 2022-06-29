using BusinessObject;

namespace DataAccess.Repository;
public interface IMemberRepository : IGenericRepository<MemberObject>
{
    Task<MemberObject> FindByEmailAsync(string email);
}
