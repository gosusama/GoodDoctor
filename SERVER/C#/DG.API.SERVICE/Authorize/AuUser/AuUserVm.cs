using DG.API.ENTITY.Models.Authorize;
using DG.API.SERVICE.BuildQuery;
using DG.API.SERVICE.BuildQuery.Query.Types;
using DG.API.SERVICE.Helper;
using DG.API.SERVICE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.SERVICE.Authorize.AuUser
{
    public class AuUserVm
    {
        public class Search : IDataSearch
        {
            public string Username { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }

            public string DefaultOrder
            {
                get
                {
                    return ClassHelper.GetPropertyName(() => new SYS_USER().Username);
                }
            }
            public List<IQueryFilter> GetFilters()
            {
                var result = new List<IQueryFilter>();
                var refObj = new SYS_USER();

                if (!string.IsNullOrEmpty(this.Username))
                {
                    result.Add(new QueryFilterLinQ
                    {
                        Property = ClassHelper.GetProperty(() => refObj.Username),
                        Value = this.Username,
                        Method = FilterMethod.Like
                    });
                }
                if (!string.IsNullOrEmpty(this.FullName))
                {
                    result.Add(new QueryFilterLinQ
                    {
                        Property = ClassHelper.GetProperty(() => refObj.FullName),
                        Value = this.FullName,
                        Method = FilterMethod.Like
                    });
                }
                if (!string.IsNullOrEmpty(this.PhoneNumber))
                {
                    result.Add(new QueryFilterLinQ
                    {
                        Property = ClassHelper.GetProperty(() => refObj.PhoneNumber),
                        Value = this.PhoneNumber,
                        Method = FilterMethod.Like
                    });
                }

                return result;
            }

            public List<IQueryFilter> GetQuickFilters()
            {
                return null;
            }

            public void LoadGeneralParam(string summary)
            {
                PhoneNumber = summary;
                Username = summary;
                FullName = summary;
            }
        }
    }
}
