using BusinessObject;

namespace DataAccess;
public class MemberDAO : GenericDAO<MemberObject>
{
    private static MemberDAO instance;
    public static MemberDAO Instance => instance ??= new MemberDAO();

    public Task<MemberObject> FindByEmailAsync(string email) => base.FirstOrDefaultAsync(x => x.Email == email);

}
