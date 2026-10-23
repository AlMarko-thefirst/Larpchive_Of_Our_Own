using Larpchive_Of_Our_Own;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace ViewModel
{
    public class AdminDB: UsersDB
    {
        public AdminList SelectAll()
        {
            command.CommandText = $"SELECT Users.Id, Users.Email, Users.IsVerified, Users.DateOfCreation, Users.Username, Users.IsActive " +
                                  $"FROM (Admin INNER JOIN " +
                                  $"Users ON Admin.ID = Users.Id)";
            AdminList wList = new AdminList(base.Select());
            return wList;
        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Admin a = entity as Admin;
            a.Email = reader["Email"].ToString();
            a.Username = reader["Username"].ToString();
            a.DateOfCreation = DateTime.Parse(reader["DateOfCreation"].ToString());
            a.IsVerified = bool.Parse(reader["IsVerified"].ToString());
            base.CreateModel(entity);
            return a;
        }
        public override BaseEntity NewEntity()
        {
            return new Admin();
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        static private AdminList list = new AdminList();
        public static Admin SelectById(int id)
        {
            AdminDB db = new AdminDB();
            list = db.SelectAll();

            Admin g = list.Find(item => item.Id == id);
            return g;

        }


        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            //Admin a = entity as Admin;
            //if (a != null)
            //{
            //    string sqlStr = "UPDATE Admin  SET Where ID=@ID";
            //    command.Parameters.Add(new OleDbParameter("@ID", a.Id));
            //}
        }
        public override void Update(BaseEntity entity)
        {
            Admin a = entity as Admin;
            if (a != null)
            {
                updated.Add(new ChangeEntity(this.CreateUpdatedSQL, entity));
                updated.Add(new ChangeEntity(base.CreateUpdatedSQL, entity));
            }
        }

    }
}
