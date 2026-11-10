using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using Larpchive_Of_Our_Own;
namespace ApiInterface
{
    public class ApiService : IApi
    {
        string uri;
        public HttpClient client;
        public ApiService()
        {
            uri = "http://localhost:5047/";
            client = new HttpClient();
        }
        #region                       =-=-=-=-=-=Get=-=-=-=-=-=
        public async Task<TagList> GetAllTags()
        {
            return await client.GetFromJsonAsync<TagList>(uri + "api/select/SelectAllTags");
        }
        public async Task<AgeRatingList> GetAllAgeRating()
        {
            return await client.GetFromJsonAsync<AgeRatingList>(uri + "api/select/SelectAllAgeRating");
        }
        public async Task<PrivacyList> GetAllPrivacy()
        {
            return await client.GetFromJsonAsync<PrivacyList>(uri + "api/select/SelectAllPrivacy");
        }
        public async Task<LanguageList> GetAllLanguages()
        {
            return await client.GetFromJsonAsync<LanguageList>(uri + "api/select/SelectAllLanguages");
        }
        public async Task<ChapterList> GetAllChapters()
        {
            return await client.GetFromJsonAsync<ChapterList>(uri + "api/select/SelectAllChapters");
        }
        public async Task<CommentList> GetAllComments()
        {
            return await client.GetFromJsonAsync<CommentList>(uri + "api/select/SelectAllComments");
        }
        public async Task<UserList> GetAllUsers()
        {
            return await client.GetFromJsonAsync<UserList>(uri + "api/select/SelectAllTags");
        }
        public async Task<WorksList> GetAllWorks()
        {
            return await client.GetFromJsonAsync<WorksList>(uri + "api/select/SelectAllWorks");
        }
        public async Task<Tags_On_WorksList> GetAllTags_On_Works()
        {
            return await client.GetFromJsonAsync<Tags_On_WorksList>(uri + "api/select/SelectAllTags_On_Works");
        }
        public async Task<AdminList> GetAllAdmin()
        {
            return await client.GetFromJsonAsync<AdminList>(uri + "api/select/SelectAllAdmin");
        }
        #endregion
        #region                      =-=-=-=-=-=Post=-=-=-=-=-=
        public async Task<int> InsertATag(Tags t)
        {
            return (await client.PostAsJsonAsync<Tags>(uri + "api/Select/InsertATag", t)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
        #region                       =-=-=-=-=-=Put=-=-=-=-=-=
        public async Task<int> UpdateATag(Tags t)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateTags_On_Works", t)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
        #region                       =-=-=-=-=-=Delete=-=-=-=-=-=
        public async Task<int> DeleteATag(int id)
        {
            return (await client.DeleteAsync(uri + "api/Select/InsertATag" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
    }

}
