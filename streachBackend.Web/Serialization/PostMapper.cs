using streachBackend.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// mapping entrance to db and from to frontend


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
                PostBody = posts.PostBody,
                AuthorName = posts.AuthorName,
                Kudos = posts.Kudos,
            };
        }
        public static Data.Models.WebPosts SerializePostModel(PostModel posts)
        {
            return new Data.Models.WebPosts
            {
                Id = posts.Id,
                CreatedOn = posts.CreatedOn,
                UpdatedOn = posts.UpdatedOn,
                PostBody = posts.PostBody,
                AuthorName = posts.AuthorName,
                Kudos = posts.Kudos,
            };
        }


    }
}