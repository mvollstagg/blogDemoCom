using System;
using System.Collections.Generic;
using System.Text;
using Data.Base;
namespace Data.Domain
{
    public class Post : IBaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Status { get; set; }
        public int AuthorId { get; set; }        
        public virtual User User { get; set; }
    }
}