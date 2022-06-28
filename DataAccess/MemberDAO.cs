using BusinessObject;
using DataAccess.AppConfig;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;
public class MemberDAO
{
    private static MemberDAO instance;
    public static MemberDAO Instance => instance ??= new MemberDAO();

    private readonly ApplicationDbContext _context = ApplicationDbContext.Instance;

    public async Task<MemberObject> FindByIdAsync(int id)
    {
        MemberObject user = await _context.Members.FindAsync(id);
        return user;
    }

    public async Task<MemberObject> FindByIdAsync(string email)
    {
        MemberObject user = null;
        try
        {
            user = await _context.Members.FirstOrDefaultAsync(user => user.Email.Equals(email));
        }
        catch { }
        return user;
    }

    public async Task AddAsync(MemberObject entity)
    {
        try
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw new Exception(ex.Message); }
    }
}
