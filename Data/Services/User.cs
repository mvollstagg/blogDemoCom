using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data.Domain;

namespace Data.Services
{
    public class UserServices : Repository<User>
    {
        private Repository<User> _User;

        public Repository<User> User
        {
            get
            {
                if (_User == null)
                {
                    _User = new Repository<User>();
                }
                return _User;
            }
        }
    }
}