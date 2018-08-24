using DG.API.ENTITY.Models.Authorize;
using DG.API.SERVICE.Helper;
using DG.API.SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.SERVICE.Authorize.AuUser
{
    public interface IAuUserService : IDataInfoService<SYS_USER>
    {
        SYS_USER FindUser(string username, string password);
    }
    public class AuUserService : DataInfoServiceBase<SYS_USER>, IAuUserService
    {
        public AuUserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public SYS_USER FindUser(string username, string password)
        {
            try
            {
                password = MD5Encrypt.MD5Hash(password);
                return UnitOfWork.Repository<SYS_USER>().DbSet.FirstOrDefault(x =>
                    x.Username.Equals(username) && x.Password.Equals(password));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
