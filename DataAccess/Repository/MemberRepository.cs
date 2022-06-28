using BusinessObject;

namespace DataAccess.Repository;
public class MemberRepository : IMemberRepository
{
    private static MemberRepository instance;
    public static MemberRepository Instance => instance ??= new MemberRepository();
    public MemberDAO dao { get; set; } = MemberDAO.Instance;

    public Task CreateAsync(MemberObject member) => dao.CreateAsync(member);

    public Task<MemberObject> FindByIdAsync(string email) => dao.FindByIdAsync(email);
    public Task<MemberObject> FindByIdAsync(int id) => dao.FindByIdAsync(id);

}
