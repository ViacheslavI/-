using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LDForum.Models.Forum
{
    public class ForumIndexModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
