using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class UsersDB : BaseDB
    {
        public UserList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Users";
            UserList Users_List = new UserList(base.Select());
            return Users_List;
        }


        public override BaseEntity NewEntity()
        { return new Users(); }

        protected override BaseEntity CreateModel(BaseEntity entity)

        {
            Users u = entity as Users;
            u.Email = reader["Email"].ToString();
            u.Username = reader["Username"].ToString();
            u.DateOfCreation = DateTime.Parse(reader["DateOfCreation"].ToString());
            u.IsVerified = bool.Parse(reader["IsVerified"].ToString());
            base.CreateModel(entity);
            return u;
        }
        public static Users SelectById(int id)
        {
            UsersDB db = new UsersDB();
            UserList list = db.SelectAll();

            Users g = list.Find(item => item.Id == id);
            return g;

        }
        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"DELETE FROM Users where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@ID", u.Id));
            }
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = $"Insert INTO Users (Email,Username,DateOfCreation) VALUES (@uMail,@uName,@uDate)";

                command.CommandText = sqlStr;
                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uMail", u.Email));
                command.Parameters.Add(new OleDbParameter("@uName", u.Username));
                OleDbParameter dateParam = new OleDbParameter("@uDate", OleDbType.Date);
                dateParam.Value = u.DateOfCreation;
                command.Parameters.Add(dateParam);

            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            Users u = entity as Users;
            if (u != null)
            {
                string sqlStr = "UPDATE Users  SET Email=@uMail, Username=@uName, DateOfCreation=@uDate Where ID=@ID";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@uMail", u.Email));
                command.Parameters.Add(new OleDbParameter("@uName", u.Username));
                OleDbParameter dateParam = new OleDbParameter("@uDate", OleDbType.Date);
                dateParam.Value = u.DateOfCreation;
                command.Parameters.Add(dateParam);
                command.Parameters.Add(new OleDbParameter("@ID", u.Id));
            }
        }
    }
}
