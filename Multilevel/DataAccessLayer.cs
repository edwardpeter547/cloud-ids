using System;
using System.Configuration;
using System.Data.OleDb;
using Dapper;

namespace Multilevel
{
    internal class DataAccessLayer
    {
        public static void CreateUser(UserModel user)
        {
            using (var connection = new OleDbConnection(GetConectionString()))
            {
                connection.Execute(@"insert into account(email, firstname, lastname, passwd, username) values(@email, @firstname, @lastname, @passwd, @username)", user);
            }
        }

        public static string GetConectionString(string ConnectionId = "multilevel")
        {
            return ConfigurationManager.ConnectionStrings[ConnectionId].ConnectionString;
        }

        public static UserModel? GetUser(string cloud_id, string password)
        {
            
            using(var connection = new OleDbConnection(GetConectionString()))
            {
                var result = connection.Query<UserModel>("select * from account where username=@CloudId and passwd=@Passwd", new { CloudId = cloud_id, Passwd = password }).ToList();
                if(result.Count > 0)
                {
                    return result.ToList()[0];
                }
                else
                {
                    return null;
                }
                
            }
        }
    }
}
