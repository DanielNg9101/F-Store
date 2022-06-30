using BusinessObject;

namespace DataAccess.Repository;
public interface IMemberRepository : IGenericRepository<Member>
{
    Task<Member> FindByEmailAsync(string email);
}
