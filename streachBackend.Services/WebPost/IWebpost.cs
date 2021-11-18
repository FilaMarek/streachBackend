using streachBackend.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace streachBackend.Services.WebPost
{
   public interface IWebpost
    {
        List<Data.Models.WebPosts> GetAllPosts();
        Data.Models.WebPosts GetWebPostByID(int id);
        ServiceResponse<Data.Models.WebPosts> CreatePost(Data.Models.WebPosts webPost);
        void UpdateKudos(int id);
    }
}
