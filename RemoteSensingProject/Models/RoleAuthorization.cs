using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using RemoteSensingProject.Models.LoginManager;

namespace RemoteSensingProject.Models
{
    public class RoleAuthorization : RoleProvider
    {
        private readonly LoginServices _loginServices = new LoginServices();
       
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }
       
        public override string[] GetRolesForUser(string username)
        {

            List<string> role = new List<string>();
            role = _loginServices.getUserRole(username);
            if (role != null && role.Count > 0)
            {
                return role.ToArray();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}