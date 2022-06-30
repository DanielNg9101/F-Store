using BusinessObject;

namespace DataAccess.Repository;
public class MemberRepository : GenericRepository<Member>, IMemberRepository
{
    // implement singleton
    private static MemberRepository instance;
    public static MemberRepository Instance => instance ??= new MemberRepository();

    public MemberDAO MemberDAO { get; set; } = MemberDAO.Instance;
    public Task<Member> FindByEmailAsync(string email) => MemberDAO.FindByEmailAsync(email);
}
