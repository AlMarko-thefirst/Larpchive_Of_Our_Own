using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class AgeRatingDB : BaseDB
    {
        public AgeRatingList SelectAll()
        {
            command.CommandText = $"SELECT * FROM AgeRating";
            AgeRatingList AgeRatingsList = new AgeRatingList(base.Select());
            return AgeRatingsList;
        }


        public override BaseEntity NewEntity()
        { return new AgeRating(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            AgeRating a = entity as AgeRating;
            a.Age_Rating = reader["AgeRating"].ToString();
            base.CreateModel(entity);
            return a;
        }
        public static AgeRating SelectById(int id)
        {
            AgeRatingDB db = new AgeRatingDB();
            AgeRatingList list = db.SelectAll();

            AgeRating g = list.Find(item => item.Id == id);
            return g;

        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AgeRating ar = entity as AgeRating;
            if (ar != null)
            {
                string sqlStr = $"DELETE FROM AgeRating where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ID", ar.Id));
            }
        }
        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AgeRating a = entity as AgeRating;
            if (a != null)
            {
                string sqlStr = $"Insert INTO AgeRating (AgeRating) VALUES (@aRating)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@aRating", a.Age_Rating));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            AgeRating a = entity as AgeRating;
            if (a != null)
            {
                string sqlStr = "UPDATE AgeRating  SET AgeRating=@aName Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@aName", a.Age_Rating));
                command.Parameters.Add(new OleDbParameter("@ID", a.Id));
            }
        }
    }
}
