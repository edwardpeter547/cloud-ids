using System;
using System.Configuration;
using System.Data.OleDb;
using System.Reflection;
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

        public static CloudServerModel? GetServer(string ipaddress)
        {
            using(var connection = new OleDbConnection(GetConectionString()))
            {
                var result = connection.Query<CloudServerModel>("select * from servers where ipaddress=@IpAddress", new {IpAddress = ipaddress }).ToList();
                if(result.Count > 0 )
                {
                    return result.ToList()[0];
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<CloudServerModel> GetCloudServers()
        {
            using(var connection = new OleDbConnection(GetConectionString()))
            {
                var result = connection.Query<CloudServerModel>("select * from servers");
                return result.ToList();
            }
        }

        public static void AddServer(CloudServerModel server)
        {
            using (var connection = new OleDbConnection(GetConectionString()))
            {
                connection.Execute(@"insert into servers(servername, port, ipaddress, secret) values(@ServerName, @Port, @IpAddress, @Secret)", GetDynamicParameters(server));
            }
        }

        public static DynamicParameters GetDynamicParameters(object instance)
        {
            DynamicParameters parameters = new DynamicParameters();
            Type serverType = instance.GetType();
            foreach (PropertyInfo property in serverType.GetProperties())
            {
                if(property.Name != "Id")
                    parameters.Add(property.Name.ToString(), property.GetValue(instance));
            }
            return parameters;
        }
    }
}
