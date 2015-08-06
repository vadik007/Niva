using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using Niva.Model;

namespace Niva.Models
{
    public class Class1
    {
        void test()
        {
            var usersContext = new UsersContext();
            usersContext.UserProfiles.Attach(new UserProfile() {});
        }
    }
    public class MyClass:IDatabaseInitializer<UsersContext>
    {
        public void InitializeDatabase(UsersContext context)
        {
            //context.
        }
    }
}