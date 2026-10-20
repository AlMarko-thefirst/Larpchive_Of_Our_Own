using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class LanguagesDB : BaseDB
    {
        public LanguageList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Languages";
            LanguageList Language_List = new LanguageList(base.Select());
            return Language_List;
        }


        public override BaseEntity NewEntity()
        { return new Languages(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Languages l = entity as Languages;
            l.LanguageNameInEnglish = reader["LanguageNameInEnglish"].ToString();
            l.LanguageNameInOriginalLangauge = reader["LanguageNameInOriginalLangauge"].ToString();
            l.LettersInAlpabetticalOrder = reader["LettersInAlpabetticalOrder"].ToString();
            base.CreateModel(entity);
            return l;
        }
        public static Languages SelectById(int id)
        {
            LanguagesDB db = new LanguagesDB();
            LanguageList list = db.SelectAll();

            Languages g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Languages l = entity as Languages;
            if (l != null)
            {
                string sqlStr = "UPDATE Languages  SET LanguageNameInEnglish=@lNameie, LanguageNameInOriginalLangauge=@lNameiol, LettersInAlpabetticalOrder=@lNamel  Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@lNameie", l.LanguageNameInEnglish));
                command.Parameters.Add(new OleDbParameter("@lNameiol", l.LanguageNameInOriginalLangauge));
                command.Parameters.Add(new OleDbParameter("@lNamel", l.LettersInAlpabetticalOrder));
                command.Parameters.Add(new OleDbParameter("@ID", l.Id));
            }
        }
    }
}
