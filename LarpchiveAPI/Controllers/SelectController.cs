using Larpchive_Of_Our_Own;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using ViewModel;
namespace LarpchiveAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SelectController : Controller
    {
        #region                       =-=-=-=-=-=Get=-=-=-=-=-=
        [HttpGet]
        public TagList SelectAllTags()
        {
            TagsDB db = new TagsDB();
            TagList Tags = db.SelectAll();
            return Tags;
        }
        [HttpGet]
        public AgeRatingList SelectAllAgeRatings()
        {
            AgeRatingDB db = new AgeRatingDB();
            AgeRatingList AgeRating = db.SelectAll();
            return AgeRating;
        }
        [HttpGet]
        public PrivacyList SelectAllPrivacy()
        {
            PrivacyDB db = new PrivacyDB();
            PrivacyList Privacy = db.SelectAll();
            return Privacy;
        }
        [HttpGet]
        public LanguageList SelectAllLanguages()
        {
            LanguagesDB db = new LanguagesDB();
            LanguageList Languages = db.SelectAll();
            return Languages;
        }
        [HttpGet]
        public ChapterList SelectAllChapters()
        {
            ChaptersDB db = new ChaptersDB();
            ChapterList Chapters = db.SelectAll();
            return Chapters;
        }
        [HttpGet]
        public CommentList SelectAllComments()
        {
            CommentsDB db = new CommentsDB();
            CommentList Comments = db.SelectAll();
            return Comments;
        }
        [HttpGet]
        public UserList SelectAllUsers()
        {
            UsersDB db = new UsersDB();
            UserList Users = db.SelectAll();
            return Users;
        }
        [HttpGet]
        public WorksList SelectAllWorks()
        {
            WorksDB db = new WorksDB();
            WorksList Works = db.SelectAll();
            return Works;
        }
        [HttpGet]
        public Tags_On_WorksList SelectAllTags_On_Works()
        {
            Tags_On_WorksDB db = new Tags_On_WorksDB();
            Tags_On_WorksList Tags_On_Works = db.SelectAll();
            return Tags_On_Works;
        }
        [HttpGet]
        public AdminList SelectAllAdmin()
        {
            AdminDB db = new AdminDB();
            AdminList Admin = db.SelectAll();
            return Admin;
        }
        #endregion
        #region                      =-=-=-=-=-=Post=-=-=-=-=-=
        [HttpPost]
        public int InsertATag([FromBody] Tags tags)
        {
            TagsDB db = new TagsDB();
            db.Insert(tags);
            int x = db.SaveChanges();
            return x;
        }
        [HttpPost]
        public int InsertAnAgeRating([FromBody] AgeRating ageRating)
        {
            AgeRatingDB db = new AgeRatingDB();
            db.Insert(ageRating);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAPrivacy([FromBody] Privacy privacy)
        {
            PrivacyDB db = new PrivacyDB();
            db.Insert(privacy);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertALanguage([FromBody] Languages language)
        {
            LanguagesDB db = new LanguagesDB();
            db.Insert(language);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAChapter([FromBody] Chapters chapter)
        {
            ChaptersDB db = new ChaptersDB();
            db.Insert(chapter);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAComment([FromBody] Comments comment)
        {
            CommentsDB db = new CommentsDB();
            db.Insert(comment);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAUser([FromBody] Users user)
        {
            UsersDB db = new UsersDB();
            db.Insert(user);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAWork([FromBody] Works work)
        {
            WorksDB db = new WorksDB();
            db.Insert(work);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertATag_On_Work([FromBody] Tags_On_Works tagOnWork)
        {
            Tags_On_WorksDB db = new Tags_On_WorksDB();
            db.Insert(tagOnWork);
            int x = db.SaveChanges();
            return x;
        }

        [HttpPost]
        public int InsertAnAdmin([FromBody] Admin admin)
        {
            AdminDB db = new AdminDB();
            db.Insert(admin);
            int x = db.SaveChanges();
            return x;
        }
        #endregion
        #region                       =-=-=-=-=-=Put=-=-=-=-=-=
        [HttpPut]
        public int UpdateTags([FromBody] Tags x)
        {
            TagsDB db = new TagsDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }
        [HttpPut]
        public int UpdateAgeRating([FromBody] AgeRating x)
        {
            AgeRatingDB db = new AgeRatingDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdatePrivacy([FromBody] Privacy x)
        {
            PrivacyDB db = new PrivacyDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateLanguage([FromBody] Languages x)
        {
            LanguagesDB db = new LanguagesDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateChapter([FromBody] Chapters x)
        {
            ChaptersDB db = new ChaptersDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateComment([FromBody] Comments x)
        {
            CommentsDB db = new CommentsDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateUser([FromBody] Users x)
        {
            UsersDB db = new UsersDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateWorks([FromBody] Works x)
        {
            WorksDB db = new WorksDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateTags_On_Works([FromBody] Tags_On_Works x)
        {
            Tags_On_WorksDB db = new Tags_On_WorksDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpPut]
        public int UpdateAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Update(x);
            int y = db.SaveChanges();
            return y;
        }
        #endregion
        #region                       =-=-=-=-=-=Delete=-=-=-=-=-=
        [HttpDelete]
        public int DeleteTag([FromBody] Tags x)
        {
            TagsDB db = new TagsDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }
        [HttpDelete]
        public int DeleteAgeRating([FromBody] AgeRating x)
        {
            AgeRatingDB db = new AgeRatingDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeletePrivacy([FromBody] Privacy x)
        {
            PrivacyDB db = new PrivacyDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteLanguage([FromBody] Languages x)
        {
            LanguagesDB db = new LanguagesDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteChapter([FromBody] Chapters x)
        {
            ChaptersDB db = new ChaptersDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteComment([FromBody] Comments x)
        {
            CommentsDB db = new CommentsDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteUser([FromBody] Users x)
        {
            UsersDB db = new UsersDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteWork([FromBody] Works x)
        {
            WorksDB db = new WorksDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteTags_On_Works([FromBody] Tags_On_Works x)
        {
            Tags_On_WorksDB db = new Tags_On_WorksDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }

        [HttpDelete]
        public int DeleteAdmin([FromBody] Admin x)
        {
            AdminDB db = new AdminDB();
            db.Delete(x);
            int y = db.SaveChanges();
            return y;
        }
        #endregion
    }
}
