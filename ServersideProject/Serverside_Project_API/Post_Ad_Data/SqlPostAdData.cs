using Serverside_Project_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Serverside_Project_API.Post_Ad_Data
{
    public class SqlPostAdData : IPostAdData
    {
        private ModelContext _modelContext;
        public SqlPostAdData(ModelContext modelContext)
        {
            _modelContext = modelContext;
        }
        public Post_Ad AddPostAd(Post_Ad postAd)
        {
            _modelContext.Post_Ads.Add(postAd);
            _modelContext.SaveChanges();
            return postAd;
        }

        public void DeletePostAd(Post_Ad postAd)
        {
            _modelContext.Post_Ads.Remove(postAd);
            _modelContext.SaveChanges();
        }

        public Post_Ad EditPostAd(Post_Ad postAd)
        {
            var existingPostAdData = _modelContext.Post_Ads.Find(postAd.Post_Id);
            if (existingPostAdData != null)
            {

                existingPostAdData.Name = postAd.Name;
                existingPostAdData.Email = postAd.Email;
                existingPostAdData.Mobile_No = postAd.Mobile_No;
                existingPostAdData.City = postAd.City;
                existingPostAdData.Property_Type = postAd.Property_Type;
                existingPostAdData.Property_Ad_Type = postAd.Property_Ad_Type;

                _modelContext.Post_Ads.Update(existingPostAdData);
                _modelContext.SaveChanges();
            }
            return postAd;
            //throw new NotImplementedException();
        }

        public Post_Ad GetPostAd(int id)
        {
            var data = _modelContext.Post_Ads.Find(id);
            return data;
        }

        public List<Post_Ad> GetPostAds()
        {
            return _modelContext.Post_Ads.ToList();
        }
    }
}
