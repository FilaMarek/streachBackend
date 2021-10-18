using streachBackend.Data;
using streachBackend.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace streachBackend.Services.WebPost
{
    public class WebpostService : IWebpost
    {

        private readonly StreachDbContext _db;
        public WebpostService(StreachDbContext dbContext)
        {
            _db = dbContext;
        }
        ServiceResponse<Data.Models.WebPosts> IWebpost.CreatePost(Data.Models.WebPosts webPost)
        {

            try
            {
                _db.WebPosts.Add(webPost);
           
                 _db.SaveChanges();
                return new ServiceResponse<Data.Models.WebPosts>
                {
                    Data = webPost,
                    Time = DateTime.UtcNow,
                    Message = "saved new post",
                    IsSuccess = true
                };
            } catch (Exception e)
            {
                return new ServiceResponse<Data.Models.WebPosts>
                {
                    Data = webPost,
                    Time = DateTime.UtcNow,
                    Message = "Error has occurd new post was not saved",
                    IsSuccess = false
                };


            };

        }

        List<Data.Models.WebPosts> IWebpost.GetAllPosts()
        {
            return _db.WebPosts.ToList();
        }

        Data.Models.WebPosts IWebpost.GetWebPostByID(int id)
        {
            return _db.WebPosts.Find(id);
        }
    }
}
