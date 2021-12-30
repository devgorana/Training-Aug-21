using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Post_Ad_Data
{
    public interface IPostAdData
    {
        List<Post_Ad> GetPostAds();
        Post_Ad GetPostAd(int id);
        Post_Ad AddPostAd(Post_Ad postAd);
        void DeletePostAd(Post_Ad postAd);
        Post_Ad EditPostAd(Post_Ad postAd);
    }
}
