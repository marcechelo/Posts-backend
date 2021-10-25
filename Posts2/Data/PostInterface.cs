using Posts2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts2.Data
{
    public interface PostInterface
    {
        IEnumerable<Posts> GetPosts();
        Posts GetPosts2ById(int id);
    }
}
