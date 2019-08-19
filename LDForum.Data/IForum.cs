using LDForum.Data.Models;
using LDForum.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LDForum.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();
        Task Create(Forum forum);
        Task Delepte(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescriptoin(int forumId, string newDescription);
        object GetPostsByForum(int id);
    }
}
