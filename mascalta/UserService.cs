using mascalta.Core.IService;
using mascalta.Data.Modules;

namespace mascalta
{
    public class UserService : IUserService
    {
        public UserTbl GetUser(int IdUser)
        {
            using (applicationDbContext context = new applicationDbContext())
            {
                UserTbl user = context.UserTbls.Where(x => x.IdUser == IdUser).FirstOrDefault();

                return user;
            }

        }
    }

}