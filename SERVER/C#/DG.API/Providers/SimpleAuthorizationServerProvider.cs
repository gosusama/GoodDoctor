using DG.API.ENTITY.Models.Authorize;
using DG.API.SERVICE.Helper;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace DG.API.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                var user = new SYS_USER();
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBGD"].ConnectionString))
                {
                    await connection.OpenAsync();
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText =
                            "SELECT * FROM SYS_USER WHERE USERNAME='" + context.UserName + "' AND PASSWORD='" + context.Password + "' AND STATUS=1";
                        using (var sqlDataReader = command.ExecuteReaderAsync(CommandBehavior.CloseConnection))
                        {
                            if (!sqlDataReader.Result.HasRows)
                            {
                                user = null;
                            }
                            else
                            {
                                while (sqlDataReader.Result.Read())
                                {
                                    user.Username = sqlDataReader.Result["USERNAME"]?.ToString();
                                    user.FullName = sqlDataReader.Result["FULLNAME"]?.ToString();
                                    user.PhoneNumber = sqlDataReader.Result["PHONENUMBER"]?.ToString();
                                    user.UserId = sqlDataReader.Result["USERID"]?.ToString();
                                    user.Level = int.Parse(sqlDataReader.Result["Level"]?.ToString());
                                }
                            }
                        }
                    }
                }
                if (user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect.");
                    return;
                }
                Action<ClaimsIdentity, string> addClaim = (ClaimsIdentity obj, string username) => { return; };
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                addClaim.Invoke(identity, user.Username);
                identity.AddClaim(new Claim(ClaimTypes.Role, "MEMBER"));
                AuthenticationProperties properties = new AuthenticationProperties(new Dictionary<string, string>
                    {
                    {
                        "userName", string.IsNullOrEmpty(user.Username)?string.Empty:user.Username
                    },
                    {
                        "fullName", string.IsNullOrEmpty(user.FullName)?string.Empty:user.FullName
                    },
                    {
                        "phoneNumber", string.IsNullOrEmpty(user.PhoneNumber)?string.Empty:user.PhoneNumber
                    },
                    {
                        "userId", string.IsNullOrEmpty(user.UserId)?string.Empty:user.UserId
                    },
                    {
                        "level", user.Level.HasValue?user.Level.ToString():string.Empty
                    }
                    });
                AuthenticationTicket ticket = new AuthenticationTicket(identity, properties);
                context.Validated(ticket);
                context.Request.Context.Authentication.SignIn(identity);
            }
            catch (Exception e)
            {
                context.SetError("invalid_grant", e.Message);
                return;
            }
        }
    }
}