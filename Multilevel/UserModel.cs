using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel
{
    internal class UserModel
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Passwd { get; set; }
        public string DisplayName
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }
    }
}
