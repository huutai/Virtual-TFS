using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Repositories;

namespace VirtualTFS.BL
{
    public class UserImpl
    {
        public List<aspnet_Users> GetListUsers()
        {
            List<aspnet_Users> list = new List<aspnet_Users>();
            aspnet_UsersRepository user = new aspnet_UsersRepository();
            list = user.GetAllaspnet_Users().ToList();
            return list;
        }
    }
}
