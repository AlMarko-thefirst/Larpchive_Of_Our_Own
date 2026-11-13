using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class ChaptersDB : BaseDB
    {
        public ChapterList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Chapters";
            ChapterList Chapter_List = new ChapterList(base.Select());
            return Chapter_List;
        }


        public override BaseEntity NewEntity()
        { return new Chapters(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Chapters c = entity as Chapters;
            c.WorkID = WorksDB.SelectById(int.Parse(reader["WorkID"].ToString()));
            c.ChapterNum = int.Parse(reader["ChapterNum"].ToString());
            c.ChapterName = reader["ChapterName"].ToString();
            c.Summary = reader["Summary"].ToString();
            c.Notes = reader["Notes"].ToString();
            c.Story = reader["Story"].ToString();
            base.CreateModel(entity);
            return c;
        }
        public static Chapters SelectById(int id)
        {
            ChaptersDB db = new ChaptersDB();
            ChapterList list = db.SelectAll();

            Chapters g = list.Find(item => item.Id == id);
            return g;

        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Chapters ch = entity as Chapters;
            if (ch != null)
            {
                string sqlStr = $"DELETE FROM Chapters where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ID", ch.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Chapters c = entity as Chapters;
            if (c != null)
            {
                string sqlStr = $"Insert INTO Chapters (ChapterName,WorkID,ChapterNum,Summary,Notes,Story) VALUES (@cName,@cWid,@cCnum,@cSum,@cNote,@cStory)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.ChapterName));
                command.Parameters.Add(new OleDbParameter("@cWid", c.WorkID.Id));
                command.Parameters.Add(new OleDbParameter("@cCnum", c.ChapterNum));
                command.Parameters.Add(new OleDbParameter("@cSum", c.Summary));
                command.Parameters.Add(new OleDbParameter("@cNote", c.Notes));
                command.Parameters.Add(new OleDbParameter("@cStory", c.Story));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Chapters c = entity as Chapters;
            if (c != null)
            {
                string sqlStr = "UPDATE Chapters  SET ChapterName=@cName, WorkID=@cWid, ChapterNum=@cCnum, Summary=@cSum, Notes=@cNote, Story=@cStory  Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@cName", c.ChapterName));
                command.Parameters.Add(new OleDbParameter("@cWid", c.WorkID.Id));
                command.Parameters.Add(new OleDbParameter("@cCnum", c.ChapterNum));
                command.Parameters.Add(new OleDbParameter("@cSum", c.Summary));
                command.Parameters.Add(new OleDbParameter("@cNote", c.Notes));
                command.Parameters.Add(new OleDbParameter("@cStory", c.Story));
                command.Parameters.Add(new OleDbParameter("@ID", c.Id));
            }
        }
    }
}
