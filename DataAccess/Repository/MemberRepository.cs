using BusinessObject;

namespace DataAccess.Repository;
public class MemberRepository : IMemberRepository
{
    private static MemberRepository instance;
    public static MemberRepository Instance => instance ??= new MemberRepository();
    public MemberDAO dao { get; set; } = MemberDAO.Instance;

    public Task<MemberObject> GetUser(string email) => dao.GetUser(email);

    Task<MemberObject> IMemberRepository.GetUser(int id) => dao.GetUser(id);
}
