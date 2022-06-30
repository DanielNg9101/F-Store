using BusinessObject;

namespace DataAccess;
public class MemberDAO : GenericDAO<Member>
{
    private static MemberDAO instance;
    public static MemberDAO Instance => instance ??= new MemberDAO();

    public Task<Member> FindByEmailAsync(string email) => base.FirstOrDefaultAsync(x => x.Email == email);

}
