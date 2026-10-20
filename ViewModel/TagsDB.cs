using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class TagsDB : BaseDB
    {
        public TagList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Tags";
            TagList TagsList = new TagList(base.Select());
            return TagsList ;
        }


        public override BaseEntity NewEntity()
        { return new Tags();}

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Tags t = entity as Tags;
            t.Tagname = reader["tagname"].ToString();
            base.CreateModel(entity);
            return t;
        }

        static private TagList list = new TagList();
        public static Tags SelectById(int id)
        {
            TagsDB db = new TagsDB();
            list = db.SelectAll();

            Tags g = list.Find(item => item.Id == id);
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
            Tags t = entity as Tags;
            if (t != null)
            {
                string sqlStr = "UPDATE Tags  SET tagname=@tName Where ID=@ID";
                
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@tName", t.Tagname));
                command.Parameters.Add(new OleDbParameter("@ID", t.Id));
            }
        }
    }
}
