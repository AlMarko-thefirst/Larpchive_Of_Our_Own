using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class WorksDB : BaseDB
    {
        public WorksList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Works";
            WorksList wList = new WorksList(base.Select());
            return wList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Works w = entity as Works;
            w.WorkName = reader["WorkName"].ToString();
            w.Description = reader["description"].ToString();
            w.ChapterGoal = reader["ChapterGoal"].ToString();
            w.Language = LanguagesDB.SelectById((int)reader["Language"]);
            w.Author = UsersDB.SelectById((int)reader["Author"]);
            w.DateOfRelease = DateTime.Parse(reader["DateOfRelease"].ToString());
            w.Privacy = PrivacyDB.SelectById((int)(reader["Privacy"]));
            w.AgeRating = AgeRatingDB.SelectById((int)reader["AgeRating"]);

            base.CreateModel(entity);
            return w;
        }
        public override BaseEntity NewEntity()
        {
            return new Works();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        static private WorksList list=new WorksList();
        public static Works SelectById(int id)
        {
            WorksDB db = new WorksDB();
            list = db.SelectAll();

            Works g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Works w = entity as Works;
            if (w != null)
            {
                string sqlStr = "UPDATE Works SET WorkName=@wName, description=@wDes, ChapterGoal=@wCG, Language=@wLang, Author=@wAuth, DateOfRelease=@wDOR, Privacy=@wPri, AgeRating=@wAg  WHERE ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@wName", w.WorkName));
                command.Parameters.Add(new OleDbParameter("@wDes", w.Description));
                command.Parameters.Add(new OleDbParameter("@wCG", w.ChapterGoal));
                command.Parameters.Add(new OleDbParameter("@wLang", w.Language.Id));
                command.Parameters.Add(new OleDbParameter("@wAuth", w.Author.Id));
                command.Parameters.Add(new OleDbParameter("@wDOR", w.DateOfRelease));
                command.Parameters.Add(new OleDbParameter("@wPri", w.Privacy.Id));
                command.Parameters.Add(new OleDbParameter("@wAg", w.AgeRating.Id));
                command.Parameters.Add(new OleDbParameter("@ID", w.Id));
            }
        }
    }
}
