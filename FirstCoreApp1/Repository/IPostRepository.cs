using FirstCoreApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp1.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
