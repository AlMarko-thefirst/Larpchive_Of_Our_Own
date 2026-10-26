using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class CommentsDB : BaseDB
    {
        public CommentList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Comments";
            CommentList Comment_List = new CommentList(base.Select());
            return Comment_List;
        }


        public override BaseEntity NewEntity()
        { return new Comments(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Comments c = entity as Comments;
            c.Comment = reader["Comment"].ToString();
            c.WorkId = int.Parse(reader["WorkID"].ToString());
            c.UserId = int.Parse(reader["UserID"].ToString());
            c.DateOfComment = DateTime.Parse(reader["DateOfComment"].ToString());
            c.Rating = int.Parse(reader["rating"].ToString());
            base.CreateModel(entity);
            return c;
        }

        public static Comments SelectById(int id)
        {
            CommentsDB db = new CommentsDB();
            CommentList list = db.SelectAll();

            Comments g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Comments c = entity as Comments;
            if (c != null)
            {
                string sqlStr = $"Insert INTO Comments (Comment,UserID,WorkID,DateOfComment,rating) VALUES (@cName,@cUid,@cWid,@cDOC,@cRate)";

                command.CommandText = sqlStr;
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Comment));
                command.Parameters.Add(new OleDbParameter("@cUid", c.UserId));
                command.Parameters.Add(new OleDbParameter("@cWid", c.WorkId));
                OleDbParameter dateParam = new OleDbParameter("@cDOC", OleDbType.Date);
                dateParam.Value = c.DateOfComment;
                command.Parameters.Add(dateParam);
                command.Parameters.Add(new OleDbParameter("@cRate", c.Rating));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Comments c = entity as Comments;
            if (c != null)
            {
                string sqlStr = "UPDATE Comments  SET Comment=@cName, UserID=@cUid, WorkID=@cWid, DateOfComment=@cDOC, rating=@cRate  Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.Comment));
                command.Parameters.Add(new OleDbParameter("@cUid", c.UserId));
                command.Parameters.Add(new OleDbParameter("@cWid", c.WorkId));
                OleDbParameter dateParam = new OleDbParameter("@cDOC", OleDbType.Date);
                dateParam.Value = c.DateOfComment;
                command.Parameters.Add(dateParam);
                command.Parameters.Add(new OleDbParameter("@cRate", c.Rating));
                command.Parameters.Add(new OleDbParameter("@ID", c.Id));
            }
        }
    }
}
