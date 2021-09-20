using streachBackend.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace streachBackend.Web.Serialization
{
    public static class PostMapper
    {
        public static PostModel SerializePostModel(Data.Models.WebPosts posts)
        {
            return new PostModel
            {
                Id = posts.Id,
                CreatedOn = posts.CreatedOn,
                UpdatedOn = posts.UpdatedOn,
                PostBody = posts.PostBody
            };
        }
        public static Data.Models.WebPosts SerializePostModel(PostModel posts)
        {
            return new Data.Models.WebPosts
            {
                Id = posts.Id,
                CreatedOn = posts.CreatedOn,
                UpdatedOn = posts.UpdatedOn,
                PostBody = posts.PostBody
            };
        }


    }
}