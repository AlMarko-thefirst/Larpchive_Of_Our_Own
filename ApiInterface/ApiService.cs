using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Xml.Linq;
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
        public async Task<int> InsertTag(Tags t)
        {
            return (await client.PostAsJsonAsync<Tags>(uri + "api/Select/InsertTag", t)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAgeRating(AgeRating a)
        {
            return (await client.PostAsJsonAsync<AgeRating>(uri + "api/Select/InsertAgeRating", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertPrivacy(Privacy p)
        {
            return (await client.PostAsJsonAsync<Privacy>(uri + "api/Select/InsertPrivacy", p)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertLanguage(Languages l)
        {
            return (await client.PostAsJsonAsync<Languages>(uri + "api/Select/InsertLanguage", l)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertChapter(Chapters c)
        {
            return (await client.PostAsJsonAsync<Chapters>(uri + "api/Select/InsertChapter", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertComment(Comments c)
        {
            return (await client.PostAsJsonAsync<Comments>(uri + "api/Select/InsertComment", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertUser(Users u)
        {
            return (await client.PostAsJsonAsync<Users>(uri + "api/Select/InsertUser", u)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertWork(Works w)
        {
            return (await client.PostAsJsonAsync<Works>(uri + "api/Select/InsertWork", w)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertTags_On_Works(Tags_On_Works tow)
        {
            return (await client.PostAsJsonAsync<Tags_On_Works>(uri + "api/Select/InsertTags_On_Work", tow)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> InsertAdmin(Admin a)
        {
            return (await client.PostAsJsonAsync<Admin>(uri + "api/Select/InsertAdmin", a)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
        #region                       =-=-=-=-=-=Put=-=-=-=-=-=
        public async Task<int> UpdateTag(Tags t)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateTags", t)).IsSuccessStatusCode ? 1 : 0;
        }
        public async Task<int> UpdateAgeRating(AgeRating a)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateAgeRating", a)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdatePrivacy(Privacy p)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdatePrivacy", p)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateLanguage(Languages l)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateLanguage", l)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateChapter(Chapters c)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateChapter", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateComment(Comments c)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateComment", c)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateUser(Users u)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateUser", u)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateWork(Works w)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateWork", w)).IsSuccessStatusCode ? 1 : 0;
        }
       
        public async Task<int> UpdateTags_On_Works(Tags_On_Works tow)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateTags_On_Work", tow)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> UpdateAdmin(Admin a)
        {
            return (await client.PutAsJsonAsync(uri + "api/select/UpdateAdmin", a)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
        #region                       =-=-=-=-=-=Delete=-=-=-=-=-=
        public async Task<int> DeleteTag(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteTag/" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAgeRating(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteAgeRating" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeletePrivacy(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeletePrivacy" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteLanguage(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteLanguages" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteChapter(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteChapter" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteComment(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteComment" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteUser(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteUser" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteWork(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteWorks" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteTags_On_Works(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteTags_On_Works" + id)).IsSuccessStatusCode ? 1 : 0;
        }

        public async Task<int> DeleteAdmin(int id)
        {
            return (await client.DeleteAsync(uri + "api/select/DeleteAdmin" + id)).IsSuccessStatusCode ? 1 : 0;
        }
        #endregion
    }

}
