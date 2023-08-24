using mascalta.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mascalta.Core.IService
{
    public interface IUserService
    {
        public UserTbl GetUser(int IdUser);
    }
}
