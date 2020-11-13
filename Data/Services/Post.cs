using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data.Domain;

namespace Data.Services
{
    public class PostServices : Repository<Post>
    {
        private Repository<Post> _Post;

        public Repository<Post> Post
        {
            get
            {
                if (_Post == null)
                {
                    _Post = new Repository<Post>();
                }
                return _Post;
            }
        }
    }
}