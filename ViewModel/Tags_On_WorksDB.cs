using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class Tags_On_WorksDB : BaseDB
    {
        public Tags_On_WorksList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Tags_On_Works";
            Tags_On_WorksList towList = new Tags_On_WorksList(base.Select());
            return towList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Tags_On_Works w = entity as Tags_On_Works;
            w.WorkId = WorksDB.SelectById((int)reader["Work_Id"]);
            w.WorkTags = TagsDB.SelectById((int)reader["Tags"]);
            base.CreateModel(entity);
            return w;
        }
        public override BaseEntity NewEntity()
        {
            return new Tags_On_Works();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Tags_On_Works tow = entity as Tags_On_Works;
            if (tow != null)
            {
                string sqlStr = $"DELETE FROM Tags_On_Works where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ID", tow.Id));
            }
        }

        static private Tags_On_WorksList list = new Tags_On_WorksList();
        public static Tags_On_Works SelectById(int id)
        {
            Tags_On_WorksDB db = new Tags_On_WorksDB();
            list = db.SelectAll();

            Tags_On_Works g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Tags_On_Works tow = entity as Tags_On_Works;
            if (tow != null)
            {
                string sqlStr = $"Insert INTO Tags_On_Works ([Work_Id],[Tags]) " +
                    $"VALUES (@towWid,@towT)";
                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@towWid", tow.WorkId.Id));
                command.Parameters.Add(new OleDbParameter("@towT", tow.WorkTags.Id));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Tags_On_Works tow = entity as Tags_On_Works;
            if (tow != null)
            {
                string sqlStr = "UPDATE Tags_On_Works SET [Work_Id]=@towWid, [Tags]=@towT WHERE ID=@ID";

                command.CommandText = sqlStr;

                command.Parameters.Add(new OleDbParameter("@towWid", tow.WorkId.Id));
                command.Parameters.Add(new OleDbParameter("@towT", tow.WorkTags.Id));
                command.Parameters.Add(new OleDbParameter("@ID", tow.Id));

            }
        }
    }
}
