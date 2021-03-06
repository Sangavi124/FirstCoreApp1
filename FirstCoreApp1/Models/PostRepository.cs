using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstCoreApp1.Models;
using FirstCoreApp1.Repository;

namespace FirstCoreApp1.Models
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel> { new PostViewModel()
            {
                postId=101, title="DevOps", description="DevOps Demo", author="john"
            },new PostViewModel()
            {
                postId=102, title="DevOps2", description="DevOps Demo", author="john"
            },
            new PostViewModel()
            {
                postId=103, title="DevOps3", description="DevOps Demo", author="john"
            },
            };
            return posts;
        }


    }
}
