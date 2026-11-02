using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
namespace ViewModel
{
    public class PrivacyDB : BaseDB
    {
        public PrivacyList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Privacy";
            PrivacyList Privacy_List = new PrivacyList(base.Select());
            return Privacy_List;
        }


        public override BaseEntity NewEntity()
        { return new Privacy(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Privacy p = entity as Privacy;
            p.PrivacyLevel = reader["PrivacyLevel"].ToString();
            base.CreateModel(entity);
            return p;
        }
        public static Privacy SelectById(int id)
        {
            PrivacyDB db = new PrivacyDB();
            PrivacyList list = db.SelectAll();

            Privacy g = list.Find(item => item.Id == id);
            return g;

        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Privacy p = entity as Privacy;
            if (p != null)
            {
                string sqlStr = $"DELETE FROM Privacy where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ID", p.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Privacy p = entity as Privacy;
            if (p != null)
            {
                string sqlStr = $"Insert INTO Privacy (PrivacyLevel) VALUES (@pName)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pName", p.PrivacyLevel));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Privacy p = entity as Privacy;
            if (p != null)
            {
                string sqlStr = "UPDATE Privacy  SET PrivacyLevel=@pName Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@pName", p.PrivacyLevel));
                command.Parameters.Add(new OleDbParameter("@ID", p.Id));
            }
        }
    }
}
