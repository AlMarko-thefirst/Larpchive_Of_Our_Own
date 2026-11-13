using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiInterface
{
    public interface IApi
    {
        #region                       =-=-=-=-=-=Get=-=-=-=-=-=
        public Task<TagList> GetAllTags();
        public Task<AgeRatingList> GetAllAgeRating();
        public Task<PrivacyList> GetAllPrivacy();
        public Task<LanguageList> GetAllLanguages();
        public Task<ChapterList> GetAllChapters();
        public Task<CommentList> GetAllComments();
        public Task<UserList> GetAllUsers();
        public Task<WorksList> GetAllWorks();
        public Task<Tags_On_WorksList> GetAllTags_On_Works();
        public Task<AdminList> GetAllAdmin();

        #endregion
        #region                       =-=-=-=-=-=Post=-=-=-=-=-=
        public Task<int> InsertTag(Tags t);
        public Task<int> InsertAgeRating(AgeRating a);
        public Task<int> InsertPrivacy(Privacy p);
        public Task<int> InsertLanguage(Languages l);
        public Task<int> InsertChapter(Chapters c);
        public Task<int> InsertComment(Comments c);
        public Task<int> InsertUser(Users u);
        public Task<int> InsertWork(Works w);
        public Task<int> InsertTags_On_Works(Tags_On_Works t);
        public Task<int> InsertAdmin(Admin a);

        #endregion
        #region                       =-=-=-=-=-=Put=-=-=-=-=-=
        public Task<int> UpdateTag(Tags t);
        public Task<int> UpdateAgeRating(AgeRating a);
        public Task<int> UpdatePrivacy(Privacy p);
        public Task<int> UpdateLanguage(Languages l);
        public Task<int> UpdateChapter(Chapters c);
        public Task<int> UpdateComment(Comments c);
        public Task<int> UpdateUser(Users u);
        public Task<int> UpdateWork(Works w);
        public Task<int> UpdateTags_On_Works(Tags_On_Works t);
        public Task<int> UpdateAdmin(Admin a);
        #endregion
        #region                       =-=-=-=-=-=Delete=-=-=-=-=-=
        public Task<int> DeleteTag(int id);
        public Task<int> DeleteAgeRating(int id);
        public Task<int> DeletePrivacy(int id);
        public Task<int> DeleteLanguage(int id);
        public Task<int> DeleteChapter(int id);
        public Task<int> DeleteComment(int id);
        public Task<int> DeleteUser(int id);
        public Task<int> DeleteWork(int id);
        public Task<int> DeleteTags_On_Works(int id);
        public Task<int> DeleteAdmin(int id);
        #endregion
    }

}
